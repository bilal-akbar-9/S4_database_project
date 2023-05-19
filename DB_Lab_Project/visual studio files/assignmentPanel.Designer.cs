namespace intial_form_1_
{
    partial class assignmentPanel
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
            this.assDesTab = new System.Windows.Forms.TabPage();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.txtAssPoints = new System.Windows.Forms.TextBox();
            this.txtAssignmetFile = new System.Windows.Forms.TextBox();
            this.txtAssTitle = new System.Windows.Forms.TextBox();
            this.txtAssDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dueDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignmentTitle = new System.Windows.Forms.Label();
            this.ViewProgressTab = new System.Windows.Forms.TabPage();
            this.countlabel = new System.Windows.Forms.Label();
            this.ViewProgressDatagridView = new System.Windows.Forms.DataGridView();
            this.buttonViewProgress = new System.Windows.Forms.Button();
            this.labelViewProgress = new System.Windows.Forms.Label();
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
            this.txtCommentDescUPDAtE = new System.Windows.Forms.TextBox();
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
            this.assDesTab.SuspendLayout();
            this.ViewProgressTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProgressDatagridView)).BeginInit();
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
            this.TeacherTabs.Controls.Add(this.assDesTab);
            this.TeacherTabs.Controls.Add(this.ViewProgressTab);
            this.TeacherTabs.Controls.Add(this.CommentsTab);
            this.TeacherTabs.Location = new System.Drawing.Point(-2, 5);
            this.TeacherTabs.Name = "TeacherTabs";
            this.TeacherTabs.SelectedIndex = 0;
            this.TeacherTabs.Size = new System.Drawing.Size(1371, 702);
            this.TeacherTabs.TabIndex = 1;
            this.TeacherTabs.Click += new System.EventHandler(this.loadCommentsToDeleteOrUpdate);
            // 
            // assDesTab
            // 
            this.assDesTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.assDesTab.Controls.Add(this.dueDateLabel);
            this.assDesTab.Controls.Add(this.txtAssPoints);
            this.assDesTab.Controls.Add(this.txtAssignmetFile);
            this.assDesTab.Controls.Add(this.txtAssTitle);
            this.assDesTab.Controls.Add(this.txtAssDesc);
            this.assDesTab.Controls.Add(this.label4);
            this.assDesTab.Controls.Add(this.label3);
            this.assDesTab.Controls.Add(this.dueDate);
            this.assDesTab.Controls.Add(this.label1);
            this.assDesTab.Controls.Add(this.assignmentTitle);
            this.assDesTab.Location = new System.Drawing.Point(4, 29);
            this.assDesTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.assDesTab.Name = "assDesTab";
            this.assDesTab.Size = new System.Drawing.Size(1363, 669);
            this.assDesTab.TabIndex = 4;
            this.assDesTab.Text = "Assignment";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(1029, 95);
            this.dueDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(79, 29);
            this.dueDateLabel.TabIndex = 47;
            this.dueDateLabel.Text = "label2";
            // 
            // txtAssPoints
            // 
            this.txtAssPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssPoints.Location = new System.Drawing.Point(908, 271);
            this.txtAssPoints.Name = "txtAssPoints";
            this.txtAssPoints.ReadOnly = true;
            this.txtAssPoints.Size = new System.Drawing.Size(216, 35);
            this.txtAssPoints.TabIndex = 45;
            // 
            // txtAssignmetFile
            // 
            this.txtAssignmetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmetFile.Location = new System.Drawing.Point(908, 398);
            this.txtAssignmetFile.Name = "txtAssignmetFile";
            this.txtAssignmetFile.ReadOnly = true;
            this.txtAssignmetFile.Size = new System.Drawing.Size(216, 35);
            this.txtAssignmetFile.TabIndex = 46;
            // 
            // txtAssTitle
            // 
            this.txtAssTitle.Location = new System.Drawing.Point(123, 146);
            this.txtAssTitle.Multiline = true;
            this.txtAssTitle.Name = "txtAssTitle";
            this.txtAssTitle.ReadOnly = true;
            this.txtAssTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAssTitle.Size = new System.Drawing.Size(632, 46);
            this.txtAssTitle.TabIndex = 44;
            // this.txtAssTitle.TextChanged += new System.EventHandler(this.txtAssTitle_TextChanged);
            // 
            // txtAssDesc
            // 
            this.txtAssDesc.Location = new System.Drawing.Point(123, 271);
            this.txtAssDesc.Multiline = true;
            this.txtAssDesc.Name = "txtAssDesc";
            this.txtAssDesc.ReadOnly = true;
            this.txtAssDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAssDesc.Size = new System.Drawing.Size(632, 276);
            this.txtAssDesc.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(903, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(903, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "Point";
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate.Location = new System.Drawing.Point(903, 98);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(121, 29);
            this.dueDate.TabIndex = 40;
            this.dueDate.Text = "DueDate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Description";
            // 
            // assignmentTitle
            // 
            this.assignmentTitle.AutoSize = true;
            this.assignmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentTitle.Location = new System.Drawing.Point(118, 98);
            this.assignmentTitle.Name = "assignmentTitle";
            this.assignmentTitle.Size = new System.Drawing.Size(66, 29);
            this.assignmentTitle.TabIndex = 38;
            this.assignmentTitle.Text = "Title";
            // 
            // ViewProgressTab
            // 
            this.ViewProgressTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewProgressTab.Controls.Add(this.countlabel);
            this.ViewProgressTab.Controls.Add(this.ViewProgressDatagridView);
            this.ViewProgressTab.Controls.Add(this.buttonViewProgress);
            this.ViewProgressTab.Controls.Add(this.labelViewProgress);
            this.ViewProgressTab.Location = new System.Drawing.Point(4, 29);
            this.ViewProgressTab.Name = "ViewProgressTab";
            this.ViewProgressTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ViewProgressTab.Size = new System.Drawing.Size(1363, 669);
            this.ViewProgressTab.TabIndex = 2;
            this.ViewProgressTab.Text = "View Progress";
            // 
            // countlabel
            // 
            this.countlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countlabel.Location = new System.Drawing.Point(38, 95);
            this.countlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countlabel.Name = "countlabel";
            this.countlabel.Size = new System.Drawing.Size(312, 88);
            this.countlabel.TabIndex = 10;
            this.countlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.countlabel.Visible = false;
            // 
            // ViewProgressDatagridView
            // 
            this.ViewProgressDatagridView.AllowUserToAddRows = false;
            this.ViewProgressDatagridView.AllowUserToDeleteRows = false;
            this.ViewProgressDatagridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewProgressDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewProgressDatagridView.Location = new System.Drawing.Point(44, 197);
            this.ViewProgressDatagridView.Name = "ViewProgressDatagridView";
            this.ViewProgressDatagridView.ReadOnly = true;
            this.ViewProgressDatagridView.RowHeadersWidth = 62;
            this.ViewProgressDatagridView.RowTemplate.Height = 28;
            this.ViewProgressDatagridView.Size = new System.Drawing.Size(1245, 438);
            this.ViewProgressDatagridView.TabIndex = 9;
            // 
            // buttonViewProgress
            // 
            this.buttonViewProgress.BackColor = System.Drawing.Color.White;
            this.buttonViewProgress.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.buttonViewProgress.FlatAppearance.BorderSize = 3;
            this.buttonViewProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProgress.Location = new System.Drawing.Point(969, 111);
            this.buttonViewProgress.Name = "buttonViewProgress";
            this.buttonViewProgress.Size = new System.Drawing.Size(320, 57);
            this.buttonViewProgress.TabIndex = 8;
            this.buttonViewProgress.Text = "Check";
            this.buttonViewProgress.UseVisualStyleBackColor = false;
            this.buttonViewProgress.Click += new System.EventHandler(this.viewProgressButton_Clicked);
            // 
            // labelViewProgress
            // 
            this.labelViewProgress.AutoSize = true;
            this.labelViewProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewProgress.Location = new System.Drawing.Point(585, 52);
            this.labelViewProgress.Name = "labelViewProgress";
            this.labelViewProgress.Size = new System.Drawing.Size(236, 37);
            this.labelViewProgress.TabIndex = 1;
            this.labelViewProgress.Text = "View Progress";
            // 
            // CommentsTab
            // 
            this.CommentsTab.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CommentsTab.Controls.Add(this.commentTABS);
            this.CommentsTab.Location = new System.Drawing.Point(4, 29);
            this.CommentsTab.Name = "CommentsTab";
            this.CommentsTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.CommentsTab.Size = new System.Drawing.Size(1363, 669);
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
            this.commentTABS.Name = "commentTABS";
            this.commentTABS.SelectedIndex = 0;
            this.commentTABS.Size = new System.Drawing.Size(1382, 663);
            this.commentTABS.TabIndex = 0;
            this.commentTABS.Click += new System.EventHandler(this.loadCommentsToDeleteOrUpdate);
            // 
            // viewCommentsTab
            // 
            this.viewCommentsTab.Controls.Add(this.noCommentToViewLabel);
            this.viewCommentsTab.Controls.Add(this.allCommentsList);
            this.viewCommentsTab.Location = new System.Drawing.Point(4, 29);
            this.viewCommentsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewCommentsTab.Name = "viewCommentsTab";
            this.viewCommentsTab.Size = new System.Drawing.Size(1374, 630);
            this.viewCommentsTab.TabIndex = 3;
            this.viewCommentsTab.Text = "Comments";
            this.viewCommentsTab.UseVisualStyleBackColor = true;
            // 
            // noCommentToViewLabel
            // 
            this.noCommentToViewLabel.AutoSize = true;
            this.noCommentToViewLabel.Location = new System.Drawing.Point(594, 302);
            this.noCommentToViewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noCommentToViewLabel.Name = "noCommentToViewLabel";
            this.noCommentToViewLabel.Size = new System.Drawing.Size(159, 20);
            this.noCommentToViewLabel.TabIndex = 27;
            this.noCommentToViewLabel.Text = "No comments to view";
            this.noCommentToViewLabel.Visible = false;
            this.noCommentToViewLabel.Click += new System.EventHandler(this.loadCommentsToDeleteOrUpdate);
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
            this.allCommentsList.RowHeadersWidth = 62;
            this.allCommentsList.Size = new System.Drawing.Size(1338, 600);
            this.allCommentsList.TabIndex = 0;
            // 
            // addCommentTab
            // 
            this.addCommentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCommentTab.Controls.Add(this.buttonAddComment);
            this.addCommentTab.Controls.Add(this.txtCommentDesc);
            this.addCommentTab.Controls.Add(this.labelCommentDesc);
            this.addCommentTab.Controls.Add(this.labelnewComment);
            this.addCommentTab.Location = new System.Drawing.Point(4, 29);
            this.addCommentTab.Name = "addCommentTab";
            this.addCommentTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.addCommentTab.Size = new System.Drawing.Size(1374, 630);
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
            this.buttonAddComment.Location = new System.Drawing.Point(897, 446);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(232, 49);
            this.buttonAddComment.TabIndex = 11;
            this.buttonAddComment.Text = "Post";
            this.buttonAddComment.UseVisualStyleBackColor = false;
            this.buttonAddComment.Click += new System.EventHandler(this.addCommentButton_Clicked);
            // 
            // txtCommentDesc
            // 
            this.txtCommentDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDesc.Location = new System.Drawing.Point(236, 197);
            this.txtCommentDesc.Multiline = true;
            this.txtCommentDesc.Name = "txtCommentDesc";
            this.txtCommentDesc.Size = new System.Drawing.Size(894, 217);
            this.txtCommentDesc.TabIndex = 9;
            // 
            // labelCommentDesc
            // 
            this.labelCommentDesc.AutoSize = true;
            this.labelCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDesc.Location = new System.Drawing.Point(231, 151);
            this.labelCommentDesc.Name = "labelCommentDesc";
            this.labelCommentDesc.Size = new System.Drawing.Size(223, 26);
            this.labelCommentDesc.TabIndex = 7;
            this.labelCommentDesc.Text = "Comment Description";
            // 
            // labelnewComment
            // 
            this.labelnewComment.AutoSize = true;
            this.labelnewComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnewComment.Location = new System.Drawing.Point(561, 35);
            this.labelnewComment.Name = "labelnewComment";
            this.labelnewComment.Size = new System.Drawing.Size(240, 37);
            this.labelnewComment.TabIndex = 6;
            this.labelnewComment.Text = "New Comment";
            // 
            // updateCommentTab
            // 
            this.updateCommentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateCommentTab.Controls.Add(this.noCommentToUpdateLabel);
            this.updateCommentTab.Controls.Add(this.SelectButton);
            this.updateCommentTab.Controls.Add(this.updateButton);
            this.updateCommentTab.Controls.Add(this.txtCommentDescUPDAtE);
            this.updateCommentTab.Controls.Add(this.labelCommentDescUpdate);
            this.updateCommentTab.Controls.Add(this.txtUpdateComment);
            this.updateCommentTab.Controls.Add(this.commentListForUpdation);
            this.updateCommentTab.Location = new System.Drawing.Point(4, 29);
            this.updateCommentTab.Name = "updateCommentTab";
            this.updateCommentTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.updateCommentTab.Size = new System.Drawing.Size(1374, 630);
            this.updateCommentTab.TabIndex = 2;
            this.updateCommentTab.Text = "Update Comment";
            // 
            // noCommentToUpdateLabel
            // 
            this.noCommentToUpdateLabel.AutoSize = true;
            this.noCommentToUpdateLabel.Location = new System.Drawing.Point(592, 308);
            this.noCommentToUpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noCommentToUpdateLabel.Name = "noCommentToUpdateLabel";
            this.noCommentToUpdateLabel.Size = new System.Drawing.Size(179, 20);
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
            this.SelectButton.Location = new System.Drawing.Point(1094, 558);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(232, 49);
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
            this.updateButton.Location = new System.Drawing.Point(1094, 558);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(232, 49);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateCommentButtonClicked);
            // 
            // txtCommentDescUPDAtE
            // 
            this.txtCommentDescUPDAtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDescUPDAtE.Location = new System.Drawing.Point(158, 208);
            this.txtCommentDescUPDAtE.Multiline = true;
            this.txtCommentDescUPDAtE.Name = "txtCommentDescUPDAtE";
            this.txtCommentDescUPDAtE.Size = new System.Drawing.Size(1020, 253);
            this.txtCommentDescUPDAtE.TabIndex = 17;
            this.txtCommentDescUPDAtE.Visible = false;
            // 
            // labelCommentDescUpdate
            // 
            this.labelCommentDescUpdate.AutoSize = true;
            this.labelCommentDescUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDescUpdate.Location = new System.Drawing.Point(153, 160);
            this.labelCommentDescUpdate.Name = "labelCommentDescUpdate";
            this.labelCommentDescUpdate.Size = new System.Drawing.Size(223, 26);
            this.labelCommentDescUpdate.TabIndex = 15;
            this.labelCommentDescUpdate.Text = "Comment Description";
            this.labelCommentDescUpdate.Visible = false;
            // 
            // txtUpdateComment
            // 
            this.txtUpdateComment.AutoSize = true;
            this.txtUpdateComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateComment.Location = new System.Drawing.Point(534, 22);
            this.txtUpdateComment.Name = "txtUpdateComment";
            this.txtUpdateComment.Size = new System.Drawing.Size(282, 37);
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
            this.commentListForUpdation.Location = new System.Drawing.Point(10, 66);
            this.commentListForUpdation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.deleteCommentTab.Location = new System.Drawing.Point(4, 29);
            this.deleteCommentTab.Name = "deleteCommentTab";
            this.deleteCommentTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.deleteCommentTab.Size = new System.Drawing.Size(1374, 630);
            this.deleteCommentTab.TabIndex = 1;
            this.deleteCommentTab.Text = "Delete Comment";
            // 
            // noCommentToDelete_Label
            // 
            this.noCommentToDelete_Label.AutoSize = true;
            this.noCommentToDelete_Label.Location = new System.Drawing.Point(564, 305);
            this.noCommentToDelete_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noCommentToDelete_Label.Name = "noCommentToDelete_Label";
            this.noCommentToDelete_Label.Size = new System.Drawing.Size(173, 20);
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
            this.commentListGridForDeletion.Location = new System.Drawing.Point(18, 63);
            this.commentListGridForDeletion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentListGridForDeletion.Name = "commentListGridForDeletion";
            this.commentListGridForDeletion.RowHeadersWidth = 62;
            this.commentListGridForDeletion.Size = new System.Drawing.Size(1304, 469);
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
            this.Deletebutton.Location = new System.Drawing.Point(1041, 540);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(270, 48);
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
            this.labelDeleteComment.Location = new System.Drawing.Point(544, 18);
            this.labelDeleteComment.Name = "labelDeleteComment";
            this.labelDeleteComment.Size = new System.Drawing.Size(269, 37);
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
            this.backButton.Location = new System.Drawing.Point(16, 714);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 62);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "←";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // assignmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 788);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.TeacherTabs);
            this.Name = "assignmentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment Panel";
            this.Load += new System.EventHandler(this.assignmentPanel_Load);
            this.TeacherTabs.ResumeLayout(false);
            this.assDesTab.ResumeLayout(false);
            this.assDesTab.PerformLayout();
            this.ViewProgressTab.ResumeLayout(false);
            this.ViewProgressTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProgressDatagridView)).EndInit();
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
        private System.Windows.Forms.TabPage ViewProgressTab;
        private System.Windows.Forms.Button buttonViewProgress;
        private System.Windows.Forms.Label labelViewProgress;
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
        private System.Windows.Forms.TextBox txtCommentDescUPDAtE;
        private System.Windows.Forms.Label labelCommentDescUpdate;
        private System.Windows.Forms.Label txtUpdateComment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView ViewProgressDatagridView;
        private System.Windows.Forms.TabPage assDesTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label assignmentTitle;
        private System.Windows.Forms.TextBox txtAssTitle;
        private System.Windows.Forms.TextBox txtAssDesc;
        private System.Windows.Forms.TextBox txtAssPoints;
        private System.Windows.Forms.TextBox txtAssignmetFile;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label countlabel;
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