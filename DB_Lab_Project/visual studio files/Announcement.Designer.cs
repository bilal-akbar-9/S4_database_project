using System.Windows.Forms;

namespace intial_form_1_
{
    partial class Announcement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UpdateAnnounceTab = new System.Windows.Forms.TabPage();
            this.modifyTitleBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.modifyDescBox = new System.Windows.Forms.TextBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.modifyAnnouncementFileBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.announcementListForModification = new System.Windows.Forms.DataGridView();
            this.RemoveAnnounceTab = new System.Windows.Forms.TabPage();
            this.deleteAnnouncementButton = new System.Windows.Forms.Button();
            this.announcementList = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AnnouncementTab = new System.Windows.Forms.TabPage();
            this.backButton = new System.Windows.Forms.Button();
            this.flowLayoutAnnouncement = new System.Windows.Forms.FlowLayoutPanel();
            this.noAnnouncementLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.classroomName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnnouncementTABS = new System.Windows.Forms.TabControl();
            this.AddAnnouncementTab = new System.Windows.Forms.TabPage();
            this.txtAnnounceTitle = new System.Windows.Forms.TextBox();
            this.assignmentTitle = new System.Windows.Forms.Label();
            this.txtAnnounceDesc = new System.Windows.Forms.TextBox();
            this.CreateAssignment = new System.Windows.Forms.Button();
            this.AssignmentDescription = new System.Windows.Forms.Label();
            this.AssignmetFile = new System.Windows.Forms.Label();
            this.txtAnnounceFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateAnnounceTab.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.announcementListForModification)).BeginInit();
            this.RemoveAnnounceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.announcementList)).BeginInit();
            this.panel3.SuspendLayout();
            this.AnnouncementTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AnnouncementTABS.SuspendLayout();
            this.AddAnnouncementTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateAnnounceTab
            // 
            this.UpdateAnnounceTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateAnnounceTab.Controls.Add(this.modifyTitleBox);
            this.UpdateAnnounceTab.Controls.Add(this.label15);
            this.UpdateAnnounceTab.Controls.Add(this.selectButton);
            this.UpdateAnnounceTab.Controls.Add(this.modifyDescBox);
            this.UpdateAnnounceTab.Controls.Add(this.modifyButton);
            this.UpdateAnnounceTab.Controls.Add(this.label13);
            this.UpdateAnnounceTab.Controls.Add(this.label14);
            this.UpdateAnnounceTab.Controls.Add(this.modifyAnnouncementFileBox);
            this.UpdateAnnounceTab.Controls.Add(this.label10);
            this.UpdateAnnounceTab.Controls.Add(this.panel4);
            this.UpdateAnnounceTab.Controls.Add(this.announcementListForModification);
            this.UpdateAnnounceTab.Location = new System.Drawing.Point(4, 22);
            this.UpdateAnnounceTab.Name = "UpdateAnnounceTab";
            this.UpdateAnnounceTab.Size = new System.Drawing.Size(1066, 508);
            this.UpdateAnnounceTab.TabIndex = 3;
            this.UpdateAnnounceTab.Text = "Update Announcement";
            // 
            // modifyTitleBox
            // 
            this.modifyTitleBox.Location = new System.Drawing.Point(127, 147);
            this.modifyTitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.modifyTitleBox.Multiline = true;
            this.modifyTitleBox.Name = "modifyTitleBox";
            this.modifyTitleBox.Size = new System.Drawing.Size(368, 18);
            this.modifyTitleBox.TabIndex = 40;
            this.modifyTitleBox.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(123, 118);
            this.label15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "Title";
            this.label15.Visible = false;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.White;
            this.selectButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.selectButton.FlatAppearance.BorderSize = 3;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Location = new System.Drawing.Point(895, 452);
            this.selectButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(88, 42);
            this.selectButton.TabIndex = 39;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // modifyDescBox
            // 
            this.modifyDescBox.Location = new System.Drawing.Point(127, 212);
            this.modifyDescBox.Margin = new System.Windows.Forms.Padding(2);
            this.modifyDescBox.Multiline = true;
            this.modifyDescBox.Name = "modifyDescBox";
            this.modifyDescBox.Size = new System.Drawing.Size(368, 115);
            this.modifyDescBox.TabIndex = 27;
            this.modifyDescBox.Visible = false;
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.White;
            this.modifyButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.modifyButton.FlatAppearance.BorderSize = 3;
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.Location = new System.Drawing.Point(895, 452);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(88, 42);
            this.modifyButton.TabIndex = 34;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Visible = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(662, 118);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Announcement File";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(123, 178);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Assignment Description";
            this.label14.Visible = false;
            // 
            // modifyAnnouncementFileBox
            // 
            this.modifyAnnouncementFileBox.Location = new System.Drawing.Point(661, 146);
            this.modifyAnnouncementFileBox.Margin = new System.Windows.Forms.Padding(2);
            this.modifyAnnouncementFileBox.Name = "modifyAnnouncementFileBox";
            this.modifyAnnouncementFileBox.Size = new System.Drawing.Size(199, 20);
            this.modifyAnnouncementFileBox.TabIndex = 29;
            this.modifyAnnouncementFileBox.Visible = false;
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
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(-2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1089, 83);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(18, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Update Announcement";
            // 
            // announcementListForModification
            // 
            this.announcementListForModification.AllowUserToAddRows = false;
            this.announcementListForModification.AllowUserToDeleteRows = false;
            this.announcementListForModification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.announcementListForModification.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.announcementListForModification.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.announcementListForModification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.announcementListForModification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.announcementListForModification.DefaultCellStyle = dataGridViewCellStyle9;
            this.announcementListForModification.EnableHeadersVisualStyles = false;
            this.announcementListForModification.Location = new System.Drawing.Point(73, 88);
            this.announcementListForModification.Margin = new System.Windows.Forms.Padding(2);
            this.announcementListForModification.MultiSelect = false;
            this.announcementListForModification.Name = "announcementListForModification";
            this.announcementListForModification.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.announcementListForModification.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.announcementListForModification.RowHeadersWidth = 51;
            this.announcementListForModification.Size = new System.Drawing.Size(898, 349);
            this.announcementListForModification.TabIndex = 38;
            // 
            // RemoveAnnounceTab
            // 
            this.RemoveAnnounceTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveAnnounceTab.Controls.Add(this.deleteAnnouncementButton);
            this.RemoveAnnounceTab.Controls.Add(this.announcementList);
            this.RemoveAnnounceTab.Controls.Add(this.label9);
            this.RemoveAnnounceTab.Controls.Add(this.panel3);
            this.RemoveAnnounceTab.Location = new System.Drawing.Point(4, 22);
            this.RemoveAnnounceTab.Name = "RemoveAnnounceTab";
            this.RemoveAnnounceTab.Size = new System.Drawing.Size(1066, 508);
            this.RemoveAnnounceTab.TabIndex = 2;
            this.RemoveAnnounceTab.Text = "Remove Announcement";
            // 
            // deleteAnnouncementButton
            // 
            this.deleteAnnouncementButton.BackColor = System.Drawing.Color.White;
            this.deleteAnnouncementButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteAnnouncementButton.FlatAppearance.BorderSize = 3;
            this.deleteAnnouncementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAnnouncementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAnnouncementButton.Location = new System.Drawing.Point(893, 450);
            this.deleteAnnouncementButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteAnnouncementButton.Name = "deleteAnnouncementButton";
            this.deleteAnnouncementButton.Size = new System.Drawing.Size(88, 42);
            this.deleteAnnouncementButton.TabIndex = 8;
            this.deleteAnnouncementButton.Text = "Delete";
            this.deleteAnnouncementButton.UseVisualStyleBackColor = false;
            this.deleteAnnouncementButton.Click += new System.EventHandler(this.deleteAnnouncementButton_Click);
            // 
            // announcementList
            // 
            this.announcementList.AllowUserToAddRows = false;
            this.announcementList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.announcementList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.announcementList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.announcementList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.announcementList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.announcementList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.announcementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.announcementList.DefaultCellStyle = dataGridViewCellStyle13;
            this.announcementList.EnableHeadersVisualStyles = false;
            this.announcementList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.announcementList.Location = new System.Drawing.Point(72, 91);
            this.announcementList.Name = "announcementList";
            this.announcementList.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.announcementList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.announcementList.RowHeadersWidth = 51;
            this.announcementList.RowTemplate.Height = 40;
            this.announcementList.RowTemplate.ReadOnly = true;
            this.announcementList.Size = new System.Drawing.Size(904, 342);
            this.announcementList.TabIndex = 7;
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
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(-3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 83);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Remove Announcement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Announcement";
            // 
            // AnnouncementTab
            // 
            this.AnnouncementTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AnnouncementTab.Controls.Add(this.noAnnouncementLabel);
            this.AnnouncementTab.Controls.Add(this.backButton);
            this.AnnouncementTab.Controls.Add(this.flowLayoutAnnouncement);
            this.AnnouncementTab.Controls.Add(this.panel1);
            this.AnnouncementTab.Controls.Add(this.label1);
            this.AnnouncementTab.Location = new System.Drawing.Point(4, 22);
            this.AnnouncementTab.Name = "AnnouncementTab";
            this.AnnouncementTab.Padding = new System.Windows.Forms.Padding(2);
            this.AnnouncementTab.Size = new System.Drawing.Size(1066, 508);
            this.AnnouncementTab.TabIndex = 0;
            this.AnnouncementTab.Text = "Announcements";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(19, 452);
            this.backButton.Margin = new System.Windows.Forms.Padding(1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 40);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "←";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flowLayoutAnnouncement
            // 
            this.flowLayoutAnnouncement.AutoScroll = true;
            this.flowLayoutAnnouncement.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutAnnouncement.Location = new System.Drawing.Point(171, 111);
            this.flowLayoutAnnouncement.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutAnnouncement.Name = "flowLayoutAnnouncement";
            this.flowLayoutAnnouncement.Size = new System.Drawing.Size(768, 316);
            this.flowLayoutAnnouncement.TabIndex = 7;
            this.flowLayoutAnnouncement.Visible = false;
            this.flowLayoutAnnouncement.WrapContents = false;
            // 
            // noAnnouncementLabel
            // 
            this.noAnnouncementLabel.AutoSize = true;
            this.noAnnouncementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noAnnouncementLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noAnnouncementLabel.Location = new System.Drawing.Point(16, 121);
            this.noAnnouncementLabel.Name = "noAnnouncementLabel";
            this.noAnnouncementLabel.Size = new System.Drawing.Size(194, 20);
            this.noAnnouncementLabel.TabIndex = 6;
            this.noAnnouncementLabel.Text = "No Announcement for you";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
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
            this.teacherNameLabel.Location = new System.Drawing.Point(29, 55);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(51, 20);
            this.teacherNameLabel.TabIndex = 4;
            this.teacherNameLabel.Text = "label1";
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
            // AnnouncementTABS
            // 
            this.AnnouncementTABS.Controls.Add(this.AnnouncementTab);
            this.AnnouncementTABS.Controls.Add(this.AddAnnouncementTab);
            this.AnnouncementTABS.Controls.Add(this.UpdateAnnounceTab);
            this.AnnouncementTABS.Controls.Add(this.RemoveAnnounceTab);
            this.AnnouncementTABS.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnnouncementTABS.HotTrack = true;
            this.AnnouncementTABS.Location = new System.Drawing.Point(-1, -1);
            this.AnnouncementTABS.Name = "AnnouncementTABS";
            this.AnnouncementTABS.SelectedIndex = 0;
            this.AnnouncementTABS.Size = new System.Drawing.Size(1074, 534);
            this.AnnouncementTABS.TabIndex = 7;
            this.AnnouncementTABS.SelectedIndexChanged += new System.EventHandler(this.AnnouncementLoadForUpdateDelete);
            this.AnnouncementTABS.Enter += new System.EventHandler(this.loadAnnouncementsAtStartPage);
            // 
            // AddAnnouncementTab
            // 
            this.AddAnnouncementTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddAnnouncementTab.Controls.Add(this.txtAnnounceTitle);
            this.AddAnnouncementTab.Controls.Add(this.assignmentTitle);
            this.AddAnnouncementTab.Controls.Add(this.txtAnnounceDesc);
            this.AddAnnouncementTab.Controls.Add(this.CreateAssignment);
            this.AddAnnouncementTab.Controls.Add(this.AssignmentDescription);
            this.AddAnnouncementTab.Controls.Add(this.AssignmetFile);
            this.AddAnnouncementTab.Controls.Add(this.txtAnnounceFile);
            this.AddAnnouncementTab.Controls.Add(this.label8);
            this.AddAnnouncementTab.Controls.Add(this.panel2);
            this.AddAnnouncementTab.Location = new System.Drawing.Point(4, 22);
            this.AddAnnouncementTab.Name = "AddAnnouncementTab";
            this.AddAnnouncementTab.Padding = new System.Windows.Forms.Padding(2);
            this.AddAnnouncementTab.Size = new System.Drawing.Size(1066, 508);
            this.AddAnnouncementTab.TabIndex = 1;
            this.AddAnnouncementTab.Text = "New Announcement";
            // 
            // txtAnnounceTitle
            // 
            this.txtAnnounceTitle.Location = new System.Drawing.Point(87, 141);
            this.txtAnnounceTitle.Margin = new System.Windows.Forms.Padding(1);
            this.txtAnnounceTitle.Multiline = true;
            this.txtAnnounceTitle.Name = "txtAnnounceTitle";
            this.txtAnnounceTitle.Size = new System.Drawing.Size(472, 22);
            this.txtAnnounceTitle.TabIndex = 36;
            // 
            // assignmentTitle
            // 
            this.assignmentTitle.AutoSize = true;
            this.assignmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentTitle.Location = new System.Drawing.Point(83, 119);
            this.assignmentTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.assignmentTitle.Name = "assignmentTitle";
            this.assignmentTitle.Size = new System.Drawing.Size(38, 20);
            this.assignmentTitle.TabIndex = 37;
            this.assignmentTitle.Text = "Title";
            // 
            // txtAnnounceDesc
            // 
            this.txtAnnounceDesc.Location = new System.Drawing.Point(87, 205);
            this.txtAnnounceDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnnounceDesc.Multiline = true;
            this.txtAnnounceDesc.Name = "txtAnnounceDesc";
            this.txtAnnounceDesc.Size = new System.Drawing.Size(472, 137);
            this.txtAnnounceDesc.TabIndex = 27;
            // 
            // CreateAssignment
            // 
            this.CreateAssignment.BackColor = System.Drawing.Color.White;
            this.CreateAssignment.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.CreateAssignment.FlatAppearance.BorderSize = 3;
            this.CreateAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAssignment.Location = new System.Drawing.Point(865, 404);
            this.CreateAssignment.Margin = new System.Windows.Forms.Padding(1);
            this.CreateAssignment.Name = "CreateAssignment";
            this.CreateAssignment.Size = new System.Drawing.Size(107, 40);
            this.CreateAssignment.TabIndex = 34;
            this.CreateAssignment.Text = "Create";
            this.CreateAssignment.UseVisualStyleBackColor = false;
            this.CreateAssignment.Click += new System.EventHandler(this.CreateAnnouncement_Click);
            // 
            // AssignmentDescription
            // 
            this.AssignmentDescription.AutoSize = true;
            this.AssignmentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentDescription.Location = new System.Drawing.Point(83, 183);
            this.AssignmentDescription.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.AssignmentDescription.Name = "AssignmentDescription";
            this.AssignmentDescription.Size = new System.Drawing.Size(89, 20);
            this.AssignmentDescription.TabIndex = 30;
            this.AssignmentDescription.Text = "Description";
            // 
            // AssignmetFile
            // 
            this.AssignmetFile.AutoSize = true;
            this.AssignmetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmetFile.Location = new System.Drawing.Point(697, 119);
            this.AssignmetFile.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.AssignmetFile.Name = "AssignmetFile";
            this.AssignmetFile.Size = new System.Drawing.Size(147, 20);
            this.AssignmetFile.TabIndex = 33;
            this.AssignmetFile.Text = "Announcement File";
            // 
            // txtAnnounceFile
            // 
            this.txtAnnounceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnounceFile.Location = new System.Drawing.Point(701, 151);
            this.txtAnnounceFile.Margin = new System.Windows.Forms.Padding(1);
            this.txtAnnounceFile.Name = "txtAnnounceFile";
            this.txtAnnounceFile.Size = new System.Drawing.Size(211, 26);
            this.txtAnnounceFile.TabIndex = 29;
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
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 83);
            this.panel2.TabIndex = 3;
            // 
            // Announcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 534);
            this.Controls.Add(this.AnnouncementTABS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Announcement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Announcements";
            this.UpdateAnnounceTab.ResumeLayout(false);
            this.UpdateAnnounceTab.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.announcementListForModification)).EndInit();
            this.RemoveAnnounceTab.ResumeLayout(false);
            this.RemoveAnnounceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.announcementList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.AnnouncementTab.ResumeLayout(false);
            this.AnnouncementTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AnnouncementTABS.ResumeLayout(false);
            this.AddAnnouncementTab.ResumeLayout(false);
            this.AddAnnouncementTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage UpdateAnnounceTab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage RemoveAnnounceTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage AnnouncementTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAnnouncement;
        private System.Windows.Forms.Label noAnnouncementLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Label classroomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl AnnouncementTABS;
        private System.Windows.Forms.TabPage AddAnnouncementTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAnnounceDesc;
        private System.Windows.Forms.Button CreateAssignment;
        private System.Windows.Forms.Label AssignmentDescription;
        private System.Windows.Forms.Label AssignmetFile;
        private System.Windows.Forms.TextBox txtAnnounceFile;
        private System.Windows.Forms.Button deleteAnnouncementButton;
        private System.Windows.Forms.DataGridView announcementList;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox modifyAnnouncementFileBox;
        private System.Windows.Forms.TextBox modifyDescBox;
        private System.Windows.Forms.DataGridView announcementListForModification;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox txtAnnounceTitle;
        private System.Windows.Forms.Label assignmentTitle;
        private System.Windows.Forms.TextBox modifyTitleBox;
        private System.Windows.Forms.Label label15;
    }
}