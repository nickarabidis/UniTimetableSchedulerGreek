namespace Scheduler.WinForm
{
    partial class PeriodForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodForm));
            semesterDataGridView = new DataGridView();
            semesterLabel = new Label();
            semesterIdLabel = new Label();
            semesterNameLabel = new Label();
            semesterIdTextBox = new TextBox();
            semesterNameTextBox = new TextBox();
            dayDataGridView = new DataGridView();
            dayLabel = new Label();
            dayIdLabel = new Label();
            dayNameLabel = new Label();
            dayIdTextBox = new TextBox();
            dayNameTextBox = new TextBox();
            startTimeDataGridView = new DataGridView();
            startTimeLabel = new Label();
            startTimeIdLabel = new Label();
            startTimeNameLabel = new Label();
            startTimeIdTextBox = new TextBox();
            startTimeNameTextBox = new TextBox();
            semesterClearButton = new Button();
            semesterDeleteButton = new Button();
            semesterAddButton = new Button();
            dayClearButton = new Button();
            dayDeleteButton = new Button();
            dayAddButton = new Button();
            startTimeClearButton = new Button();
            startTimeDeleteButton = new Button();
            startTimeAddButton = new Button();
            periodErrorProvider = new ErrorProvider(components);
            totalSemesterValueLabel = new Label();
            totalSemestersLabel = new Label();
            totalDayValueLabel = new Label();
            totalDaysLabel = new Label();
            totalStartTimeValueLabel = new Label();
            totalStartTimesLabel = new Label();
            deleteAllStartTimeButton = new Button();
            deleteAllSemesterButton = new Button();
            deleteAllDayButton = new Button();
            printSemesterButton = new Button();
            printDayButton = new Button();
            printStartTimeButton = new Button();
            dgDayId = new DataGridViewTextBoxColumn();
            dgDayName = new DataGridViewTextBoxColumn();
            dgSemesterId = new DataGridViewTextBoxColumn();
            dgSemesterName = new DataGridViewTextBoxColumn();
            dgStartTimeId = new DataGridViewTextBoxColumn();
            dgStartTimeName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)semesterDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startTimeDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)periodErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // semesterDataGridView
            // 
            semesterDataGridView.AllowUserToAddRows = false;
            semesterDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            semesterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            semesterDataGridView.Columns.AddRange(new DataGridViewColumn[] { dgSemesterId, dgSemesterName });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            semesterDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            semesterDataGridView.Location = new Point(72, 194);
            semesterDataGridView.Name = "semesterDataGridView";
            semesterDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            semesterDataGridView.Size = new Size(200, 160);
            semesterDataGridView.TabIndex = 38;
            semesterDataGridView.MouseDoubleClick += semesterDataGridView_MouseDoubleClick;
            // 
            // semesterLabel
            // 
            semesterLabel.AutoSize = true;
            semesterLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            semesterLabel.Location = new Point(122, 35);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new Size(104, 25);
            semesterLabel.TabIndex = 37;
            semesterLabel.Text = "ΕΞΑΜΗΝΑ:";
            // 
            // semesterIdLabel
            // 
            semesterIdLabel.AutoSize = true;
            semesterIdLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            semesterIdLabel.Location = new Point(44, 91);
            semesterIdLabel.Name = "semesterIdLabel";
            semesterIdLabel.Size = new Size(22, 17);
            semesterIdLabel.TabIndex = 36;
            semesterIdLabel.Text = "Id:";
            // 
            // semesterNameLabel
            // 
            semesterNameLabel.AutoSize = true;
            semesterNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            semesterNameLabel.Location = new Point(5, 124);
            semesterNameLabel.Name = "semesterNameLabel";
            semesterNameLabel.Size = new Size(61, 17);
            semesterNameLabel.TabIndex = 35;
            semesterNameLabel.Text = "ΟΝΟΜΑ:";
            // 
            // semesterIdTextBox
            // 
            semesterIdTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            semesterIdTextBox.Location = new Point(72, 88);
            semesterIdTextBox.Margin = new Padding(3, 4, 3, 4);
            semesterIdTextBox.Name = "semesterIdTextBox";
            semesterIdTextBox.Size = new Size(200, 25);
            semesterIdTextBox.TabIndex = 34;
            semesterIdTextBox.KeyPress += semesterIdTextBox_KeyPress;
            // 
            // semesterNameTextBox
            // 
            semesterNameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            semesterNameTextBox.Location = new Point(72, 121);
            semesterNameTextBox.Margin = new Padding(3, 4, 3, 4);
            semesterNameTextBox.Name = "semesterNameTextBox";
            semesterNameTextBox.Size = new Size(200, 25);
            semesterNameTextBox.TabIndex = 33;
            // 
            // dayDataGridView
            // 
            dayDataGridView.AllowUserToAddRows = false;
            dayDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            dayDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dayDataGridView.Columns.AddRange(new DataGridViewColumn[] { dgDayId, dgDayName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dayDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dayDataGridView.Location = new Point(375, 194);
            dayDataGridView.Name = "dayDataGridView";
            dayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dayDataGridView.Size = new Size(200, 160);
            dayDataGridView.TabIndex = 44;
            dayDataGridView.MouseDoubleClick += dayDataGridView_MouseDoubleClick;
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dayLabel.Location = new Point(429, 35);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(87, 25);
            dayLabel.TabIndex = 43;
            dayLabel.Text = "ΗΜΕΡΕΣ:";
            // 
            // dayIdLabel
            // 
            dayIdLabel.AutoSize = true;
            dayIdLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dayIdLabel.Location = new Point(347, 91);
            dayIdLabel.Name = "dayIdLabel";
            dayIdLabel.Size = new Size(22, 17);
            dayIdLabel.TabIndex = 42;
            dayIdLabel.Text = "Id:";
            // 
            // dayNameLabel
            // 
            dayNameLabel.AutoSize = true;
            dayNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dayNameLabel.Location = new Point(308, 124);
            dayNameLabel.Name = "dayNameLabel";
            dayNameLabel.Size = new Size(61, 17);
            dayNameLabel.TabIndex = 41;
            dayNameLabel.Text = "ΟΝΟΜΑ:";
            // 
            // dayIdTextBox
            // 
            dayIdTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dayIdTextBox.Location = new Point(375, 88);
            dayIdTextBox.Margin = new Padding(3, 4, 3, 4);
            dayIdTextBox.Name = "dayIdTextBox";
            dayIdTextBox.Size = new Size(200, 25);
            dayIdTextBox.TabIndex = 40;
            dayIdTextBox.KeyPress += dayIdTextBox_KeyPress;
            // 
            // dayNameTextBox
            // 
            dayNameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dayNameTextBox.Location = new Point(375, 121);
            dayNameTextBox.Margin = new Padding(3, 4, 3, 4);
            dayNameTextBox.Name = "dayNameTextBox";
            dayNameTextBox.Size = new Size(200, 25);
            dayNameTextBox.TabIndex = 39;
            // 
            // startTimeDataGridView
            // 
            startTimeDataGridView.AllowUserToAddRows = false;
            startTimeDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            startTimeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            startTimeDataGridView.Columns.AddRange(new DataGridViewColumn[] { dgStartTimeId, dgStartTimeName });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            startTimeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            startTimeDataGridView.Location = new Point(673, 194);
            startTimeDataGridView.Name = "startTimeDataGridView";
            startTimeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            startTimeDataGridView.Size = new Size(200, 160);
            startTimeDataGridView.TabIndex = 50;
            startTimeDataGridView.MouseDoubleClick += startTimeDataGridView_MouseDoubleClick;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            startTimeLabel.Location = new Point(693, 35);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(146, 25);
            startTimeLabel.TabIndex = 49;
            startTimeLabel.Text = "ΩΡΕΣ ΕΝΑΡΞΗΣ:";
            // 
            // startTimeIdLabel
            // 
            startTimeIdLabel.AutoSize = true;
            startTimeIdLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            startTimeIdLabel.Location = new Point(645, 91);
            startTimeIdLabel.Name = "startTimeIdLabel";
            startTimeIdLabel.Size = new Size(22, 17);
            startTimeIdLabel.TabIndex = 48;
            startTimeIdLabel.Text = "Id:";
            // 
            // startTimeNameLabel
            // 
            startTimeNameLabel.AutoSize = true;
            startTimeNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            startTimeNameLabel.Location = new Point(606, 124);
            startTimeNameLabel.Name = "startTimeNameLabel";
            startTimeNameLabel.Size = new Size(61, 17);
            startTimeNameLabel.TabIndex = 47;
            startTimeNameLabel.Text = "ΟΝΟΜΑ:";
            // 
            // startTimeIdTextBox
            // 
            startTimeIdTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            startTimeIdTextBox.Location = new Point(673, 88);
            startTimeIdTextBox.Margin = new Padding(3, 4, 3, 4);
            startTimeIdTextBox.Name = "startTimeIdTextBox";
            startTimeIdTextBox.Size = new Size(200, 25);
            startTimeIdTextBox.TabIndex = 46;
            startTimeIdTextBox.KeyPress += startTimeIdTextBox_KeyPress;
            // 
            // startTimeNameTextBox
            // 
            startTimeNameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            startTimeNameTextBox.Location = new Point(673, 121);
            startTimeNameTextBox.Margin = new Padding(3, 4, 3, 4);
            startTimeNameTextBox.Name = "startTimeNameTextBox";
            startTimeNameTextBox.Size = new Size(200, 25);
            startTimeNameTextBox.TabIndex = 45;
            // 
            // semesterClearButton
            // 
            semesterClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            semesterClearButton.Location = new Point(207, 153);
            semesterClearButton.Name = "semesterClearButton";
            semesterClearButton.Size = new Size(65, 35);
            semesterClearButton.TabIndex = 53;
            semesterClearButton.Text = "Clear";
            semesterClearButton.UseVisualStyleBackColor = true;
            semesterClearButton.Click += semesterClearButton_Click;
            // 
            // semesterDeleteButton
            // 
            semesterDeleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            semesterDeleteButton.Location = new Point(143, 153);
            semesterDeleteButton.Name = "semesterDeleteButton";
            semesterDeleteButton.Size = new Size(58, 35);
            semesterDeleteButton.TabIndex = 52;
            semesterDeleteButton.Text = "Delete";
            semesterDeleteButton.UseVisualStyleBackColor = true;
            semesterDeleteButton.Click += semesterDeleteButton_Click;
            // 
            // semesterAddButton
            // 
            semesterAddButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            semesterAddButton.Location = new Point(72, 153);
            semesterAddButton.Name = "semesterAddButton";
            semesterAddButton.Size = new Size(65, 35);
            semesterAddButton.TabIndex = 51;
            semesterAddButton.Text = "Add";
            semesterAddButton.UseVisualStyleBackColor = true;
            semesterAddButton.Click += semesterAddButton_Click;
            // 
            // dayClearButton
            // 
            dayClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dayClearButton.Location = new Point(510, 153);
            dayClearButton.Name = "dayClearButton";
            dayClearButton.Size = new Size(65, 35);
            dayClearButton.TabIndex = 56;
            dayClearButton.Text = "Clear";
            dayClearButton.UseVisualStyleBackColor = true;
            dayClearButton.Click += dayClearButton_Click;
            // 
            // dayDeleteButton
            // 
            dayDeleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dayDeleteButton.Location = new Point(446, 153);
            dayDeleteButton.Name = "dayDeleteButton";
            dayDeleteButton.Size = new Size(58, 35);
            dayDeleteButton.TabIndex = 55;
            dayDeleteButton.Text = "Delete";
            dayDeleteButton.UseVisualStyleBackColor = true;
            dayDeleteButton.Click += dayDeleteButton_Click;
            // 
            // dayAddButton
            // 
            dayAddButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dayAddButton.Location = new Point(375, 153);
            dayAddButton.Name = "dayAddButton";
            dayAddButton.Size = new Size(65, 35);
            dayAddButton.TabIndex = 54;
            dayAddButton.Text = "Add";
            dayAddButton.UseVisualStyleBackColor = true;
            dayAddButton.Click += dayAddButton_Click;
            // 
            // startTimeClearButton
            // 
            startTimeClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            startTimeClearButton.Location = new Point(808, 153);
            startTimeClearButton.Name = "startTimeClearButton";
            startTimeClearButton.Size = new Size(65, 35);
            startTimeClearButton.TabIndex = 59;
            startTimeClearButton.Text = "Clear";
            startTimeClearButton.UseVisualStyleBackColor = true;
            startTimeClearButton.Click += startTimeClearButton_Click;
            // 
            // startTimeDeleteButton
            // 
            startTimeDeleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            startTimeDeleteButton.Location = new Point(744, 153);
            startTimeDeleteButton.Name = "startTimeDeleteButton";
            startTimeDeleteButton.Size = new Size(58, 35);
            startTimeDeleteButton.TabIndex = 58;
            startTimeDeleteButton.Text = "Delete";
            startTimeDeleteButton.UseVisualStyleBackColor = true;
            startTimeDeleteButton.Click += startTimeDeleteButton_Click;
            // 
            // startTimeAddButton
            // 
            startTimeAddButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            startTimeAddButton.Location = new Point(673, 153);
            startTimeAddButton.Name = "startTimeAddButton";
            startTimeAddButton.Size = new Size(65, 35);
            startTimeAddButton.TabIndex = 57;
            startTimeAddButton.Text = "Add";
            startTimeAddButton.UseVisualStyleBackColor = true;
            startTimeAddButton.Click += startTimeAddButton_Click;
            // 
            // periodErrorProvider
            // 
            periodErrorProvider.ContainerControl = this;
            // 
            // totalSemesterValueLabel
            // 
            totalSemesterValueLabel.AutoSize = true;
            totalSemesterValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalSemesterValueLabel.Location = new Point(229, 395);
            totalSemesterValueLabel.Name = "totalSemesterValueLabel";
            totalSemesterValueLabel.Size = new Size(13, 15);
            totalSemesterValueLabel.TabIndex = 61;
            totalSemesterValueLabel.Text = "0";
            // 
            // totalSemestersLabel
            // 
            totalSemestersLabel.AutoSize = true;
            totalSemestersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalSemestersLabel.Location = new Point(98, 395);
            totalSemestersLabel.Name = "totalSemestersLabel";
            totalSemestersLabel.Size = new Size(128, 15);
            totalSemestersLabel.TabIndex = 60;
            totalSemestersLabel.Text = "ΣΥΝΟΛΟ ΕΞΑΜΗΝΩΝ:";
            // 
            // totalDayValueLabel
            // 
            totalDayValueLabel.AutoSize = true;
            totalDayValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalDayValueLabel.Location = new Point(533, 395);
            totalDayValueLabel.Name = "totalDayValueLabel";
            totalDayValueLabel.Size = new Size(13, 15);
            totalDayValueLabel.TabIndex = 63;
            totalDayValueLabel.Text = "0";
            // 
            // totalDaysLabel
            // 
            totalDaysLabel.AutoSize = true;
            totalDaysLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalDaysLabel.Location = new Point(415, 395);
            totalDaysLabel.Name = "totalDaysLabel";
            totalDaysLabel.Size = new Size(112, 15);
            totalDaysLabel.TabIndex = 62;
            totalDaysLabel.Text = "ΣΥΝΟΛΟ ΗΜΕΡΩΝ:";
            // 
            // totalStartTimeValueLabel
            // 
            totalStartTimeValueLabel.AutoSize = true;
            totalStartTimeValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalStartTimeValueLabel.Location = new Point(845, 394);
            totalStartTimeValueLabel.Name = "totalStartTimeValueLabel";
            totalStartTimeValueLabel.Size = new Size(13, 15);
            totalStartTimeValueLabel.TabIndex = 65;
            totalStartTimeValueLabel.Text = "0";
            // 
            // totalStartTimesLabel
            // 
            totalStartTimesLabel.AutoSize = true;
            totalStartTimesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalStartTimesLabel.Location = new Point(690, 394);
            totalStartTimesLabel.Name = "totalStartTimesLabel";
            totalStartTimesLabel.Size = new Size(149, 15);
            totalStartTimesLabel.TabIndex = 64;
            totalStartTimesLabel.Text = "ΣΥΝΟΛΟ ΩΡΩΝ ΕΝΑΡΞΗΣ:";
            // 
            // deleteAllStartTimeButton
            // 
            deleteAllStartTimeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteAllStartTimeButton.Location = new Point(800, 357);
            deleteAllStartTimeButton.Name = "deleteAllStartTimeButton";
            deleteAllStartTimeButton.Size = new Size(73, 34);
            deleteAllStartTimeButton.TabIndex = 68;
            deleteAllStartTimeButton.Text = "Delete All";
            deleteAllStartTimeButton.UseVisualStyleBackColor = true;
            deleteAllStartTimeButton.Click += deleteAllStartTimeButton_Click;
            // 
            // deleteAllSemesterButton
            // 
            deleteAllSemesterButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteAllSemesterButton.Location = new Point(199, 357);
            deleteAllSemesterButton.Name = "deleteAllSemesterButton";
            deleteAllSemesterButton.Size = new Size(73, 34);
            deleteAllSemesterButton.TabIndex = 69;
            deleteAllSemesterButton.Text = "Delete All";
            deleteAllSemesterButton.UseVisualStyleBackColor = true;
            deleteAllSemesterButton.Click += deleteAllSemesterButton_Click;
            // 
            // deleteAllDayButton
            // 
            deleteAllDayButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteAllDayButton.Location = new Point(502, 357);
            deleteAllDayButton.Name = "deleteAllDayButton";
            deleteAllDayButton.Size = new Size(73, 34);
            deleteAllDayButton.TabIndex = 70;
            deleteAllDayButton.Text = "Delete All";
            deleteAllDayButton.UseVisualStyleBackColor = true;
            deleteAllDayButton.Click += deleteAllDayButton_Click;
            // 
            // printSemesterButton
            // 
            printSemesterButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            printSemesterButton.Location = new Point(72, 357);
            printSemesterButton.Margin = new Padding(4);
            printSemesterButton.Name = "printSemesterButton";
            printSemesterButton.Size = new Size(73, 34);
            printSemesterButton.TabIndex = 76;
            printSemesterButton.Text = "Print Data";
            printSemesterButton.UseVisualStyleBackColor = true;
            printSemesterButton.Click += printSemesterButton_Click;
            // 
            // printDayButton
            // 
            printDayButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            printDayButton.Location = new Point(375, 357);
            printDayButton.Margin = new Padding(4);
            printDayButton.Name = "printDayButton";
            printDayButton.Size = new Size(73, 34);
            printDayButton.TabIndex = 77;
            printDayButton.Text = "Print Data";
            printDayButton.UseVisualStyleBackColor = true;
            printDayButton.Click += printDayButton_Click;
            // 
            // printStartTimeButton
            // 
            printStartTimeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            printStartTimeButton.Location = new Point(673, 357);
            printStartTimeButton.Margin = new Padding(4);
            printStartTimeButton.Name = "printStartTimeButton";
            printStartTimeButton.Size = new Size(73, 34);
            printStartTimeButton.TabIndex = 78;
            printStartTimeButton.Text = "Print Data";
            printStartTimeButton.UseVisualStyleBackColor = true;
            printStartTimeButton.Click += printStartTimeButton_Click;
            // 
            // dgDayId
            // 
            dgDayId.HeaderText = "Id";
            dgDayId.Name = "dgDayId";
            dgDayId.Width = 50;
            // 
            // dgDayName
            // 
            dgDayName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgDayName.HeaderText = "ΟΝΟΜΑ";
            dgDayName.Name = "dgDayName";
            // 
            // dgSemesterId
            // 
            dgSemesterId.HeaderText = "Id";
            dgSemesterId.Name = "dgSemesterId";
            dgSemesterId.Width = 50;
            // 
            // dgSemesterName
            // 
            dgSemesterName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgSemesterName.HeaderText = "ΟΝΟΜΑ";
            dgSemesterName.Name = "dgSemesterName";
            // 
            // dgStartTimeId
            // 
            dgStartTimeId.HeaderText = "Id";
            dgStartTimeId.Name = "dgStartTimeId";
            dgStartTimeId.Width = 50;
            // 
            // dgStartTimeName
            // 
            dgStartTimeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgStartTimeName.HeaderText = "ΟΝΟΜΑ";
            dgStartTimeName.Name = "dgStartTimeName";
            // 
            // PeriodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(933, 433);
            Controls.Add(printStartTimeButton);
            Controls.Add(printDayButton);
            Controls.Add(printSemesterButton);
            Controls.Add(deleteAllDayButton);
            Controls.Add(deleteAllSemesterButton);
            Controls.Add(deleteAllStartTimeButton);
            Controls.Add(totalStartTimeValueLabel);
            Controls.Add(totalStartTimesLabel);
            Controls.Add(totalDayValueLabel);
            Controls.Add(totalDaysLabel);
            Controls.Add(totalSemesterValueLabel);
            Controls.Add(totalSemestersLabel);
            Controls.Add(startTimeClearButton);
            Controls.Add(startTimeDeleteButton);
            Controls.Add(startTimeAddButton);
            Controls.Add(dayClearButton);
            Controls.Add(dayDeleteButton);
            Controls.Add(dayAddButton);
            Controls.Add(semesterClearButton);
            Controls.Add(semesterDeleteButton);
            Controls.Add(semesterAddButton);
            Controls.Add(startTimeDataGridView);
            Controls.Add(startTimeLabel);
            Controls.Add(startTimeIdLabel);
            Controls.Add(startTimeNameLabel);
            Controls.Add(startTimeIdTextBox);
            Controls.Add(startTimeNameTextBox);
            Controls.Add(dayDataGridView);
            Controls.Add(dayLabel);
            Controls.Add(dayIdLabel);
            Controls.Add(dayNameLabel);
            Controls.Add(dayIdTextBox);
            Controls.Add(dayNameTextBox);
            Controls.Add(semesterDataGridView);
            Controls.Add(semesterLabel);
            Controls.Add(semesterIdLabel);
            Controls.Add(semesterNameLabel);
            Controls.Add(semesterIdTextBox);
            Controls.Add(semesterNameTextBox);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "PeriodForm";
            Text = "ΧΡΟΝΙΚΟΣ ΠΕΡΙΟΔΟΣ";
            Load += PeriodForm_Load;
            ((System.ComponentModel.ISupportInitialize)semesterDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)startTimeDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)periodErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView semesterDataGridView;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label semesterIdLabel;
        private System.Windows.Forms.Label semesterNameLabel;
        private System.Windows.Forms.TextBox semesterIdTextBox;
        private System.Windows.Forms.TextBox semesterNameTextBox;
        private System.Windows.Forms.DataGridView dayDataGridView;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label dayIdLabel;
        private System.Windows.Forms.Label dayNameLabel;
        private System.Windows.Forms.TextBox dayIdTextBox;
        private System.Windows.Forms.TextBox dayNameTextBox;
        private System.Windows.Forms.DataGridView startTimeDataGridView;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label startTimeIdLabel;
        private System.Windows.Forms.Label startTimeNameLabel;
        private System.Windows.Forms.TextBox startTimeIdTextBox;
        private System.Windows.Forms.TextBox startTimeNameTextBox;
        private System.Windows.Forms.Button semesterClearButton;
        private System.Windows.Forms.Button semesterDeleteButton;
        private System.Windows.Forms.Button semesterAddButton;
        private System.Windows.Forms.Button dayClearButton;
        private System.Windows.Forms.Button dayDeleteButton;
        private System.Windows.Forms.Button dayAddButton;
        private System.Windows.Forms.Button startTimeClearButton;
        private System.Windows.Forms.Button startTimeDeleteButton;
        private System.Windows.Forms.Button startTimeAddButton;
        private System.Windows.Forms.ErrorProvider periodErrorProvider;
        private System.Windows.Forms.Label totalStartTimeValueLabel;
        private System.Windows.Forms.Label totalStartTimesLabel;
        private System.Windows.Forms.Label totalDayValueLabel;
        private System.Windows.Forms.Label totalDaysLabel;
        private System.Windows.Forms.Label totalSemesterValueLabel;
        private System.Windows.Forms.Label totalSemestersLabel;
        private Button deleteAllDayButton;
        private Button deleteAllSemesterButton;
        private Button deleteAllStartTimeButton;
        private Button printStartTimeButton;
        private Button printDayButton;
        private Button printSemesterButton;
        private DataGridViewTextBoxColumn dgSemesterId;
        private DataGridViewTextBoxColumn dgSemesterName;
        private DataGridViewTextBoxColumn dgDayId;
        private DataGridViewTextBoxColumn dgDayName;
        private DataGridViewTextBoxColumn dgStartTimeId;
        private DataGridViewTextBoxColumn dgStartTimeName;
    }
}