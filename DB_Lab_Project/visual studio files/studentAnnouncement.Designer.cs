using System.Windows.Forms;

namespace intial_form_1_
{
    partial class studentAnnouncement
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
            this.AnnouncementTab = new System.Windows.Forms.TabPage();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noAnnouncementLabel = new System.Windows.Forms.Label();
            this.flowLayoutAnnouncement = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.classroomName = new System.Windows.Forms.Label();
            this.AnnouncementTABS = new System.Windows.Forms.TabControl();
            this.AnnouncementTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AnnouncementTABS.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnnouncementTab
            // 
            this.AnnouncementTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AnnouncementTab.Controls.Add(this.backButton);
            this.AnnouncementTab.Controls.Add(this.label1);
            this.AnnouncementTab.Controls.Add(this.noAnnouncementLabel);
            this.AnnouncementTab.Controls.Add(this.flowLayoutAnnouncement);
            this.AnnouncementTab.Location = new System.Drawing.Point(4, 22);
            this.AnnouncementTab.Name = "AnnouncementTab";
            this.AnnouncementTab.Size = new System.Drawing.Size(1066, 508);
            this.AnnouncementTab.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(17, 453);
            this.backButton.Margin = new System.Windows.Forms.Padding(1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 40);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "←";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(474, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Made by BTI with 💓";
            this.label1.Visible = false;
            // 
            // noAnnouncementLabel
            // 
            this.noAnnouncementLabel.AutoSize = true;
            this.noAnnouncementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noAnnouncementLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noAnnouncementLabel.Location = new System.Drawing.Point(22, 100);
            this.noAnnouncementLabel.Name = "noAnnouncementLabel";
            this.noAnnouncementLabel.Size = new System.Drawing.Size(194, 20);
            this.noAnnouncementLabel.TabIndex = 6;
            this.noAnnouncementLabel.Text = "No Announcement for you";
            // 
            // flowLayoutAnnouncement
            // 
            this.flowLayoutAnnouncement.AutoScroll = true;
            this.flowLayoutAnnouncement.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutAnnouncement.Location = new System.Drawing.Point(163, 100);
            this.flowLayoutAnnouncement.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutAnnouncement.Name = "flowLayoutAnnouncement";
            this.flowLayoutAnnouncement.Size = new System.Drawing.Size(760, 316);
            this.flowLayoutAnnouncement.TabIndex = 7;
            this.flowLayoutAnnouncement.Visible = false;
            this.flowLayoutAnnouncement.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.studentNameLabel);
            this.panel1.Controls.Add(this.classroomName);
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 83);
            this.panel1.TabIndex = 2;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentNameLabel.Location = new System.Drawing.Point(29, 55);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(51, 20);
            this.studentNameLabel.TabIndex = 4;
            this.studentNameLabel.Text = "label1";
            // 
            // classroomName
            // 
            this.classroomName.AutoSize = true;
            this.classroomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classroomName.Location = new System.Drawing.Point(18, 22);
            this.classroomName.Name = "classroomName";
            this.classroomName.Size = new System.Drawing.Size(210, 31);
            this.classroomName.TabIndex = 0;
            this.classroomName.Text = "Announcements";
            // 
            // AnnouncementTABS
            // 
            this.AnnouncementTABS.Controls.Add(this.AnnouncementTab);
            this.AnnouncementTABS.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnnouncementTABS.HotTrack = true;
            this.AnnouncementTABS.Location = new System.Drawing.Point(-1, -1);
            this.AnnouncementTABS.Name = "AnnouncementTABS";
            this.AnnouncementTABS.SelectedIndex = 0;
            this.AnnouncementTABS.Size = new System.Drawing.Size(1074, 534);
            this.AnnouncementTABS.TabIndex = 7;
            // 
            // studentAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnnouncementTABS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "studentAnnouncement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Announcements";
            this.Load += new System.EventHandler(this.studentAnnouncement_Load);
            this.AnnouncementTab.ResumeLayout(false);
            this.AnnouncementTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AnnouncementTABS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage AnnouncementTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAnnouncement;
        private System.Windows.Forms.Label noAnnouncementLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label classroomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl AnnouncementTABS;
        private System.Windows.Forms.Button backButton;
    }
}