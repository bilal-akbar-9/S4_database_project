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
            this.TeacherTab_1 = new System.Windows.Forms.TabPage();
            this.CreateAssignment = new System.Windows.Forms.Button();
            this.AssignmetFile = new System.Windows.Forms.Label();
            this.assPoints = new System.Windows.Forms.Label();
            this.AssignmentDueDate = new System.Windows.Forms.Label();
            this.AssignmentDescription = new System.Windows.Forms.Label();
            this.txtAssignmetFile = new System.Windows.Forms.TextBox();
            this.txtAssPoints = new System.Windows.Forms.TextBox();
            this.txtAssDueDate = new System.Windows.Forms.TextBox();
            this.txtAssDesc = new System.Windows.Forms.TextBox();
            this.createNewAssingment = new System.Windows.Forms.Label();
            this.TeacherTab_2 = new System.Windows.Forms.TabPage();
            this.buttonSetDeadline = new System.Windows.Forms.Button();
            this.txtAssDue = new System.Windows.Forms.TextBox();
            this.txtAssNo = new System.Windows.Forms.TextBox();
            this.labelAssignmentDueDate = new System.Windows.Forms.Label();
            this.labelAssignmentNumber = new System.Windows.Forms.Label();
            this.labelSetDeadlinesofAssignments = new System.Windows.Forms.Label();
            this.ViewProgressTab = new System.Windows.Forms.TabPage();
            this.buttonViewProgress = new System.Windows.Forms.Button();
            this.txtAssNo2 = new System.Windows.Forms.TextBox();
            this.labelAssNo2 = new System.Windows.Forms.Label();
            this.txtStudentsID = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.Label();
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
            this.updateCommentTab = new System.Windows.Forms.TabPage();
            this.TeacherTabs.SuspendLayout();
            this.TeacherTab_1.SuspendLayout();
            this.TeacherTab_2.SuspendLayout();
            this.ViewProgressTab.SuspendLayout();
            this.CommentsTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.addCommentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherTabs
            // 
            this.TeacherTabs.Controls.Add(this.TeacherTab_1);
            this.TeacherTabs.Controls.Add(this.TeacherTab_2);
            this.TeacherTabs.Controls.Add(this.ViewProgressTab);
            this.TeacherTabs.Controls.Add(this.CommentsTab);
            this.TeacherTabs.Location = new System.Drawing.Point(-1, 3);
            this.TeacherTabs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeacherTabs.Name = "TeacherTabs";
            this.TeacherTabs.SelectedIndex = 0;
            this.TeacherTabs.Size = new System.Drawing.Size(931, 456);
            this.TeacherTabs.TabIndex = 1;
            // 
            // TeacherTab_1
            // 
            this.TeacherTab_1.Controls.Add(this.CreateAssignment);
            this.TeacherTab_1.Controls.Add(this.AssignmetFile);
            this.TeacherTab_1.Controls.Add(this.assPoints);
            this.TeacherTab_1.Controls.Add(this.AssignmentDueDate);
            this.TeacherTab_1.Controls.Add(this.AssignmentDescription);
            this.TeacherTab_1.Controls.Add(this.txtAssignmetFile);
            this.TeacherTab_1.Controls.Add(this.txtAssPoints);
            this.TeacherTab_1.Controls.Add(this.txtAssDueDate);
            this.TeacherTab_1.Controls.Add(this.txtAssDesc);
            this.TeacherTab_1.Controls.Add(this.createNewAssingment);
            this.TeacherTab_1.Location = new System.Drawing.Point(4, 22);
            this.TeacherTab_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeacherTab_1.Name = "TeacherTab_1";
            this.TeacherTab_1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeacherTab_1.Size = new System.Drawing.Size(923, 430);
            this.TeacherTab_1.TabIndex = 0;
            this.TeacherTab_1.Text = "Create Assignment";
            this.TeacherTab_1.UseVisualStyleBackColor = true;
            // 
            // CreateAssignment
            // 
            this.CreateAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAssignment.Location = new System.Drawing.Point(718, 344);
            this.CreateAssignment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateAssignment.Name = "CreateAssignment";
            this.CreateAssignment.Size = new System.Drawing.Size(107, 40);
            this.CreateAssignment.TabIndex = 22;
            this.CreateAssignment.Text = "Create";
            this.CreateAssignment.UseVisualStyleBackColor = true;
            this.CreateAssignment.Click += new System.EventHandler(this.CreateAssignment_Click);
            // 
            // AssignmetFile
            // 
            this.AssignmetFile.AutoSize = true;
            this.AssignmetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmetFile.Location = new System.Drawing.Point(101, 224);
            this.AssignmetFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmetFile.Name = "AssignmetFile";
            this.AssignmetFile.Size = new System.Drawing.Size(122, 20);
            this.AssignmetFile.TabIndex = 21;
            this.AssignmetFile.Text = "Assignment File";
            // 
            // assPoints
            // 
            this.assPoints.AutoSize = true;
            this.assPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assPoints.Location = new System.Drawing.Point(666, 224);
            this.assPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assPoints.Name = "assPoints";
            this.assPoints.Size = new System.Drawing.Size(141, 20);
            this.assPoints.TabIndex = 20;
            this.assPoints.Text = "Assignment Points";
            // 
            // AssignmentDueDate
            // 
            this.AssignmentDueDate.AutoSize = true;
            this.AssignmentDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentDueDate.Location = new System.Drawing.Point(666, 84);
            this.AssignmentDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmentDueDate.Name = "AssignmentDueDate";
            this.AssignmentDueDate.Size = new System.Drawing.Size(162, 20);
            this.AssignmentDueDate.TabIndex = 19;
            this.AssignmentDueDate.Text = "Assignment DueDate";
            // 
            // AssignmentDescription
            // 
            this.AssignmentDescription.AutoSize = true;
            this.AssignmentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentDescription.Location = new System.Drawing.Point(101, 84);
            this.AssignmentDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmentDescription.Name = "AssignmentDescription";
            this.AssignmentDescription.Size = new System.Drawing.Size(177, 20);
            this.AssignmentDescription.TabIndex = 18;
            this.AssignmentDescription.Text = "Assignment Description";
            // 
            // txtAssignmetFile
            // 
            this.txtAssignmetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmetFile.Location = new System.Drawing.Point(103, 264);
            this.txtAssignmetFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssignmetFile.Name = "txtAssignmetFile";
            this.txtAssignmetFile.Size = new System.Drawing.Size(127, 26);
            this.txtAssignmetFile.TabIndex = 17;
            // 
            // txtAssPoints
            // 
            this.txtAssPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssPoints.Location = new System.Drawing.Point(669, 264);
            this.txtAssPoints.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssPoints.Name = "txtAssPoints";
            this.txtAssPoints.Size = new System.Drawing.Size(141, 26);
            this.txtAssPoints.TabIndex = 16;
            // 
            // txtAssDueDate
            // 
            this.txtAssDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssDueDate.Location = new System.Drawing.Point(669, 119);
            this.txtAssDueDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssDueDate.Name = "txtAssDueDate";
            this.txtAssDueDate.Size = new System.Drawing.Size(141, 26);
            this.txtAssDueDate.TabIndex = 15;
            // 
            // txtAssDesc
            // 
            this.txtAssDesc.Location = new System.Drawing.Point(103, 119);
            this.txtAssDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssDesc.Multiline = true;
            this.txtAssDesc.Name = "txtAssDesc";
            this.txtAssDesc.Size = new System.Drawing.Size(414, 85);
            this.txtAssDesc.TabIndex = 14;
            // 
            // createNewAssingment
            // 
            this.createNewAssingment.AutoSize = true;
            this.createNewAssingment.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createNewAssingment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewAssingment.Location = new System.Drawing.Point(349, 28);
            this.createNewAssingment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createNewAssingment.Name = "createNewAssingment";
            this.createNewAssingment.Size = new System.Drawing.Size(269, 26);
            this.createNewAssingment.TabIndex = 13;
            this.createNewAssingment.Text = "Create New Assignment";
            // 
            // TeacherTab_2
            // 
            this.TeacherTab_2.Controls.Add(this.buttonSetDeadline);
            this.TeacherTab_2.Controls.Add(this.txtAssDue);
            this.TeacherTab_2.Controls.Add(this.txtAssNo);
            this.TeacherTab_2.Controls.Add(this.labelAssignmentDueDate);
            this.TeacherTab_2.Controls.Add(this.labelAssignmentNumber);
            this.TeacherTab_2.Controls.Add(this.labelSetDeadlinesofAssignments);
            this.TeacherTab_2.Location = new System.Drawing.Point(4, 22);
            this.TeacherTab_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeacherTab_2.Name = "TeacherTab_2";
            this.TeacherTab_2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TeacherTab_2.Size = new System.Drawing.Size(923, 430);
            this.TeacherTab_2.TabIndex = 1;
            this.TeacherTab_2.Text = "Set Deadline";
            this.TeacherTab_2.UseVisualStyleBackColor = true;
            // 
            // buttonSetDeadline
            // 
            this.buttonSetDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetDeadline.Location = new System.Drawing.Point(725, 339);
            this.buttonSetDeadline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSetDeadline.Name = "buttonSetDeadline";
            this.buttonSetDeadline.Size = new System.Drawing.Size(99, 42);
            this.buttonSetDeadline.TabIndex = 5;
            this.buttonSetDeadline.Text = "Submit";
            this.buttonSetDeadline.UseVisualStyleBackColor = true;
            this.buttonSetDeadline.Click += new System.EventHandler(this.buttonSetDeadline_Click);
            // 
            // txtAssDue
            // 
            this.txtAssDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssDue.Location = new System.Drawing.Point(333, 121);
            this.txtAssDue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssDue.Name = "txtAssDue";
            this.txtAssDue.Size = new System.Drawing.Size(156, 24);
            this.txtAssDue.TabIndex = 4;
            // 
            // txtAssNo
            // 
            this.txtAssNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssNo.Location = new System.Drawing.Point(45, 121);
            this.txtAssNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssNo.Name = "txtAssNo";
            this.txtAssNo.Size = new System.Drawing.Size(135, 24);
            this.txtAssNo.TabIndex = 3;
            // 
            // labelAssignmentDueDate
            // 
            this.labelAssignmentDueDate.AutoSize = true;
            this.labelAssignmentDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignmentDueDate.Location = new System.Drawing.Point(330, 74);
            this.labelAssignmentDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAssignmentDueDate.Name = "labelAssignmentDueDate";
            this.labelAssignmentDueDate.Size = new System.Drawing.Size(159, 18);
            this.labelAssignmentDueDate.TabIndex = 2;
            this.labelAssignmentDueDate.Text = "Assignment Due Date?";
            this.labelAssignmentDueDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelAssignmentNumber
            // 
            this.labelAssignmentNumber.AutoSize = true;
            this.labelAssignmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignmentNumber.Location = new System.Drawing.Point(42, 74);
            this.labelAssignmentNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAssignmentNumber.Name = "labelAssignmentNumber";
            this.labelAssignmentNumber.Size = new System.Drawing.Size(150, 18);
            this.labelAssignmentNumber.TabIndex = 1;
            this.labelAssignmentNumber.Text = "Assignment Number?";
            this.labelAssignmentNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelSetDeadlinesofAssignments
            // 
            this.labelSetDeadlinesofAssignments.AutoSize = true;
            this.labelSetDeadlinesofAssignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetDeadlinesofAssignments.Location = new System.Drawing.Point(330, 20);
            this.labelSetDeadlinesofAssignments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSetDeadlinesofAssignments.Name = "labelSetDeadlinesofAssignments";
            this.labelSetDeadlinesofAssignments.Size = new System.Drawing.Size(251, 20);
            this.labelSetDeadlinesofAssignments.TabIndex = 0;
            this.labelSetDeadlinesofAssignments.Text = "Set Deadlines of Assignments";
            // 
            // ViewProgressTab
            // 
            this.ViewProgressTab.Controls.Add(this.buttonViewProgress);
            this.ViewProgressTab.Controls.Add(this.txtAssNo2);
            this.ViewProgressTab.Controls.Add(this.labelAssNo2);
            this.ViewProgressTab.Controls.Add(this.txtStudentsID);
            this.ViewProgressTab.Controls.Add(this.StudentID);
            this.ViewProgressTab.Controls.Add(this.labelViewProgress);
            this.ViewProgressTab.Location = new System.Drawing.Point(4, 22);
            this.ViewProgressTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewProgressTab.Name = "ViewProgressTab";
            this.ViewProgressTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewProgressTab.Size = new System.Drawing.Size(923, 430);
            this.ViewProgressTab.TabIndex = 2;
            this.ViewProgressTab.Text = "View Progress";
            this.ViewProgressTab.UseVisualStyleBackColor = true;
            // 
            // buttonViewProgress
            // 
            this.buttonViewProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProgress.Location = new System.Drawing.Point(731, 339);
            this.buttonViewProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonViewProgress.Name = "buttonViewProgress";
            this.buttonViewProgress.Size = new System.Drawing.Size(93, 41);
            this.buttonViewProgress.TabIndex = 8;
            this.buttonViewProgress.Text = "Submit";
            this.buttonViewProgress.UseVisualStyleBackColor = true;
            this.buttonViewProgress.Click += new System.EventHandler(this.viewProgressButton_Clicked);
            // 
            // txtAssNo2
            // 
            this.txtAssNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssNo2.Location = new System.Drawing.Point(75, 240);
            this.txtAssNo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssNo2.Name = "txtAssNo2";
            this.txtAssNo2.Size = new System.Drawing.Size(135, 24);
            this.txtAssNo2.TabIndex = 7;
            // 
            // labelAssNo2
            // 
            this.labelAssNo2.AutoSize = true;
            this.labelAssNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssNo2.Location = new System.Drawing.Point(72, 193);
            this.labelAssNo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAssNo2.Name = "labelAssNo2";
            this.labelAssNo2.Size = new System.Drawing.Size(150, 18);
            this.labelAssNo2.TabIndex = 6;
            this.labelAssNo2.Text = "Assignment Number?";
            // 
            // txtStudentsID
            // 
            this.txtStudentsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentsID.Location = new System.Drawing.Point(75, 129);
            this.txtStudentsID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStudentsID.Name = "txtStudentsID";
            this.txtStudentsID.Size = new System.Drawing.Size(135, 24);
            this.txtStudentsID.TabIndex = 5;
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(72, 82);
            this.StudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(84, 18);
            this.StudentID.TabIndex = 4;
            this.StudentID.Text = "Student ID?";
            // 
            // labelViewProgress
            // 
            this.labelViewProgress.AutoSize = true;
            this.labelViewProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewProgress.Location = new System.Drawing.Point(385, 27);
            this.labelViewProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelViewProgress.Name = "labelViewProgress";
            this.labelViewProgress.Size = new System.Drawing.Size(123, 20);
            this.labelViewProgress.TabIndex = 1;
            this.labelViewProgress.Text = "View Progress";
            // 
            // CommentsTab
            // 
            this.CommentsTab.Controls.Add(this.tabControl1);
            this.CommentsTab.Location = new System.Drawing.Point(4, 22);
            this.CommentsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CommentsTab.Name = "CommentsTab";
            this.CommentsTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CommentsTab.Size = new System.Drawing.Size(923, 430);
            this.CommentsTab.TabIndex = 3;
            this.CommentsTab.Text = "Comments";
            this.CommentsTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addCommentTab);
            this.tabControl1.Controls.Add(this.deleteCommentTab);
            this.tabControl1.Controls.Add(this.updateCommentTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // addCommentTab
            // 
            this.addCommentTab.Controls.Add(this.txtAssignmentID);
            this.addCommentTab.Controls.Add(this.AssignmentID);
            this.addCommentTab.Controls.Add(this.buttonAddComment);
            this.addCommentTab.Controls.Add(this.txtCommentDate);
            this.addCommentTab.Controls.Add(this.txtCommentDesc);
            this.addCommentTab.Controls.Add(this.labelCOmmentDate);
            this.addCommentTab.Controls.Add(this.labelCommentDesc);
            this.addCommentTab.Controls.Add(this.labelnewComment);
            this.addCommentTab.Location = new System.Drawing.Point(4, 22);
            this.addCommentTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCommentTab.Name = "addCommentTab";
            this.addCommentTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCommentTab.Size = new System.Drawing.Size(913, 405);
            this.addCommentTab.TabIndex = 0;
            this.addCommentTab.Text = "Add Comment";
            this.addCommentTab.UseVisualStyleBackColor = true;
            // 
            // txtAssignmentID
            // 
            this.txtAssignmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmentID.Location = new System.Drawing.Point(511, 230);
            this.txtAssignmentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAssignmentID.Name = "txtAssignmentID";
            this.txtAssignmentID.Size = new System.Drawing.Size(156, 24);
            this.txtAssignmentID.TabIndex = 13;
            this.txtAssignmentID.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // AssignmentID
            // 
            this.AssignmentID.AutoSize = true;
            this.AssignmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentID.Location = new System.Drawing.Point(507, 189);
            this.AssignmentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmentID.Name = "AssignmentID";
            this.AssignmentID.Size = new System.Drawing.Size(103, 18);
            this.AssignmentID.TabIndex = 12;
            this.AssignmentID.Text = "Assignment ID";
            this.AssignmentID.Click += new System.EventHandler(this.label1_Click_6);
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddComment.Location = new System.Drawing.Point(749, 334);
            this.buttonAddComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(99, 42);
            this.buttonAddComment.TabIndex = 11;
            this.buttonAddComment.Text = "Submit";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.addCommentButton_Clicked);
            // 
            // txtCommentDate
            // 
            this.txtCommentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDate.Location = new System.Drawing.Point(511, 125);
            this.txtCommentDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCommentDate.Name = "txtCommentDate";
            this.txtCommentDate.Size = new System.Drawing.Size(156, 24);
            this.txtCommentDate.TabIndex = 10;
            this.txtCommentDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtCommentDesc
            // 
            this.txtCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDesc.Location = new System.Drawing.Point(69, 125);
            this.txtCommentDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCommentDesc.Multiline = true;
            this.txtCommentDesc.Name = "txtCommentDesc";
            this.txtCommentDesc.Size = new System.Drawing.Size(347, 166);
            this.txtCommentDesc.TabIndex = 9;
            this.txtCommentDesc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelCOmmentDate
            // 
            this.labelCOmmentDate.AutoSize = true;
            this.labelCOmmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOmmentDate.Location = new System.Drawing.Point(507, 84);
            this.labelCOmmentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCOmmentDate.Name = "labelCOmmentDate";
            this.labelCOmmentDate.Size = new System.Drawing.Size(109, 18);
            this.labelCOmmentDate.TabIndex = 8;
            this.labelCOmmentDate.Text = "Comment Date";
            this.labelCOmmentDate.Click += new System.EventHandler(this.label1_Click_5);
            // 
            // labelCommentDesc
            // 
            this.labelCommentDesc.AutoSize = true;
            this.labelCommentDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDesc.Location = new System.Drawing.Point(66, 78);
            this.labelCommentDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommentDesc.Name = "labelCommentDesc";
            this.labelCommentDesc.Size = new System.Drawing.Size(153, 18);
            this.labelCommentDesc.TabIndex = 7;
            this.labelCommentDesc.Text = "Comment Description";
            this.labelCommentDesc.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // labelnewComment
            // 
            this.labelnewComment.AutoSize = true;
            this.labelnewComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnewComment.Location = new System.Drawing.Point(356, 27);
            this.labelnewComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnewComment.Name = "labelnewComment";
            this.labelnewComment.Size = new System.Drawing.Size(124, 20);
            this.labelnewComment.TabIndex = 6;
            this.labelnewComment.Text = "New Comment";
            this.labelnewComment.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // deleteCommentTab
            // 
            this.deleteCommentTab.Location = new System.Drawing.Point(4, 22);
            this.deleteCommentTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteCommentTab.Name = "deleteCommentTab";
            this.deleteCommentTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteCommentTab.Size = new System.Drawing.Size(913, 405);
            this.deleteCommentTab.TabIndex = 1;
            this.deleteCommentTab.Text = "Delete Comment";
            this.deleteCommentTab.UseVisualStyleBackColor = true;
            // 
            // updateCommentTab
            // 
            this.updateCommentTab.Location = new System.Drawing.Point(4, 22);
            this.updateCommentTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateCommentTab.Name = "updateCommentTab";
            this.updateCommentTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateCommentTab.Size = new System.Drawing.Size(913, 405);
            this.updateCommentTab.TabIndex = 2;
            this.updateCommentTab.Text = "Update Comment";
            this.updateCommentTab.UseVisualStyleBackColor = true;
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 467);
            this.Controls.Add(this.TeacherTabs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeacherPanel";
            this.Text = "TeacherPanel";
            this.Load += new System.EventHandler(this.TeacherPanel_Load);
            this.TeacherTabs.ResumeLayout(false);
            this.TeacherTab_1.ResumeLayout(false);
            this.TeacherTab_1.PerformLayout();
            this.TeacherTab_2.ResumeLayout(false);
            this.TeacherTab_2.PerformLayout();
            this.ViewProgressTab.ResumeLayout(false);
            this.ViewProgressTab.PerformLayout();
            this.CommentsTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.addCommentTab.ResumeLayout(false);
            this.addCommentTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TeacherTabs;
        private System.Windows.Forms.TabPage TeacherTab_1;
        private System.Windows.Forms.Button CreateAssignment;
        private System.Windows.Forms.Label AssignmetFile;
        private System.Windows.Forms.Label assPoints;
        private System.Windows.Forms.Label AssignmentDueDate;
        private System.Windows.Forms.Label AssignmentDescription;
        private System.Windows.Forms.TextBox txtAssignmetFile;
        private System.Windows.Forms.TextBox txtAssPoints;
        private System.Windows.Forms.TextBox txtAssDueDate;
        private System.Windows.Forms.TextBox txtAssDesc;
        private System.Windows.Forms.Label createNewAssingment;
        private System.Windows.Forms.TabPage TeacherTab_2;
        private System.Windows.Forms.Label labelAssignmentDueDate;
        private System.Windows.Forms.Label labelAssignmentNumber;
        private System.Windows.Forms.Label labelSetDeadlinesofAssignments;
        private System.Windows.Forms.TextBox txtAssDue;
        private System.Windows.Forms.TextBox txtAssNo;
        private System.Windows.Forms.Button buttonSetDeadline;
        private System.Windows.Forms.TabPage ViewProgressTab;
        private System.Windows.Forms.Button buttonViewProgress;
        private System.Windows.Forms.TextBox txtAssNo2;
        private System.Windows.Forms.Label labelAssNo2;
        private System.Windows.Forms.TextBox txtStudentsID;
        private System.Windows.Forms.Label StudentID;
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
    }
}