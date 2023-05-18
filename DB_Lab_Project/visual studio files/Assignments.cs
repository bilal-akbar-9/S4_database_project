using MyApplication;
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

namespace intial_form_1_
{
    public partial class Assignments : Form
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

        public Assignments()
        {
            InitializeComponent();
        }

        public Assignments(String teacherName, String teacherUsername, String classroomID)
        {
            InitializeComponent();
            this.teacherUsername = teacherUsername;
            this.classroomID = classroomID;
            this.teacherName = teacherName;
            cn = new SqlConnection(dbcon.MyConnection());
        }
        private Color RandomColor(int assignmentCounter)
        {
            //the colors: 138, 197, 255 ,, 209, 236, 241 ,, 233, 233, 233
            if (assignmentCounter > 3)
                assignmentCounter = 1;
            if (assignmentCounter == 1)
                return Color.FromArgb(138, 197, 255);
            else if (assignmentCounter == 2)
                return Color.FromArgb(209, 236, 241);
            else
                return Color.FromArgb(233, 233, 233);
        }
        private void loadAssignmentAtStartPage(object sender, EventArgs e)
        {
            flowLayoutAssignment.Controls.Clear();
            flowLayoutAssignment.Controls.Add(new Label());
            flowLayoutAssignment.Visible = true;
            string assignmentIDtempVar;
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * FROM Assignment WHERE classroomID = @classroomID AND username_Teacher = @teacherUsername", cn);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                cm.Parameters.AddWithValue("@teacherUsername", teacherUsername);
                dr = cm.ExecuteReader();
                if (!dr.HasRows)
                {
                    noClassLabel.Visible = true;
                    noClassLabel.Text = "No Assignments Found";
                }
                else
                {
                    noClassLabel.Visible = false;
                    int assignmentCounter = 1;
                    Debug.WriteLine("Assignments found");
                    while (dr.Read())
                    {
                        teacherNameLabel.Text = teacherName;
                        //Panel
                        Panel panel = new Panel();
                        panel.Size = new Size(691, 100);
                        panel.BackColor = RandomColor(assignmentCounter);
                        assignmentCounter++;
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Name = dr["assignmentID"].ToString();

                        //assignmentID Label
                        Label assignmentTitle = new Label();
                        assignmentTitle.Text = dr["assignmentTitle"].ToString();
                        assignmentTitle.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        assignmentTitle.Location = new Point(10, 10);
                        assignmentTitle.Size = new Size(300, 20);
                                                
                        //assignmentDescription Label
                        Label assignmentDescription = new Label();
                        assignmentDescription.Text = dr["assignmentDescription"].ToString();
                        assignmentDescription.Font = new Font("HP Simplified Hans", 12);
                        assignmentDescription.AutoSize = true;
                        assignmentDescription.Location = new Point(10, 40);

                        Label DueDate = new Label();
                        DueDate.Text = "Due Date: " + dr["assignmentDueDate"].ToString();
                        DueDate.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        DueDate.AutoSize = true;
                        //DueDate should be at the bottom right of the panel
                        DueDate.Location = new Point(400, 60);

                        panel.Controls.Add(assignmentDescription);
                        panel.Controls.Add(assignmentTitle);
                        panel.Controls.Add(DueDate);
                        flowLayoutAssignment.Controls.Add(panel);
                        panel.Click += (s, ev) =>
                        {
                            this.Hide();
                            assignmentPanel assignmentPanel = new assignmentPanel(teacherName, teacherUsername, classroomID, panel.Name);
                            assignmentPanel.Show();
                        };
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAssDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAssignment_Click(object sender, EventArgs e)
        {
            string AssignmentTitle = txtAssTitle.Text;
            string AssignmentDesc = txtAssDesc.Text;
            string AssignmentDueDate = txtAssDueDate.Value.ToString("yyyy-MM-dd HH:mm");
            //should not allow due date to be before today
            if (txtAssDueDate.Value < DateTime.Today)
            {
                MessageBox.Show("Due date cannot be before today");
                return;
            }
            string AssignmentFile = txtAssignmetFile.Text;
            string AssignmentPoints = txtAssPoints.Text;

            try
            {
                cn.Open();
                cm = new SqlCommand("insert into Assignment (assignmentDescription,assignmentPoints,assignmentDueDate,assignmentFile,classroomID,username_Teacher,assignmentTitle) values (@AssignmentDesc,@AssignmentPoints,@AssignmentDueDate,@AssignmentFile,@classroomID,@username,@assignmentTitle)", cn);
                cm.Parameters.AddWithValue("@AssignmentDesc", AssignmentDesc);
                cm.Parameters.AddWithValue("@AssignmentDueDate", AssignmentDueDate);
                cm.Parameters.AddWithValue("@AssignmentFile", AssignmentFile);
                cm.Parameters.AddWithValue("@AssignmentPoints", AssignmentPoints);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                cm.Parameters.AddWithValue("@username", teacherUsername);
                cm.Parameters.AddWithValue("@assignmentTitle", AssignmentTitle);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Assignment Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAssDesc.Clear();
                txtAssignmetFile.Clear();
                txtAssPoints.Clear();
                txtAssDesc.Focus();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteAssigmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there are any selected rows
                if (assignmentsList.SelectedRows.Count == 0 || assignmentsList.SelectedRows[0].IsNewRow)
                {
                    MessageBox.Show("No assignments selected.");
                    return;
                }

                // Display a confirmation dialog box
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected assignments?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms the deletion, proceed with deletion
                if (result == DialogResult.Yes)
                {
                    // Iterate over the selected rows in the GridView
                    foreach (DataGridViewRow row in assignmentsList.SelectedRows)
                    {
                        // Get the assignment ID from the selected row
                        int assignmentID = Convert.ToInt32(row.Cells["AssignmentID"].Value);

                        // Execute the delete query using the assignment ID
                        cm = new SqlCommand("DELETE FROM Assignment WHERE AssignmentID = @assignmentID", cn);
                        cm.Parameters.AddWithValue("@assignmentID", assignmentID);
                        cn.Open();
                        cm.ExecuteNonQuery();
                    }

                    // Refresh the GridView after deletion
                    DataTable dt = (DataTable)assignmentsList.DataSource;
                    dt.Clear();
                    adapter.Fill(dt);
                    cn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AssignmentloadForUpdateDelete(object sender, EventArgs e)
        {
            try
            {
                if (AssignmentTABS.SelectedTab.Name == "RemoveAssignmentTab")
                {
                    DataTable dt = new DataTable();
                    cn.Open();
                    cm = new SqlCommand("select * from Assignment where classroomID=@classroomID", cn);
                    cm.Parameters.AddWithValue("@classroomID", classroomID);
                    adapter = new SqlDataAdapter(cm);
                    adapter.Fill(dt);
                    assignmentsList.DataSource = dt;
                    cn.Close();
                }
                else if (AssignmentTABS.SelectedTab.Name == "UpdateAssTab")
                {
                    DataTable dt = new DataTable();
                    cn.Open();
                    cm = new SqlCommand("select * from Assignment where classroomID=@classroomID", cn);
                    cm.Parameters.AddWithValue("@classroomID", classroomID);
                    adapter = new SqlDataAdapter(cm);
                    adapter.Fill(dt);
                    assignmentsListForModification.DataSource = dt;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the modified values from the controls or fields
                string assignmentTitle = modifyTitleBox.Text;
                string assignmentDescription = modifyDescBox.Text;
                string assignmentPoints = modifyAssignmentPointsBox.Text;
                string assignmentDueDate = modifyDueDateBox.Value.ToString("yyyy-MM-dd HH:mm");
                string assignmentFile = modifyAssignmentFileBox.Text;
                //dont allow due date to be before today
                if (modifyDueDateBox.Value < DateTime.Today)
                {
                    MessageBox.Show("Due date cannot be before today");
                    return;
                }
                //Validate assignmentTitle and prompt user if it's empty
                if (string.IsNullOrEmpty(assignmentTitle))
                {
                    MessageBox.Show("Please enter a value for Assignment Title.");
                    return; // Stop further execution
                }
                // Validate assignmentDescription and prompt user if it's empty
                if (string.IsNullOrEmpty(assignmentDescription))
                {
                    MessageBox.Show("Please enter a value for Assignment Description.");
                    return; // Stop further execution
                }

                // Validate assignmentPoints and prompt user if it's empty
                if (string.IsNullOrEmpty(assignmentPoints))
                {
                    MessageBox.Show("Please enter a value for Assignment Points.");
                    return; // Stop further execution
                }
                //if date is empty, set it to null
                if (string.IsNullOrEmpty(assignmentDueDate))
                {
                    assignmentDueDate = null;
                    cm.Parameters.AddWithValue("@assignmentDueDate", DBNull.Value);
                }
                //if file is empty, set it to null
                if (string.IsNullOrEmpty(assignmentFile))
                {
                    assignmentFile = null;
                    cm.Parameters.AddWithValue("@assignmentFile", DBNull.Value);
                }

                // Execute the necessary SQL query to update the record in the database
                cn.Open();
                //if data is empty, set it to null run query with dat

                cm = new SqlCommand("UPDATE Assignment SET assignmentTitle = @assignmentTitle,  assignmentDescription = @assignmentDescription, assignmentPoints = @assignmentPoints, assignmentDueDate = @assignmentDueDate, assignmentFile = @assignmentFile WHERE assignmentID = @assignmentID", cn);
                cm.Parameters.AddWithValue("@assignmentDescription", assignmentDescription);
                cm.Parameters.AddWithValue("@assignmentPoints", assignmentPoints);
                cm.Parameters.AddWithValue("@assignmentDueDate", assignmentDueDate);
                cm.Parameters.AddWithValue("@assignmentFile", assignmentFile);
                cm.Parameters.AddWithValue("@assignmentTitle", assignmentTitle);
                cm.Parameters.AddWithValue("@assignmentID", this.assignmentID);
                cm.ExecuteNonQuery();
                cn.Close();

                // Display a success message or perform any other action upon successful modification
                MessageBox.Show("Assignment modified successfully.");
                AssignmentloadForUpdateDelete(sender, e);
                toggleUpdateAssignmentTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get the assignment ID from the selected row
                int assignmentID = Convert.ToInt32(assignmentsListForModification.SelectedRows[0].Cells["AssignmentID"].Value);
                this.assignmentID = assignmentID.ToString();
                //fetch the data from the database using the assignment ID
                cn.Open();
                cm = new SqlCommand("select * from Assignment where assignmentID=@assignmentID", cn);
                cm.Parameters.AddWithValue("@assignmentID", assignmentID);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    //display the data in the textboxes
                    modifyDescBox.Text = dr["assignmentDescription"].ToString();
                    modifyAssignmentPointsBox.Text = dr["assignmentPoints"].ToString();
                    modifyDueDateBox.Text = dr["assignmentDueDate"].ToString();
                    modifyAssignmentFileBox.Text = dr["assignmentFile"].ToString();
                    modifyTitleBox.Text = dr["assignmentTitle"].ToString();
                    toggleUpdateAssignmentTab();
                }
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void toggleUpdateAssignmentTab()
        {
            if (assignmentsListForModification.Visible == true){
            //make the assignmentsList invisible
            assignmentsListForModification.Visible = false;
            //delete selectButton
            selectButton.Visible = false;
            //make all textboxes visible
            modifyDescBox.Visible = true;
            modifyAssignmentPointsBox.Visible = true;
            modifyDueDateBox.Visible = true;
            modifyAssignmentFileBox.Visible = true;
            modifyTitleBox.Visible = true;
            //make all labels visible
            label14.Visible = true;
            label13.Visible = true;
            label12.Visible = true;
            label11.Visible = true;
            label15.Visible = true;
            // labelAssiID.Visible = true;
            // textBoxAssID.Visible = true;
            //make the modify button visible
            modifyButton.Visible = true;
            }
            else if (assignmentsListForModification.Visible == false)
            {
                //make the assignmentsList visible
                assignmentsListForModification.Visible = true;
                //make the selectButton visible
                selectButton.Visible = true;
                //make all textboxes invisible
                modifyDescBox.Visible = false;
                modifyAssignmentPointsBox.Visible = false;
                modifyDueDateBox.Visible = false;
                modifyAssignmentFileBox.Visible = false;
                modifyTitleBox.Visible = false;
                //make all labels invisible
                label14.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                label11.Visible = false;
                label15.Visible = false;
                // labelAssiID.Visible = false;
                // textBoxAssID.Visible = false;
                //make the modify button invisible
                modifyButton.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class classForm = new Class(teacherName,teacherUsername,classroomID);
            classForm.Show();
        }

    }
}
