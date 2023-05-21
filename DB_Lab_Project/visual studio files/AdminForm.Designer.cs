namespace intial_form_1_
{
    partial class AdminForm
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
            System.Windows.Forms.Label NameText;
            this.AccountRelated = new System.Windows.Forms.TabControl();
            this.CreateAccount = new System.Windows.Forms.TabPage();
            this.Cancel1 = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.Button();
            this.Role = new System.Windows.Forms.Label();
            this.role1 = new System.Windows.Forms.ComboBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.retypePassword1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.save2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reTypePassword2 = new System.Windows.Forms.ComboBox();
            this.newPassword2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.oldPassword2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.username2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.save3 = new System.Windows.Forms.Button();
            this.isActive3 = new System.Windows.Forms.CheckBox();
            this.username3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.passwordData = new System.Windows.Forms.Label();
            this.checkButton4 = new System.Windows.Forms.Button();
            this.username4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            NameText = new System.Windows.Forms.Label();
            this.AccountRelated.SuspendLayout();
            this.CreateAccount.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.BackColor = System.Drawing.Color.White;
            NameText.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NameText.Location = new System.Drawing.Point(138, 45);
            NameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            NameText.Name = "NameText";
            NameText.Size = new System.Drawing.Size(38, 16);
            NameText.TabIndex = 6;
            NameText.Text = "Name";
            NameText.Click += new System.EventHandler(this.label4_Click);
            // 
            // AccountRelated
            // 
            this.AccountRelated.Controls.Add(this.CreateAccount);
            this.AccountRelated.Controls.Add(this.tabPage2);
            this.AccountRelated.Controls.Add(this.tabPage1);
            this.AccountRelated.Controls.Add(this.tabPage3);
            this.AccountRelated.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountRelated.Location = new System.Drawing.Point(0, 0);
            this.AccountRelated.Margin = new System.Windows.Forms.Padding(0);
            this.AccountRelated.Name = "AccountRelated";
            this.AccountRelated.SelectedIndex = 0;
            this.AccountRelated.Size = new System.Drawing.Size(662, 360);
            this.AccountRelated.TabIndex = 0;
            this.AccountRelated.SelectedIndexChanged += new System.EventHandler(this.AccountRelated_SelectedIndexChanged);
            // 
            // CreateAccount
            // 
            this.CreateAccount.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.CreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.CreateAccount.Controls.Add(this.panel1);
            this.CreateAccount.Location = new System.Drawing.Point(4, 25);
            this.CreateAccount.Margin = new System.Windows.Forms.Padding(0);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(654, 331);
            this.CreateAccount.TabIndex = 0;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Cancel1
            // 
            this.Cancel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cancel1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancel1.Location = new System.Drawing.Point(373, 236);
            this.Cancel1.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel1.Name = "Cancel1";
            this.Cancel1.Size = new System.Drawing.Size(79, 39);
            this.Cancel1.TabIndex = 11;
            this.Cancel1.Text = "Cancel";
            this.Cancel1.UseVisualStyleBackColor = false;
            this.Cancel1.Click += new System.EventHandler(this.Cancel1_Click);
            // 
            // save1
            // 
            this.save1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(136)))), ((int)(((byte)(238)))));
            this.save1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save1.ForeColor = System.Drawing.SystemColors.Control;
            this.save1.Location = new System.Drawing.Point(473, 236);
            this.save1.Margin = new System.Windows.Forms.Padding(2);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(79, 39);
            this.save1.TabIndex = 10;
            this.save1.Text = "Save";
            this.save1.UseVisualStyleBackColor = false;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.BackColor = System.Drawing.Color.White;
            this.Role.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.Location = new System.Drawing.Point(146, 196);
            this.Role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(30, 16);
            this.Role.TabIndex = 9;
            this.Role.Text = "Role";
            this.Role.Click += new System.EventHandler(this.Role_Click);
            // 
            // role1
            // 
            this.role1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role1.FormattingEnabled = true;
            this.role1.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.role1.Location = new System.Drawing.Point(188, 193);
            this.role1.Margin = new System.Windows.Forms.Padding(2);
            this.role1.Name = "role1";
            this.role1.Size = new System.Drawing.Size(364, 24);
            this.role1.TabIndex = 8;
            this.role1.SelectedIndexChanged += new System.EventHandler(this.role1_SelectedIndexChanged);
            // 
            // Name1
            // 
            this.Name1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name1.Font = new System.Drawing.Font("HP Simplified Hans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.Location = new System.Drawing.Point(188, 38);
            this.Name1.Margin = new System.Windows.Forms.Padding(2);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(364, 23);
            this.Name1.TabIndex = 7;
            this.Name1.TextChanged += new System.EventHandler(this.Name1_TextChanged);
            // 
            // retypePassword1
            // 
            this.retypePassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.retypePassword1.Font = new System.Drawing.Font("HP Simplified Hans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypePassword1.Location = new System.Drawing.Point(188, 157);
            this.retypePassword1.Margin = new System.Windows.Forms.Padding(2);
            this.retypePassword1.Name = "retypePassword1";
            this.retypePassword1.Size = new System.Drawing.Size(364, 23);
            this.retypePassword1.TabIndex = 5;
            this.retypePassword1.TextChanged += new System.EventHandler(this.retypePassword1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-Type Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // password1
            // 
            this.password1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password1.Font = new System.Drawing.Font("HP Simplified Hans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password1.Location = new System.Drawing.Point(188, 113);
            this.password1.Margin = new System.Windows.Forms.Padding(2);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(364, 23);
            this.password1.TabIndex = 3;
            this.password1.TextChanged += new System.EventHandler(this.password1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // username1
            // 
            this.username1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username1.Font = new System.Drawing.Font("HP Simplified Hans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username1.Location = new System.Drawing.Point(188, 75);
            this.username1.Margin = new System.Windows.Forms.Padding(2);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(364, 23);
            this.username1.TabIndex = 1;
            this.username1.TextChanged += new System.EventHandler(this.username1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(654, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Password";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(378, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // save2
            // 
            this.save2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(136)))), ((int)(((byte)(238)))));
            this.save2.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save2.ForeColor = System.Drawing.SystemColors.Control;
            this.save2.Location = new System.Drawing.Point(471, 234);
            this.save2.Margin = new System.Windows.Forms.Padding(2);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(79, 39);
            this.save2.TabIndex = 22;
            this.save2.Text = "Save";
            this.save2.UseVisualStyleBackColor = false;
            this.save2.Click += new System.EventHandler(this.save2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Re-type Password";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // reTypePassword2
            // 
            this.reTypePassword2.FormattingEnabled = true;
            this.reTypePassword2.Location = new System.Drawing.Point(186, 182);
            this.reTypePassword2.Margin = new System.Windows.Forms.Padding(2);
            this.reTypePassword2.Name = "reTypePassword2";
            this.reTypePassword2.Size = new System.Drawing.Size(364, 24);
            this.reTypePassword2.TabIndex = 20;
            this.reTypePassword2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // newPassword2
            // 
            this.newPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassword2.Font = new System.Drawing.Font("HP Simplified Hans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword2.Location = new System.Drawing.Point(186, 142);
            this.newPassword2.Margin = new System.Windows.Forms.Padding(2);
            this.newPassword2.Name = "newPassword2";
            this.newPassword2.Size = new System.Drawing.Size(364, 23);
            this.newPassword2.TabIndex = 17;
            this.newPassword2.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "New Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // oldPassword2
            // 
            this.oldPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldPassword2.Font = new System.Drawing.Font("HP Simplified Hans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassword2.Location = new System.Drawing.Point(186, 97);
            this.oldPassword2.Margin = new System.Windows.Forms.Padding(2);
            this.oldPassword2.Name = "oldPassword2";
            this.oldPassword2.Size = new System.Drawing.Size(364, 23);
            this.oldPassword2.TabIndex = 15;
            this.oldPassword2.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Old Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // username2
            // 
            this.username2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username2.Font = new System.Drawing.Font("HP Simplified Hans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username2.Location = new System.Drawing.Point(186, 54);
            this.username2.Margin = new System.Windows.Forms.Padding(2);
            this.username2.Name = "username2";
            this.username2.Size = new System.Drawing.Size(364, 23);
            this.username2.TabIndex = 13;
            this.username2.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Username";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(654, 331);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Active \\ DeActive Account";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // save3
            // 
            this.save3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(136)))), ((int)(((byte)(238)))));
            this.save3.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save3.ForeColor = System.Drawing.SystemColors.Control;
            this.save3.Location = new System.Drawing.Point(450, 148);
            this.save3.Margin = new System.Windows.Forms.Padding(2);
            this.save3.Name = "save3";
            this.save3.Size = new System.Drawing.Size(79, 39);
            this.save3.TabIndex = 35;
            this.save3.Text = "Save";
            this.save3.UseVisualStyleBackColor = false;
            this.save3.Click += new System.EventHandler(this.save3_Click_1);
            // 
            // isActive3
            // 
            this.isActive3.AutoSize = true;
            this.isActive3.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActive3.Location = new System.Drawing.Point(165, 127);
            this.isActive3.Margin = new System.Windows.Forms.Padding(2);
            this.isActive3.Name = "isActive3";
            this.isActive3.Size = new System.Drawing.Size(79, 23);
            this.isActive3.TabIndex = 34;
            this.isActive3.Text = "isActive";
            this.isActive3.UseVisualStyleBackColor = true;
            this.isActive3.CheckedChanged += new System.EventHandler(this.isActive3_CheckedChanged);
            // 
            // username3
            // 
            this.username3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username3.Font = new System.Drawing.Font("HP Simplified Hans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username3.Location = new System.Drawing.Point(165, 87);
            this.username3.Margin = new System.Windows.Forms.Padding(2);
            this.username3.Name = "username3";
            this.username3.Size = new System.Drawing.Size(364, 23);
            this.username3.TabIndex = 25;
            this.username3.TextChanged += new System.EventHandler(this.username3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Username";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(654, 331);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "checkPassword";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // passwordData
            // 
            this.passwordData.AutoSize = true;
            this.passwordData.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordData.ForeColor = System.Drawing.SystemColors.Highlight;
            this.passwordData.Location = new System.Drawing.Point(178, 192);
            this.passwordData.Name = "passwordData";
            this.passwordData.Size = new System.Drawing.Size(73, 19);
            this.passwordData.TabIndex = 40;
            this.passwordData.Tag = "";
            this.passwordData.Text = "password";
            this.passwordData.Visible = false;
            this.passwordData.Click += new System.EventHandler(this.label9_Click);
            // 
            // checkButton4
            // 
            this.checkButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(136)))), ((int)(((byte)(238)))));
            this.checkButton4.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton4.ForeColor = System.Drawing.SystemColors.Control;
            this.checkButton4.Location = new System.Drawing.Point(444, 135);
            this.checkButton4.Margin = new System.Windows.Forms.Padding(2);
            this.checkButton4.Name = "checkButton4";
            this.checkButton4.Size = new System.Drawing.Size(79, 39);
            this.checkButton4.TabIndex = 39;
            this.checkButton4.Text = "Check";
            this.checkButton4.UseVisualStyleBackColor = false;
            this.checkButton4.Click += new System.EventHandler(this.checkButton4_Click);
            // 
            // username4
            // 
            this.username4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username4.Font = new System.Drawing.Font("HP Simplified Hans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username4.Location = new System.Drawing.Point(159, 88);
            this.username4.Margin = new System.Windows.Forms.Padding(2);
            this.username4.Name = "username4";
            this.username4.Size = new System.Drawing.Size(364, 23);
            this.username4.TabIndex = 37;
            this.username4.TextChanged += new System.EventHandler(this.userField4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Username";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.username1);
            this.panel1.Controls.Add(this.password1);
            this.panel1.Controls.Add(this.retypePassword1);
            this.panel1.Controls.Add(this.role1);
            this.panel1.Controls.Add(this.Role);
            this.panel1.Controls.Add(NameText);
            this.panel1.Controls.Add(this.Cancel1);
            this.panel1.Controls.Add(this.save1);
            this.panel1.Controls.Add(this.Name1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(35, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 300);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.username2);
            this.panel2.Controls.Add(this.oldPassword2);
            this.panel2.Controls.Add(this.newPassword2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.reTypePassword2);
            this.panel2.Controls.Add(this.save2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(35, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 300);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.username3);
            this.panel3.Controls.Add(this.isActive3);
            this.panel3.Controls.Add(this.save3);
            this.panel3.Location = new System.Drawing.Point(35, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 300);
            this.panel3.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.passwordData);
            this.panel4.Controls.Add(this.username4);
            this.panel4.Controls.Add(this.checkButton4);
            this.panel4.Location = new System.Drawing.Point(35, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 300);
            this.panel4.TabIndex = 41;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(656, 352);
            this.Controls.Add(this.AccountRelated);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.AccountRelated.ResumeLayout(false);
            this.CreateAccount.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AccountRelated;
        private System.Windows.Forms.TabPage CreateAccount;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TextBox retypePassword1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.ComboBox role1;
        private System.Windows.Forms.Button Cancel1;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newPassword2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oldPassword2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox username2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox reTypePassword2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox isActive3;
        private System.Windows.Forms.TextBox username3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save2;
        private System.Windows.Forms.Button save3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label passwordData;
        private System.Windows.Forms.Button checkButton4;
        private System.Windows.Forms.TextBox username4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}