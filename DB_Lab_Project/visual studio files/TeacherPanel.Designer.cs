namespace intial_form_1_
{
    partial class TeacherPanel
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
            this.ViewProgressTab = new System.Windows.Forms.TabPage();
            this.ViewProgressDatagridView = new System.Windows.Forms.DataGridView();
            this.buttonViewProgress = new System.Windows.Forms.Button();
            this.labelViewProgress = new System.Windows.Forms.Label();
            this.CommentsTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.Deletebutton = new System.Windows.Forms.Button();
            this.txtCommentID = new System.Windows.Forms.TextBox();
            this.labelCommentID = new System.Windows.Forms.Label();
            this.labelDeleteComment = new System.Windows.Forms.Label();
            this.updateCommentTab = new System.Windows.Forms.TabPage();
            this.txtCOmmentIDUpdate = new System.Windows.Forms.TextBox();
            this.labelcommentIDUpdate = new System.Windows.Forms.Label();
            this.txtAssIDUpdate = new System.Windows.Forms.TextBox();
            this.labelAssIDUpdate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCommentDateUpdate = new System.Windows.Forms.TextBox();
            this.txtCommentDescUPDAtE = new System.Windows.Forms.TextBox();
            this.labelCommetnDate = new System.Windows.Forms.Label();
            this.labelCommentDescUpdate = new System.Windows.Forms.Label();
            this.txtUpdateComment = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.countlabel = new System.Windows.Forms.Label();
            this.TeacherTabs.SuspendLayout();
            this.ViewProgressTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProgressDatagridView)).BeginInit();
            this.CommentsTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.addCommentTab.SuspendLayout();
            this.deleteCommentTab.SuspendLayout();
            this.updateCommentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherTabs
            // 
            this.TeacherTabs.Controls.Add(this.ViewProgressTab);
            this.TeacherTabs.Controls.Add(this.CommentsTab);
            this.TeacherTabs.Location = new System.Drawing.Point(-2, 5);
            this.TeacherTabs.Name = "TeacherTabs";
            this.TeacherTabs.SelectedIndex = 0;
            this.TeacherTabs.Size = new System.Drawing.Size(1371, 702);
            this.TeacherTabs.TabIndex = 1;
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
            this.ViewProgressTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewProgressTab.Size = new System.Drawing.Size(1363, 669);
            this.ViewProgressTab.TabIndex = 2;
            this.ViewProgressTab.Text = "View Progress";
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
            this.ViewProgressDatagridView.Size = new System.Drawing.Size(1245, 439);
            this.ViewProgressDatagridView.TabIndex = 9;
            // 
            // buttonViewProgress
            // 
            this.buttonViewProgress.BackColor = System.Drawing.Color.White;
            this.buttonViewProgress.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.buttonViewProgress.FlatAppearance.BorderSize = 3;
            this.buttonViewProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProgress.Location = new System.Drawing.Point(540, 124);
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
            this.CommentsTab.Controls.Add(this.tabControl1);
            this.CommentsTab.Location = new System.Drawing.Point(4, 29);
            this.CommentsTab.Name = "CommentsTab";
            this.CommentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CommentsTab.Size = new System.Drawing.Size(1363, 669);
            this.CommentsTab.TabIndex = 3;
            this.CommentsTab.Text = "Comments";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addCommentTab);
            this.tabControl1.Controls.Add(this.deleteCommentTab);
            this.tabControl1.Controls.Add(this.updateCommentTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1382, 663);
            this.tabControl1.TabIndex = 0;
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
            this.addCommentTab.Location = new System.Drawing.Point(4, 29);
            this.addCommentTab.Name = "addCommentTab";
            this.addCommentTab.Padding = new System.Windows.Forms.Padding(3);
            this.addCommentTab.Size = new System.Drawing.Size(1374, 630);
            this.addCommentTab.TabIndex = 0;
            this.addCommentTab.Text = "Add Comment";
            // 
            // txtAssignmentID
            // 
            this.txtAssignmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmentID.Location = new System.Drawing.Point(897, 325);
            this.txtAssignmentID.Name = "txtAssignmentID";
            this.txtAssignmentID.Size = new System.Drawing.Size(232, 32);
            this.txtAssignmentID.TabIndex = 13;
            // 
            // AssignmentID
            // 
            this.AssignmentID.AutoSize = true;
            this.AssignmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentID.Location = new System.Drawing.Point(892, 271);
            this.AssignmentID.Name = "AssignmentID";
            this.AssignmentID.Size = new System.Drawing.Size(155, 26);
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
            this.buttonAddComment.Location = new System.Drawing.Point(897, 483);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(232, 49);
            this.buttonAddComment.TabIndex = 11;
            this.buttonAddComment.Text = "Post";
            this.buttonAddComment.UseVisualStyleBackColor = false;
            this.buttonAddComment.Click += new System.EventHandler(this.addCommentButton_Clicked);
            // 
            // txtCommentDate
            // 
            this.txtCommentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDate.Location = new System.Drawing.Point(897, 197);
            this.txtCommentDate.Name = "txtCommentDate";
            this.txtCommentDate.Size = new System.Drawing.Size(232, 32);
            this.txtCommentDate.TabIndex = 10;
            // 
            // txtCommentDesc
            // 
            this.txtCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDesc.Location = new System.Drawing.Point(236, 197);
            this.txtCommentDesc.Multiline = true;
            this.txtCommentDesc.Name = "txtCommentDesc";
            this.txtCommentDesc.Size = new System.Drawing.Size(518, 253);
            this.txtCommentDesc.TabIndex = 9;
            // 
            // labelCOmmentDate
            // 
            this.labelCOmmentDate.AutoSize = true;
            this.labelCOmmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOmmentDate.Location = new System.Drawing.Point(892, 132);
            this.labelCOmmentDate.Name = "labelCOmmentDate";
            this.labelCOmmentDate.Size = new System.Drawing.Size(160, 26);
            this.labelCOmmentDate.TabIndex = 8;
            this.labelCOmmentDate.Text = "Comment Date";
            // 
            // labelCommentDesc
            // 
            this.labelCommentDesc.AutoSize = true;
            this.labelCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDesc.Location = new System.Drawing.Point(231, 132);
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
            // deleteCommentTab
            // 
            this.deleteCommentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteCommentTab.Controls.Add(this.Deletebutton);
            this.deleteCommentTab.Controls.Add(this.txtCommentID);
            this.deleteCommentTab.Controls.Add(this.labelCommentID);
            this.deleteCommentTab.Controls.Add(this.labelDeleteComment);
            this.deleteCommentTab.Location = new System.Drawing.Point(4, 29);
            this.deleteCommentTab.Name = "deleteCommentTab";
            this.deleteCommentTab.Padding = new System.Windows.Forms.Padding(3);
            this.deleteCommentTab.Size = new System.Drawing.Size(1374, 630);
            this.deleteCommentTab.TabIndex = 1;
            this.deleteCommentTab.Text = "Delete Comment";
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.White;
            this.Deletebutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Deletebutton.FlatAppearance.BorderSize = 3;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(654, 289);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(270, 48);
            this.Deletebutton.TabIndex = 16;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.DeleteCommentButton);
            // 
            // txtCommentID
            // 
            this.txtCommentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentID.Location = new System.Drawing.Point(654, 185);
            this.txtCommentID.Name = "txtCommentID";
            this.txtCommentID.Size = new System.Drawing.Size(270, 39);
            this.txtCommentID.TabIndex = 15;
            // 
            // labelCommentID
            // 
            this.labelCommentID.AutoSize = true;
            this.labelCommentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentID.Location = new System.Drawing.Point(426, 183);
            this.labelCommentID.Name = "labelCommentID";
            this.labelCommentID.Size = new System.Drawing.Size(170, 32);
            this.labelCommentID.TabIndex = 14;
            this.labelCommentID.Text = "Comment ID";
            // 
            // labelDeleteComment
            // 
            this.labelDeleteComment.AutoSize = true;
            this.labelDeleteComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteComment.Location = new System.Drawing.Point(542, 37);
            this.labelDeleteComment.Name = "labelDeleteComment";
            this.labelDeleteComment.Size = new System.Drawing.Size(269, 37);
            this.labelDeleteComment.TabIndex = 7;
            this.labelDeleteComment.Text = "Delete Comment";
            // 
            // updateCommentTab
            // 
            this.updateCommentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateCommentTab.Controls.Add(this.txtCOmmentIDUpdate);
            this.updateCommentTab.Controls.Add(this.labelcommentIDUpdate);
            this.updateCommentTab.Controls.Add(this.txtAssIDUpdate);
            this.updateCommentTab.Controls.Add(this.labelAssIDUpdate);
            this.updateCommentTab.Controls.Add(this.button1);
            this.updateCommentTab.Controls.Add(this.txtCommentDateUpdate);
            this.updateCommentTab.Controls.Add(this.txtCommentDescUPDAtE);
            this.updateCommentTab.Controls.Add(this.labelCommetnDate);
            this.updateCommentTab.Controls.Add(this.labelCommentDescUpdate);
            this.updateCommentTab.Controls.Add(this.txtUpdateComment);
            this.updateCommentTab.Location = new System.Drawing.Point(4, 29);
            this.updateCommentTab.Name = "updateCommentTab";
            this.updateCommentTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateCommentTab.Size = new System.Drawing.Size(1374, 630);
            this.updateCommentTab.TabIndex = 2;
            this.updateCommentTab.Text = "Update Comment";
            // 
            // txtCOmmentIDUpdate
            // 
            this.txtCOmmentIDUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOmmentIDUpdate.Location = new System.Drawing.Point(1068, 189);
            this.txtCOmmentIDUpdate.Name = "txtCOmmentIDUpdate";
            this.txtCOmmentIDUpdate.Size = new System.Drawing.Size(232, 32);
            this.txtCOmmentIDUpdate.TabIndex = 23;
            // 
            // labelcommentIDUpdate
            // 
            this.labelcommentIDUpdate.AutoSize = true;
            this.labelcommentIDUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcommentIDUpdate.Location = new System.Drawing.Point(1064, 125);
            this.labelcommentIDUpdate.Name = "labelcommentIDUpdate";
            this.labelcommentIDUpdate.Size = new System.Drawing.Size(136, 26);
            this.labelcommentIDUpdate.TabIndex = 22;
            this.labelcommentIDUpdate.Text = "Comment ID";
            // 
            // txtAssIDUpdate
            // 
            this.txtAssIDUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssIDUpdate.Location = new System.Drawing.Point(734, 331);
            this.txtAssIDUpdate.Name = "txtAssIDUpdate";
            this.txtAssIDUpdate.Size = new System.Drawing.Size(232, 32);
            this.txtAssIDUpdate.TabIndex = 21;
            // 
            // labelAssIDUpdate
            // 
            this.labelAssIDUpdate.AutoSize = true;
            this.labelAssIDUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssIDUpdate.Location = new System.Drawing.Point(732, 271);
            this.labelAssIDUpdate.Name = "labelAssIDUpdate";
            this.labelAssIDUpdate.Size = new System.Drawing.Size(155, 26);
            this.labelAssIDUpdate.TabIndex = 20;
            this.labelAssIDUpdate.Text = "Assignment ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1068, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 49);
            this.button1.TabIndex = 19;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.UpdateCOmmentButton);
            // 
            // txtCommentDateUpdate
            // 
            this.txtCommentDateUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDateUpdate.Location = new System.Drawing.Point(734, 189);
            this.txtCommentDateUpdate.Name = "txtCommentDateUpdate";
            this.txtCommentDateUpdate.Size = new System.Drawing.Size(232, 32);
            this.txtCommentDateUpdate.TabIndex = 18;
            // 
            // txtCommentDescUPDAtE
            // 
            this.txtCommentDescUPDAtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDescUPDAtE.Location = new System.Drawing.Point(106, 197);
            this.txtCommentDescUPDAtE.Multiline = true;
            this.txtCommentDescUPDAtE.Name = "txtCommentDescUPDAtE";
            this.txtCommentDescUPDAtE.Size = new System.Drawing.Size(518, 253);
            this.txtCommentDescUPDAtE.TabIndex = 17;
            // 
            // labelCommetnDate
            // 
            this.labelCommetnDate.AutoSize = true;
            this.labelCommetnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommetnDate.Location = new System.Drawing.Point(726, 125);
            this.labelCommetnDate.Name = "labelCommetnDate";
            this.labelCommetnDate.Size = new System.Drawing.Size(160, 26);
            this.labelCommetnDate.TabIndex = 16;
            this.labelCommetnDate.Text = "Comment Date";
            // 
            // labelCommentDescUpdate
            // 
            this.labelCommentDescUpdate.AutoSize = true;
            this.labelCommentDescUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDescUpdate.Location = new System.Drawing.Point(100, 125);
            this.labelCommentDescUpdate.Name = "labelCommentDescUpdate";
            this.labelCommentDescUpdate.Size = new System.Drawing.Size(223, 26);
            this.labelCommentDescUpdate.TabIndex = 15;
            this.labelCommentDescUpdate.Text = "Comment Description";
            // 
            // txtUpdateComment
            // 
            this.txtUpdateComment.AutoSize = true;
            this.txtUpdateComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateComment.Location = new System.Drawing.Point(534, 43);
            this.txtUpdateComment.Name = "txtUpdateComment";
            this.txtUpdateComment.Size = new System.Drawing.Size(282, 37);
            this.txtUpdateComment.TabIndex = 14;
            this.txtUpdateComment.Text = "Update Comment";
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
            // countlabel
            // 
            this.countlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countlabel.Location = new System.Drawing.Point(1032, 124);
            this.countlabel.Name = "countlabel";
            this.countlabel.Size = new System.Drawing.Size(208, 57);
            this.countlabel.TabIndex = 10;
            this.countlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.countlabel.Visible = false;
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 788);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.TeacherTabs);
            this.Name = "TeacherPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherPanel";
            this.TeacherTabs.ResumeLayout(false);
            this.ViewProgressTab.ResumeLayout(false);
            this.ViewProgressTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProgressDatagridView)).EndInit();
            this.CommentsTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.addCommentTab.ResumeLayout(false);
            this.addCommentTab.PerformLayout();
            this.deleteCommentTab.ResumeLayout(false);
            this.deleteCommentTab.PerformLayout();
            this.updateCommentTab.ResumeLayout(false);
            this.updateCommentTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TeacherTabs;
        private System.Windows.Forms.TabPage ViewProgressTab;
        private System.Windows.Forms.Button buttonViewProgress;
        private System.Windows.Forms.Label labelViewProgress;
        private System.Windows.Forms.TabPage CommentsTab;
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.TextBox txtCommentID;
        private System.Windows.Forms.Label labelCommentID;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.TextBox txtAssIDUpdate;
        private System.Windows.Forms.Label labelAssIDUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCommentDateUpdate;
        private System.Windows.Forms.TextBox txtCommentDescUPDAtE;
        private System.Windows.Forms.Label labelCommetnDate;
        private System.Windows.Forms.Label labelCommentDescUpdate;
        private System.Windows.Forms.Label txtUpdateComment;
        private System.Windows.Forms.TextBox txtCOmmentIDUpdate;
        private System.Windows.Forms.Label labelcommentIDUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView ViewProgressDatagridView;
        private System.Windows.Forms.Label countlabel;
    }
}