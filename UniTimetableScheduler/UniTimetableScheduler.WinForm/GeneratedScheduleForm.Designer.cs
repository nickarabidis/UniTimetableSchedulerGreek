﻿namespace Scheduler.WinForm
{
    partial class GeneratedScheduleForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratedScheduleForm));
            generatedSchedulerDataGridView = new DataGridView();
            headerTextLabel = new Label();
            dgGeneratedSchedulerId = new DataGridViewTextBoxColumn();
            dgGeneratedCourse = new DataGridViewTextBoxColumn();
            dgGeneratedProfessor = new DataGridViewTextBoxColumn();
            dgGeneratedDuration = new DataGridViewTextBoxColumn();
            dgGeneratedSemester = new DataGridViewTextBoxColumn();
            dgGeneratedFinalDay = new DataGridViewTextBoxColumn();
            dgGeneratedFinalStartTime = new DataGridViewTextBoxColumn();
            dgGeneratedFinalRoom = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)generatedSchedulerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // generatedSchedulerDataGridView
            // 
            generatedSchedulerDataGridView.AllowUserToAddRows = false;
            generatedSchedulerDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            generatedSchedulerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            generatedSchedulerDataGridView.Columns.AddRange(new DataGridViewColumn[] { dgGeneratedSchedulerId, dgGeneratedCourse, dgGeneratedProfessor, dgGeneratedDuration, dgGeneratedSemester, dgGeneratedFinalDay, dgGeneratedFinalStartTime, dgGeneratedFinalRoom });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            generatedSchedulerDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            generatedSchedulerDataGridView.Location = new Point(35, 38);
            generatedSchedulerDataGridView.Margin = new Padding(4);
            generatedSchedulerDataGridView.Name = "generatedSchedulerDataGridView";
            generatedSchedulerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            generatedSchedulerDataGridView.Size = new Size(900, 490);
            generatedSchedulerDataGridView.TabIndex = 16;
            // 
            // headerTextLabel
            // 
            headerTextLabel.AutoSize = true;
            headerTextLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            headerTextLabel.Location = new Point(244, 9);
            headerTextLabel.Margin = new Padding(4, 0, 4, 0);
            headerTextLabel.Name = "headerTextLabel";
            headerTextLabel.Size = new Size(460, 25);
            headerTextLabel.TabIndex = 17;
            headerTextLabel.Text = "ΤΕΛΙΚΑ ΔΕΔΟΜΕΝΑ ΩΡΟΛΟΓΙΟΥ ΠΡΟΓΡΑΜΜΑΤΟΣ:";
            // 
            // dgGeneratedSchedulerId
            // 
            dgGeneratedSchedulerId.HeaderText = "Id ΠΡΟΓΡ. ΜΑΘ.";
            dgGeneratedSchedulerId.Name = "dgGeneratedSchedulerId";
            // 
            // dgGeneratedCourse
            // 
            dgGeneratedCourse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgGeneratedCourse.HeaderText = "ΜΑΘΗΜΑ";
            dgGeneratedCourse.Name = "dgGeneratedCourse";
            // 
            // dgGeneratedProfessor
            // 
            dgGeneratedProfessor.HeaderText = "ΚΑΘΗΓΗΤΗΣ";
            dgGeneratedProfessor.Name = "dgGeneratedProfessor";
            dgGeneratedProfessor.Width = 150;
            // 
            // dgGeneratedDuration
            // 
            dgGeneratedDuration.HeaderText = "ΔΙΑΡΚΕΙΑ";
            dgGeneratedDuration.Name = "dgGeneratedDuration";
            dgGeneratedDuration.Width = 75;
            // 
            // dgGeneratedSemester
            // 
            dgGeneratedSemester.HeaderText = "ΕΞΑΜΗΝΟ";
            dgGeneratedSemester.Name = "dgGeneratedSemester";
            dgGeneratedSemester.Width = 80;
            // 
            // dgGeneratedFinalDay
            // 
            dgGeneratedFinalDay.HeaderText = "ΤΕΛΙΚΗ ΗΜΕΡΑ";
            dgGeneratedFinalDay.Name = "dgGeneratedFinalDay";
            dgGeneratedFinalDay.Width = 80;
            // 
            // dgGeneratedFinalStartTime
            // 
            dgGeneratedFinalStartTime.HeaderText = "ΤΕΛΙΚΗ ΩΡΑ ΕΝΑΡΞΗΣ";
            dgGeneratedFinalStartTime.Name = "dgGeneratedFinalStartTime";
            dgGeneratedFinalStartTime.Width = 110;
            // 
            // dgGeneratedFinalRoom
            // 
            dgGeneratedFinalRoom.HeaderText = "ΤΕΛΙΚΗ ΑΙΘΟΥΣΑ";
            dgGeneratedFinalRoom.Name = "dgGeneratedFinalRoom";
            dgGeneratedFinalRoom.Width = 80;
            // 
            // GeneratedScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(969, 554);
            Controls.Add(headerTextLabel);
            Controls.Add(generatedSchedulerDataGridView);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GeneratedScheduleForm";
            Text = "ΤΕΛΙΚΑ ΔΕΔΟΜΕΝΑ ΩΡΟΛΟΓΙΟΥ ΠΡΟΓΡΑΜΜΑΤΟΣ";
            Load += GeneratedScheduleForm_Load;
            ((System.ComponentModel.ISupportInitialize)generatedSchedulerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView generatedSchedulerDataGridView;
        private Label headerTextLabel;
        private DataGridViewTextBoxColumn dgGeneratedSchedulerId;
        private DataGridViewTextBoxColumn dgGeneratedCourse;
        private DataGridViewTextBoxColumn dgGeneratedProfessor;
        private DataGridViewTextBoxColumn dgGeneratedDuration;
        private DataGridViewTextBoxColumn dgGeneratedSemester;
        private DataGridViewTextBoxColumn dgGeneratedFinalDay;
        private DataGridViewTextBoxColumn dgGeneratedFinalStartTime;
        private DataGridViewTextBoxColumn dgGeneratedFinalRoom;
    }
}