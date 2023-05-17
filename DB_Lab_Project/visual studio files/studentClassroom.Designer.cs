namespace intial_form_1_
{
    partial class studentClassroom
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
            this.classroomName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlClassroom = new System.Windows.Forms.TabControl();
            this.ClassesPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.noClassLabel = new System.Windows.Forms.Label();
            this.manageClasses = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.enrollUnenrollButton = new System.Windows.Forms.Button();
            this.unenrollRadioButton = new System.Windows.Forms.RadioButton();
            this.enrollRadioButton = new System.Windows.Forms.RadioButton();
            this.classCodeField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControlClassroom.SuspendLayout();
            this.ClassesPage.SuspendLayout();
            this.manageClasses.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // classroomName
            // 
            this.classroomName.AutoSize = true;
            this.classroomName.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classroomName.Location = new System.Drawing.Point(16, 18);
            this.classroomName.Name = "classroomName";
            this.classroomName.Size = new System.Drawing.Size(136, 31);
            this.classroomName.TabIndex = 0;
            this.classroomName.Text = "Classroom";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.studentNameLabel);
            this.panel1.Controls.Add(this.classroomName);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 83);
            this.panel1.TabIndex = 2;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentNameLabel.Location = new System.Drawing.Point(27, 51);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(50, 18);
            this.studentNameLabel.TabIndex = 4;
            this.studentNameLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(479, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Made by BTI with 💓";
            this.label1.Visible = false;
            // 
            // tabControlClassroom
            // 
            this.tabControlClassroom.Controls.Add(this.ClassesPage);
            this.tabControlClassroom.Controls.Add(this.manageClasses);
            this.tabControlClassroom.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControlClassroom.HotTrack = true;
            this.tabControlClassroom.Location = new System.Drawing.Point(-3, -2);
            this.tabControlClassroom.Name = "tabControlClassroom";
            this.tabControlClassroom.SelectedIndex = 0;
            this.tabControlClassroom.Size = new System.Drawing.Size(1094, 542);
            this.tabControlClassroom.TabIndex = 6;
            // 
            // ClassesPage
            // 
            this.ClassesPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClassesPage.Controls.Add(this.flowLayoutPanel1);
            this.ClassesPage.Controls.Add(this.noClassLabel);
            this.ClassesPage.Controls.Add(this.panel1);
            this.ClassesPage.Controls.Add(this.label1);
            this.ClassesPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesPage.Name = "ClassesPage";
            this.ClassesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesPage.Size = new System.Drawing.Size(1086, 516);
            this.ClassesPage.TabIndex = 0;
            this.ClassesPage.Text = "Classes";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 152);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1011, 292);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Visible = false;
            // 
            // noClassLabel
            // 
            this.noClassLabel.AutoSize = true;
            this.noClassLabel.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noClassLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noClassLabel.Location = new System.Drawing.Point(16, 111);
            this.noClassLabel.Name = "noClassLabel";
            this.noClassLabel.Size = new System.Drawing.Size(98, 18);
            this.noClassLabel.TabIndex = 6;
            this.noClassLabel.Text = "No Class Text";
            this.noClassLabel.Visible = false;
            // 
            // manageClasses
            // 
            this.manageClasses.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manageClasses.Controls.Add(this.label17);
            this.manageClasses.Controls.Add(this.enrollUnenrollButton);
            this.manageClasses.Controls.Add(this.unenrollRadioButton);
            this.manageClasses.Controls.Add(this.enrollRadioButton);
            this.manageClasses.Controls.Add(this.classCodeField);
            this.manageClasses.Controls.Add(this.label12);
            this.manageClasses.Controls.Add(this.label11);
            this.manageClasses.Controls.Add(this.panel5);
            this.manageClasses.Location = new System.Drawing.Point(4, 22);
            this.manageClasses.Name = "manageClasses";
            this.manageClasses.Size = new System.Drawing.Size(1086, 516);
            this.manageClasses.TabIndex = 4;
            this.manageClasses.Text = "Enroll/Unenroll Classes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("HP Simplified Hans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(263, 226);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 22);
            this.label17.TabIndex = 14;
            this.label17.Text = "Enroll/Unenroll";
            // 
            // enrollUnenrollButton
            // 
            this.enrollUnenrollButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.enrollUnenrollButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.enrollUnenrollButton.FlatAppearance.BorderSize = 3;
            this.enrollUnenrollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrollUnenrollButton.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollUnenrollButton.Location = new System.Drawing.Point(460, 290);
            this.enrollUnenrollButton.Name = "enrollUnenrollButton";
            this.enrollUnenrollButton.Size = new System.Drawing.Size(304, 35);
            this.enrollUnenrollButton.TabIndex = 13;
            this.enrollUnenrollButton.Text = "Enroll";
            this.enrollUnenrollButton.UseVisualStyleBackColor = false;
            this.enrollUnenrollButton.Click += new System.EventHandler(this.enrollUnenrollButton_Click);
            // 
            // unenrollRadioButton
            // 
            this.unenrollRadioButton.AutoSize = true;
            this.unenrollRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.unenrollRadioButton.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unenrollRadioButton.ForeColor = System.Drawing.Color.Red;
            this.unenrollRadioButton.Location = new System.Drawing.Point(678, 226);
            this.unenrollRadioButton.Name = "unenrollRadioButton";
            this.unenrollRadioButton.Size = new System.Drawing.Size(85, 22);
            this.unenrollRadioButton.TabIndex = 12;
            this.unenrollRadioButton.TabStop = true;
            this.unenrollRadioButton.Text = "Unenroll";
            this.unenrollRadioButton.UseVisualStyleBackColor = false;
            this.unenrollRadioButton.CheckedChanged += new System.EventHandler(this.unenrollRadioButton_CheckedChanged);
            // 
            // enrollRadioButton
            // 
            this.enrollRadioButton.AutoSize = true;
            this.enrollRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.enrollRadioButton.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollRadioButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.enrollRadioButton.Location = new System.Drawing.Point(460, 226);
            this.enrollRadioButton.Name = "enrollRadioButton";
            this.enrollRadioButton.Size = new System.Drawing.Size(67, 22);
            this.enrollRadioButton.TabIndex = 11;
            this.enrollRadioButton.TabStop = true;
            this.enrollRadioButton.Text = "Enroll";
            this.enrollRadioButton.UseVisualStyleBackColor = false;
            this.enrollRadioButton.CheckedChanged += new System.EventHandler(this.enrollRadioButton_CheckedChanged);
            // 
            // classCodeField
            // 
            this.classCodeField.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCodeField.Location = new System.Drawing.Point(460, 164);
            this.classCodeField.Multiline = true;
            this.classCodeField.Name = "classCodeField";
            this.classCodeField.Size = new System.Drawing.Size(304, 30);
            this.classCodeField.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("HP Simplified Hans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(263, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Class Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(477, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Made by BTI with 💓";
            this.label11.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(-1, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1089, 83);
            this.panel5.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(16, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(283, 31);
            this.label16.TabIndex = 7;
            this.label16.Text = "Enroll/Unenroll Classes";
            // 
            // studentClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 536);
            this.Controls.Add(this.tabControlClassroom);
            this.Name = "studentClassroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.studentClassroom_FormClosed);
            this.Load += new System.EventHandler(this.studentClassroom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlClassroom.ResumeLayout(false);
            this.ClassesPage.ResumeLayout(false);
            this.ClassesPage.PerformLayout();
            this.manageClasses.ResumeLayout(false);
            this.manageClasses.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label classroomName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlClassroom;
        private System.Windows.Forms.TabPage ClassesPage;
        private System.Windows.Forms.Label noClassLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage manageClasses;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton unenrollRadioButton;
        private System.Windows.Forms.RadioButton enrollRadioButton;
        private System.Windows.Forms.TextBox classCodeField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button enrollUnenrollButton;
    }
}