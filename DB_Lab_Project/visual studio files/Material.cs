using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApplication;

namespace intial_form_1_
{
    public partial class Material : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        String teacherName;
        String teacherUsername;
        String classroomID;
        SqlDataAdapter adapter;
        String assignmentID;
        public Material()
        {
            InitializeComponent();
        }
        public Material(String teacherName, String teacherUsername, String classroomID)
        {
            InitializeComponent();
            this.teacherName = teacherName;
            this.teacherUsername = teacherUsername;
            this.classroomID = classroomID;
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private Color RandomColor(int materialCounter)
        {
            //the colors: 138, 197, 255 ,, 209, 236, 241 ,, 233, 233, 233
            if (materialCounter > 3)
                materialCounter = 1;
            if (materialCounter == 1)
                return Color.FromArgb(138, 197, 255);
            else if (materialCounter == 2)
                return Color.FromArgb(209, 236, 241);
            else
                return Color.FromArgb(233, 233, 233);
        }

        

        private void loadMaterialAtStartPage(object sender, EventArgs e)
        {
            flowLayoutMaterial.Controls.Clear();
            flowLayoutMaterial.Controls.Add(new Label());
            flowLayoutMaterial.Visible = true;
            string materialIDTempVar;
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Material where classroomID = @classroomID and username_Teacher = @teacherUsername", cn);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                cm.Parameters.AddWithValue("@teacherUsername", teacherUsername);


                dr = cm.ExecuteReader();
                if (!dr.HasRows)
                {
                    noMaterialLabel.Visible = true;
                    noMaterialLabel.Text = "No Material Found";
                }
                else
                {
                    noMaterialLabel.Visible = false;
                    int materialCounter = 1;
                    while (dr.Read())
                    {
                        subjectNameLabel.Text = teacherName;
                        //Panel
                        Panel panel = new Panel();
                        panel.Size = new Size(691, 100);
                        panel.BackColor = RandomColor(materialCounter);
                        materialCounter++;
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Name = dr["materialID"].ToString();

                        //assignmentID Label
                        Label materialTitle = new Label();
                        materialTitle.Text = dr["materialTitle"].ToString();
                        materialTitle.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        materialTitle.Location = new Point(10, 10);
                        materialTitle.Size = new Size(300, 20);

                        //materialDescription Label
                        Label materialDescription = new Label();
                        materialDescription.Text = dr["materialDescription"].ToString();
                        materialDescription.Font = new Font("HP Simplified Hans", 12);
                        materialDescription.AutoSize = true;
                        materialDescription.Location = new Point(10, 40);

                        // Label DueDate = new Label();
                        // DueDate.Text = "Due Date: " + dr["assignmentDueDate"].ToString();
                        // DueDate.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        // DueDate.AutoSize = true;
                        // //DueDate should be at the bottom right of the panel
                        // DueDate.Location = new Point(400, 60);

                        panel.Controls.Add(materialDescription);
                        panel.Controls.Add(materialTitle);
                        // panel.Controls.Add(DueDate);
                        flowLayoutMaterial.Controls.Add(panel);
                        // panel.Click += (s, ev) =>
                        // {
                        //     this.Hide();
                        //     assignmentPanel assignmentPanel = new assignmentPanel(teacherName, teacherUsername, classroomID, panel.Name);
                        //     assignmentPanel.Show();
                        // };
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void uploadMaterial_Click(object sender, EventArgs e)
        {
                string MaterialTitle = materialTitleBox.Text;
                string MaterialDescription = materialDescBox.Text;
                string MaterialType = materialTypeBox.Text;
              
              //if empty fields are found, ask the user to fill them
                if (MaterialTitle == "" || MaterialDescription == "" || MaterialType == "")
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

                try
                {
                    cn.Open();
                    cm = new SqlCommand("insert into Material (materialTitle, materialDescription, materialType, classroomID, username_Teacher) values (@materialTitle, @materialDescription, @materialType, @classroomID, @username_Teacher)", cn);
                    cm.Parameters.AddWithValue("@materialTitle", MaterialTitle);
                    cm.Parameters.AddWithValue("@materialDescription", MaterialDescription);
                    cm.Parameters.AddWithValue("@materialType", MaterialType);
                    cm.Parameters.AddWithValue("@classroomID", classroomID);
                    cm.Parameters.AddWithValue("@username_Teacher", teacherUsername);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Material Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // MaterialDescription.Clear();
                    // materialLab.Clear();
                    // txtAssPoints.Clear();
                    // MaterialDescription.Focus();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
                loadMaterialAtStartPage(sender, e);
        }

        private void loadMaterialToUpdateDelete(object sender, EventArgs e)
        {
            try
            {
                if (materialTabs.SelectedTab.Name == "removeMaterialTab")
                {
                    DataTable dt = new DataTable();
                    cn.Open();
                    cm = new SqlCommand("select * from Material where classroomID=@classroomID", cn);
                    cm.Parameters.AddWithValue("@classroomID", classroomID);
                    int materialCount = Convert.ToInt32(cm.ExecuteScalar());
                        //if there is no comment for this assignment, then label will be shown to the user, else the grid will be shown
                        if (materialCount == 0)
                        {
                            noMaterialForDeletionLabel.Visible = true;
                            noMaterialForDeletionLabel.ForeColor = Color.Red;
                        //select button and grid will be hidden
                            deleteMaterialButton.Visible = false;
                            materialListToRemove.Visible = false;
                        }
                        else
                        {
                            deleteMaterialButton.Visible = true;
                            materialListToRemove.Visible = true;
                            noMaterialForDeletionLabel.Visible = false;
                            adapter = new SqlDataAdapter(cm);
                            adapter.Fill(dt);
                            materialListToRemove.DataSource = dt;
                        }

                    cn.Close();
                }
                else if (materialTabs.SelectedTab.Name == "updateMaterialTab")
                {
                    toggleUpdateMaterialTabToSelection();
                    DataTable dt = new DataTable();
                    cn.Open();
                    cm = new SqlCommand("select * from Material where classroomID=@classroomID", cn);
                    cm.Parameters.AddWithValue("@classroomID", classroomID);
                    int materialCount = Convert.ToInt32(cm.ExecuteScalar());
                        //if there is no comment for this assignment, then label will be shown to the user, else the grid will be shown
                        if (materialCount == 0)
                        {
                            noMaterialForUpdation_Label.Visible = true;
                            noMaterialForUpdation_Label.ForeColor = Color.Red;
                        //select button and grid will be hidden
                            selectMaterialButton.Visible = false;
                            materialListForModification.Visible = false;
                        }
                        else
                        {
                            selectMaterialButton.Visible = true;
                            materialListForModification.Visible = true;
                            noMaterialForUpdation_Label.Visible = false;
                            adapter = new SqlDataAdapter(cm);
                            adapter.Fill(dt);
                            materialListForModification.DataSource = dt;
                        }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteMaterialButton_Click(object sender, EventArgs e)
        {
            //check if the comment is selected or not
            if (materialListToRemove.SelectedRows.Count == 0 || materialListToRemove.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Please select material to delete");
                return;
            }
            //ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected material?", "Confirmation", MessageBoxButtons.YesNo);
            //delete all the select comments
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in materialListToRemove.SelectedRows)
                {
                    try
                    {   
                        int materialID = Convert.ToInt32(row.Cells["materialID"].Value);
                        //query to delete the comment
                        cm = new SqlCommand("delete from Material where materialID=@materialID", cn);
                        cm.Parameters.AddWithValue("@materialID", materialID);
                        cn.Open();
                        cm.ExecuteNonQuery();
                        cm.Dispose(); // add this line
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
                DataTable dt = (DataTable)materialListToRemove.DataSource;
                dt.Clear();
                adapter.Fill(dt);
                cn.Close();
               //if grid is empty then hide the delete button
                if (dt.Rows.Count == 0)
                {
                    deleteMaterialButton.Visible = false;
                    materialListToRemove.Visible = false;
                    noMaterialForDeletionLabel.Visible = true;
                    noMaterialForDeletionLabel.ForeColor = Color.Red;
                }
            }
            loadMaterialAtStartPage(sender, e);

        }

        private void selectMaterialForModifcionBtn_Click(object sender, EventArgs e)
        {
             try {
                //check if the comment is selected or not
                if (materialListForModification.SelectedRows.Count == 0 || materialListForModification.SelectedRows[0].IsNewRow)
                {
                    MessageBox.Show("Please select material to update");
                    return;
                }
                //get the material id from the selected row
                int materialID = Convert.ToInt32(materialListForModification.SelectedRows[0].Cells["materialID"].Value);
                //get the material data from the database
                cn.Open();
                cm = new SqlCommand("select * from Material where materialID=@materialID", cn);
                cm.Parameters.AddWithValue("@materialID", materialID);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    //set the material data to the textboxes
                    modifyTitleBox.Text = dr["materialTitle"].ToString();
                    modifyDescBox.Text = dr["materialDescription"].ToString();
                    modifyTypeBox.Text = dr["materialType"].ToString();
                    toggleUpdateMaterialTabToEditable();
                }
                dr.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toggleUpdateMaterialTabToEditable() {
                materialListForModification.Visible = false;
                selectMaterialButton.Visible = false;
                modifyTitleBox.Visible = true;
                modifyDescBox.Visible = true;
                modifyTypeBox.Visible = true;
                updateMaterialButton.Visible = true;
                materialTypeLabel2.Visible = true;
                materialTitleLabel2.Visible = true;
                materialDescriptionLabel2.Visible = true;
                
        }
        private void toggleUpdateMaterialTabToSelection() {
            materialListForModification.Visible = true;
                selectMaterialButton.Visible = true;
                modifyTitleBox.Visible = false;
                modifyDescBox.Visible = false;
                modifyTypeBox.Visible = false;
                updateMaterialButton.Visible = false;
                materialTypeLabel2.Visible = false;
                materialTitleLabel2.Visible = false;
                materialDescriptionLabel2.Visible = false;
        }

        private void materialUpdateButton_Click(object sender, EventArgs e)
        {
                try
                {
                    string MaterialTitle = modifyTitleBox.Text;
                    string MaterialDescription = modifyDescBox.Text;
                    string MaterialType =  modifyTypeBox.Text;
                    //store the comment id from the selected row
                    int materialID = Convert.ToInt32(materialListForModification.SelectedRows[0].Cells["materialID"].Value);
                    //handle null value with messagebox
                    if (MaterialTitle == "" || MaterialDescription == "" || MaterialType == "")
                    {
                        MessageBox.Show("Please fill all the fields");
                        return;
                    }


                    cn.Open();
                    cm = new SqlCommand("update Material set materialTitle=@materialTitle, materialDescription=@materialDescription, materialType=@materialType where materialID=@materialID", cn);
                    cm.Parameters.AddWithValue("@materialTitle", MaterialTitle);
                    cm.Parameters.AddWithValue("@materialDescription", MaterialDescription);
                    cm.Parameters.AddWithValue("@materialType", MaterialType);
                    cm.Parameters.AddWithValue("@materialID", materialID);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Material Updated Successfully ");
                    loadMaterialToUpdateDelete(sender, e);
                    toggleUpdateMaterialTabToSelection();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
