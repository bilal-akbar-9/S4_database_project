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
            this.addCommentTab = new System.Windows.Forms.TabPage();
            this.txtAssignmentID = new System.Windows.Forms.TextBox();
            this.AssignmentID = new System.Windows.Forms.Label();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.txtCommentDate = new System.Windows.Forms.TextBox();
            this.txtCommentDesc = new System.Windows.Forms.TextBox();
            this.labelCOmmentDate = new System.Windows.Forms.Label();
            this.labelCommentDesc = new System.Windows.Forms.Label();
            this.labelnewComment = new System.Windows.Forms.Label();
            this.deleteCommentTab = new System.Windows.Forms.TabPage();
            this.noCommentToDelete_Label = new System.Windows.Forms.Label();
            this.commentListGridForDeletion = new System.Windows.Forms.DataGridView();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.labelDeleteComment = new System.Windows.Forms.Label();
            this.updateCommentTab = new System.Windows.Forms.TabPage();
            this.SelectButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.txtCommentDescUPDAtE = new System.Windows.Forms.TextBox();
            this.labelCommetnDateUpdate = new System.Windows.Forms.Label();
            this.labelCommentDescUpdate = new System.Windows.Forms.Label();
            this.txtUpdateComment = new System.Windows.Forms.Label();
            this.commentListForUpdation = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.txtCommentDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.TeacherTabs.SuspendLayout();
            this.assDesTab.SuspendLayout();
            this.ViewProgressTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProgressDatagridView)).BeginInit();
            this.CommentsTab.SuspendLayout();
            this.commentTABS.SuspendLayout();
            this.addCommentTab.SuspendLayout();
            this.deleteCommentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentListGridForDeletion)).BeginInit();
            this.updateCommentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentListForUpdation)).BeginInit();
            this.SuspendLayout();
            // 
            // TeacherTabs
            // 
            this.TeacherTabs.Controls.Add(this.assDesTab);
            this.TeacherTabs.Controls.Add(this.ViewProgressTab);
            this.TeacherTabs.Controls.Add(this.CommentsTab);
            this.TeacherTabs.Location = new System.Drawing.Point(-1, 3);
            this.TeacherTabs.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherTabs.Name = "TeacherTabs";
            this.TeacherTabs.SelectedIndex = 0;
            this.TeacherTabs.Size = new System.Drawing.Size(914, 456);
            this.TeacherTabs.TabIndex = 1;
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
            this.assDesTab.Location = new System.Drawing.Point(4, 22);
            this.assDesTab.Name = "assDesTab";
            this.assDesTab.Size = new System.Drawing.Size(906, 430);
            this.assDesTab.TabIndex = 4;
            this.assDesTab.Text = "Assignment";
            this.assDesTab.Click += new System.EventHandler(this.assDesTab_Click);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(686, 62);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(51, 20);
            this.dueDateLabel.TabIndex = 47;
            this.dueDateLabel.Text = "label2";
            // 
            // txtAssPoints
            // 
            this.txtAssPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssPoints.Location = new System.Drawing.Point(605, 176);
            this.txtAssPoints.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssPoints.Name = "txtAssPoints";
            this.txtAssPoints.ReadOnly = true;
            this.txtAssPoints.Size = new System.Drawing.Size(145, 26);
            this.txtAssPoints.TabIndex = 45;
            // 
            // txtAssignmetFile
            // 
            this.txtAssignmetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmetFile.Location = new System.Drawing.Point(605, 259);
            this.txtAssignmetFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssignmetFile.Name = "txtAssignmetFile";
            this.txtAssignmetFile.ReadOnly = true;
            this.txtAssignmetFile.Size = new System.Drawing.Size(145, 26);
            this.txtAssignmetFile.TabIndex = 46;
            // 
            // txtAssTitle
            // 
            this.txtAssTitle.Location = new System.Drawing.Point(82, 95);
            this.txtAssTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssTitle.Multiline = true;
            this.txtAssTitle.Name = "txtAssTitle";
            this.txtAssTitle.ReadOnly = true;
            this.txtAssTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAssTitle.Size = new System.Drawing.Size(423, 31);
            this.txtAssTitle.TabIndex = 44;
            // 
            // txtAssDesc
            // 
            this.txtAssDesc.Location = new System.Drawing.Point(82, 176);
            this.txtAssDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssDesc.Multiline = true;
            this.txtAssDesc.Name = "txtAssDesc";
            this.txtAssDesc.ReadOnly = true;
            this.txtAssDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAssDesc.Size = new System.Drawing.Size(423, 181);
            this.txtAssDesc.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(602, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Point";
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate.Location = new System.Drawing.Point(602, 64);
            this.dueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(86, 20);
            this.dueDate.TabIndex = 40;
            this.dueDate.Text = "DueDate:";
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
            // ViewProgressTab
            // 
            this.ViewProgressTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewProgressTab.Controls.Add(this.countlabel);
            this.ViewProgressTab.Controls.Add(this.ViewProgressDatagridView);
            this.ViewProgressTab.Controls.Add(this.buttonViewProgress);
            this.ViewProgressTab.Controls.Add(this.labelViewProgress);
            this.ViewProgressTab.Location = new System.Drawing.Point(4, 22);
            this.ViewProgressTab.Margin = new System.Windows.Forms.Padding(2);
            this.ViewProgressTab.Name = "ViewProgressTab";
            this.ViewProgressTab.Padding = new System.Windows.Forms.Padding(2);
            this.ViewProgressTab.Size = new System.Drawing.Size(906, 430);
            this.ViewProgressTab.TabIndex = 2;
            this.ViewProgressTab.Text = "View Progress";
            // 
            // countlabel
            // 
            this.countlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countlabel.Location = new System.Drawing.Point(25, 62);
            this.countlabel.Name = "countlabel";
            this.countlabel.Size = new System.Drawing.Size(208, 57);
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
            this.ViewProgressDatagridView.Location = new System.Drawing.Point(29, 128);
            this.ViewProgressDatagridView.Margin = new System.Windows.Forms.Padding(2);
            this.ViewProgressDatagridView.Name = "ViewProgressDatagridView";
            this.ViewProgressDatagridView.ReadOnly = true;
            this.ViewProgressDatagridView.RowHeadersWidth = 62;
            this.ViewProgressDatagridView.RowTemplate.Height = 28;
            this.ViewProgressDatagridView.Size = new System.Drawing.Size(830, 285);
            this.ViewProgressDatagridView.TabIndex = 9;
            // 
            // buttonViewProgress
            // 
            this.buttonViewProgress.BackColor = System.Drawing.Color.White;
            this.buttonViewProgress.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.buttonViewProgress.FlatAppearance.BorderSize = 3;
            this.buttonViewProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProgress.Location = new System.Drawing.Point(646, 72);
            this.buttonViewProgress.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewProgress.Name = "buttonViewProgress";
            this.buttonViewProgress.Size = new System.Drawing.Size(213, 37);
            this.buttonViewProgress.TabIndex = 8;
            this.buttonViewProgress.Text = "Check";
            this.buttonViewProgress.UseVisualStyleBackColor = false;
            this.buttonViewProgress.Click += new System.EventHandler(this.viewProgressButton_Clicked);
            // 
            // labelViewProgress
            // 
            this.labelViewProgress.AutoSize = true;
            this.labelViewProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewProgress.Location = new System.Drawing.Point(390, 34);
            this.labelViewProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelViewProgress.Name = "labelViewProgress";
            this.labelViewProgress.Size = new System.Drawing.Size(166, 26);
            this.labelViewProgress.TabIndex = 1;
            this.labelViewProgress.Text = "View Progress";
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
            this.commentTABS.Controls.Add(this.addCommentTab);
            this.commentTABS.Controls.Add(this.deleteCommentTab);
            this.commentTABS.Controls.Add(this.updateCommentTab);
            this.commentTABS.Location = new System.Drawing.Point(0, 0);
            this.commentTABS.Margin = new System.Windows.Forms.Padding(2);
            this.commentTABS.Name = "commentTABS";
            this.commentTABS.SelectedIndex = 0;
            this.commentTABS.Size = new System.Drawing.Size(921, 431);
            this.commentTABS.TabIndex = 0;
            this.commentTABS.Click += new System.EventHandler(this.loadCommentsToDeleteOrUpdate);
            // 
            // addCommentTab
            // 
            this.addCommentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCommentTab.Controls.Add(this.txtAssignmentID);
            this.addCommentTab.Controls.Add(this.AssignmentID);
            this.addCommentTab.Controls.Add(this.buttonAddComment);
            this.addCommentTab.Controls.Add(this.txtCommentDate);
            this.addCommentTab.Controls.Add(this.txtCommentDesc);
            this.addCommentTab.Controls.Add(this.labelCOmmentDate);
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
            // txtAssignmentID
            // 
            this.txtAssignmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmentID.Location = new System.Drawing.Point(598, 211);
            this.txtAssignmentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssignmentID.Name = "txtAssignmentID";
            this.txtAssignmentID.Size = new System.Drawing.Size(156, 24);
            this.txtAssignmentID.TabIndex = 13;
            // 
            // AssignmentID
            // 
            this.AssignmentID.AutoSize = true;
            this.AssignmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentID.Location = new System.Drawing.Point(595, 176);
            this.AssignmentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmentID.Name = "AssignmentID";
            this.AssignmentID.Size = new System.Drawing.Size(103, 18);
            this.AssignmentID.TabIndex = 12;
            this.AssignmentID.Text = "Assignment ID";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.BackColor = System.Drawing.Color.White;
            this.buttonAddComment.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonAddComment.FlatAppearance.BorderSize = 3;
            this.buttonAddComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddComment.Location = new System.Drawing.Point(598, 314);
            this.buttonAddComment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(155, 32);
            this.buttonAddComment.TabIndex = 11;
            this.buttonAddComment.Text = "Post";
            this.buttonAddComment.UseVisualStyleBackColor = false;
            this.buttonAddComment.Click += new System.EventHandler(this.addCommentButton_Clicked);
            // 
            // txtCommentDate
            // 
            this.txtCommentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDate.Location = new System.Drawing.Point(598, 128);
            this.txtCommentDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentDate.Name = "txtCommentDate";
            this.txtCommentDate.Size = new System.Drawing.Size(156, 24);
            this.txtCommentDate.TabIndex = 10;
            // 
            // txtCommentDesc
            // 
            this.txtCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDesc.Location = new System.Drawing.Point(157, 128);
            this.txtCommentDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentDesc.Multiline = true;
            this.txtCommentDesc.Name = "txtCommentDesc";
            this.txtCommentDesc.Size = new System.Drawing.Size(347, 166);
            this.txtCommentDesc.TabIndex = 9;
            // 
            // labelCOmmentDate
            // 
            this.labelCOmmentDate.AutoSize = true;
            this.labelCOmmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOmmentDate.Location = new System.Drawing.Point(595, 86);
            this.labelCOmmentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCOmmentDate.Name = "labelCOmmentDate";
            this.labelCOmmentDate.Size = new System.Drawing.Size(109, 18);
            this.labelCOmmentDate.TabIndex = 8;
            this.labelCOmmentDate.Text = "Comment Date";
            // 
            // labelCommentDesc
            // 
            this.labelCommentDesc.AutoSize = true;
            this.labelCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDesc.Location = new System.Drawing.Point(154, 86);
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
            this.commentListGridForDeletion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentListGridForDeletion.Location = new System.Drawing.Point(5, 52);
            this.commentListGridForDeletion.Name = "commentListGridForDeletion";
            this.commentListGridForDeletion.Size = new System.Drawing.Size(869, 294);
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
            this.labelDeleteComment.Location = new System.Drawing.Point(361, 24);
            this.labelDeleteComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeleteComment.Name = "labelDeleteComment";
            this.labelDeleteComment.Size = new System.Drawing.Size(191, 26);
            this.labelDeleteComment.TabIndex = 7;
            this.labelDeleteComment.Text = "Delete Comment";
            // 
            // updateCommentTab
            // 
            this.updateCommentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateCommentTab.Controls.Add(this.txtCommentDateUpdate);
            this.updateCommentTab.Controls.Add(this.SelectButton);
            this.updateCommentTab.Controls.Add(this.updateButton);
            this.updateCommentTab.Controls.Add(this.txtCommentDescUPDAtE);
            this.updateCommentTab.Controls.Add(this.labelCommetnDateUpdate);
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
            // txtCommentDescUPDAtE
            // 
            this.txtCommentDescUPDAtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDescUPDAtE.Location = new System.Drawing.Point(93, 153);
            this.txtCommentDescUPDAtE.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentDescUPDAtE.Multiline = true;
            this.txtCommentDescUPDAtE.Name = "txtCommentDescUPDAtE";
            this.txtCommentDescUPDAtE.Size = new System.Drawing.Size(681, 166);
            this.txtCommentDescUPDAtE.TabIndex = 17;
            this.txtCommentDescUPDAtE.Visible = false;
            // 
            // labelCommetnDateUpdate
            // 
            this.labelCommetnDateUpdate.AutoSize = true;
            this.labelCommetnDateUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommetnDateUpdate.Location = new System.Drawing.Point(460, 120);
            this.labelCommetnDateUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommetnDateUpdate.Name = "labelCommetnDateUpdate";
            this.labelCommetnDateUpdate.Size = new System.Drawing.Size(109, 18);
            this.labelCommetnDateUpdate.TabIndex = 16;
            this.labelCommetnDateUpdate.Text = "Comment Date";
            this.labelCommetnDateUpdate.Visible = false;
            // 
            // labelCommentDescUpdate
            // 
            this.labelCommentDescUpdate.AutoSize = true;
            this.labelCommentDescUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDescUpdate.Location = new System.Drawing.Point(90, 120);
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
            this.commentListForUpdation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentListForUpdation.Location = new System.Drawing.Point(22, 43);
            this.commentListForUpdation.MultiSelect = false;
            this.commentListForUpdation.Name = "commentListForUpdation";
            this.commentListForUpdation.Size = new System.Drawing.Size(877, 315);
            this.commentListForUpdation.TabIndex = 24;
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
            // txtCommentDateUpdate
            // 
            this.txtCommentDateUpdate.Location = new System.Drawing.Point(574, 118);
            this.txtCommentDateUpdate.Name = "txtCommentDateUpdate";
            this.txtCommentDateUpdate.Size = new System.Drawing.Size(200, 20);
            this.txtCommentDateUpdate.TabIndex = 26;
            this.txtCommentDateUpdate.Visible = false;
            // 
            // assignmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.TeacherTabs);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.addCommentTab.ResumeLayout(false);
            this.addCommentTab.PerformLayout();
            this.deleteCommentTab.ResumeLayout(false);
            this.deleteCommentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentListGridForDeletion)).EndInit();
            this.updateCommentTab.ResumeLayout(false);
            this.updateCommentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentListForUpdation)).EndInit();
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
        private System.Windows.Forms.TextBox txtCommentDate;
        private System.Windows.Forms.TextBox txtCommentDesc;
        private System.Windows.Forms.Label labelCOmmentDate;
        private System.Windows.Forms.Label labelCommentDesc;
        private System.Windows.Forms.Label labelnewComment;
        private System.Windows.Forms.TabPage deleteCommentTab;
        private System.Windows.Forms.TabPage updateCommentTab;
        private System.Windows.Forms.TextBox txtAssignmentID;
        private System.Windows.Forms.Label AssignmentID;
        private System.Windows.Forms.Label labelDeleteComment;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox txtCommentDescUPDAtE;
        private System.Windows.Forms.Label labelCommetnDateUpdate;
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
        private System.Windows.Forms.DateTimePicker txtCommentDateUpdate;
    }
}