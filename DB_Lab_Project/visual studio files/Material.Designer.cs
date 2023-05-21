using System.Windows.Forms;

namespace intial_form_1_
{
    partial class Material
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
            this.updateMaterialTab = new System.Windows.Forms.TabPage();
            this.noMaterialForUpdation_Label = new System.Windows.Forms.Label();
            this.modifyTitleBox = new System.Windows.Forms.TextBox();
            this.materialTitleLabel2 = new System.Windows.Forms.Label();
            this.selectMaterialButton = new System.Windows.Forms.Button();
            this.modifyDescBox = new System.Windows.Forms.TextBox();
            this.updateMaterialButton = new System.Windows.Forms.Button();
            this.materialTypeLabel2 = new System.Windows.Forms.Label();
            this.materialDescriptionLabel2 = new System.Windows.Forms.Label();
            this.modifyTypeBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.updateMaterial = new System.Windows.Forms.Label();
            this.materialListForModification = new System.Windows.Forms.DataGridView();
            this.removeMaterialTab = new System.Windows.Forms.TabPage();
            this.noMaterialForDeletionLabel = new System.Windows.Forms.Label();
            this.deleteMaterialButton = new System.Windows.Forms.Button();
            this.materialListToRemove = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.removeMaterialLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newMaterialLabel = new System.Windows.Forms.Label();
            this.viewMaterialTab = new System.Windows.Forms.TabPage();
            this.backButton = new System.Windows.Forms.Button();
            this.flowLayoutMaterial = new System.Windows.Forms.FlowLayoutPanel();
            this.noMaterialLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            this.classroomName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTabs = new System.Windows.Forms.TabControl();
            this.addMaterialTab = new System.Windows.Forms.TabPage();
            this.materialTitleBox = new System.Windows.Forms.TextBox();
            this.materialTitleLabel = new System.Windows.Forms.Label();
            this.materialDescBox = new System.Windows.Forms.TextBox();
            this.CreateAssignment = new System.Windows.Forms.Button();
            this.AssignmentDescriptionLabel = new System.Windows.Forms.Label();
            this.materialTypeBox = new System.Windows.Forms.TextBox();
            this.materialTypeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateMaterialTab.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialListForModification)).BeginInit();
            this.removeMaterialTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialListToRemove)).BeginInit();
            this.panel3.SuspendLayout();
            this.viewMaterialTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.materialTabs.SuspendLayout();
            this.addMaterialTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateMaterialTab
            // 
            this.updateMaterialTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateMaterialTab.Controls.Add(this.noMaterialForUpdation_Label);
            this.updateMaterialTab.Controls.Add(this.modifyTitleBox);
            this.updateMaterialTab.Controls.Add(this.materialTitleLabel2);
            this.updateMaterialTab.Controls.Add(this.selectMaterialButton);
            this.updateMaterialTab.Controls.Add(this.modifyDescBox);
            this.updateMaterialTab.Controls.Add(this.updateMaterialButton);
            this.updateMaterialTab.Controls.Add(this.materialTypeLabel2);
            this.updateMaterialTab.Controls.Add(this.materialDescriptionLabel2);
            this.updateMaterialTab.Controls.Add(this.modifyTypeBox);
            this.updateMaterialTab.Controls.Add(this.label10);
            this.updateMaterialTab.Controls.Add(this.panel4);
            this.updateMaterialTab.Controls.Add(this.materialListForModification);
            this.updateMaterialTab.Location = new System.Drawing.Point(4, 22);
            this.updateMaterialTab.Name = "updateMaterialTab";
            this.updateMaterialTab.Size = new System.Drawing.Size(1066, 508);
            this.updateMaterialTab.TabIndex = 3;
            this.updateMaterialTab.Text = "Update Material";
            this.updateMaterialTab.Click += new System.EventHandler(this.loadMaterialToUpdateDelete);
            // 
            // noMaterialForUpdation_Label
            // 
            this.noMaterialForUpdation_Label.AutoSize = true;
            this.noMaterialForUpdation_Label.Location = new System.Drawing.Point(495, 233);
            this.noMaterialForUpdation_Label.Name = "noMaterialForUpdation_Label";
            this.noMaterialForUpdation_Label.Size = new System.Drawing.Size(90, 13);
            this.noMaterialForUpdation_Label.TabIndex = 42;
            this.noMaterialForUpdation_Label.Text = "No material found";
            // 
            // modifyTitleBox
            // 
            this.modifyTitleBox.Location = new System.Drawing.Point(115, 149);
            this.modifyTitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.modifyTitleBox.Multiline = true;
            this.modifyTitleBox.Name = "modifyTitleBox";
            this.modifyTitleBox.Size = new System.Drawing.Size(216, 18);
            this.modifyTitleBox.TabIndex = 40;
            this.modifyTitleBox.Visible = false;
            // 
            // materialTitleLabel2
            // 
            this.materialTitleLabel2.AutoSize = true;
            this.materialTitleLabel2.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTitleLabel2.Location = new System.Drawing.Point(111, 113);
            this.materialTitleLabel2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialTitleLabel2.Name = "materialTitleLabel2";
            this.materialTitleLabel2.Size = new System.Drawing.Size(38, 20);
            this.materialTitleLabel2.TabIndex = 41;
            this.materialTitleLabel2.Text = "Title";
            this.materialTitleLabel2.Visible = false;
            // 
            // selectMaterialButton
            // 
            this.selectMaterialButton.BackColor = System.Drawing.Color.White;
            this.selectMaterialButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.selectMaterialButton.FlatAppearance.BorderSize = 3;
            this.selectMaterialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectMaterialButton.Location = new System.Drawing.Point(895, 452);
            this.selectMaterialButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectMaterialButton.Name = "selectMaterialButton";
            this.selectMaterialButton.Size = new System.Drawing.Size(88, 42);
            this.selectMaterialButton.TabIndex = 39;
            this.selectMaterialButton.Text = "Select";
            this.selectMaterialButton.UseVisualStyleBackColor = false;
            this.selectMaterialButton.Click += new System.EventHandler(this.selectMaterialForModifcionBtn_Click);
            // 
            // modifyDescBox
            // 
            this.modifyDescBox.Location = new System.Drawing.Point(115, 233);
            this.modifyDescBox.Margin = new System.Windows.Forms.Padding(2);
            this.modifyDescBox.Multiline = true;
            this.modifyDescBox.Name = "modifyDescBox";
            this.modifyDescBox.Size = new System.Drawing.Size(298, 115);
            this.modifyDescBox.TabIndex = 27;
            this.modifyDescBox.Visible = false;
            // 
            // updateMaterialButton
            // 
            this.updateMaterialButton.BackColor = System.Drawing.Color.White;
            this.updateMaterialButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.updateMaterialButton.FlatAppearance.BorderSize = 3;
            this.updateMaterialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateMaterialButton.Font = new System.Drawing.Font("HP Simplified Hans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMaterialButton.Location = new System.Drawing.Point(895, 452);
            this.updateMaterialButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateMaterialButton.Name = "updateMaterialButton";
            this.updateMaterialButton.Size = new System.Drawing.Size(88, 42);
            this.updateMaterialButton.TabIndex = 34;
            this.updateMaterialButton.Text = "Update";
            this.updateMaterialButton.UseVisualStyleBackColor = false;
            this.updateMaterialButton.Visible = false;
            this.updateMaterialButton.Click += new System.EventHandler(this.materialUpdateButton_Click);
            // 
            // materialTypeLabel2
            // 
            this.materialTypeLabel2.AutoSize = true;
            this.materialTypeLabel2.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTypeLabel2.Location = new System.Drawing.Point(719, 149);
            this.materialTypeLabel2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialTypeLabel2.Name = "materialTypeLabel2";
            this.materialTypeLabel2.Size = new System.Drawing.Size(103, 20);
            this.materialTypeLabel2.TabIndex = 33;
            this.materialTypeLabel2.Text = "Material Type";
            this.materialTypeLabel2.Visible = false;
            // 
            // materialDescriptionLabel2
            // 
            this.materialDescriptionLabel2.AutoSize = true;
            this.materialDescriptionLabel2.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialDescriptionLabel2.Location = new System.Drawing.Point(111, 198);
            this.materialDescriptionLabel2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialDescriptionLabel2.Name = "materialDescriptionLabel2";
            this.materialDescriptionLabel2.Size = new System.Drawing.Size(89, 20);
            this.materialDescriptionLabel2.TabIndex = 30;
            this.materialDescriptionLabel2.Text = "Description";
            this.materialDescriptionLabel2.Visible = false;
            // 
            // modifyTypeBox
            // 
            this.modifyTypeBox.Location = new System.Drawing.Point(723, 171);
            this.modifyTypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.modifyTypeBox.Name = "modifyTypeBox";
            this.modifyTypeBox.Size = new System.Drawing.Size(199, 20);
            this.modifyTypeBox.TabIndex = 28;
            this.modifyTypeBox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.updateMaterial);
            this.panel4.Location = new System.Drawing.Point(-2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1089, 83);
            this.panel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(893, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "label1";
            this.label6.Visible = false;
            // 
            // updateMaterial
            // 
            this.updateMaterial.AutoSize = true;
            this.updateMaterial.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMaterial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateMaterial.Location = new System.Drawing.Point(18, 24);
            this.updateMaterial.Name = "updateMaterial";
            this.updateMaterial.Size = new System.Drawing.Size(205, 31);
            this.updateMaterial.TabIndex = 0;
            this.updateMaterial.Text = "Update Material";
            // 
            // materialListForModification
            // 
            this.materialListForModification.AllowUserToAddRows = false;
            this.materialListForModification.AllowUserToDeleteRows = false;
            this.materialListForModification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialListForModification.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.materialListForModification.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HP Simplified Hans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialListForModification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.materialListForModification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HP Simplified Hans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialListForModification.DefaultCellStyle = dataGridViewCellStyle2;
            this.materialListForModification.EnableHeadersVisualStyles = false;
            this.materialListForModification.Location = new System.Drawing.Point(73, 88);
            this.materialListForModification.Margin = new System.Windows.Forms.Padding(2);
            this.materialListForModification.MultiSelect = false;
            this.materialListForModification.Name = "materialListForModification";
            this.materialListForModification.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("HP Simplified Hans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialListForModification.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.materialListForModification.RowHeadersWidth = 51;
            this.materialListForModification.Size = new System.Drawing.Size(898, 349);
            this.materialListForModification.TabIndex = 38;
            // 
            // removeMaterialTab
            // 
            this.removeMaterialTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.removeMaterialTab.Controls.Add(this.noMaterialForDeletionLabel);
            this.removeMaterialTab.Controls.Add(this.deleteMaterialButton);
            this.removeMaterialTab.Controls.Add(this.materialListToRemove);
            this.removeMaterialTab.Controls.Add(this.label9);
            this.removeMaterialTab.Controls.Add(this.panel3);
            this.removeMaterialTab.Location = new System.Drawing.Point(4, 22);
            this.removeMaterialTab.Name = "removeMaterialTab";
            this.removeMaterialTab.Size = new System.Drawing.Size(1066, 508);
            this.removeMaterialTab.TabIndex = 2;
            this.removeMaterialTab.Text = "Remove Material";
            // 
            // noMaterialForDeletionLabel
            // 
            this.noMaterialForDeletionLabel.AutoSize = true;
            this.noMaterialForDeletionLabel.Location = new System.Drawing.Point(481, 253);
            this.noMaterialForDeletionLabel.Name = "noMaterialForDeletionLabel";
            this.noMaterialForDeletionLabel.Size = new System.Drawing.Size(93, 13);
            this.noMaterialForDeletionLabel.TabIndex = 9;
            this.noMaterialForDeletionLabel.Text = "No material found.";
            // 
            // deleteMaterialButton
            // 
            this.deleteMaterialButton.BackColor = System.Drawing.Color.White;
            this.deleteMaterialButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteMaterialButton.FlatAppearance.BorderSize = 3;
            this.deleteMaterialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMaterialButton.Font = new System.Drawing.Font("HP Simplified Hans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMaterialButton.Location = new System.Drawing.Point(888, 452);
            this.deleteMaterialButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteMaterialButton.Name = "deleteMaterialButton";
            this.deleteMaterialButton.Size = new System.Drawing.Size(88, 42);
            this.deleteMaterialButton.TabIndex = 8;
            this.deleteMaterialButton.Text = "Delete";
            this.deleteMaterialButton.UseVisualStyleBackColor = false;
            this.deleteMaterialButton.Visible = false;
            this.deleteMaterialButton.Click += new System.EventHandler(this.deleteMaterialButton_Click);
            // 
            // materialListToRemove
            // 
            this.materialListToRemove.AllowUserToAddRows = false;
            this.materialListToRemove.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.materialListToRemove.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.materialListToRemove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialListToRemove.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.materialListToRemove.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("HP Simplified Hans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialListToRemove.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.materialListToRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("HP Simplified Hans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialListToRemove.DefaultCellStyle = dataGridViewCellStyle6;
            this.materialListToRemove.EnableHeadersVisualStyles = false;
            this.materialListToRemove.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.materialListToRemove.Location = new System.Drawing.Point(72, 91);
            this.materialListToRemove.Name = "materialListToRemove";
            this.materialListToRemove.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("HP Simplified Hans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialListToRemove.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.materialListToRemove.RowHeadersWidth = 51;
            this.materialListToRemove.RowTemplate.Height = 40;
            this.materialListToRemove.RowTemplate.ReadOnly = true;
            this.materialListToRemove.Size = new System.Drawing.Size(904, 342);
            this.materialListToRemove.TabIndex = 7;
            this.materialListToRemove.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.removeMaterialLabel);
            this.panel3.Location = new System.Drawing.Point(-3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 83);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(893, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "label1";
            this.label4.Visible = false;
            // 
            // removeMaterialLabel
            // 
            this.removeMaterialLabel.AutoSize = true;
            this.removeMaterialLabel.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMaterialLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeMaterialLabel.Location = new System.Drawing.Point(18, 24);
            this.removeMaterialLabel.Name = "removeMaterialLabel";
            this.removeMaterialLabel.Size = new System.Drawing.Size(218, 31);
            this.removeMaterialLabel.TabIndex = 0;
            this.removeMaterialLabel.Text = "Remove Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(893, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // newMaterialLabel
            // 
            this.newMaterialLabel.AutoSize = true;
            this.newMaterialLabel.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMaterialLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newMaterialLabel.Location = new System.Drawing.Point(18, 24);
            this.newMaterialLabel.Name = "newMaterialLabel";
            this.newMaterialLabel.Size = new System.Drawing.Size(172, 31);
            this.newMaterialLabel.TabIndex = 0;
            this.newMaterialLabel.Text = "New Material";
            // 
            // viewMaterialTab
            // 
            this.viewMaterialTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewMaterialTab.Controls.Add(this.backButton);
            this.viewMaterialTab.Controls.Add(this.flowLayoutMaterial);
            this.viewMaterialTab.Controls.Add(this.noMaterialLabel);
            this.viewMaterialTab.Controls.Add(this.panel1);
            this.viewMaterialTab.Controls.Add(this.label1);
            this.viewMaterialTab.Location = new System.Drawing.Point(4, 22);
            this.viewMaterialTab.Name = "viewMaterialTab";
            this.viewMaterialTab.Padding = new System.Windows.Forms.Padding(2);
            this.viewMaterialTab.Size = new System.Drawing.Size(1066, 508);
            this.viewMaterialTab.TabIndex = 0;
            this.viewMaterialTab.Text = "Material";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("HP Simplified Hans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // flowLayoutMaterial
            // 
            this.flowLayoutMaterial.AutoScroll = true;
            this.flowLayoutMaterial.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutMaterial.Location = new System.Drawing.Point(171, 111);
            this.flowLayoutMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutMaterial.Name = "flowLayoutMaterial";
            this.flowLayoutMaterial.Size = new System.Drawing.Size(768, 316);
            this.flowLayoutMaterial.TabIndex = 7;
            this.flowLayoutMaterial.Visible = false;
            this.flowLayoutMaterial.WrapContents = false;
            // 
            // noMaterialLabel
            // 
            this.noMaterialLabel.AutoSize = true;
            this.noMaterialLabel.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMaterialLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noMaterialLabel.Location = new System.Drawing.Point(16, 111);
            this.noMaterialLabel.Name = "noMaterialLabel";
            this.noMaterialLabel.Size = new System.Drawing.Size(123, 20);
            this.noMaterialLabel.TabIndex = 6;
            this.noMaterialLabel.Text = "No Material Text";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.subjectNameLabel);
            this.panel1.Controls.Add(this.classroomName);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 83);
            this.panel1.TabIndex = 2;
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.AutoSize = true;
            this.subjectNameLabel.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subjectNameLabel.Location = new System.Drawing.Point(29, 55);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(106, 20);
            this.subjectNameLabel.TabIndex = 4;
            this.subjectNameLabel.Text = "subject Name";
            // 
            // classroomName
            // 
            this.classroomName.AutoSize = true;
            this.classroomName.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classroomName.Location = new System.Drawing.Point(18, 22);
            this.classroomName.Name = "classroomName";
            this.classroomName.Size = new System.Drawing.Size(110, 31);
            this.classroomName.TabIndex = 0;
            this.classroomName.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(480, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Made by BTI with 💓";
            this.label1.Visible = false;
            // 
            // materialTabs
            // 
            this.materialTabs.Controls.Add(this.viewMaterialTab);
            this.materialTabs.Controls.Add(this.addMaterialTab);
            this.materialTabs.Controls.Add(this.updateMaterialTab);
            this.materialTabs.Controls.Add(this.removeMaterialTab);
            this.materialTabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTabs.HotTrack = true;
            this.materialTabs.Location = new System.Drawing.Point(-1, -1);
            this.materialTabs.Name = "materialTabs";
            this.materialTabs.SelectedIndex = 0;
            this.materialTabs.Size = new System.Drawing.Size(1074, 534);
            this.materialTabs.TabIndex = 7;
            this.materialTabs.Click += new System.EventHandler(this.loadMaterialToUpdateDelete);
            this.materialTabs.Enter += new System.EventHandler(this.loadMaterialAtStartPage);
            // 
            // addMaterialTab
            // 
            this.addMaterialTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addMaterialTab.Controls.Add(this.materialTitleBox);
            this.addMaterialTab.Controls.Add(this.materialTitleLabel);
            this.addMaterialTab.Controls.Add(this.materialDescBox);
            this.addMaterialTab.Controls.Add(this.CreateAssignment);
            this.addMaterialTab.Controls.Add(this.AssignmentDescriptionLabel);
            this.addMaterialTab.Controls.Add(this.materialTypeBox);
            this.addMaterialTab.Controls.Add(this.materialTypeLabel);
            this.addMaterialTab.Controls.Add(this.label8);
            this.addMaterialTab.Controls.Add(this.panel2);
            this.addMaterialTab.Location = new System.Drawing.Point(4, 22);
            this.addMaterialTab.Name = "addMaterialTab";
            this.addMaterialTab.Padding = new System.Windows.Forms.Padding(2);
            this.addMaterialTab.Size = new System.Drawing.Size(1066, 508);
            this.addMaterialTab.TabIndex = 1;
            this.addMaterialTab.Text = "New Material";
            // 
            // materialTitleBox
            // 
            this.materialTitleBox.Location = new System.Drawing.Point(67, 143);
            this.materialTitleBox.Margin = new System.Windows.Forms.Padding(1);
            this.materialTitleBox.Multiline = true;
            this.materialTitleBox.Name = "materialTitleBox";
            this.materialTitleBox.Size = new System.Drawing.Size(283, 22);
            this.materialTitleBox.TabIndex = 36;
            // 
            // materialTitleLabel
            // 
            this.materialTitleLabel.AutoSize = true;
            this.materialTitleLabel.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTitleLabel.Location = new System.Drawing.Point(63, 112);
            this.materialTitleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialTitleLabel.Name = "materialTitleLabel";
            this.materialTitleLabel.Size = new System.Drawing.Size(38, 20);
            this.materialTitleLabel.TabIndex = 37;
            this.materialTitleLabel.Text = "Title";
            // 
            // materialDescBox
            // 
            this.materialDescBox.Location = new System.Drawing.Point(67, 249);
            this.materialDescBox.Margin = new System.Windows.Forms.Padding(2);
            this.materialDescBox.Multiline = true;
            this.materialDescBox.Name = "materialDescBox";
            this.materialDescBox.Size = new System.Drawing.Size(332, 137);
            this.materialDescBox.TabIndex = 27;
            // 
            // CreateAssignment
            // 
            this.CreateAssignment.BackColor = System.Drawing.Color.White;
            this.CreateAssignment.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.CreateAssignment.FlatAppearance.BorderSize = 3;
            this.CreateAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAssignment.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAssignment.Location = new System.Drawing.Point(848, 404);
            this.CreateAssignment.Margin = new System.Windows.Forms.Padding(1);
            this.CreateAssignment.Name = "CreateAssignment";
            this.CreateAssignment.Size = new System.Drawing.Size(107, 40);
            this.CreateAssignment.TabIndex = 34;
            this.CreateAssignment.Text = "Upload";
            this.CreateAssignment.UseVisualStyleBackColor = false;
            this.CreateAssignment.Click += new System.EventHandler(this.uploadMaterial_Click);
            // 
            // AssignmentDescriptionLabel
            // 
            this.AssignmentDescriptionLabel.AutoSize = true;
            this.AssignmentDescriptionLabel.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentDescriptionLabel.Location = new System.Drawing.Point(63, 205);
            this.AssignmentDescriptionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.AssignmentDescriptionLabel.Name = "AssignmentDescriptionLabel";
            this.AssignmentDescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.AssignmentDescriptionLabel.TabIndex = 30;
            this.AssignmentDescriptionLabel.Text = "Description";
            // 
            // materialTypeBox
            // 
            this.materialTypeBox.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTypeBox.Location = new System.Drawing.Point(789, 205);
            this.materialTypeBox.Margin = new System.Windows.Forms.Padding(1);
            this.materialTypeBox.Name = "materialTypeBox";
            this.materialTypeBox.Size = new System.Drawing.Size(145, 26);
            this.materialTypeBox.TabIndex = 28;
            // 
            // materialTypeLabel
            // 
            this.materialTypeLabel.AutoSize = true;
            this.materialTypeLabel.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTypeLabel.Location = new System.Drawing.Point(785, 170);
            this.materialTypeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialTypeLabel.Name = "materialTypeLabel";
            this.materialTypeLabel.Size = new System.Drawing.Size(103, 20);
            this.materialTypeLabel.TabIndex = 32;
            this.materialTypeLabel.Text = "Material Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.newMaterialLabel);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 83);
            this.panel2.TabIndex = 3;
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 534);
            this.Controls.Add(this.materialTabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Material";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignments";
            this.updateMaterialTab.ResumeLayout(false);
            this.updateMaterialTab.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialListForModification)).EndInit();
            this.removeMaterialTab.ResumeLayout(false);
            this.removeMaterialTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialListToRemove)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.viewMaterialTab.ResumeLayout(false);
            this.viewMaterialTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.materialTabs.ResumeLayout(false);
            this.addMaterialTab.ResumeLayout(false);
            this.addMaterialTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage updateMaterialTab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label updateMaterial;
        private System.Windows.Forms.TabPage removeMaterialTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label removeMaterialLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newMaterialLabel;
        private System.Windows.Forms.TabPage viewMaterialTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMaterial;
        private System.Windows.Forms.Label noMaterialLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label subjectNameLabel;
        private System.Windows.Forms.Label classroomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl materialTabs;
        private System.Windows.Forms.TabPage addMaterialTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox materialDescBox;
        private System.Windows.Forms.Button CreateAssignment;
        private System.Windows.Forms.Label AssignmentDescriptionLabel;
        private System.Windows.Forms.TextBox materialTypeBox;
        private System.Windows.Forms.Label materialTypeLabel;
        private System.Windows.Forms.Button deleteMaterialButton;
        private System.Windows.Forms.DataGridView materialListToRemove;
        private System.Windows.Forms.Button updateMaterialButton;
        private System.Windows.Forms.Label materialTypeLabel2;
        private System.Windows.Forms.Label materialDescriptionLabel2;
        private System.Windows.Forms.TextBox modifyTypeBox;
        private System.Windows.Forms.TextBox modifyDescBox;
        private System.Windows.Forms.DataGridView materialListForModification;
        private System.Windows.Forms.Button selectMaterialButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox materialTitleBox;
        private System.Windows.Forms.Label materialTitleLabel;
        private System.Windows.Forms.TextBox modifyTitleBox;
        private System.Windows.Forms.Label materialTitleLabel2;
        private Label noMaterialForDeletionLabel;
        private Label noMaterialForUpdation_Label;
    }
}