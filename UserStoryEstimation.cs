using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygilePlayground
{
    public class UserStoryEstimation
    {
        private MainForm _mainForm;
        public UserStoryEstimation(MainForm mainForm)
        {
            _mainForm = mainForm;
        }
        public UserStoryScore CalculateScore()
        {
            int result = 0;
            double demostrableScore;
            if ((string)_mainForm.comboBoxDemonstrable.SelectedItem == @"Demonstrable")
            {
                demostrableScore = 10.0;
            }
            else
            {
                demostrableScore = 0;
            }
            result += (int)demostrableScore;
            double acceptanceScore;
            if ((string)_mainForm.comboBoxAcceptanceCriteria.SelectedItem == @"Present")
            {
                acceptanceScore = 20.0;
            }
            else
            {
                acceptanceScore = 0;
            }
            result += (int)acceptanceScore;
            double collateralMaterialsAvailabilityScore;
            if ((string)_mainForm.comboBoxCollateralMaterialsAvailability.SelectedItem == @"Available")
            {
                collateralMaterialsAvailabilityScore = 25.0 / 2.0 * 2;
            }
            else if ((string)_mainForm.comboBoxCollateralMaterialsAvailability.SelectedItem == @"Will be provided in sprint")
            {
                collateralMaterialsAvailabilityScore = 25.0 / 2.0 * 1;
            }
            else collateralMaterialsAvailabilityScore = 0;
            result += (int)collateralMaterialsAvailabilityScore;
            double estimableScore;
            if ((string)_mainForm.comboBoxEstimable.SelectedItem == @"Regular story (1-5 story points)")
            {
                estimableScore = 20.0 / 2.0 * 2;
            }
            else if ((string)_mainForm.comboBoxEstimable.SelectedItem == @"Large story(8 - 13 story points)")
            {
                estimableScore = 20.0 / 2.0 * 1;
            }
            else estimableScore = 0;
            result += (int)estimableScore;
            double splittableScore;
            if ((string)_mainForm.comboBoxSplittable.SelectedItem == @"Can be splitted")
            {
                splittableScore = 25.0;
            }
            else
            {
                splittableScore = 0;
            }
            result += (int)splittableScore;

            Color tmpBackgroundColor;
            Color tmpForegroundColor;
            if (result < 50)
            {
                tmpForegroundColor = Color.YellowGreen;
                tmpBackgroundColor = Color.Red;
            }
            else
            {
                if (result < 70)
                {
                    tmpForegroundColor = Color.YellowGreen;
                    tmpBackgroundColor = Color.Orange;
                }
                else
                {
                    if (result < 100)
                    {
                        tmpForegroundColor = Color.YellowGreen;
                        tmpBackgroundColor = Color.Blue;
                    }
                    else
                    {
                        tmpForegroundColor = Color.Yellow;
                        tmpBackgroundColor = Color.Blue;
                    }
                }
            }


            UserStoryScore score = new UserStoryScore()
            { backgroundColor = tmpBackgroundColor, foregroundColor = tmpForegroundColor, Score = result.ToString() };



            return score;
        }
    }
    public class UserStoryScore
    {
        public Color foregroundColor;
        public Color backgroundColor;
        public string Score;
    }
}
