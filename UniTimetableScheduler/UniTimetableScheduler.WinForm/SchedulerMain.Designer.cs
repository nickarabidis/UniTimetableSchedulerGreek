﻿namespace Scheduler.WinForm
{
    partial class SchedulerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerMain));
            menuStrip = new MenuStrip();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            professorsToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            periodsToolStripMenuItem = new ToolStripMenuItem();
            preferencesToolStripMenuItem = new ToolStripMenuItem();
            dependenciesToolStripMenuItem = new ToolStripMenuItem();
            schedulerToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, professorsToolStripMenuItem, roomsToolStripMenuItem, periodsToolStripMenuItem, preferencesToolStripMenuItem, dependenciesToolStripMenuItem, schedulerToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(1234, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(89, 20);
            coursesToolStripMenuItem.Text = "ΜΑΘΗΜΑΤΑ";
            coursesToolStripMenuItem.Click += coursesToolStripMenuItem_Click;
            // 
            // professorsToolStripMenuItem
            // 
            professorsToolStripMenuItem.Name = "professorsToolStripMenuItem";
            professorsToolStripMenuItem.Size = new Size(85, 20);
            professorsToolStripMenuItem.Text = "ΚΑΘΗΓΗΤΕΣ";
            professorsToolStripMenuItem.Click += professorsToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(73, 20);
            roomsToolStripMenuItem.Text = "ΑΙΘΟΥΣΕΣ";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // periodsToolStripMenuItem
            // 
            periodsToolStripMenuItem.Name = "periodsToolStripMenuItem";
            periodsToolStripMenuItem.Size = new Size(130, 20);
            periodsToolStripMenuItem.Text = "ΧΡΟΝΙΚΟΙ ΠΕΡΙΟΔΟΙ";
            periodsToolStripMenuItem.Click += periodsToolStripMenuItem_Click;
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(94, 20);
            preferencesToolStripMenuItem.Text = "ΠΡΟΤΙΜΗΣΕΙΣ";
            preferencesToolStripMenuItem.Click += preferencesToolStripMenuItem_Click;
            // 
            // dependenciesToolStripMenuItem
            // 
            dependenciesToolStripMenuItem.Name = "dependenciesToolStripMenuItem";
            dependenciesToolStripMenuItem.Size = new Size(82, 20);
            dependenciesToolStripMenuItem.Text = "ΕΞΑΡΤΗΣΕΙΣ";
            dependenciesToolStripMenuItem.Click += dependenciesToolStripMenuItem_Click;
            // 
            // schedulerToolStripMenuItem
            // 
            schedulerToolStripMenuItem.Name = "schedulerToolStripMenuItem";
            schedulerToolStripMenuItem.Size = new Size(219, 20);
            schedulerToolStripMenuItem.Text = "ΠΡΟΓΡΑΜΜΑΤΙΣΜΟΣ ΜΑΘΗΜΑΤΩΝ";
            schedulerToolStripMenuItem.Click += schedulerToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 789);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1234, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(185, 17);
            toolStripStatusLabel.Text = "Developed by Nikolaos Arampidis";
            // 
            // SchedulerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 811);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SchedulerMain";
            Text = "ΑΡΧΙΚΗ ΟΘΟΝΗ";
            Load += SchedulerMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem professorsToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem periodsToolStripMenuItem;
        private ToolStripMenuItem dependenciesToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripMenuItem schedulerToolStripMenuItem;
    }
}



