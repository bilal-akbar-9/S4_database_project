namespace intial_form_1_
{
    partial class announcementPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TeacherTabs = new System.Windows.Forms.TabControl();
            this.announceDesTab = new System.Windows.Forms.TabPage();
            this.txtAnnounceFile = new System.Windows.Forms.TextBox();
            this.txtAnnounceTitle = new System.Windows.Forms.TextBox();
            this.txtAnnounceDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignmentTitle = new System.Windows.Forms.Label();
            this.CommentsTab = new System.Windows.Forms.TabPage();
            this.commentTABS = new System.Windows.Forms.TabControl();
            this.viewCommentsTab = new System.Windows.Forms.TabPage();
            this.noCommentToViewLabel = new System.Windows.Forms.Label();
            this.allCommentsList = new System.Windows.Forms.DataGridView();
            this.addCommentTab = new System.Windows.Forms.TabPage();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.txtCommentDesc = new System.Windows.Forms.TextBox();
            this.labelCommentDesc = new System.Windows.Forms.Label();
            this.labelnewComment = new System.Windows.Forms.Label();
            this.updateCommentTab = new System.Windows.Forms.TabPage();
            this.noCommentToUpdateLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.txtCommentDescUpdate = new System.Windows.Forms.TextBox();
            this.labelCommentDescUpdate = new System.Windows.Forms.Label();
            this.txtUpdateComment = new System.Windows.Forms.Label();
            this.commentListForUpdation = new System.Windows.Forms.DataGridView();
            this.deleteCommentTab = new System.Windows.Forms.TabPage();
            this.noCommentToDelete_Label = new System.Windows.Forms.Label();
            this.commentListGridForDeletion = new System.Windows.Forms.DataGridView();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.labelDeleteComment = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.TeacherTabs.SuspendLayout();
            this.announceDesTab.SuspendLayout();
            this.CommentsTab.SuspendLayout();
            this.commentTABS.SuspendLayout();
            this.viewCommentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCommentsList)).BeginInit();
            this.addCommentTab.SuspendLayout();
            this.updateCommentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentListForUpdation)).BeginInit();
            this.deleteCommentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentListGridForDeletion)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherTabs
            // 
            this.TeacherTabs.Controls.Add(this.announceDesTab);
            this.TeacherTabs.Controls.Add(this.CommentsTab);
            this.TeacherTabs.Location = new System.Drawing.Point(-1, 3);
            this.TeacherTabs.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherTabs.Name = "TeacherTabs";
            this.TeacherTabs.SelectedIndex = 0;
            this.TeacherTabs.Size = new System.Drawing.Size(914, 456);
            this.TeacherTabs.TabIndex = 1;
            this.TeacherTabs.Click += new System.EventHandler(this.loadCommentsToDeleteOrUpdate);
            // 
            // announceDesTab
            // 
            this.announceDesTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.announceDesTab.Controls.Add(this.txtAnnounceFile);
            this.announceDesTab.Controls.Add(this.txtAnnounceTitle);
            this.announceDesTab.Controls.Add(this.txtAnnounceDesc);
            this.announceDesTab.Controls.Add(this.label4);
            this.announceDesTab.Controls.Add(this.label1);
            this.announceDesTab.Controls.Add(this.assignmentTitle);
            this.announceDesTab.Location = new System.Drawing.Point(4, 22);
            this.announceDesTab.Name = "announceDesTab";
            this.announceDesTab.Size = new System.Drawing.Size(906, 430);
            this.announceDesTab.TabIndex = 4;
            this.announceDesTab.Text = "Annuoncement";
            // 
            // txtAnnounceFile
            // 
            this.txtAnnounceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnounceFile.Location = new System.Drawing.Point(625, 98);
            this.txtAnnounceFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnnounceFile.Name = "txtAnnounceFile";
            this.txtAnnounceFile.ReadOnly = true;
            this.txtAnnounceFile.Size = new System.Drawing.Size(145, 26);
            this.txtAnnounceFile.TabIndex = 46;
            // 
            // txtAnnounceTitle
            // 
            this.txtAnnounceTitle.Location = new System.Drawing.Point(82, 95);
            this.txtAnnounceTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnnounceTitle.Multiline = true;
            this.txtAnnounceTitle.Name = "txtAnnounceTitle";
            this.txtAnnounceTitle.ReadOnly = true;
            this.txtAnnounceTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnnounceTitle.Size = new System.Drawing.Size(423, 31);
            this.txtAnnounceTitle.TabIndex = 44;
            // 
            // txtAnnounceDesc
            // 
            this.txtAnnounceDesc.Location = new System.Drawing.Point(82, 176);
            this.txtAnnounceDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnnounceDesc.Multiline = true;
            this.txtAnnounceDesc.Name = "txtAnnounceDesc";
            this.txtAnnounceDesc.ReadOnly = true;
            this.txtAnnounceDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnnounceDesc.Size = new System.Drawing.Size(688, 181);
            this.txtAnnounceDesc.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(622, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Description";
            // 
            // assignmentTitle
            // 
            this.assignmentTitle.AutoSize = true;
            this.assignmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentTitle.Location = new System.Drawing.Point(79, 64);
            this.assignmentTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assignmentTitle.Name = "assignmentTitle";
            this.assignmentTitle.Size = new System.Drawing.Size(43, 20);
            this.assignmentTitle.TabIndex = 38;
            this.assignmentTitle.Text = "Title";
            // 
            // CommentsTab
            // 
            this.CommentsTab.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CommentsTab.Controls.Add(this.commentTABS);
            this.CommentsTab.Location = new System.Drawing.Point(4, 22);
            this.CommentsTab.Margin = new System.Windows.Forms.Padding(2);
            this.CommentsTab.Name = "CommentsTab";
            this.CommentsTab.Padding = new System.Windows.Forms.Padding(2);
            this.CommentsTab.Size = new System.Drawing.Size(906, 430);
            this.CommentsTab.TabIndex = 3;
            this.CommentsTab.Text = "Comments";
            // 
            // commentTABS
            // 
            this.commentTABS.Controls.Add(this.viewCommentsTab);
            this.commentTABS.Controls.Add(this.addCommentTab);
            this.commentTABS.Controls.Add(this.updateCommentTab);
            this.commentTABS.Controls.Add(this.deleteCommentTab);
            this.commentTABS.Location = new System.Drawing.Point(0, 0);
            this.commentTABS.Margin = new System.Windows.Forms.Padding(2);
            this.commentTABS.Name = "commentTABS";
            this.commentTABS.SelectedIndex = 0;
            this.commentTABS.Size = new System.Drawing.Size(921, 431);
            this.commentTABS.TabIndex = 0;
            this.commentTABS.Click += new System.EventHandler(this.loadCommentsToDeleteOrUpdate);
            // 
            // viewCommentsTab
            // 
            this.viewCommentsTab.Controls.Add(this.noCommentToViewLabel);
            this.viewCommentsTab.Controls.Add(this.allCommentsList);
            this.viewCommentsTab.Location = new System.Drawing.Point(4, 22);
            this.viewCommentsTab.Name = "viewCommentsTab";
            this.viewCommentsTab.Size = new System.Drawing.Size(913, 405);
            this.viewCommentsTab.TabIndex = 3;
            this.viewCommentsTab.Text = "Comments";
            this.viewCommentsTab.UseVisualStyleBackColor = true;
            // 
            // noCommentToViewLabel
            // 
            this.noCommentToViewLabel.AutoSize = true;
            this.noCommentToViewLabel.Location = new System.Drawing.Point(396, 196);
            this.noCommentToViewLabel.Name = "noCommentToViewLabel";
            this.noCommentToViewLabel.Size = new System.Drawing.Size(109, 13);
            this.noCommentToViewLabel.TabIndex = 27;
            this.noCommentToViewLabel.Text = "No comments to view";
            this.noCommentToViewLabel.Visible = false;
            // 
            // allCommentsList
            // 
            this.allCommentsList.AllowUserToAddRows = false;
            this.allCommentsList.AllowUserToDeleteRows = false;
            this.allCommentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allCommentsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.allCommentsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.allCommentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allCommentsList.DefaultCellStyle = dataGridViewCellStyle1;
            this.allCommentsList.Location = new System.Drawing.Point(5, 12);
            this.allCommentsList.Name = "allCommentsList";
            this.allCommentsList.Size = new System.Drawing.Size(892, 390);
            this.allCommentsList.TabIndex = 0;
            // 
            // addCommentTab
            // 
            this.addCommentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCommentTab.Controls.Add(this.buttonAddComment);
            this.addCommentTab.Controls.Add(this.txtCommentDesc);
            this.addCommentTab.Controls.Add(this.labelCommentDesc);
            this.addCommentTab.Controls.Add(this.labelnewComment);
            this.addCommentTab.Location = new System.Drawing.Point(4, 22);
            this.addCommentTab.Margin = new System.Windows.Forms.Padding(2);
            this.addCommentTab.Name = "addCommentTab";
            this.addCommentTab.Padding = new System.Windows.Forms.Padding(2);
            this.addCommentTab.Size = new System.Drawing.Size(913, 405);
            this.addCommentTab.TabIndex = 0;
            this.addCommentTab.Text = "Add Comment";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.BackColor = System.Drawing.Color.White;
            this.buttonAddComment.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonAddComment.FlatAppearance.BorderSize = 3;
            this.buttonAddComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddComment.Location = new System.Drawing.Point(598, 290);
            this.buttonAddComment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(155, 32);
            this.buttonAddComment.TabIndex = 11;
            this.buttonAddComment.Text = "Post";
            this.buttonAddComment.UseVisualStyleBackColor = false;
            this.buttonAddComment.Click += new System.EventHandler(this.addCommentButton_Clicked);
            // 
            // txtCommentDesc
            // 
            this.txtCommentDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDesc.Location = new System.Drawing.Point(157, 128);
            this.txtCommentDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentDesc.Multiline = true;
            this.txtCommentDesc.Name = "txtCommentDesc";
            this.txtCommentDesc.Size = new System.Drawing.Size(596, 141);
            this.txtCommentDesc.TabIndex = 9;
            // 
            // labelCommentDesc
            // 
            this.labelCommentDesc.AutoSize = true;
            this.labelCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDesc.Location = new System.Drawing.Point(154, 98);
            this.labelCommentDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommentDesc.Name = "labelCommentDesc";
            this.labelCommentDesc.Size = new System.Drawing.Size(153, 18);
            this.labelCommentDesc.TabIndex = 7;
            this.labelCommentDesc.Text = "Comment Description";
            // 
            // labelnewComment
            // 
            this.labelnewComment.AutoSize = true;
            this.labelnewComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnewComment.Location = new System.Drawing.Point(374, 23);
            this.labelnewComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnewComment.Name = "labelnewComment";
            this.labelnewComment.Size = new System.Drawing.Size(169, 26);
            this.labelnewComment.TabIndex = 6;
            this.labelnewComment.Text = "New Comment";
            // 
            // updateCommentTab
            // 
            this.updateCommentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateCommentTab.Controls.Add(this.noCommentToUpdateLabel);
            this.updateCommentTab.Controls.Add(this.SelectButton);
            this.updateCommentTab.Controls.Add(this.updateButton);
            this.updateCommentTab.Controls.Add(this.txtCommentDescUpdate);
            this.updateCommentTab.Controls.Add(this.labelCommentDescUpdate);
            this.updateCommentTab.Controls.Add(this.txtUpdateComment);
            this.updateCommentTab.Controls.Add(this.commentListForUpdation);
            this.updateCommentTab.Location = new System.Drawing.Point(4, 22);
            this.updateCommentTab.Margin = new System.Windows.Forms.Padding(2);
            this.updateCommentTab.Name = "updateCommentTab";
            this.updateCommentTab.Padding = new System.Windows.Forms.Padding(2);
            this.updateCommentTab.Size = new System.Drawing.Size(913, 405);
            this.updateCommentTab.TabIndex = 2;
            this.updateCommentTab.Text = "Update Comment";
            // 
            // noCommentToUpdateLabel
            // 
            this.noCommentToUpdateLabel.AutoSize = true;
            this.noCommentToUpdateLabel.Location = new System.Drawing.Point(395, 200);
            this.noCommentToUpdateLabel.Name = "noCommentToUpdateLabel";
            this.noCommentToUpdateLabel.Size = new System.Drawing.Size(120, 13);
            this.noCommentToUpdateLabel.TabIndex = 26;
            this.noCommentToUpdateLabel.Text = "No comments to update";
            this.noCommentToUpdateLabel.Visible = false;
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.White;
            this.SelectButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.SelectButton.FlatAppearance.BorderSize = 3;
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.Location = new System.Drawing.Point(729, 363);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(155, 32);
            this.SelectButton.TabIndex = 25;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.selectCommentsButtonClicked);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.White;
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.updateButton.FlatAppearance.BorderSize = 3;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(729, 363);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(155, 32);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateCommentButtonClicked);
            // 
            // txtCommentDescUpdate
            // 
            this.txtCommentDescUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDescUpdate.Location = new System.Drawing.Point(105, 135);
            this.txtCommentDescUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentDescUpdate.Multiline = true;
            this.txtCommentDescUpdate.Name = "txtCommentDescUpdate";
            this.txtCommentDescUpdate.Size = new System.Drawing.Size(681, 166);
            this.txtCommentDescUpdate.TabIndex = 17;
            this.txtCommentDescUpdate.Visible = false;
            // 
            // labelCommentDescUpdate
            // 
            this.labelCommentDescUpdate.AutoSize = true;
            this.labelCommentDescUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDescUpdate.Location = new System.Drawing.Point(102, 104);
            this.labelCommentDescUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommentDescUpdate.Name = "labelCommentDescUpdate";
            this.labelCommentDescUpdate.Size = new System.Drawing.Size(153, 18);
            this.labelCommentDescUpdate.TabIndex = 15;
            this.labelCommentDescUpdate.Text = "Comment Description";
            this.labelCommentDescUpdate.Visible = false;
            // 
            // txtUpdateComment
            // 
            this.txtUpdateComment.AutoSize = true;
            this.txtUpdateComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateComment.Location = new System.Drawing.Point(356, 14);
            this.txtUpdateComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUpdateComment.Name = "txtUpdateComment";
            this.txtUpdateComment.Size = new System.Drawing.Size(198, 26);
            this.txtUpdateComment.TabIndex = 14;
            this.txtUpdateComment.Text = "Update Comment";
            // 
            // commentListForUpdation
            // 
            this.commentListForUpdation.AllowUserToAddRows = false;
            this.commentListForUpdation.AllowUserToDeleteRows = false;
            this.commentListForUpdation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commentListForUpdation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.commentListForUpdation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentListForUpdation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.commentListForUpdation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentListForUpdation.DefaultCellStyle = dataGridViewCellStyle3;
            this.commentListForUpdation.EnableHeadersVisualStyles = false;
            this.commentListForUpdation.Location = new System.Drawing.Point(7, 43);
            this.commentListForUpdation.MultiSelect = false;
            this.commentListForUpdation.Name = "commentListForUpdation";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentListForUpdation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.commentListForUpdation.Size = new System.Drawing.Size(887, 315);
            this.commentListForUpdation.TabIndex = 24;
            // 
            // deleteCommentTab
            // 
            this.deleteCommentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteCommentTab.Controls.Add(this.noCommentToDelete_Label);
            this.deleteCommentTab.Controls.Add(this.commentListGridForDeletion);
            this.deleteCommentTab.Controls.Add(this.Deletebutton);
            this.deleteCommentTab.Controls.Add(this.labelDeleteComment);
            this.deleteCommentTab.Location = new System.Drawing.Point(4, 22);
            this.deleteCommentTab.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCommentTab.Name = "deleteCommentTab";
            this.deleteCommentTab.Padding = new System.Windows.Forms.Padding(2);
            this.deleteCommentTab.Size = new System.Drawing.Size(913, 405);
            this.deleteCommentTab.TabIndex = 1;
            this.deleteCommentTab.Text = "Delete Comment";
            // 
            // noCommentToDelete_Label
            // 
            this.noCommentToDelete_Label.AutoSize = true;
            this.noCommentToDelete_Label.Location = new System.Drawing.Point(376, 198);
            this.noCommentToDelete_Label.Name = "noCommentToDelete_Label";
            this.noCommentToDelete_Label.Size = new System.Drawing.Size(116, 13);
            this.noCommentToDelete_Label.TabIndex = 18;
            this.noCommentToDelete_Label.Text = "No comments to delete";
            this.noCommentToDelete_Label.Visible = false;
            // 
            // commentListGridForDeletion
            // 
            this.commentListGridForDeletion.AllowUserToAddRows = false;
            this.commentListGridForDeletion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentListGridForDeletion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.commentListGridForDeletion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commentListGridForDeletion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.commentListGridForDeletion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentListGridForDeletion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.commentListGridForDeletion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentListGridForDeletion.DefaultCellStyle = dataGridViewCellStyle7;
            this.commentListGridForDeletion.EnableHeadersVisualStyles = false;
            this.commentListGridForDeletion.Location = new System.Drawing.Point(12, 41);
            this.commentListGridForDeletion.Name = "commentListGridForDeletion";
            this.commentListGridForDeletion.Size = new System.Drawing.Size(869, 305);
            this.commentListGridForDeletion.TabIndex = 17;
            this.commentListGridForDeletion.Visible = false;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.White;
            this.Deletebutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Deletebutton.FlatAppearance.BorderSize = 3;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(694, 351);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(180, 31);
            this.Deletebutton.TabIndex = 16;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Visible = false;
            this.Deletebutton.Click += new System.EventHandler(this.DeleteCommentButtonClicked);
            // 
            // labelDeleteComment
            // 
            this.labelDeleteComment.AutoSize = true;
            this.labelDeleteComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteComment.Location = new System.Drawing.Point(363, 12);
            this.labelDeleteComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeleteComment.Name = "labelDeleteComment";
            this.labelDeleteComment.Size = new System.Drawing.Size(191, 26);
            this.labelDeleteComment.TabIndex = 7;
            this.labelDeleteComment.Text = "Delete Comment";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(11, 464);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 40);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "←";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // announcementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.TeacherTabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "announcementPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Announcement Panel";
            this.Load += new System.EventHandler(this.announcementPanel_Load);
            this.TeacherTabs.ResumeLayout(false);
            this.announceDesTab.ResumeLayout(false);
            this.announceDesTab.PerformLayout();
            this.CommentsTab.ResumeLayout(false);
            this.commentTABS.ResumeLayout(false);
            this.viewCommentsTab.ResumeLayout(false);
            this.viewCommentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCommentsList)).EndInit();
            this.addCommentTab.ResumeLayout(false);
            this.addCommentTab.PerformLayout();
            this.updateCommentTab.ResumeLayout(false);
            this.updateCommentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentListForUpdation)).EndInit();
            this.deleteCommentTab.ResumeLayout(false);
            this.deleteCommentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentListGridForDeletion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TeacherTabs;
        private System.Windows.Forms.TabPage CommentsTab;
        private System.Windows.Forms.TabControl commentTABS;
        private System.Windows.Forms.TabPage addCommentTab;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.TextBox txtCommentDesc;
        private System.Windows.Forms.Label labelCommentDesc;
        private System.Windows.Forms.Label labelnewComment;
        private System.Windows.Forms.TabPage deleteCommentTab;
        private System.Windows.Forms.TabPage updateCommentTab;
        private System.Windows.Forms.Label labelDeleteComment;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox txtCommentDescUpdate;
        private System.Windows.Forms.Label labelCommentDescUpdate;
        private System.Windows.Forms.Label txtUpdateComment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TabPage announceDesTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label assignmentTitle;
        private System.Windows.Forms.TextBox txtAnnounceTitle;
        private System.Windows.Forms.TextBox txtAnnounceDesc;
        private System.Windows.Forms.TextBox txtAnnounceFile;
        private System.Windows.Forms.DataGridView commentListGridForDeletion;
        private System.Windows.Forms.Label noCommentToDelete_Label;
        private System.Windows.Forms.DataGridView commentListForUpdation;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label noCommentToUpdateLabel;
        private System.Windows.Forms.TabPage viewCommentsTab;
        private System.Windows.Forms.DataGridView allCommentsList;
        private System.Windows.Forms.Label noCommentToViewLabel;
    }
}