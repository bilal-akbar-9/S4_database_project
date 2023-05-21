namespace intial_form_1_
{
    partial class generateReport
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
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.studentReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.studentsReport = new System.Windows.Forms.TabPage();
            this.assignmentScoreReport = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assignmentReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.studentsReport.SuspendLayout();
            this.assignmentScoreReport.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // classroomName
            // 
            this.classroomName.AutoSize = true;
            this.classroomName.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classroomName.Location = new System.Drawing.Point(18, 12);
            this.classroomName.Name = "classroomName";
            this.classroomName.Size = new System.Drawing.Size(216, 31);
            this.classroomName.TabIndex = 1;
            this.classroomName.Text = "ClassroomName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.teacherNameLabel);
            this.panel1.Controls.Add(this.classroomName);
            this.panel1.Location = new System.Drawing.Point(3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 83);
            this.panel1.TabIndex = 28;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherNameLabel.Location = new System.Drawing.Point(21, 43);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(113, 20);
            this.teacherNameLabel.TabIndex = 5;
            this.teacherNameLabel.Text = "Teacher Name";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("HP Simplified Hans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(25, 451);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 40);
            this.backButton.TabIndex = 29;
            this.backButton.Text = "←";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // studentReport
            // 
            this.studentReport.LocalReport.ReportEmbeddedResource = "intial_form_1_.studentReport.rdlc";
            this.studentReport.Location = new System.Drawing.Point(28, 109);
            this.studentReport.Name = "studentReport";
            //this.studentReport.ServerReport.BearerToken = null;
            this.studentReport.Size = new System.Drawing.Size(841, 280);
            this.studentReport.TabIndex = 30;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.studentsReport);
            this.tabControl1.Controls.Add(this.assignmentScoreReport);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 447);
            this.tabControl1.TabIndex = 31;
            // 
            // studentsReport
            // 
            this.studentsReport.Controls.Add(this.panel1);
            this.studentsReport.Controls.Add(this.studentReport);
            this.studentsReport.Location = new System.Drawing.Point(4, 22);
            this.studentsReport.Name = "studentsReport";
            this.studentsReport.Padding = new System.Windows.Forms.Padding(3);
            this.studentsReport.Size = new System.Drawing.Size(910, 421);
            this.studentsReport.TabIndex = 0;
            this.studentsReport.Text = "Student Report";
            this.studentsReport.UseVisualStyleBackColor = true;
            // 
            // assignmentScoreReport
            // 
            this.assignmentScoreReport.Controls.Add(this.assignmentReport);
            this.assignmentScoreReport.Controls.Add(this.panel2);
            this.assignmentScoreReport.Location = new System.Drawing.Point(4, 22);
            this.assignmentScoreReport.Name = "assignmentScoreReport";
            this.assignmentScoreReport.Padding = new System.Windows.Forms.Padding(3);
            this.assignmentScoreReport.Size = new System.Drawing.Size(910, 421);
            this.assignmentScoreReport.TabIndex = 1;
            this.assignmentScoreReport.Text = "Assignment Score Report";
            this.assignmentScoreReport.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 83);
            this.panel2.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teacher Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "ClassroomName";
            // 
            // assignmentReport
            // 
            this.assignmentReport.LocalReport.ReportEmbeddedResource = "intial_form_1_.assignmentReport.rdlc";
            this.assignmentReport.Location = new System.Drawing.Point(35, 109);
            this.assignmentReport.Name = "assignmentReport";
            //this.assignmentReport.ServerReport.BearerToken = null;
            this.assignmentReport.Size = new System.Drawing.Size(841, 280);
            this.assignmentReport.TabIndex = 31;
            // 
            // generateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.backButton);
            this.Name = "generateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Report";
            this.Load += new System.EventHandler(this.generateReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.studentsReport.ResumeLayout(false);
            this.assignmentScoreReport.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label classroomName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Button backButton;
        private Microsoft.Reporting.WinForms.ReportViewer studentReport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage studentsReport;
        private System.Windows.Forms.TabPage assignmentScoreReport;
        private Microsoft.Reporting.WinForms.ReportViewer assignmentReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}