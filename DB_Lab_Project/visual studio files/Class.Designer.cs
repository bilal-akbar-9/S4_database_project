using System;

namespace intial_form_1_
{
    partial class Class
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
            this.assignmentButton = new System.Windows.Forms.Button();
            this.Material = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classroomName = new System.Windows.Forms.Label();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignmentButton
            // 
            this.assignmentButton.Location = new System.Drawing.Point(27, 112);
            this.assignmentButton.Name = "assignmentButton";
            this.assignmentButton.Size = new System.Drawing.Size(75, 23);
            this.assignmentButton.TabIndex = 0;
            this.assignmentButton.Text = "Assignment";
            this.assignmentButton.UseVisualStyleBackColor = true;
            this.assignmentButton.Click += new System.EventHandler(this.createAssignmentButton_Clicked);
            // 
            // Material
            // 
            this.Material.Location = new System.Drawing.Point(27, 160);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(75, 23);
            this.Material.TabIndex = 1;
            this.Material.Text = "Material";
            this.Material.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.teacherNameLabel);
            this.panel1.Controls.Add(this.classroomName);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 83);
            this.panel1.TabIndex = 0;
            // 
            // classroomName
            // 
            this.classroomName.AutoSize = true;
            this.classroomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classroomName.Location = new System.Drawing.Point(23, 19);
            this.classroomName.Name = "classroomName";
            this.classroomName.Size = new System.Drawing.Size(216, 31);
            this.classroomName.TabIndex = 1;
            this.classroomName.Text = "ClassroomName";
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherNameLabel.Location = new System.Drawing.Point(25, 50);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(113, 20);
            this.teacherNameLabel.TabIndex = 5;
            this.teacherNameLabel.Text = "Teacher Name";
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.assignmentButton);
            this.Name = "Class";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.Class_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button assignmentButton;
        private System.Windows.Forms.Button Material;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label classroomName;
        private System.Windows.Forms.Label teacherNameLabel;
    }
}