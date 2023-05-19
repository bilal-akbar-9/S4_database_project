namespace intial_form_1_
{
    partial class StudentAssignments
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
            this.backButtonStu = new System.Windows.Forms.Button();
            this.flowLayoutStudentAssignment = new System.Windows.Forms.FlowLayoutPanel();
            this.noClassLabelStu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacherNameStudentLabel = new System.Windows.Forms.Label();
            this.classroomStuName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButtonStu
            // 
            this.backButtonStu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backButtonStu.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.backButtonStu.FlatAppearance.BorderSize = 3;
            this.backButtonStu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButtonStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtonStu.ForeColor = System.Drawing.Color.White;
            this.backButtonStu.Location = new System.Drawing.Point(35, 731);
            this.backButtonStu.Margin = new System.Windows.Forms.Padding(2);
            this.backButtonStu.Name = "backButtonStu";
            this.backButtonStu.Size = new System.Drawing.Size(129, 62);
            this.backButtonStu.TabIndex = 32;
            this.backButtonStu.Text = "←";
            this.backButtonStu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButtonStu.UseVisualStyleBackColor = false;
            this.backButtonStu.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flowLayoutStudentAssignment
            // 
            this.flowLayoutStudentAssignment.AutoScroll = true;
            this.flowLayoutStudentAssignment.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutStudentAssignment.Location = new System.Drawing.Point(245, 206);
            this.flowLayoutStudentAssignment.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutStudentAssignment.Name = "flowLayoutStudentAssignment";
            this.flowLayoutStudentAssignment.Size = new System.Drawing.Size(1152, 486);
            this.flowLayoutStudentAssignment.TabIndex = 31;
            this.flowLayoutStudentAssignment.Visible = false;
            this.flowLayoutStudentAssignment.WrapContents = false;
            // 
            // noClassLabelStu
            // 
            this.noClassLabelStu.AutoSize = true;
            this.noClassLabelStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noClassLabelStu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noClassLabelStu.Location = new System.Drawing.Point(13, 206);
            this.noClassLabelStu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noClassLabelStu.Name = "noClassLabelStu";
            this.noClassLabelStu.Size = new System.Drawing.Size(164, 29);
            this.noClassLabelStu.TabIndex = 30;
            this.noClassLabelStu.Text = "No Class Text";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.teacherNameStudentLabel);
            this.panel1.Controls.Add(this.classroomStuName);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1599, 129);
            this.panel1.TabIndex = 28;
            // 
            // teacherNameStudentLabel
            // 
            this.teacherNameStudentLabel.AutoSize = true;
            this.teacherNameStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameStudentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherNameStudentLabel.Location = new System.Drawing.Point(44, 85);
            this.teacherNameStudentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teacherNameStudentLabel.Name = "teacherNameStudentLabel";
            this.teacherNameStudentLabel.Size = new System.Drawing.Size(79, 29);
            this.teacherNameStudentLabel.TabIndex = 4;
            this.teacherNameStudentLabel.Text = "label1";
            // 
            // classroomStuName
            // 
            this.classroomStuName.AutoSize = true;
            this.classroomStuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomStuName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classroomStuName.Location = new System.Drawing.Point(27, 34);
            this.classroomStuName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classroomStuName.Name = "classroomStuName";
            this.classroomStuName.Size = new System.Drawing.Size(257, 47);
            this.classroomStuName.TabIndex = 0;
            this.classroomStuName.Text = "Assignments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(709, 764);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Made by BTI with 💓";
            this.label1.Visible = false;
            // 
            // StudentAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1601, 827);
            this.Controls.Add(this.backButtonStu);
            this.Controls.Add(this.flowLayoutStudentAssignment);
            this.Controls.Add(this.noClassLabelStu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "StudentAssignments";
            this.Text = "StudentAssignments";
            this.Activated += new System.EventHandler(this.loadAssignmentAtStartPageStudentClas);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButtonStu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutStudentAssignment;
        private System.Windows.Forms.Label noClassLabelStu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label teacherNameStudentLabel;
        private System.Windows.Forms.Label classroomStuName;
        private System.Windows.Forms.Label label1;
    }
}