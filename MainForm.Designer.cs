namespace PlaygilePlayground
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlPlaygileComponents = new System.Windows.Forms.TabControl();
            this.tabPageUserStoryAssessment = new System.Windows.Forms.TabPage();
            this.labelTotalScore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSplittable = new System.Windows.Forms.ComboBox();
            this.comboBoxEstimable = new System.Windows.Forms.ComboBox();
            this.comboBoxCollateralMaterialsAvailability = new System.Windows.Forms.ComboBox();
            this.comboBoxAcceptanceCriteria = new System.Windows.Forms.ComboBox();
            this.comboBoxDemonstrable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageSprintBacklogAssessment = new System.Windows.Forms.TabPage();
            this.tabPageProjectProgress = new System.Windows.Forms.TabPage();
            this.buttonRecalculate = new System.Windows.Forms.Button();
            this.buttonLoadProgressData = new System.Windows.Forms.Button();
            this.labelPredictedProjectEnd = new System.Windows.Forms.Label();
            this.labelIdealProjectEnd = new System.Windows.Forms.Label();
            this.textBoxSprintLength = new System.Windows.Forms.TextBox();
            this.chartPrediction = new LiveCharts.WinForms.CartesianChart();
            this.textBoxTeamVelocity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarFourDaysBeforeEnd = new System.Windows.Forms.TrackBar();
            this.trackBarThreeDaysBeforeEnd = new System.Windows.Forms.TrackBar();
            this.trackBarTwoDaysBeforeEnd = new System.Windows.Forms.TrackBar();
            this.trackBarLastDayBeforeEnd = new System.Windows.Forms.TrackBar();
            this.cartesianChartBacklogReadiness = new LiveCharts.WinForms.CartesianChart();
            this.labelTotalBacklogScore = new System.Windows.Forms.Label();
            this.tabControlPlaygileComponents.SuspendLayout();
            this.tabPageUserStoryAssessment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSprintBacklogAssessment.SuspendLayout();
            this.tabPageProjectProgress.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFourDaysBeforeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreeDaysBeforeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTwoDaysBeforeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLastDayBeforeEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPlaygileComponents
            // 
            this.tabControlPlaygileComponents.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlPlaygileComponents.Controls.Add(this.tabPageUserStoryAssessment);
            this.tabControlPlaygileComponents.Controls.Add(this.tabPageSprintBacklogAssessment);
            this.tabControlPlaygileComponents.Controls.Add(this.tabPageProjectProgress);
            this.tabControlPlaygileComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPlaygileComponents.Location = new System.Drawing.Point(16, 15);
            this.tabControlPlaygileComponents.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPlaygileComponents.Name = "tabControlPlaygileComponents";
            this.tabControlPlaygileComponents.SelectedIndex = 0;
            this.tabControlPlaygileComponents.Size = new System.Drawing.Size(1172, 534);
            this.tabControlPlaygileComponents.TabIndex = 0;
            // 
            // tabPageUserStoryAssessment
            // 
            this.tabPageUserStoryAssessment.Controls.Add(this.labelTotalScore);
            this.tabPageUserStoryAssessment.Controls.Add(this.groupBox1);
            this.tabPageUserStoryAssessment.Location = new System.Drawing.Point(4, 32);
            this.tabPageUserStoryAssessment.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageUserStoryAssessment.Name = "tabPageUserStoryAssessment";
            this.tabPageUserStoryAssessment.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageUserStoryAssessment.Size = new System.Drawing.Size(1164, 498);
            this.tabPageUserStoryAssessment.TabIndex = 0;
            this.tabPageUserStoryAssessment.Text = "User Story Assessment";
            this.tabPageUserStoryAssessment.UseVisualStyleBackColor = true;
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.AutoSize = true;
            this.labelTotalScore.BackColor = System.Drawing.Color.Blue;
            this.labelTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalScore.ForeColor = System.Drawing.Color.Yellow;
            this.labelTotalScore.Location = new System.Drawing.Point(896, 322);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(175, 91);
            this.labelTotalScore.TabIndex = 6;
            this.labelTotalScore.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSplittable);
            this.groupBox1.Controls.Add(this.comboBoxEstimable);
            this.groupBox1.Controls.Add(this.comboBoxCollateralMaterialsAvailability);
            this.groupBox1.Controls.Add(this.comboBoxAcceptanceCriteria);
            this.groupBox1.Controls.Add(this.comboBoxDemonstrable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answer the following questions about User Story";
            // 
            // comboBoxSplittable
            // 
            this.comboBoxSplittable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSplittable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSplittable.FormattingEnabled = true;
            this.comboBoxSplittable.Items.AddRange(new object[] {
            "Can be splitted",
            "Not enough information"});
            this.comboBoxSplittable.Location = new System.Drawing.Point(795, 202);
            this.comboBoxSplittable.Name = "comboBoxSplittable";
            this.comboBoxSplittable.Size = new System.Drawing.Size(349, 28);
            this.comboBoxSplittable.TabIndex = 9;
            this.comboBoxSplittable.SelectedIndexChanged += new System.EventHandler(this.comboBoxSplittable_SelectedIndexChanged);
            // 
            // comboBoxEstimable
            // 
            this.comboBoxEstimable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstimable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstimable.FormattingEnabled = true;
            this.comboBoxEstimable.Items.AddRange(new object[] {
            "Regular story (1-5 story points)",
            "Large story (8-13 story points)",
            "Team is not able to estimate (21)"});
            this.comboBoxEstimable.Location = new System.Drawing.Point(795, 163);
            this.comboBoxEstimable.Name = "comboBoxEstimable";
            this.comboBoxEstimable.Size = new System.Drawing.Size(349, 28);
            this.comboBoxEstimable.TabIndex = 8;
            this.comboBoxEstimable.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstimable_SelectedIndexChanged);
            // 
            // comboBoxCollateralMaterialsAvailability
            // 
            this.comboBoxCollateralMaterialsAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCollateralMaterialsAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCollateralMaterialsAvailability.FormattingEnabled = true;
            this.comboBoxCollateralMaterialsAvailability.Items.AddRange(new object[] {
            "Available",
            "Will be provided in sprint",
            "Not available"});
            this.comboBoxCollateralMaterialsAvailability.Location = new System.Drawing.Point(795, 124);
            this.comboBoxCollateralMaterialsAvailability.Name = "comboBoxCollateralMaterialsAvailability";
            this.comboBoxCollateralMaterialsAvailability.Size = new System.Drawing.Size(349, 28);
            this.comboBoxCollateralMaterialsAvailability.TabIndex = 7;
            this.comboBoxCollateralMaterialsAvailability.SelectedIndexChanged += new System.EventHandler(this.comboBoxCollateralMaterialsAvailability_SelectedIndexChanged);
            // 
            // comboBoxAcceptanceCriteria
            // 
            this.comboBoxAcceptanceCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcceptanceCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAcceptanceCriteria.FormattingEnabled = true;
            this.comboBoxAcceptanceCriteria.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.comboBoxAcceptanceCriteria.Location = new System.Drawing.Point(795, 85);
            this.comboBoxAcceptanceCriteria.Name = "comboBoxAcceptanceCriteria";
            this.comboBoxAcceptanceCriteria.Size = new System.Drawing.Size(349, 28);
            this.comboBoxAcceptanceCriteria.TabIndex = 6;
            this.comboBoxAcceptanceCriteria.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcceptanceCriteria_SelectedIndexChanged);
            // 
            // comboBoxDemonstrable
            // 
            this.comboBoxDemonstrable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDemonstrable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDemonstrable.FormattingEnabled = true;
            this.comboBoxDemonstrable.Items.AddRange(new object[] {
            "Demonstrable",
            "Not Demonstrable"});
            this.comboBoxDemonstrable.Location = new System.Drawing.Point(795, 46);
            this.comboBoxDemonstrable.Name = "comboBoxDemonstrable";
            this.comboBoxDemonstrable.Size = new System.Drawing.Size(349, 28);
            this.comboBoxDemonstrable.TabIndex = 5;
            this.comboBoxDemonstrable.SelectedIndexChanged += new System.EventHandler(this.comboBoxDemonstrable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "The result of the User Story\'s implementation can be demonstrated";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(392, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Can be splitted into sub-tasks not longer than 1 day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clear Acceptance Criteria are provided";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(421, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "The Team is able to estimate User Story in story points";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(466, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Collateral Materials (Art, Economy, Analytics, etc.) availability";
            // 
            // tabPageSprintBacklogAssessment
            // 
            this.tabPageSprintBacklogAssessment.Controls.Add(this.labelTotalBacklogScore);
            this.tabPageSprintBacklogAssessment.Controls.Add(this.groupBox2);
            this.tabPageSprintBacklogAssessment.Location = new System.Drawing.Point(4, 32);
            this.tabPageSprintBacklogAssessment.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSprintBacklogAssessment.Name = "tabPageSprintBacklogAssessment";
            this.tabPageSprintBacklogAssessment.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSprintBacklogAssessment.Size = new System.Drawing.Size(1164, 498);
            this.tabPageSprintBacklogAssessment.TabIndex = 1;
            this.tabPageSprintBacklogAssessment.Text = "Sprint Backlog Assessment";
            this.tabPageSprintBacklogAssessment.UseVisualStyleBackColor = true;
            // 
            // tabPageProjectProgress
            // 
            this.tabPageProjectProgress.Controls.Add(this.buttonRecalculate);
            this.tabPageProjectProgress.Controls.Add(this.buttonLoadProgressData);
            this.tabPageProjectProgress.Controls.Add(this.labelPredictedProjectEnd);
            this.tabPageProjectProgress.Controls.Add(this.labelIdealProjectEnd);
            this.tabPageProjectProgress.Controls.Add(this.textBoxSprintLength);
            this.tabPageProjectProgress.Controls.Add(this.chartPrediction);
            this.tabPageProjectProgress.Controls.Add(this.textBoxTeamVelocity);
            this.tabPageProjectProgress.Controls.Add(this.label7);
            this.tabPageProjectProgress.Controls.Add(this.label4);
            this.tabPageProjectProgress.Location = new System.Drawing.Point(4, 32);
            this.tabPageProjectProgress.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageProjectProgress.Name = "tabPageProjectProgress";
            this.tabPageProjectProgress.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageProjectProgress.Size = new System.Drawing.Size(1164, 498);
            this.tabPageProjectProgress.TabIndex = 2;
            this.tabPageProjectProgress.Text = "Project Progress";
            this.tabPageProjectProgress.UseVisualStyleBackColor = true;
            // 
            // buttonRecalculate
            // 
            this.buttonRecalculate.Location = new System.Drawing.Point(3, 169);
            this.buttonRecalculate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRecalculate.Name = "buttonRecalculate";
            this.buttonRecalculate.Size = new System.Drawing.Size(225, 36);
            this.buttonRecalculate.TabIndex = 11;
            this.buttonRecalculate.Text = "Recalculate";
            this.buttonRecalculate.UseVisualStyleBackColor = true;
            this.buttonRecalculate.Click += new System.EventHandler(this.buttonRecalculate_Click);
            // 
            // buttonLoadProgressData
            // 
            this.buttonLoadProgressData.Location = new System.Drawing.Point(3, 7);
            this.buttonLoadProgressData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadProgressData.Name = "buttonLoadProgressData";
            this.buttonLoadProgressData.Size = new System.Drawing.Size(225, 36);
            this.buttonLoadProgressData.TabIndex = 10;
            this.buttonLoadProgressData.Text = "Load Progress Data";
            this.buttonLoadProgressData.UseVisualStyleBackColor = true;
            this.buttonLoadProgressData.Click += new System.EventHandler(this.buttonLoadProgressData_Click);
            // 
            // labelPredictedProjectEnd
            // 
            this.labelPredictedProjectEnd.AutoSize = true;
            this.labelPredictedProjectEnd.Location = new System.Drawing.Point(3, 319);
            this.labelPredictedProjectEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPredictedProjectEnd.Name = "labelPredictedProjectEnd";
            this.labelPredictedProjectEnd.Size = new System.Drawing.Size(152, 20);
            this.labelPredictedProjectEnd.TabIndex = 9;
            this.labelPredictedProjectEnd.Text = "Predicted End: N/A";
            // 
            // labelIdealProjectEnd
            // 
            this.labelIdealProjectEnd.AutoSize = true;
            this.labelIdealProjectEnd.Location = new System.Drawing.Point(3, 289);
            this.labelIdealProjectEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdealProjectEnd.Name = "labelIdealProjectEnd";
            this.labelIdealProjectEnd.Size = new System.Drawing.Size(116, 20);
            this.labelIdealProjectEnd.TabIndex = 8;
            this.labelIdealProjectEnd.Text = "Ideal End: N/A";
            // 
            // textBoxSprintLength
            // 
            this.textBoxSprintLength.Location = new System.Drawing.Point(188, 130);
            this.textBoxSprintLength.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSprintLength.Name = "textBoxSprintLength";
            this.textBoxSprintLength.Size = new System.Drawing.Size(40, 27);
            this.textBoxSprintLength.TabIndex = 7;
            this.textBoxSprintLength.Text = "14";
            // 
            // chartPrediction
            // 
            this.chartPrediction.Location = new System.Drawing.Point(248, 7);
            this.chartPrediction.Margin = new System.Windows.Forms.Padding(4);
            this.chartPrediction.Name = "chartPrediction";
            this.chartPrediction.Size = new System.Drawing.Size(905, 466);
            this.chartPrediction.TabIndex = 0;
            this.chartPrediction.Text = "Project status";
            // 
            // textBoxTeamVelocity
            // 
            this.textBoxTeamVelocity.Location = new System.Drawing.Point(188, 97);
            this.textBoxTeamVelocity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTeamVelocity.Name = "textBoxTeamVelocity";
            this.textBoxTeamVelocity.Size = new System.Drawing.Size(40, 27);
            this.textBoxTeamVelocity.TabIndex = 6;
            this.textBoxTeamVelocity.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sprint Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Team\'s Velocity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cartesianChartBacklogReadiness);
            this.groupBox2.Controls.Add(this.trackBarLastDayBeforeEnd);
            this.groupBox2.Controls.Add(this.trackBarTwoDaysBeforeEnd);
            this.groupBox2.Controls.Add(this.trackBarThreeDaysBeforeEnd);
            this.groupBox2.Controls.Add(this.trackBarFourDaysBeforeEnd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1150, 334);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill the Backlog readiness percentage per planning days below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Four days before the Sprint ends";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Three days before the Sprint ends";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Last day of the Sprint";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Two days before the Sprint ends";
            // 
            // trackBarFourDaysBeforeEnd
            // 
            this.trackBarFourDaysBeforeEnd.LargeChange = 10;
            this.trackBarFourDaysBeforeEnd.Location = new System.Drawing.Point(365, 49);
            this.trackBarFourDaysBeforeEnd.Maximum = 100;
            this.trackBarFourDaysBeforeEnd.Name = "trackBarFourDaysBeforeEnd";
            this.trackBarFourDaysBeforeEnd.Size = new System.Drawing.Size(383, 56);
            this.trackBarFourDaysBeforeEnd.SmallChange = 5;
            this.trackBarFourDaysBeforeEnd.TabIndex = 4;
            this.trackBarFourDaysBeforeEnd.Scroll += new System.EventHandler(this.trackBarFourDaysBeforeEnd_Scroll);
            // 
            // trackBarThreeDaysBeforeEnd
            // 
            this.trackBarThreeDaysBeforeEnd.LargeChange = 10;
            this.trackBarThreeDaysBeforeEnd.Location = new System.Drawing.Point(365, 113);
            this.trackBarThreeDaysBeforeEnd.Maximum = 100;
            this.trackBarThreeDaysBeforeEnd.Name = "trackBarThreeDaysBeforeEnd";
            this.trackBarThreeDaysBeforeEnd.Size = new System.Drawing.Size(383, 56);
            this.trackBarThreeDaysBeforeEnd.SmallChange = 5;
            this.trackBarThreeDaysBeforeEnd.TabIndex = 5;
            this.trackBarThreeDaysBeforeEnd.Scroll += new System.EventHandler(this.trackBarThreeDaysBeforeEnd_Scroll);
            // 
            // trackBarTwoDaysBeforeEnd
            // 
            this.trackBarTwoDaysBeforeEnd.LargeChange = 10;
            this.trackBarTwoDaysBeforeEnd.Location = new System.Drawing.Point(365, 177);
            this.trackBarTwoDaysBeforeEnd.Maximum = 100;
            this.trackBarTwoDaysBeforeEnd.Name = "trackBarTwoDaysBeforeEnd";
            this.trackBarTwoDaysBeforeEnd.Size = new System.Drawing.Size(383, 56);
            this.trackBarTwoDaysBeforeEnd.SmallChange = 5;
            this.trackBarTwoDaysBeforeEnd.TabIndex = 6;
            this.trackBarTwoDaysBeforeEnd.Scroll += new System.EventHandler(this.trackBarTwoDaysBeforeEnd_Scroll);
            // 
            // trackBarLastDayBeforeEnd
            // 
            this.trackBarLastDayBeforeEnd.LargeChange = 10;
            this.trackBarLastDayBeforeEnd.Location = new System.Drawing.Point(365, 241);
            this.trackBarLastDayBeforeEnd.Maximum = 100;
            this.trackBarLastDayBeforeEnd.Name = "trackBarLastDayBeforeEnd";
            this.trackBarLastDayBeforeEnd.Size = new System.Drawing.Size(383, 56);
            this.trackBarLastDayBeforeEnd.SmallChange = 5;
            this.trackBarLastDayBeforeEnd.TabIndex = 7;
            this.trackBarLastDayBeforeEnd.Scroll += new System.EventHandler(this.trackBarLastDayBeforeEnd_Scroll);
            // 
            // cartesianChartBacklogReadiness
            // 
            this.cartesianChartBacklogReadiness.Location = new System.Drawing.Point(774, 49);
            this.cartesianChartBacklogReadiness.Name = "cartesianChartBacklogReadiness";
            this.cartesianChartBacklogReadiness.Size = new System.Drawing.Size(370, 248);
            this.cartesianChartBacklogReadiness.TabIndex = 8;
            // 
            // labelTotalBacklogScore
            // 
            this.labelTotalBacklogScore.AutoSize = true;
            this.labelTotalBacklogScore.BackColor = System.Drawing.Color.Blue;
            this.labelTotalBacklogScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBacklogScore.ForeColor = System.Drawing.Color.Yellow;
            this.labelTotalBacklogScore.Location = new System.Drawing.Point(896, 369);
            this.labelTotalBacklogScore.Name = "labelTotalBacklogScore";
            this.labelTotalBacklogScore.Size = new System.Drawing.Size(175, 91);
            this.labelTotalBacklogScore.TabIndex = 7;
            this.labelTotalBacklogScore.Text = "N/A";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 564);
            this.Controls.Add(this.tabControlPlaygileComponents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Playgile Playground";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlPlaygileComponents.ResumeLayout(false);
            this.tabPageUserStoryAssessment.ResumeLayout(false);
            this.tabPageUserStoryAssessment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSprintBacklogAssessment.ResumeLayout(false);
            this.tabPageSprintBacklogAssessment.PerformLayout();
            this.tabPageProjectProgress.ResumeLayout(false);
            this.tabPageProjectProgress.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFourDaysBeforeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreeDaysBeforeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTwoDaysBeforeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLastDayBeforeEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPlaygileComponents;
        private System.Windows.Forms.TabPage tabPageUserStoryAssessment;
        private System.Windows.Forms.TabPage tabPageSprintBacklogAssessment;
        private System.Windows.Forms.TabPage tabPageProjectProgress;
        private LiveCharts.WinForms.CartesianChart chartPrediction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTeamVelocity;
        private System.Windows.Forms.TextBox textBoxSprintLength;
        private System.Windows.Forms.Label labelPredictedProjectEnd;
        private System.Windows.Forms.Label labelIdealProjectEnd;
        private System.Windows.Forms.Button buttonLoadProgressData;
        private System.Windows.Forms.Button buttonRecalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxDemonstrable;
        public System.Windows.Forms.ComboBox comboBoxAcceptanceCriteria;
        public System.Windows.Forms.ComboBox comboBoxCollateralMaterialsAvailability;
        public System.Windows.Forms.ComboBox comboBoxSplittable;
        public System.Windows.Forms.ComboBox comboBoxEstimable;
        private System.Windows.Forms.Label labelTotalScore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarFourDaysBeforeEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBarLastDayBeforeEnd;
        private System.Windows.Forms.TrackBar trackBarTwoDaysBeforeEnd;
        private System.Windows.Forms.TrackBar trackBarThreeDaysBeforeEnd;
        public LiveCharts.WinForms.CartesianChart cartesianChartBacklogReadiness;
        public System.Windows.Forms.Label labelTotalBacklogScore;
    }
}

