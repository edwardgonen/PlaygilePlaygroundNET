using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using LiveCharts;
using LiveCharts.Wpf;

namespace PlaygilePlayground
{
    public class ProjectProgress
    {
        private LiveCharts.WinForms.CartesianChart _chartPrediction;
        public int SprintLength { get; private set; }
        private double _teamVelocity;
        private ProgressData _progressData;
        private ProgressData _idealData;
        private MainForm _mainForm;

        public ProjectProgress(MainForm mainForm)
        {
            _mainForm = mainForm;
        }
        public bool IsProgressDataLoaded()
        {
            return _progressData?.Length() > 0;
        }
        public string Initiate(LiveCharts.WinForms.CartesianChart chartPrediction, double teamVelocity, int sprintLength, ArrayList progressDataUnconvertedStrings)
        {
            _chartPrediction = chartPrediction;
            SprintLength = sprintLength;
            _teamVelocity = teamVelocity;
            _idealData = new ProgressData();

            _progressData = new ProgressData();
            string result = _progressData.AddDataAsLines(progressDataUnconvertedStrings);
            if (!string.IsNullOrEmpty(result)) return result;

            //adjust data to time line
            if (_progressData.GetEstimationDatesList().Count() == 0) return result;

            DateTime lastDateTime = _progressData.GetEstimationDatesList().Last();
            DateTime startProjectDateTime = _progressData.GetEstimationDatesList().First();
            int daysLeftSinceLastUpdateTillEndOfSprint = (lastDateTime - startProjectDateTime).Days % SprintLength;
            DateTime recentSprintEnd = lastDateTime.AddDays(SprintLength - daysLeftSinceLastUpdateTillEndOfSprint);
            double remainingWorkInRecentSprint =
                _teamVelocity * ((double)(SprintLength - daysLeftSinceLastUpdateTillEndOfSprint) / (double)SprintLength);
            double momentaryEstimation = _progressData.GetEstimationValuesList().Last() - remainingWorkInRecentSprint;
            //first let's set the predicted point to the end of recent sprint
            DataPair tmpPair = new DataPair(recentSprintEnd, momentaryEstimation);
            _progressData.AddDataPair(tmpPair);

            //calculate prediction
            DateTime pointDate = recentSprintEnd;
            do
            {
                pointDate = pointDate.AddDays(SprintLength);
                momentaryEstimation -= _teamVelocity;
                tmpPair = new DataPair(pointDate, Math.Max(momentaryEstimation, 0));
                _progressData.AddDataPair(tmpPair);
            } while (momentaryEstimation > 0);
            ChartValues<double> actualAndPredictedValues = new ChartValues<double>(_progressData.GetEstimationValuesList());
            
            //calculate ideal
            tmpPair = new DataPair(_progressData.GetEstimationDatesList().First(), _progressData.GetEstimationValuesList().First());
            _idealData.AddDataPair(tmpPair);
            momentaryEstimation = _idealData.GetEstimationValuesList().First();
            pointDate = _idealData.GetEstimationDatesList().First();
            do
            {
                momentaryEstimation -= _teamVelocity;
                pointDate = pointDate.AddDays(SprintLength);
                tmpPair = new DataPair(pointDate, Math.Max(momentaryEstimation, 0));
                _idealData.AddDataPair(tmpPair);
            } while (momentaryEstimation > 0);
            ChartValues<double> idealValues = new ChartValues<double>(_idealData.GetEstimationValuesList());

            DateTime idealProjectEnd = _idealData.GetEstimationDatesList().Last().AddDays(-1);
            _mainForm.SetIdealProjectEnd(idealProjectEnd.ToShortDateString());
            DateTime predictedProjectEnd = _progressData.GetEstimationDatesList().Last().AddDays(-1);
            _mainForm.SetPredictedProjectEnd(predictedProjectEnd.ToShortDateString());

            _chartPrediction.Series.Clear();
            _chartPrediction.AxisX.Clear();
            _chartPrediction.AxisY.Clear();

            _chartPrediction.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = @"Ideal",
                    Values = idealValues
                },
                new LineSeries
                {
                    Title = @"Actual/Predicted",
                    Values = actualAndPredictedValues
                }
            };

            List<string> dates = new List<string>();
            //what time is longer? ideal or real
            if (_progressData.GetEstimationDatesList().Last() >= _idealData.GetEstimationDatesList().Last())
            {
                foreach (var tmp in _progressData.GetEstimationDatesList())
                    dates.Add(tmp.ToShortDateString());
            }
            else
            {
                foreach (var tmp in _idealData.GetEstimationDatesList())
                    dates.Add(tmp.ToShortDateString());
            }
            
            _chartPrediction.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = dates
            });

            _chartPrediction.AxisY.Add(new Axis
            {
                Title = "Story Points",
                MinValue = 0
            });

            _chartPrediction.LegendLocation = LegendLocation.Top;

            return result;
        }

        public static ArrayList LoadDataFromFile(string fileName)
        {
            ArrayList lines = new ArrayList();

            using (StreamReader r = new StreamReader(fileName))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    //don't add empty strings
                    line = line.Trim();

                    if (line != String.Empty &&
                        !line.StartsWith(@";") && !line.StartsWith(@"/"))
                    {
                        lines.Add(line);
                    }
                }
            }

            return lines;
        }
    }

    public class ProgressData
    {
        private readonly List<DataPair> _progressData = new List<DataPair>();
        public int Length()
        {
            return _progressData.Count;
        }
        public IEnumerable<double> GetEstimationValuesList()
        {
            return _progressData.Select(x => x.RemainingEstimation).Distinct();
        }
        public IEnumerable<DateTime> GetEstimationDatesList()
        {
            return _progressData.Select(x => x.Date).Distinct();
        }

        public void AddDataPair(DataPair dataPair)
        {
            _progressData.Add(dataPair);
        }
        public string AddDataAsLines(ArrayList progressDataStrings)
        {
            string result = @"";
            DateTimeFormatInfo dtfi = new CultureInfo("en-US").DateTimeFormat;
            //convert data string <date>,<estimation>
            foreach (string line in progressDataStrings)
            {
                try
                {
                    string[] stringParts = line?.Split(',');
                    if (stringParts != null && stringParts.Length >=2)
                    {
                        _progressData.Add(new DataPair(Convert.ToDateTime(stringParts[0], dtfi), double.Parse(stringParts[1])));
                    }
                }
                catch (Exception)
                {
                    // ignored
                    result = @"Wrong string format " + line;
                    return result;
                }
            }

            return result;
        }
    }

    public class DataPair
    {
        public DateTime Date { get; }
        public double RemainingEstimation { get; }

        public DataPair(DateTime date, double estimation)
        {
            Date = date;
            RemainingEstimation = estimation;
        }
    }

}
