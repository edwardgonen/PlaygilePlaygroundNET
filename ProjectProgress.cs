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

            //adjust data to time line in dates
            if (_progressData.GetEstimationDatesList().Count() == 0) return result;

            bool projectInitialEstimationSpecified = false;
            double initialEstimationSpecified = 500;
            bool projectStartSpecified = false;
            DateTime specifiedProjectDate = new DateTime(2020, 6, 1, 0, 0, 0);

            DateTime startProjectDateTime;
            double initialProjectEstimation;
            if (projectStartSpecified)
                startProjectDateTime = specifiedProjectDate;
            else
                startProjectDateTime = _progressData.GetEstimationDatesList().First();
            if (projectInitialEstimationSpecified)
                initialProjectEstimation = initialEstimationSpecified;
            else
                initialProjectEstimation = _progressData.GetEstimationValuesList().First();

            double dailyVelocity = _teamVelocity / (double)SprintLength;
            DateTime lastDateTimeInProjectData = _progressData.GetEstimationDatesList().Last();
            DataPair tmpPair;
            int daysLeftSinceLastUpdateTillEndOfSprint = SprintLength - 1 - (lastDateTimeInProjectData - startProjectDateTime).Days % SprintLength;
            DateTime closestSprintEnd = lastDateTimeInProjectData.AddDays(daysLeftSinceLastUpdateTillEndOfSprint);

            double endSprintExpectation  = 0;
            double idealEstimation = 0;

            if (daysLeftSinceLastUpdateTillEndOfSprint > 0)
            {
                //add predicted closest sprint end
                double remainingWorkInRecentSprint = dailyVelocity * ((double)(daysLeftSinceLastUpdateTillEndOfSprint));
                endSprintExpectation = Math.Max(_progressData.GetEstimationValuesList().Last() - remainingWorkInRecentSprint, 0);

                tmpPair = new DataPair(closestSprintEnd, endSprintExpectation);
                _progressData.AddDataPair(tmpPair);
            }
            //to this point the predicted array contains real data from the past.
            //The dates of those estimations may not be on the sprint end
            //so we need to add those points to the ideal line to make both lines parallel in sense of dates
            //it is easy since the ideal is linear y = initial estimation -(DailyVelocity) * NumberOfDaysSinceProjectStarts
            tmpPair = new DataPair(startProjectDateTime, initialProjectEstimation);
            _idealData.AddDataPair(tmpPair);
            for (int i = 1; i < _progressData.Length(); i++)
            {
                //calculate this point distance from the project start
                idealEstimation = CalculateIdealEstimationByDate(startProjectDateTime, _progressData.GetElementAtIndex(i).Date, initialProjectEstimation, dailyVelocity);
                tmpPair = new DataPair(_progressData.GetElementAtIndex(i).Date, idealEstimation);
                _idealData.AddDataPair(tmpPair);
                if (idealEstimation <= 0) break;
            }


            //calculate prediction
            //first let's set the predicted point to the end of recent sprint
            DateTime lastSprintEnd = closestSprintEnd;

            double lastFullSprintEndValue = _progressData.GetEstimationValuesList().Last();
            DateTime pointDate = lastSprintEnd;
            bool continueAddingIdealPoints = true;
            bool continueAddingProgressPoints = true;
            while (endSprintExpectation > 0 || idealEstimation > 0)
            {
                pointDate = pointDate.AddDays(SprintLength);
                endSprintExpectation = CalculateIdealEstimationByDate(lastSprintEnd, pointDate, lastFullSprintEndValue, dailyVelocity);
                continueAddingProgressPoints = AddDataPairToList(continueAddingProgressPoints, pointDate, endSprintExpectation, _progressData);
                idealEstimation = CalculateIdealEstimationByDate(startProjectDateTime, pointDate, initialProjectEstimation, dailyVelocity);
                continueAddingIdealPoints = AddDataPairToList(continueAddingIdealPoints, pointDate, idealEstimation, _idealData);
            };

            //end of the project for each set is the last date where the estimation is 0 while the next one is not 0
            DateTime idealProjectEnd = _idealData.GetElementAtIndex(0).Date;
            for (int i = _idealData.GetEstimationValuesList().Count() - 1; i > 0; i--)
            {
                if (_idealData.GetElementAtIndex(i).RemainingEstimation <= 0 && _idealData.GetElementAtIndex(i - 1).RemainingEstimation > 0)
                {
                    idealProjectEnd = _idealData.GetElementAtIndex(i).Date;
                    break;
                }
            }
            //end of the project for each set is the last date where the estimation is 0 while the next one is not 0
            DateTime predictedProjectEnd = _progressData.GetElementAtIndex(0).Date;
            for (int i = _progressData.GetEstimationValuesList().Count() - 1; i > 0; i--)
            {
                if (_progressData.GetElementAtIndex(i).RemainingEstimation <= 0 && _progressData.GetElementAtIndex(i - 1).RemainingEstimation > 0)
                {
                    predictedProjectEnd = _progressData.GetElementAtIndex(i).Date;
                    break;
                }
            }


            ChartValues<double> actualAndPredictedValues = new ChartValues<double>(_progressData.GetEstimationValuesList());
            ChartValues<double> idealValues = new ChartValues<double>(_idealData.GetEstimationValuesList());


            _mainForm.SetIdealProjectEnd(idealProjectEnd.ToShortDateString());
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
        private bool AddDataPairToList(bool continueAddingPoints, DateTime date, double estimation, ProgressData data)
        {
            bool result = continueAddingPoints;
            if (continueAddingPoints)
            {
                DataPair tmpPair = new DataPair(date, Math.Max(estimation, 0));
                if (estimation <= 0) result = false;
                data.AddDataPair(tmpPair);
            }
            return result;
        }
        private double CalculateIdealEstimationByDate(DateTime projectStartDate, DateTime currentDate, double initialProjectEstimation, double dailyVelocity)
        {
            int distanceDays = (currentDate - projectStartDate).Days;
            return Math.Max(initialProjectEstimation - distanceDays * dailyVelocity, 0);
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
            return _progressData.Select(x => x.RemainingEstimation);
        }
        public IEnumerable<DateTime> GetEstimationDatesList()
        {
            return _progressData.Select(x => x.Date).Distinct();
        }
        public DataPair GetElementAtIndex(int index)
        {
            if (_progressData.Count > 0 && index < _progressData.Count)
            {
                return _progressData[index];
            }
            return null;
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
