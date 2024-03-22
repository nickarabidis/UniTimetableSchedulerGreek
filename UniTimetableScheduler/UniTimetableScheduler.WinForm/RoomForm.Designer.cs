namespace Scheduler.WinForm
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            roomLabComboBox = new ComboBox();
            roomLabLabel = new Label();
            roomDataGridView = new DataGridView();
            roomLabel = new Label();
            roomIdLabel = new Label();
            roomNameLabel = new Label();
            roomIdTextBox = new TextBox();
            roomNameTextBox = new TextBox();
            roomClearButton = new Button();
            roomDeleteButton = new Button();
            roomAddButton = new Button();
            roomErrorProvider = new ErrorProvider(components);
            totalRoomValueLabel = new Label();
            totalRoomsLabel = new Label();
            deleteAllButton = new Button();
            printButton = new Button();
            dgRoomId = new DataGridViewTextBoxColumn();
            dgRoomName = new DataGridViewTextBoxColumn();
            dgRoomLab = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // roomLabComboBox
            // 
            roomLabComboBox.FormattingEnabled = true;
            roomLabComboBox.Location = new Point(378, 107);
            roomLabComboBox.Name = "roomLabComboBox";
            roomLabComboBox.Size = new Size(162, 25);
            roomLabComboBox.TabIndex = 32;
            // 
            // roomLabLabel
            // 
            roomLabLabel.AutoSize = true;
            roomLabLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabLabel.Location = new Point(290, 110);
            roomLabLabel.Name = "roomLabLabel";
            roomLabLabel.Size = new Size(82, 17);
            roomLabLabel.TabIndex = 31;
            roomLabLabel.Text = "ΕΡΓΑΣΤΗΡΙΟ:";
            // 
            // roomDataGridView
            // 
            roomDataGridView.AllowUserToAddRows = false;
            roomDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            roomDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomDataGridView.Columns.AddRange(new DataGridViewColumn[] { dgRoomId, dgRoomName, dgRoomLab });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            roomDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            roomDataGridView.Location = new Point(76, 213);
            roomDataGridView.Name = "roomDataGridView";
            roomDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomDataGridView.Size = new Size(464, 239);
            roomDataGridView.TabIndex = 30;
            roomDataGridView.MouseDoubleClick += roomDataGridView_MouseDoubleClick;
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabel.Location = new Point(244, 35);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(102, 25);
            roomLabel.TabIndex = 29;
            roomLabel.Text = "ΑΙΘΟΥΣΕΣ:";
            // 
            // roomIdLabel
            // 
            roomIdLabel.AutoSize = true;
            roomIdLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            roomIdLabel.Location = new Point(48, 110);
            roomIdLabel.Name = "roomIdLabel";
            roomIdLabel.Size = new Size(22, 17);
            roomIdLabel.TabIndex = 28;
            roomIdLabel.Text = "Id:";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            roomNameLabel.Location = new Point(12, 143);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new Size(61, 17);
            roomNameLabel.TabIndex = 27;
            roomNameLabel.Text = "ΟΝΟΜΑ:";
            // 
            // roomIdTextBox
            // 
            roomIdTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            roomIdTextBox.Location = new Point(76, 107);
            roomIdTextBox.Margin = new Padding(3, 4, 3, 4);
            roomIdTextBox.Name = "roomIdTextBox";
            roomIdTextBox.Size = new Size(185, 25);
            roomIdTextBox.TabIndex = 26;
            roomIdTextBox.KeyPress += roomIdTextBox_KeyPress;
            // 
            // roomNameTextBox
            // 
            roomNameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            roomNameTextBox.Location = new Point(76, 140);
            roomNameTextBox.Margin = new Padding(3, 4, 3, 4);
            roomNameTextBox.Name = "roomNameTextBox";
            roomNameTextBox.Size = new Size(464, 25);
            roomNameTextBox.TabIndex = 25;
            // 
            // roomClearButton
            // 
            roomClearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            roomClearButton.Location = new Point(352, 172);
            roomClearButton.Name = "roomClearButton";
            roomClearButton.Size = new Size(78, 35);
            roomClearButton.TabIndex = 35;
            roomClearButton.Text = "Clear";
            roomClearButton.UseVisualStyleBackColor = true;
            roomClearButton.Click += roomClearButton_Click;
            // 
            // roomDeleteButton
            // 
            roomDeleteButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            roomDeleteButton.Location = new Point(268, 172);
            roomDeleteButton.Name = "roomDeleteButton";
            roomDeleteButton.Size = new Size(78, 35);
            roomDeleteButton.TabIndex = 34;
            roomDeleteButton.Text = "Delete";
            roomDeleteButton.UseVisualStyleBackColor = true;
            roomDeleteButton.Click += roomDeleteButton_Click;
            // 
            // roomAddButton
            // 
            roomAddButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            roomAddButton.Location = new Point(184, 172);
            roomAddButton.Name = "roomAddButton";
            roomAddButton.Size = new Size(78, 35);
            roomAddButton.TabIndex = 33;
            roomAddButton.Text = "Add";
            roomAddButton.UseVisualStyleBackColor = true;
            roomAddButton.Click += roomAddButton_Click;
            // 
            // roomErrorProvider
            // 
            roomErrorProvider.ContainerControl = this;
            // 
            // totalRoomValueLabel
            // 
            totalRoomValueLabel.AutoSize = true;
            totalRoomValueLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalRoomValueLabel.Location = new Point(200, 455);
            totalRoomValueLabel.Name = "totalRoomValueLabel";
            totalRoomValueLabel.Size = new Size(13, 15);
            totalRoomValueLabel.TabIndex = 41;
            totalRoomValueLabel.Text = "0";
            // 
            // totalRoomsLabel
            // 
            totalRoomsLabel.AutoSize = true;
            totalRoomsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalRoomsLabel.Location = new Point(73, 455);
            totalRoomsLabel.Name = "totalRoomsLabel";
            totalRoomsLabel.Size = new Size(121, 15);
            totalRoomsLabel.TabIndex = 40;
            totalRoomsLabel.Text = "ΣΥΝΟΛΟ ΑΙΘΟΥΣΩΝ:";
            // 
            // deleteAllButton
            // 
            deleteAllButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteAllButton.Location = new Point(463, 172);
            deleteAllButton.Name = "deleteAllButton";
            deleteAllButton.Size = new Size(77, 35);
            deleteAllButton.TabIndex = 42;
            deleteAllButton.Text = "Delete All";
            deleteAllButton.UseVisualStyleBackColor = true;
            deleteAllButton.Click += deleteAllButton_Click;
            // 
            // printButton
            // 
            printButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            printButton.Location = new Point(463, 455);
            printButton.Margin = new Padding(4);
            printButton.Name = "printButton";
            printButton.Size = new Size(77, 34);
            printButton.TabIndex = 75;
            printButton.Text = "Print Data";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // dgRoomId
            // 
            dgRoomId.HeaderText = "Id";
            dgRoomId.Name = "dgRoomId";
            dgRoomId.Width = 70;
            // 
            // dgRoomName
            // 
            dgRoomName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgRoomName.HeaderText = "ΟΝΟΜΑ";
            dgRoomName.Name = "dgRoomName";
            // 
            // dgRoomLab
            // 
            dgRoomLab.HeaderText = "ΕΡΓ";
            dgRoomLab.Name = "dgRoomLab";
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(598, 503);
            Controls.Add(printButton);
            Controls.Add(deleteAllButton);
            Controls.Add(totalRoomValueLabel);
            Controls.Add(totalRoomsLabel);
            Controls.Add(roomClearButton);
            Controls.Add(roomDeleteButton);
            Controls.Add(roomAddButton);
            Controls.Add(roomLabComboBox);
            Controls.Add(roomLabLabel);
            Controls.Add(roomDataGridView);
            Controls.Add(roomLabel);
            Controls.Add(roomIdLabel);
            Controls.Add(roomNameLabel);
            Controls.Add(roomIdTextBox);
            Controls.Add(roomNameTextBox);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "RoomForm";
            Text = "ΑΙΘΟΥΣΑ";
            Load += RoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)roomDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox roomLabComboBox;
        private System.Windows.Forms.Label roomLabLabel;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label roomIdLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.TextBox roomIdTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Button roomClearButton;
        private System.Windows.Forms.Button roomDeleteButton;
        private System.Windows.Forms.Button roomAddButton;
        private System.Windows.Forms.ErrorProvider roomErrorProvider;
        private System.Windows.Forms.Label totalRoomValueLabel;
        private System.Windows.Forms.Label totalRoomsLabel;
        private Button deleteAllButton;
        private Button printButton;
        private DataGridViewTextBoxColumn dgRoomId;
        private DataGridViewTextBoxColumn dgRoomName;
        private DataGridViewTextBoxColumn dgRoomLab;
    }
}