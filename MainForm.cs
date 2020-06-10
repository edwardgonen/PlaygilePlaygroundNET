using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PlaygilePlayground
{
    public partial class MainForm : Form
    {
        ProjectProgress _projectProgress;
        UserStoryEstimation _userStoryEstimation;
        BacklogReadinessAssessment _backlogAssessment;
        ArrayList _lines = new ArrayList();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //initiate all controls
            //project progress
            _projectProgress =  new ProjectProgress(this);
            //set demo data
            ArrayList demoLines = new ArrayList() {@"6/1/2020, 500",  @"6/15/2020,450", @"6/20/2020, 600"};
            Recalculate(chartPrediction, demoLines);

            //story assessment
            _userStoryEstimation = new UserStoryEstimation(this);
            comboBoxDemonstrable.SelectedIndex = 0;
            comboBoxAcceptanceCriteria.SelectedIndex = 0;
            comboBoxCollateralMaterialsAvailability.SelectedIndex = 0;
            comboBoxEstimable.SelectedIndex = 0;
            comboBoxSplittable.SelectedIndex = 0;

            //backlog assessment
            _backlogAssessment = new BacklogReadinessAssessment(this);
            _backlogAssessment.Recalculate(0, 0, 0, 0);

        }

        public void SetIdealProjectEnd(string projectEnd)
        {
            labelIdealProjectEnd.Text = @"Ideal Project End " + projectEnd;
        }
        public void SetPredictedProjectEnd(string projectEnd)
        {
            labelPredictedProjectEnd.Text = @"Real End " + projectEnd;
        }

        private void buttonLoadProgressData_Click(object sender, EventArgs e)
        {
            //open file
            FileDialog openFileDialogLoadData = new OpenFileDialog();
            openFileDialogLoadData.Title = @"Select data CSV file";
            openFileDialogLoadData.Filter = @"Data | *.csv";
            openFileDialogLoadData.FileName = @"";
            DialogResult dr = openFileDialogLoadData.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //load
                _lines = ProjectProgress.LoadDataFromFile(openFileDialogLoadData.FileName);
                if (_lines.Count > 0)
                {

                    Recalculate(chartPrediction, _lines);
                }
                else
                {
                    MessageBox.Show(@"Failed to read data file " + openFileDialogLoadData.FileName, @"Data read error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRecalculate_Click(object sender, EventArgs e)
        {
            if (_projectProgress.IsProgressDataLoaded())
                Recalculate(chartPrediction, _lines);
            else
                MessageBox.Show(@"Please load the data file first", @"Data read error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Recalculate(LiveCharts.WinForms.CartesianChart chartPrediction, ArrayList progressDataUnconvertedStrings = null)
        {
            double velocity;
            if (!double.TryParse(textBoxTeamVelocity.Text, out velocity))
            {
                MessageBox.Show(@"Wrong team velocity " + textBoxTeamVelocity.Text, @"Invalid input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int tmpSprintLength;
            if (!int.TryParse(textBoxSprintLength.Text, out tmpSprintLength))
            {
                MessageBox.Show(@"Wrong sprint length " + textBoxSprintLength.Text, @"Invalid input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = _projectProgress.Initiate(chartPrediction, velocity, tmpSprintLength, progressDataUnconvertedStrings);
            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show(result, @"Please load the data first",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void comboBoxDemonstrable_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserStoryScore use = _userStoryEstimation.CalculateScore();
            labelTotalScore.Text = use.Score;
            labelTotalScore.ForeColor = use.foregroundColor;
            labelTotalScore.BackColor = use.backgroundColor;
        }

        private void comboBoxAcceptanceCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserStoryScore use = _userStoryEstimation.CalculateScore();
            labelTotalScore.Text = use.Score;
            labelTotalScore.ForeColor = use.foregroundColor;
            labelTotalScore.BackColor = use.backgroundColor;
        }

        private void comboBoxCollateralMaterialsAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserStoryScore use = _userStoryEstimation.CalculateScore();
            labelTotalScore.Text = use.Score;
            labelTotalScore.ForeColor = use.foregroundColor;
            labelTotalScore.BackColor = use.backgroundColor;
        }

        private void comboBoxEstimable_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserStoryScore use = _userStoryEstimation.CalculateScore();
            labelTotalScore.Text = use.Score;
            labelTotalScore.ForeColor = use.foregroundColor;
            labelTotalScore.BackColor = use.backgroundColor;
        }

        private void comboBoxSplittable_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserStoryScore use = _userStoryEstimation.CalculateScore();
            labelTotalScore.Text = use.Score;
            labelTotalScore.ForeColor = use.foregroundColor;
            labelTotalScore.BackColor = use.backgroundColor;
        }

        private void trackBarFourDaysBeforeEnd_Scroll(object sender, EventArgs e)
        {
            _backlogAssessment.Recalculate(
                trackBarFourDaysBeforeEnd.Value, 
                trackBarThreeDaysBeforeEnd.Value, 
                trackBarTwoDaysBeforeEnd.Value, 
                trackBarLastDayBeforeEnd.Value);
        }

        private void trackBarThreeDaysBeforeEnd_Scroll(object sender, EventArgs e)
        {
            _backlogAssessment.Recalculate(
                trackBarFourDaysBeforeEnd.Value,
                trackBarThreeDaysBeforeEnd.Value,
                trackBarTwoDaysBeforeEnd.Value,
                trackBarLastDayBeforeEnd.Value);
        }

        private void trackBarTwoDaysBeforeEnd_Scroll(object sender, EventArgs e)
        {
            _backlogAssessment.Recalculate(
                trackBarFourDaysBeforeEnd.Value,
                trackBarThreeDaysBeforeEnd.Value,
                trackBarTwoDaysBeforeEnd.Value,
                trackBarLastDayBeforeEnd.Value);
        }

        private void trackBarLastDayBeforeEnd_Scroll(object sender, EventArgs e)
        {
            _backlogAssessment.Recalculate(
                trackBarFourDaysBeforeEnd.Value,
                trackBarThreeDaysBeforeEnd.Value,
                trackBarTwoDaysBeforeEnd.Value,
                trackBarLastDayBeforeEnd.Value);
        }
    }
}
