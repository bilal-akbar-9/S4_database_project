namespace intial_form_1_
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.teacherRadioButton = new System.Windows.Forms.RadioButton();
            this.adminRadionButton = new System.Windows.Forms.RadioButton();
            this.loginAsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cyber-security-g8f1e0ea85_1280.png");
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.username.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Italic);
            this.username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.username.Location = new System.Drawing.Point(21, 288);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(275, 23);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.password.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Italic);
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.Location = new System.Drawing.Point(21, 330);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(276, 23);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Font = new System.Drawing.Font("HP Simplified", 12F);
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Login.Location = new System.Drawing.Point(167, 376);
            this.Login.Margin = new System.Windows.Forms.Padding(2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(130, 34);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button2.Font = new System.Drawing.Font("HP Simplified", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(21, 376);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.studentRadioButton.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.studentRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.studentRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.studentRadioButton.Location = new System.Drawing.Point(21, 255);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(63, 18);
            this.studentRadioButton.TabIndex = 5;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = false;
            // 
            // teacherRadioButton
            // 
            this.teacherRadioButton.AutoSize = true;
            this.teacherRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.teacherRadioButton.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.teacherRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.teacherRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.teacherRadioButton.Location = new System.Drawing.Point(135, 255);
            this.teacherRadioButton.Name = "teacherRadioButton";
            this.teacherRadioButton.Size = new System.Drawing.Size(63, 18);
            this.teacherRadioButton.TabIndex = 6;
            this.teacherRadioButton.TabStop = true;
            this.teacherRadioButton.Text = "Teacher";
            this.teacherRadioButton.UseVisualStyleBackColor = false;
            // 
            // adminRadionButton
            // 
            this.adminRadionButton.AutoSize = true;
            this.adminRadionButton.BackColor = System.Drawing.Color.Transparent;
            this.adminRadionButton.Font = new System.Drawing.Font("HP Simplified", 9F);
            this.adminRadionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.adminRadionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.adminRadionButton.Location = new System.Drawing.Point(243, 255);
            this.adminRadionButton.Name = "adminRadionButton";
            this.adminRadionButton.Size = new System.Drawing.Size(56, 18);
            this.adminRadionButton.TabIndex = 7;
            this.adminRadionButton.TabStop = true;
            this.adminRadionButton.Text = "Admin";
            this.adminRadionButton.UseVisualStyleBackColor = false;
            // 
            // loginAsLabel
            // 
            this.loginAsLabel.AutoSize = true;
            this.loginAsLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginAsLabel.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold);
            this.loginAsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.loginAsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginAsLabel.Location = new System.Drawing.Point(17, 223);
            this.loginAsLabel.Name = "loginAsLabel";
            this.loginAsLabel.Size = new System.Drawing.Size(72, 21);
            this.loginAsLabel.TabIndex = 8;
            this.loginAsLabel.Text = "Login as:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.loginAsLabel);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.studentRadioButton);
            this.panel1.Controls.Add(this.teacherRadioButton);
            this.panel1.Controls.Add(this.adminRadionButton);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(23, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 449);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 65);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(101, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // LoginForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(368, 500);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton teacherRadioButton;
        private System.Windows.Forms.RadioButton adminRadionButton;
        private System.Windows.Forms.Label loginAsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

