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
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.classroomName = new System.Windows.Forms.Label();
            this.announcementButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignmentButton
            // 
            this.assignmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.assignmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentButton.Location = new System.Drawing.Point(145, 236);
            this.assignmentButton.Name = "assignmentButton";
            this.assignmentButton.Size = new System.Drawing.Size(633, 68);
            this.assignmentButton.TabIndex = 0;
            this.assignmentButton.Text = "Assignment";
            this.assignmentButton.UseVisualStyleBackColor = false;
            this.assignmentButton.Click += new System.EventHandler(this.createAssignmentButton_Clicked);
            // 
            // Material
            // 
            this.Material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Material.Location = new System.Drawing.Point(145, 342);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(633, 68);
            this.Material.TabIndex = 1;
            this.Material.Text = "Material";
            this.Material.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.teacherNameLabel);
            this.panel1.Controls.Add(this.classroomName);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 83);
            this.panel1.TabIndex = 0;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherNameLabel.Location = new System.Drawing.Point(26, 50);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(105, 18);
            this.teacherNameLabel.TabIndex = 5;
            this.teacherNameLabel.Text = "Teacher Name";
            // 
            // classroomName
            // 
            this.classroomName.AutoSize = true;
            this.classroomName.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classroomName.Location = new System.Drawing.Point(23, 19);
            this.classroomName.Name = "classroomName";
            this.classroomName.Size = new System.Drawing.Size(204, 31);
            this.classroomName.TabIndex = 1;
            this.classroomName.Text = "ClassroomName";
            // 
            // announcementButton
            // 
            this.announcementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.announcementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcementButton.Location = new System.Drawing.Point(145, 130);
            this.announcementButton.Name = "announcementButton";
            this.announcementButton.Size = new System.Drawing.Size(633, 68);
            this.announcementButton.TabIndex = 2;
            this.announcementButton.Text = "Announcement";
            this.announcementButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("HP Simplified Hans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(11, 461);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 40);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "←";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.announcementButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.assignmentButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Class_FormClosed);
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
        private System.Windows.Forms.Button announcementButton;
        private System.Windows.Forms.Button backButton;
    }
}