namespace intial_form_1_
{
    partial class classroom
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlClassroom = new System.Windows.Forms.TabControl();
            this.ClassesP = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.noClassLabel = new System.Windows.Forms.Label();
            this.AddClassP = new System.Windows.Forms.TabPage();
            this.Add = new System.Windows.Forms.Button();
            this.classNameField1 = new System.Windows.Forms.TextBox();
            this.className = new System.Windows.Forms.Label();
            this.classCodeField1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateClassP = new System.Windows.Forms.TabPage();
            this.update = new System.Windows.Forms.Button();
            this.classNameField2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.classCodeField2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RemoveClassP = new System.Windows.Forms.TabPage();
            this.remove = new System.Windows.Forms.Button();
            this.classCodeField3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.assignmentButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControlClassroom.SuspendLayout();
            this.ClassesP.SuspendLayout();
            this.AddClassP.SuspendLayout();
            this.panel2.SuspendLayout();
            this.UpdateClassP.SuspendLayout();
            this.panel4.SuspendLayout();
            this.RemoveClassP.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // classroomName
            // 
            this.classroomName.AutoSize = true;
            this.classroomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classroomName.Location = new System.Drawing.Point(18, 24);
            this.classroomName.Name = "classroomName";
            this.classroomName.Size = new System.Drawing.Size(144, 31);
            this.classroomName.TabIndex = 0;
            this.classroomName.Text = "Classroom";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.teacherNameLabel);
            this.panel1.Controls.Add(this.classroomName);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 83);
            this.panel1.TabIndex = 2;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherNameLabel.Location = new System.Drawing.Point(893, 48);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(51, 20);
            this.teacherNameLabel.TabIndex = 4;
            this.teacherNameLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(480, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Made by BTI with 💓";
            this.label1.Visible = false;
            // 
            // tabControlClassroom
            // 
            this.tabControlClassroom.Controls.Add(this.ClassesP);
            this.tabControlClassroom.Controls.Add(this.AddClassP);
            this.tabControlClassroom.Controls.Add(this.UpdateClassP);
            this.tabControlClassroom.Controls.Add(this.RemoveClassP);
            this.tabControlClassroom.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControlClassroom.HotTrack = true;
            this.tabControlClassroom.Location = new System.Drawing.Point(-3, -2);
            this.tabControlClassroom.Name = "tabControlClassroom";
            this.tabControlClassroom.SelectedIndex = 0;
            this.tabControlClassroom.Size = new System.Drawing.Size(1094, 542);
            this.tabControlClassroom.TabIndex = 6;
            // 
            // ClassesP
            // 
            this.ClassesP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClassesP.Controls.Add(this.assignmentButton);
            this.ClassesP.Controls.Add(this.flowLayoutPanel1);
            this.ClassesP.Controls.Add(this.noClassLabel);
            this.ClassesP.Controls.Add(this.panel1);
            this.ClassesP.Controls.Add(this.label1);
            this.ClassesP.Location = new System.Drawing.Point(4, 22);
            this.ClassesP.Name = "ClassesP";
            this.ClassesP.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesP.Size = new System.Drawing.Size(1086, 516);
            this.ClassesP.TabIndex = 0;
            this.ClassesP.Text = "Classes";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 152);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1011, 238);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Visible = false;
            // 
            // noClassLabel
            // 
            this.noClassLabel.AutoSize = true;
            this.noClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noClassLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noClassLabel.Location = new System.Drawing.Point(16, 111);
            this.noClassLabel.Name = "noClassLabel";
            this.noClassLabel.Size = new System.Drawing.Size(106, 20);
            this.noClassLabel.TabIndex = 6;
            this.noClassLabel.Text = "No Class Text";
            this.noClassLabel.Visible = false;
            // 
            // AddClassP
            // 
            this.AddClassP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddClassP.Controls.Add(this.Add);
            this.AddClassP.Controls.Add(this.classNameField1);
            this.AddClassP.Controls.Add(this.className);
            this.AddClassP.Controls.Add(this.classCodeField1);
            this.AddClassP.Controls.Add(this.label12);
            this.AddClassP.Controls.Add(this.label8);
            this.AddClassP.Controls.Add(this.panel2);
            this.AddClassP.Location = new System.Drawing.Point(4, 22);
            this.AddClassP.Name = "AddClassP";
            this.AddClassP.Padding = new System.Windows.Forms.Padding(3);
            this.AddClassP.Size = new System.Drawing.Size(1086, 516);
            this.AddClassP.TabIndex = 1;
            this.AddClassP.Text = "Add Class";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.Add.FlatAppearance.BorderSize = 3;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(475, 302);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(304, 35);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // classNameField1
            // 
            this.classNameField1.Location = new System.Drawing.Point(475, 213);
            this.classNameField1.Multiline = true;
            this.classNameField1.Name = "classNameField1";
            this.classNameField1.Size = new System.Drawing.Size(304, 30);
            this.classNameField1.TabIndex = 10;
            // 
            // className
            // 
            this.className.AutoSize = true;
            this.className.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.className.Location = new System.Drawing.Point(307, 213);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(111, 24);
            this.className.TabIndex = 9;
            this.className.Text = "Class Name";
            // 
            // classCodeField1
            // 
            this.classCodeField1.Location = new System.Drawing.Point(475, 154);
            this.classCodeField1.Multiline = true;
            this.classCodeField1.Name = "classCodeField1";
            this.classCodeField1.Size = new System.Drawing.Size(304, 30);
            this.classCodeField1.TabIndex = 8;
            this.classCodeField1.TextChanged += new System.EventHandler(this.classCode_TextChanged);
            this.classCodeField1.GotFocus += new System.EventHandler(this.classCode_GotFocus);
            this.classCodeField1.LostFocus += new System.EventHandler(this.classCode_LostFocus);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(307, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "Class Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(480, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Made by BTI with 💓";
            this.label8.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 83);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(893, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Class";
            // 
            // UpdateClassP
            // 
            this.UpdateClassP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateClassP.Controls.Add(this.update);
            this.UpdateClassP.Controls.Add(this.classNameField2);
            this.UpdateClassP.Controls.Add(this.label13);
            this.UpdateClassP.Controls.Add(this.classCodeField2);
            this.UpdateClassP.Controls.Add(this.label15);
            this.UpdateClassP.Controls.Add(this.label10);
            this.UpdateClassP.Controls.Add(this.panel4);
            this.UpdateClassP.Location = new System.Drawing.Point(4, 22);
            this.UpdateClassP.Name = "UpdateClassP";
            this.UpdateClassP.Size = new System.Drawing.Size(1086, 516);
            this.UpdateClassP.TabIndex = 3;
            this.UpdateClassP.Text = "Update Class";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.update.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.update.FlatAppearance.BorderSize = 3;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(475, 302);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(304, 35);
            this.update.TabIndex = 16;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // classNameField2
            // 
            this.classNameField2.Location = new System.Drawing.Point(475, 213);
            this.classNameField2.Multiline = true;
            this.classNameField2.Name = "classNameField2";
            this.classNameField2.Size = new System.Drawing.Size(304, 30);
            this.classNameField2.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(307, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "Class Name";
            // 
            // classCodeField2
            // 
            this.classCodeField2.Location = new System.Drawing.Point(475, 154);
            this.classCodeField2.Multiline = true;
            this.classCodeField2.Name = "classCodeField2";
            this.classCodeField2.Size = new System.Drawing.Size(304, 30);
            this.classCodeField2.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(307, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Class Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(480, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Made by BTI with 💓";
            this.label10.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(-2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1089, 83);
            this.panel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(893, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "label1";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(18, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Update Class";
            // 
            // RemoveClassP
            // 
            this.RemoveClassP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveClassP.Controls.Add(this.remove);
            this.RemoveClassP.Controls.Add(this.classCodeField3);
            this.RemoveClassP.Controls.Add(this.label14);
            this.RemoveClassP.Controls.Add(this.label9);
            this.RemoveClassP.Controls.Add(this.panel3);
            this.RemoveClassP.Location = new System.Drawing.Point(4, 22);
            this.RemoveClassP.Name = "RemoveClassP";
            this.RemoveClassP.Size = new System.Drawing.Size(1086, 516);
            this.RemoveClassP.TabIndex = 2;
            this.RemoveClassP.Text = "Remove Class";
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.remove.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.remove.FlatAppearance.BorderSize = 3;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(475, 238);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(304, 35);
            this.remove.TabIndex = 16;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // classCodeField3
            // 
            this.classCodeField3.Location = new System.Drawing.Point(475, 154);
            this.classCodeField3.Multiline = true;
            this.classCodeField3.Name = "classCodeField3";
            this.classCodeField3.Size = new System.Drawing.Size(304, 30);
            this.classCodeField3.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(307, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "Class Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(480, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Made by BTI with 💓";
            this.label9.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(-3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 83);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(893, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "label1";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Remove Class";
            // 
            // assignmentButton
            // 
            this.assignmentButton.Location = new System.Drawing.Point(909, 111);
            this.assignmentButton.Name = "assignmentButton";
            this.assignmentButton.Size = new System.Drawing.Size(75, 23);
            this.assignmentButton.TabIndex = 8;
            this.assignmentButton.Text = "Assignment";
            this.assignmentButton.UseVisualStyleBackColor = true;
            this.assignmentButton.Click += new System.EventHandler(this.createAssignmentButton);
            // 
            // classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 536);
            this.Controls.Add(this.tabControlClassroom);
            this.Name = "classroom";
            this.Text = "classroom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.classroom_FormClosed);
            this.Load += new System.EventHandler(this.classroom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlClassroom.ResumeLayout(false);
            this.ClassesP.ResumeLayout(false);
            this.ClassesP.PerformLayout();
            this.AddClassP.ResumeLayout(false);
            this.AddClassP.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.UpdateClassP.ResumeLayout(false);
            this.UpdateClassP.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.RemoveClassP.ResumeLayout(false);
            this.RemoveClassP.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label classroomName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlClassroom;
        private System.Windows.Forms.TabPage ClassesP;
        private System.Windows.Forms.TabPage AddClassP;
        private System.Windows.Forms.TabPage RemoveClassP;
        private System.Windows.Forms.TabPage UpdateClassP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label noClassLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox classCodeField1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox classNameField1;
        private System.Windows.Forms.Label className;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox classCodeField3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox classNameField2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox classCodeField2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button assignmentButton;
    }
}