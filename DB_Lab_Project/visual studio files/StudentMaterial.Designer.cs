namespace intial_form_1_
{
    partial class StudentMaterial
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
            this.MaterialbackButton = new System.Windows.Forms.Button();
            this.flowLayoutStudentMaterial = new System.Windows.Forms.FlowLayoutPanel();
            this.stdNoMaterialLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stdNamelabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaterialbackButton
            // 
            this.MaterialbackButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MaterialbackButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.MaterialbackButton.FlatAppearance.BorderSize = 3;
            this.MaterialbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaterialbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialbackButton.ForeColor = System.Drawing.Color.White;
            this.MaterialbackButton.Location = new System.Drawing.Point(23, 475);
            this.MaterialbackButton.Margin = new System.Windows.Forms.Padding(1);
            this.MaterialbackButton.Name = "MaterialbackButton";
            this.MaterialbackButton.Size = new System.Drawing.Size(86, 40);
            this.MaterialbackButton.TabIndex = 32;
            this.MaterialbackButton.Text = "←";
            this.MaterialbackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MaterialbackButton.UseVisualStyleBackColor = false;
            this.MaterialbackButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flowLayoutStudentMaterial
            // 
            this.flowLayoutStudentMaterial.AutoScroll = true;
            this.flowLayoutStudentMaterial.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutStudentMaterial.Location = new System.Drawing.Point(163, 134);
            this.flowLayoutStudentMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutStudentMaterial.Name = "flowLayoutStudentMaterial";
            this.flowLayoutStudentMaterial.Size = new System.Drawing.Size(768, 316);
            this.flowLayoutStudentMaterial.TabIndex = 31;
            this.flowLayoutStudentMaterial.Visible = false;
            this.flowLayoutStudentMaterial.WrapContents = false;
            // 
            // stdNoMaterialLabel
            // 
            this.stdNoMaterialLabel.AutoSize = true;
            this.stdNoMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdNoMaterialLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stdNoMaterialLabel.Location = new System.Drawing.Point(9, 134);
            this.stdNoMaterialLabel.Name = "stdNoMaterialLabel";
            this.stdNoMaterialLabel.Size = new System.Drawing.Size(106, 20);
            this.stdNoMaterialLabel.TabIndex = 30;
            this.stdNoMaterialLabel.Text = "No Class Text";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.stdNamelabel);
            this.panel1.Controls.Add(this.materialLabel);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 84);
            this.panel1.TabIndex = 28;
            // 
            // stdNamelabel
            // 
            this.stdNamelabel.AutoSize = true;
            this.stdNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdNamelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stdNamelabel.Location = new System.Drawing.Point(27, 55);
            this.stdNamelabel.Name = "stdNamelabel";
            this.stdNamelabel.Size = new System.Drawing.Size(49, 20);
            this.stdNamelabel.TabIndex = 4;
            this.stdNamelabel.Text = "name";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel.Location = new System.Drawing.Point(16, 22);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(110, 31);
            this.materialLabel.TabIndex = 0;
            this.materialLabel.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(473, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Made by BTI with 💓";
            this.label1.Visible = false;
            // 
            // StudentMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 538);
            this.Controls.Add(this.MaterialbackButton);
            this.Controls.Add(this.flowLayoutStudentMaterial);
            this.Controls.Add(this.stdNoMaterialLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentMaterial";
            this.Text = "Student Material";
            this.Activated += new System.EventHandler(this.loadMaterialAtStartPageStudentClass);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MaterialbackButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutStudentMaterial;
        private System.Windows.Forms.Label stdNoMaterialLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stdNamelabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label label1;
    }
}