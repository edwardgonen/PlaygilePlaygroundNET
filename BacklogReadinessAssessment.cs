using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygilePlayground
{
    public class BacklogReadinessAssessment
    {
        private MainForm _mainForm;
        public BacklogReadinessAssessment(MainForm mainForm)
        {
            _mainForm = mainForm;
            Initiate();
        }
        public void Initiate()
        {
            _mainForm.cartesianChartBacklogReadiness.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Readiness",
                    Values = new ChartValues<double> { 0, 0, 0, 0 }
                }
            };

            _mainForm.cartesianChartBacklogReadiness.AxisX.Add(new Axis
            {
                Title = "Days before Sprint ends",
                Labels = new[] { "4", "3", "2", "1" }
            });

            _mainForm.cartesianChartBacklogReadiness.AxisY.Add(new Axis
            {
                Title = "Day percentage",
                MinValue = 0,
                MaxValue = 100
            });
        }

        public void Recalculate(double fourthDayPercentage, double thirdDayPercentage, double secondDayPercentage, double lastDayPercentage)
        {
            const int numOfDays = 4;
            const double maxTotalScore = 100.0;
            _mainForm.cartesianChartBacklogReadiness.Series[0].Values[0] = fourthDayPercentage;
            _mainForm.cartesianChartBacklogReadiness.Series[0].Values[1] = thirdDayPercentage;
            _mainForm.cartesianChartBacklogReadiness.Series[0].Values[2] = secondDayPercentage;
            _mainForm.cartesianChartBacklogReadiness.Series[0].Values[3] = lastDayPercentage;
            //calculation
            double[] weight = new double[] {1.0, 5.0, 10.0, 50.0 };
            double[] expectedPercentage = new double[] { 100.0, 100.0, 100.0, 100.0 };
            double[] dayScore = new double[numOfDays];
            double[] minimalDayScore = new double[numOfDays];
            double[] dayScoreAdjustedByWeight = new double[numOfDays];
            double[] maximalDayScore = new double[numOfDays];
            double[] normalizedDayScore = new double[numOfDays];

            double maxTotalDayScore = 0;
            double minTotalDayScore = 0;
            for (int i = 0; i < numOfDays; i++)
            {
                minimalDayScore[i] = -100.0 * weight[i];
                minTotalDayScore += minimalDayScore[i];
                maximalDayScore[i] = 0;
                maxTotalDayScore += maximalDayScore[i];
            }

            double normalization = maxTotalScore / (maxTotalDayScore - minTotalDayScore);
            double totalNormalizedDayScore = 0;
            for (int i = 0; i < numOfDays; i++)
            {
                dayScore[i] = (double)_mainForm.cartesianChartBacklogReadiness.Series[0].Values[i] - expectedPercentage[i];
                dayScoreAdjustedByWeight[i] = dayScore[i] * weight[i];
                normalizedDayScore[i] = dayScoreAdjustedByWeight[i] * normalization;
                totalNormalizedDayScore += normalizedDayScore[i];
            }

            _mainForm.labelTotalBacklogScore.Text = ((int)(maxTotalScore + totalNormalizedDayScore)).ToString();
        }
    }
}
