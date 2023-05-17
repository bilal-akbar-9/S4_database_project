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
            this.assignmentTab = new System.Windows.Forms.TabPage();
            this.assignmentSubTabs = new System.Windows.Forms.TabControl();
            this.createAssignmentTab = new System.Windows.Forms.TabPage();
            this.txtAssDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtAssDesc = new System.Windows.Forms.TextBox();
            this.CreateAssignment = new System.Windows.Forms.Button();
            this.AssignmentDescription = new System.Windows.Forms.Label();
            this.txtAssPoints = new System.Windows.Forms.TextBox();
            this.assPoints = new System.Windows.Forms.Label();
            this.AssignmetFile = new System.Windows.Forms.Label();
            this.AssignmentDueDate = new System.Windows.Forms.Label();
            this.txtAssignmetFile = new System.Windows.Forms.TextBox();
            this.createNewAssingment = new System.Windows.Forms.Label();
            this.deleteAssigmentTab = new System.Windows.Forms.TabPage();
            this.deleteAssigmentButton = new System.Windows.Forms.Button();
            this.assignmentsList = new System.Windows.Forms.DataGridView();
            this.modifyAssignmentTab = new System.Windows.Forms.TabPage();
            this.modifyDueDateBox = new System.Windows.Forms.DateTimePicker();
            this.modifyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modifyAssignmentFileBox = new System.Windows.Forms.TextBox();
            this.modifyAssignmentPointsBox = new System.Windows.Forms.TextBox();
            this.modifyDescBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.assignmentsListForModification = new System.Windows.Forms.DataGridView();
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
            this.TeacherTabs.SuspendLayout();
            this.assignmentTab.SuspendLayout();
            this.assignmentSubTabs.SuspendLayout();
            this.createAssignmentTab.SuspendLayout();
            this.deleteAssigmentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsList)).BeginInit();
            this.modifyAssignmentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsListForModification)).BeginInit();
            this.ViewProgressTab.SuspendLayout();
            this.CommentsTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.addCommentTab.SuspendLayout();
            this.deleteCommentTab.SuspendLayout();
            this.updateCommentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeacherTabs
            // 
            this.TeacherTabs.Controls.Add(this.assignmentTab);
            this.TeacherTabs.Controls.Add(this.ViewProgressTab);
            this.TeacherTabs.Controls.Add(this.CommentsTab);
            this.TeacherTabs.Location = new System.Drawing.Point(-1, 3);
            this.TeacherTabs.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherTabs.Name = "TeacherTabs";
            this.TeacherTabs.SelectedIndex = 0;
            this.TeacherTabs.Size = new System.Drawing.Size(931, 456);
            this.TeacherTabs.TabIndex = 1;
            // 
            // assignmentTab
            // 
            this.assignmentTab.BackColor = System.Drawing.SystemColors.HotTrack;
            this.assignmentTab.Controls.Add(this.assignmentSubTabs);
            this.assignmentTab.Location = new System.Drawing.Point(4, 22);
            this.assignmentTab.Margin = new System.Windows.Forms.Padding(2);
            this.assignmentTab.Name = "assignmentTab";
            this.assignmentTab.Padding = new System.Windows.Forms.Padding(2);
            this.assignmentTab.Size = new System.Drawing.Size(923, 430);
            this.assignmentTab.TabIndex = 0;
            this.assignmentTab.Text = "Assignment";
            // 
            // assignmentSubTabs
            // 
            this.assignmentSubTabs.Controls.Add(this.createAssignmentTab);
            this.assignmentSubTabs.Controls.Add(this.deleteAssigmentTab);
            this.assignmentSubTabs.Controls.Add(this.modifyAssignmentTab);
            this.assignmentSubTabs.Location = new System.Drawing.Point(-1, 0);
            this.assignmentSubTabs.Name = "assignmentSubTabs";
            this.assignmentSubTabs.SelectedIndex = 0;
            this.assignmentSubTabs.Size = new System.Drawing.Size(919, 434);
            this.assignmentSubTabs.TabIndex = 23;
            this.assignmentSubTabs.Click += new System.EventHandler(this.load_Assignments);
            // 
            // createAssignmentTab
            // 
            this.createAssignmentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createAssignmentTab.Controls.Add(this.txtAssDueDate);
            this.createAssignmentTab.Controls.Add(this.txtAssDesc);
            this.createAssignmentTab.Controls.Add(this.CreateAssignment);
            this.createAssignmentTab.Controls.Add(this.AssignmentDescription);
            this.createAssignmentTab.Controls.Add(this.txtAssPoints);
            this.createAssignmentTab.Controls.Add(this.assPoints);
            this.createAssignmentTab.Controls.Add(this.AssignmetFile);
            this.createAssignmentTab.Controls.Add(this.AssignmentDueDate);
            this.createAssignmentTab.Controls.Add(this.txtAssignmetFile);
            this.createAssignmentTab.Controls.Add(this.createNewAssingment);
            this.createAssignmentTab.Location = new System.Drawing.Point(4, 22);
            this.createAssignmentTab.Name = "createAssignmentTab";
            this.createAssignmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.createAssignmentTab.Size = new System.Drawing.Size(911, 408);
            this.createAssignmentTab.TabIndex = 0;
            this.createAssignmentTab.Text = "Create Assignment";
            // 
            // txtAssDueDate
            // 
            this.txtAssDueDate.Font = new System.Drawing.Font("HP Simplified Hans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssDueDate.Location = new System.Drawing.Point(634, 101);
            this.txtAssDueDate.Name = "txtAssDueDate";
            this.txtAssDueDate.Size = new System.Drawing.Size(229, 22);
            this.txtAssDueDate.TabIndex = 25;
            // 
            // txtAssDesc
            // 
            this.txtAssDesc.Location = new System.Drawing.Point(27, 101);
            this.txtAssDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssDesc.Multiline = true;
            this.txtAssDesc.Name = "txtAssDesc";
            this.txtAssDesc.Size = new System.Drawing.Size(332, 137);
            this.txtAssDesc.TabIndex = 14;
            // 
            // CreateAssignment
            // 
            this.CreateAssignment.BackColor = System.Drawing.Color.White;
            this.CreateAssignment.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.CreateAssignment.FlatAppearance.BorderSize = 3;
            this.CreateAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAssignment.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAssignment.Location = new System.Drawing.Point(754, 315);
            this.CreateAssignment.Margin = new System.Windows.Forms.Padding(2);
            this.CreateAssignment.Name = "CreateAssignment";
            this.CreateAssignment.Size = new System.Drawing.Size(107, 40);
            this.CreateAssignment.TabIndex = 22;
            this.CreateAssignment.Text = "Create";
            this.CreateAssignment.UseVisualStyleBackColor = false;
            this.CreateAssignment.Click += new System.EventHandler(this.CreateAssignment_Click);
            // 
            // AssignmentDescription
            // 
            this.AssignmentDescription.AutoSize = true;
            this.AssignmentDescription.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentDescription.Location = new System.Drawing.Point(26, 74);
            this.AssignmentDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmentDescription.Name = "AssignmentDescription";
            this.AssignmentDescription.Size = new System.Drawing.Size(171, 18);
            this.AssignmentDescription.TabIndex = 18;
            this.AssignmentDescription.Text = "Assignment Description";
            // 
            // txtAssPoints
            // 
            this.txtAssPoints.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssPoints.Location = new System.Drawing.Point(634, 212);
            this.txtAssPoints.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssPoints.Name = "txtAssPoints";
            this.txtAssPoints.Size = new System.Drawing.Size(145, 26);
            this.txtAssPoints.TabIndex = 16;
            // 
            // assPoints
            // 
            this.assPoints.AutoSize = true;
            this.assPoints.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assPoints.Location = new System.Drawing.Point(631, 180);
            this.assPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.assPoints.Name = "assPoints";
            this.assPoints.Size = new System.Drawing.Size(136, 18);
            this.assPoints.TabIndex = 20;
            this.assPoints.Text = "Assignment Points";
            // 
            // AssignmetFile
            // 
            this.AssignmetFile.AutoSize = true;
            this.AssignmetFile.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmetFile.Location = new System.Drawing.Point(26, 292);
            this.AssignmetFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmetFile.Name = "AssignmetFile";
            this.AssignmetFile.Size = new System.Drawing.Size(116, 18);
            this.AssignmetFile.TabIndex = 21;
            this.AssignmetFile.Text = "Assignment File";
            // 
            // AssignmentDueDate
            // 
            this.AssignmentDueDate.AutoSize = true;
            this.AssignmentDueDate.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentDueDate.Location = new System.Drawing.Point(631, 74);
            this.AssignmentDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmentDueDate.Name = "AssignmentDueDate";
            this.AssignmentDueDate.Size = new System.Drawing.Size(151, 18);
            this.AssignmentDueDate.TabIndex = 19;
            this.AssignmentDueDate.Text = "Assignment DueDate";
            // 
            // txtAssignmetFile
            // 
            this.txtAssignmetFile.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmetFile.Location = new System.Drawing.Point(29, 323);
            this.txtAssignmetFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssignmetFile.Name = "txtAssignmetFile";
            this.txtAssignmetFile.Size = new System.Drawing.Size(211, 26);
            this.txtAssignmetFile.TabIndex = 17;
            // 
            // createNewAssingment
            // 
            this.createNewAssingment.AutoSize = true;
            this.createNewAssingment.BackColor = System.Drawing.Color.Transparent;
            this.createNewAssingment.Font = new System.Drawing.Font("HP Simplified Hans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewAssingment.Location = new System.Drawing.Point(341, 15);
            this.createNewAssingment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createNewAssingment.Name = "createNewAssingment";
            this.createNewAssingment.Size = new System.Drawing.Size(256, 25);
            this.createNewAssingment.TabIndex = 13;
            this.createNewAssingment.Text = "Create New Assignment";
            // 
            // deleteAssigmentTab
            // 
            this.deleteAssigmentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteAssigmentTab.Controls.Add(this.deleteAssigmentButton);
            this.deleteAssigmentTab.Controls.Add(this.assignmentsList);
            this.deleteAssigmentTab.Location = new System.Drawing.Point(4, 22);
            this.deleteAssigmentTab.Name = "deleteAssigmentTab";
            this.deleteAssigmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.deleteAssigmentTab.Size = new System.Drawing.Size(911, 408);
            this.deleteAssigmentTab.TabIndex = 1;
            this.deleteAssigmentTab.Text = "Delete Assignment";
            // 
            // deleteAssigmentButton
            // 
            this.deleteAssigmentButton.BackColor = System.Drawing.Color.White;
            this.deleteAssigmentButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteAssigmentButton.FlatAppearance.BorderSize = 3;
            this.deleteAssigmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAssigmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAssigmentButton.Location = new System.Drawing.Point(807, 353);
            this.deleteAssigmentButton.Name = "deleteAssigmentButton";
            this.deleteAssigmentButton.Size = new System.Drawing.Size(88, 42);
            this.deleteAssigmentButton.TabIndex = 1;
            this.deleteAssigmentButton.Text = "Delete";
            this.deleteAssigmentButton.UseVisualStyleBackColor = false;
            this.deleteAssigmentButton.Click += new System.EventHandler(this.deleteAssignmentButton_Clicked);
            // 
            // assignmentsList
            // 
            this.assignmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentsList.Location = new System.Drawing.Point(0, 2);
            this.assignmentsList.Name = "assignmentsList";
            this.assignmentsList.RowHeadersWidth = 51;
            this.assignmentsList.Size = new System.Drawing.Size(904, 342);
            this.assignmentsList.TabIndex = 0;
            // 
            // modifyAssignmentTab
            // 
            this.modifyAssignmentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modifyAssignmentTab.Controls.Add(this.modifyDueDateBox);
            this.modifyAssignmentTab.Controls.Add(this.modifyButton);
            this.modifyAssignmentTab.Controls.Add(this.label4);
            this.modifyAssignmentTab.Controls.Add(this.label1);
            this.modifyAssignmentTab.Controls.Add(this.label3);
            this.modifyAssignmentTab.Controls.Add(this.label2);
            this.modifyAssignmentTab.Controls.Add(this.modifyAssignmentFileBox);
            this.modifyAssignmentTab.Controls.Add(this.modifyAssignmentPointsBox);
            this.modifyAssignmentTab.Controls.Add(this.modifyDescBox);
            this.modifyAssignmentTab.Controls.Add(this.selectButton);
            this.modifyAssignmentTab.Controls.Add(this.assignmentsListForModification);
            this.modifyAssignmentTab.Location = new System.Drawing.Point(4, 22);
            this.modifyAssignmentTab.Name = "modifyAssignmentTab";
            this.modifyAssignmentTab.Size = new System.Drawing.Size(911, 408);
            this.modifyAssignmentTab.TabIndex = 2;
            this.modifyAssignmentTab.Text = "ModifyAssigment";
            // 
            // modifyDueDateBox
            // 
            this.modifyDueDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyDueDateBox.Location = new System.Drawing.Point(551, 68);
            this.modifyDueDateBox.Name = "modifyDueDateBox";
            this.modifyDueDateBox.Size = new System.Drawing.Size(238, 23);
            this.modifyDueDateBox.TabIndex = 26;
            this.modifyDueDateBox.Value = new System.DateTime(2023, 5, 17, 12, 55, 26, 0);
            this.modifyDueDateBox.Visible = false;
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.White;
            this.modifyButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.modifyButton.FlatAppearance.BorderSize = 3;
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.Location = new System.Drawing.Point(807, 353);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(88, 42);
            this.modifyButton.TabIndex = 25;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Visible = false;
            this.modifyButton.Click += new System.EventHandler(this.assignmentModifyButton_Clicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Assignment Points";
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Assignment DueDate";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Assignment File";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Assignment Description";
            this.label2.Visible = false;
            // 
            // modifyAssignmentFileBox
            // 
            this.modifyAssignmentFileBox.Location = new System.Drawing.Point(26, 278);
            this.modifyAssignmentFileBox.Name = "modifyAssignmentFileBox";
            this.modifyAssignmentFileBox.Size = new System.Drawing.Size(199, 20);
            this.modifyAssignmentFileBox.TabIndex = 5;
            this.modifyAssignmentFileBox.Visible = false;
            // 
            // modifyAssignmentPointsBox
            // 
            this.modifyAssignmentPointsBox.Location = new System.Drawing.Point(551, 185);
            this.modifyAssignmentPointsBox.Name = "modifyAssignmentPointsBox";
            this.modifyAssignmentPointsBox.Size = new System.Drawing.Size(199, 20);
            this.modifyAssignmentPointsBox.TabIndex = 4;
            this.modifyAssignmentPointsBox.Visible = false;
            // 
            // modifyDescBox
            // 
            this.modifyDescBox.Location = new System.Drawing.Point(26, 68);
            this.modifyDescBox.Multiline = true;
            this.modifyDescBox.Name = "modifyDescBox";
            this.modifyDescBox.Size = new System.Drawing.Size(322, 137);
            this.modifyDescBox.TabIndex = 2;
            this.modifyDescBox.Visible = false;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.White;
            this.selectButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.selectButton.FlatAppearance.BorderSize = 3;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Location = new System.Drawing.Point(807, 353);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(88, 42);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.assignmentSelectButton_Clicked);
            // 
            // assignmentsListForModification
            // 
            this.assignmentsListForModification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentsListForModification.Location = new System.Drawing.Point(1, 0);
            this.assignmentsListForModification.MultiSelect = false;
            this.assignmentsListForModification.Name = "assignmentsListForModification";
            this.assignmentsListForModification.RowHeadersWidth = 51;
            this.assignmentsListForModification.Size = new System.Drawing.Size(923, 342);
            this.assignmentsListForModification.TabIndex = 0;
            // 
            // ViewProgressTab
            // 
            this.ViewProgressTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewProgressTab.Controls.Add(this.buttonViewProgress);
            this.ViewProgressTab.Controls.Add(this.txtAssNo2);
            this.ViewProgressTab.Controls.Add(this.labelAssNo2);
            this.ViewProgressTab.Controls.Add(this.txtStudentsID);
            this.ViewProgressTab.Controls.Add(this.StudentID);
            this.ViewProgressTab.Controls.Add(this.labelViewProgress);
            this.ViewProgressTab.Location = new System.Drawing.Point(4, 22);
            this.ViewProgressTab.Margin = new System.Windows.Forms.Padding(2);
            this.ViewProgressTab.Name = "ViewProgressTab";
            this.ViewProgressTab.Padding = new System.Windows.Forms.Padding(2);
            this.ViewProgressTab.Size = new System.Drawing.Size(923, 430);
            this.ViewProgressTab.TabIndex = 2;
            this.ViewProgressTab.Text = "View Progress";
            // 
            // buttonViewProgress
            // 
            this.buttonViewProgress.BackColor = System.Drawing.Color.White;
            this.buttonViewProgress.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.buttonViewProgress.FlatAppearance.BorderSize = 3;
            this.buttonViewProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewProgress.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProgress.Location = new System.Drawing.Point(479, 234);
            this.buttonViewProgress.Margin = new System.Windows.Forms.Padding(2);
            this.buttonViewProgress.Name = "buttonViewProgress";
            this.buttonViewProgress.Size = new System.Drawing.Size(213, 37);
            this.buttonViewProgress.TabIndex = 8;
            this.buttonViewProgress.Text = "Check";
            this.buttonViewProgress.UseVisualStyleBackColor = false;
            this.buttonViewProgress.Click += new System.EventHandler(this.viewProgressButton_Clicked);
            // 
            // txtAssNo2
            // 
            this.txtAssNo2.Font = new System.Drawing.Font("HP Simplified Hans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssNo2.Location = new System.Drawing.Point(479, 173);
            this.txtAssNo2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssNo2.Name = "txtAssNo2";
            this.txtAssNo2.Size = new System.Drawing.Size(214, 29);
            this.txtAssNo2.TabIndex = 7;
            // 
            // labelAssNo2
            // 
            this.labelAssNo2.AutoSize = true;
            this.labelAssNo2.Font = new System.Drawing.Font("HP Simplified Hans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssNo2.Location = new System.Drawing.Point(269, 176);
            this.labelAssNo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAssNo2.Name = "labelAssNo2";
            this.labelAssNo2.Size = new System.Drawing.Size(175, 22);
            this.labelAssNo2.TabIndex = 6;
            this.labelAssNo2.Text = "Assignment Number";
            // 
            // txtStudentsID
            // 
            this.txtStudentsID.Font = new System.Drawing.Font("HP Simplified Hans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentsID.Location = new System.Drawing.Point(479, 115);
            this.txtStudentsID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentsID.Name = "txtStudentsID";
            this.txtStudentsID.Size = new System.Drawing.Size(214, 29);
            this.txtStudentsID.TabIndex = 5;
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Font = new System.Drawing.Font("HP Simplified Hans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(269, 115);
            this.StudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(95, 22);
            this.StudentID.TabIndex = 4;
            this.StudentID.Text = "Student ID";
            this.StudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelViewProgress
            // 
            this.labelViewProgress.AutoSize = true;
            this.labelViewProgress.Font = new System.Drawing.Font("HP Simplified Hans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewProgress.Location = new System.Drawing.Point(390, 34);
            this.labelViewProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelViewProgress.Name = "labelViewProgress";
            this.labelViewProgress.Size = new System.Drawing.Size(159, 25);
            this.labelViewProgress.TabIndex = 1;
            this.labelViewProgress.Text = "View Progress";
            // 
            // CommentsTab
            // 
            this.CommentsTab.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CommentsTab.Controls.Add(this.tabControl1);
            this.CommentsTab.Location = new System.Drawing.Point(4, 22);
            this.CommentsTab.Margin = new System.Windows.Forms.Padding(2);
            this.CommentsTab.Name = "CommentsTab";
            this.CommentsTab.Padding = new System.Windows.Forms.Padding(2);
            this.CommentsTab.Size = new System.Drawing.Size(923, 430);
            this.CommentsTab.TabIndex = 3;
            this.CommentsTab.Text = "Comments";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addCommentTab);
            this.tabControl1.Controls.Add(this.deleteCommentTab);
            this.tabControl1.Controls.Add(this.updateCommentTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 431);
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
            this.txtAssignmentID.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmentID.Location = new System.Drawing.Point(598, 211);
            this.txtAssignmentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssignmentID.Name = "txtAssignmentID";
            this.txtAssignmentID.Size = new System.Drawing.Size(156, 24);
            this.txtAssignmentID.TabIndex = 13;
            // 
            // AssignmentID
            // 
            this.AssignmentID.AutoSize = true;
            this.AssignmentID.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentID.Location = new System.Drawing.Point(595, 176);
            this.AssignmentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssignmentID.Name = "AssignmentID";
            this.AssignmentID.Size = new System.Drawing.Size(101, 17);
            this.AssignmentID.TabIndex = 12;
            this.AssignmentID.Text = "Assignment ID";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.BackColor = System.Drawing.Color.White;
            this.buttonAddComment.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonAddComment.FlatAppearance.BorderSize = 3;
            this.buttonAddComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddComment.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtCommentDate.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDate.Location = new System.Drawing.Point(598, 128);
            this.txtCommentDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentDate.Name = "txtCommentDate";
            this.txtCommentDate.Size = new System.Drawing.Size(156, 24);
            this.txtCommentDate.TabIndex = 10;
            // 
            // txtCommentDesc
            // 
            this.txtCommentDesc.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelCOmmentDate.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOmmentDate.Location = new System.Drawing.Point(595, 86);
            this.labelCOmmentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCOmmentDate.Name = "labelCOmmentDate";
            this.labelCOmmentDate.Size = new System.Drawing.Size(104, 17);
            this.labelCOmmentDate.TabIndex = 8;
            this.labelCOmmentDate.Text = "Comment Date";
            // 
            // labelCommentDesc
            // 
            this.labelCommentDesc.AutoSize = true;
            this.labelCommentDesc.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDesc.Location = new System.Drawing.Point(154, 86);
            this.labelCommentDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommentDesc.Name = "labelCommentDesc";
            this.labelCommentDesc.Size = new System.Drawing.Size(147, 17);
            this.labelCommentDesc.TabIndex = 7;
            this.labelCommentDesc.Text = "Comment Description";
            // 
            // labelnewComment
            // 
            this.labelnewComment.AutoSize = true;
            this.labelnewComment.Font = new System.Drawing.Font("HP Simplified Hans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnewComment.Location = new System.Drawing.Point(374, 23);
            this.labelnewComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnewComment.Name = "labelnewComment";
            this.labelnewComment.Size = new System.Drawing.Size(160, 25);
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
            this.deleteCommentTab.Location = new System.Drawing.Point(4, 22);
            this.deleteCommentTab.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCommentTab.Name = "deleteCommentTab";
            this.deleteCommentTab.Padding = new System.Windows.Forms.Padding(2);
            this.deleteCommentTab.Size = new System.Drawing.Size(913, 405);
            this.deleteCommentTab.TabIndex = 1;
            this.deleteCommentTab.Text = "Delete Comment";
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.White;
            this.Deletebutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Deletebutton.FlatAppearance.BorderSize = 3;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(436, 188);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(180, 31);
            this.Deletebutton.TabIndex = 16;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.DeleteCommentButton);
            // 
            // txtCommentID
            // 
            this.txtCommentID.Font = new System.Drawing.Font("HP Simplified Hans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentID.Location = new System.Drawing.Point(436, 120);
            this.txtCommentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentID.Name = "txtCommentID";
            this.txtCommentID.Size = new System.Drawing.Size(181, 29);
            this.txtCommentID.TabIndex = 15;
            // 
            // labelCommentID
            // 
            this.labelCommentID.AutoSize = true;
            this.labelCommentID.Font = new System.Drawing.Font("HP Simplified Hans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentID.Location = new System.Drawing.Point(284, 119);
            this.labelCommentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommentID.Name = "labelCommentID";
            this.labelCommentID.Size = new System.Drawing.Size(110, 22);
            this.labelCommentID.TabIndex = 14;
            this.labelCommentID.Text = "Comment ID";
            // 
            // labelDeleteComment
            // 
            this.labelDeleteComment.AutoSize = true;
            this.labelDeleteComment.Font = new System.Drawing.Font("HP Simplified Hans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteComment.Location = new System.Drawing.Point(361, 24);
            this.labelDeleteComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeleteComment.Name = "labelDeleteComment";
            this.labelDeleteComment.Size = new System.Drawing.Size(183, 25);
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
            this.updateCommentTab.Location = new System.Drawing.Point(4, 22);
            this.updateCommentTab.Margin = new System.Windows.Forms.Padding(2);
            this.updateCommentTab.Name = "updateCommentTab";
            this.updateCommentTab.Padding = new System.Windows.Forms.Padding(2);
            this.updateCommentTab.Size = new System.Drawing.Size(913, 405);
            this.updateCommentTab.TabIndex = 2;
            this.updateCommentTab.Text = "Update Comment";
            // 
            // txtCOmmentIDUpdate
            // 
            this.txtCOmmentIDUpdate.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOmmentIDUpdate.Location = new System.Drawing.Point(712, 123);
            this.txtCOmmentIDUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCOmmentIDUpdate.Name = "txtCOmmentIDUpdate";
            this.txtCOmmentIDUpdate.Size = new System.Drawing.Size(156, 24);
            this.txtCOmmentIDUpdate.TabIndex = 23;
            // 
            // labelcommentIDUpdate
            // 
            this.labelcommentIDUpdate.AutoSize = true;
            this.labelcommentIDUpdate.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcommentIDUpdate.Location = new System.Drawing.Point(709, 81);
            this.labelcommentIDUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcommentIDUpdate.Name = "labelcommentIDUpdate";
            this.labelcommentIDUpdate.Size = new System.Drawing.Size(87, 17);
            this.labelcommentIDUpdate.TabIndex = 22;
            this.labelcommentIDUpdate.Text = "Comment ID";
            // 
            // txtAssIDUpdate
            // 
            this.txtAssIDUpdate.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssIDUpdate.Location = new System.Drawing.Point(489, 215);
            this.txtAssIDUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssIDUpdate.Name = "txtAssIDUpdate";
            this.txtAssIDUpdate.Size = new System.Drawing.Size(156, 24);
            this.txtAssIDUpdate.TabIndex = 21;
            // 
            // labelAssIDUpdate
            // 
            this.labelAssIDUpdate.AutoSize = true;
            this.labelAssIDUpdate.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssIDUpdate.Location = new System.Drawing.Point(488, 176);
            this.labelAssIDUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAssIDUpdate.Name = "labelAssIDUpdate";
            this.labelAssIDUpdate.Size = new System.Drawing.Size(101, 17);
            this.labelAssIDUpdate.TabIndex = 20;
            this.labelAssIDUpdate.Text = "Assignment ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(712, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.UpdateCOmmentButton);
            // 
            // txtCommentDateUpdate
            // 
            this.txtCommentDateUpdate.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDateUpdate.Location = new System.Drawing.Point(489, 123);
            this.txtCommentDateUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentDateUpdate.Name = "txtCommentDateUpdate";
            this.txtCommentDateUpdate.Size = new System.Drawing.Size(156, 24);
            this.txtCommentDateUpdate.TabIndex = 18;
            // 
            // txtCommentDescUPDAtE
            // 
            this.txtCommentDescUPDAtE.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentDescUPDAtE.Location = new System.Drawing.Point(71, 128);
            this.txtCommentDescUPDAtE.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentDescUPDAtE.Multiline = true;
            this.txtCommentDescUPDAtE.Name = "txtCommentDescUPDAtE";
            this.txtCommentDescUPDAtE.Size = new System.Drawing.Size(347, 166);
            this.txtCommentDescUPDAtE.TabIndex = 17;
            // 
            // labelCommetnDate
            // 
            this.labelCommetnDate.AutoSize = true;
            this.labelCommetnDate.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommetnDate.Location = new System.Drawing.Point(484, 81);
            this.labelCommetnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommetnDate.Name = "labelCommetnDate";
            this.labelCommetnDate.Size = new System.Drawing.Size(104, 17);
            this.labelCommetnDate.TabIndex = 16;
            this.labelCommetnDate.Text = "Comment Date";
            // 
            // labelCommentDescUpdate
            // 
            this.labelCommentDescUpdate.AutoSize = true;
            this.labelCommentDescUpdate.Font = new System.Drawing.Font("HP Simplified Hans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentDescUpdate.Location = new System.Drawing.Point(67, 81);
            this.labelCommentDescUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommentDescUpdate.Name = "labelCommentDescUpdate";
            this.labelCommentDescUpdate.Size = new System.Drawing.Size(147, 17);
            this.labelCommentDescUpdate.TabIndex = 15;
            this.labelCommentDescUpdate.Text = "Comment Description";
            // 
            // txtUpdateComment
            // 
            this.txtUpdateComment.AutoSize = true;
            this.txtUpdateComment.Font = new System.Drawing.Font("HP Simplified Hans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateComment.Location = new System.Drawing.Point(356, 28);
            this.txtUpdateComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUpdateComment.Name = "txtUpdateComment";
            this.txtUpdateComment.Size = new System.Drawing.Size(190, 25);
            this.txtUpdateComment.TabIndex = 14;
            this.txtUpdateComment.Text = "Update Comment";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("HP Simplified Hans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.TeacherTabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeacherPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherPanel";
            this.TeacherTabs.ResumeLayout(false);
            this.assignmentTab.ResumeLayout(false);
            this.assignmentSubTabs.ResumeLayout(false);
            this.createAssignmentTab.ResumeLayout(false);
            this.createAssignmentTab.PerformLayout();
            this.deleteAssigmentTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsList)).EndInit();
            this.modifyAssignmentTab.ResumeLayout(false);
            this.modifyAssignmentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsListForModification)).EndInit();
            this.ViewProgressTab.ResumeLayout(false);
            this.ViewProgressTab.PerformLayout();
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
        private System.Windows.Forms.TabPage assignmentTab;
        private System.Windows.Forms.Button CreateAssignment;
        private System.Windows.Forms.Label AssignmetFile;
        private System.Windows.Forms.Label assPoints;
        private System.Windows.Forms.Label AssignmentDueDate;
        private System.Windows.Forms.Label AssignmentDescription;
        private System.Windows.Forms.TextBox txtAssignmetFile;
        private System.Windows.Forms.TextBox txtAssPoints;
        private System.Windows.Forms.TextBox txtAssDesc;
        private System.Windows.Forms.Label createNewAssingment;
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
        private System.Windows.Forms.TabControl assignmentSubTabs;
        private System.Windows.Forms.TabPage createAssignmentTab;
        private System.Windows.Forms.TabPage deleteAssigmentTab;
        private System.Windows.Forms.TabPage modifyAssignmentTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView assignmentsList;
        private System.Windows.Forms.Button deleteAssigmentButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.DataGridView assignmentsListForModification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modifyAssignmentFileBox;
        private System.Windows.Forms.TextBox modifyAssignmentPointsBox;
        private System.Windows.Forms.TextBox modifyDescBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.DateTimePicker txtAssDueDate;
        private System.Windows.Forms.DateTimePicker modifyDueDateBox;
        private System.Windows.Forms.Button backButton;
    }
}