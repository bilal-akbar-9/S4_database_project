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
        String teacherUsername;
        String classroomID;
        String teacherName;
        SqlDataAdapter adapter;

        public Assignments()
        {
            InitializeComponent();
        }

        public Assignments(String teacherName,String teacherUsername, String classroomID)
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
            if (assignmentCounter == 0)
                return Color.FromArgb(138, 197, 255);
            else if (assignmentCounter == 1)
                return Color.FromArgb(209, 236, 241);
            else
                return Color.FromArgb(233, 233, 233);
        }
        private void Assignments_Load(object sender, EventArgs e)
        {
            flowLayoutAssignment.Controls.Clear();
            flowLayoutAssignment.Controls.Add(new Label());
            flowLayoutAssignment.Visible = true;

            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * FROM Assignment WHERE classroomID = @classroomID AND username_Teacher = @teacherUsername", cn);
                // cm = new SqlCommand("SELECT * FROM Classroom", cn);
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
                    int assignmentCounter = 1;
                    Debug.WriteLine("Assignments found");
                    while (dr.Read())
                    {
                        //Panel
                        Panel panel = new Panel();
                        panel.Size = new Size(200, 100);
                        panel.BackColor = RandomColor(assignmentCounter);
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Name = dr["assignmentID"].ToString();
                        panel.AutoScroll = true;
                        panel.AutoSize = false;

                        //assignmentID Label
                        Label assignmentID = new Label();
                        assignmentID.Text = "Assignment ID: " + dr["assignmentID"].ToString();
                        assignmentID.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        assignmentID.Location = new Point(10, 10);
                        assignmentID.Size = new Size(180, 20);
                        //scrollbar
                        assignmentID.AutoEllipsis = true;
                        assignmentID.AutoSize = true;
                        assignmentID.TextAlign = ContentAlignment.TopLeft;

                        //assignmentDescription Label
                        Label assignmentDescription = new Label();
                        assignmentDescription.Text = "Assignment Description: " + dr["assignmentDescription"].ToString();
                        assignmentDescription.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        assignmentDescription.Location = new Point(10, 30);
                        assignmentDescription.Size = new Size(180, 50);
                        //scrollbar
                        assignmentDescription.AutoEllipsis = true;
                        assignmentDescription.AutoSize = true;
                        assignmentDescription.TextAlign = ContentAlignment.TopLeft;

                        panel.Controls.Add(assignmentDescription);
                        panel.Controls.Add(assignmentID);
                        flowLayoutAssignment.Controls.Add(panel);
                        panel.Click += (s, ev) =>
                        {
                            TeacherPanel teacherPanel = new TeacherPanel("", teacherUsername, classroomID);
                            teacherPanel.Show();
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
            string AssignmentDesc = txtAssDesc.Text;
            string AssignmentDueDate = txtAssDueDate.Value.ToString("yyyy-MM-dd");
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
                cm = new SqlCommand("insert into Assignment (assignmentDescription,assignmentPoints,assignmentDueDate,assignmentFile,classroomID,username_Teacher) values (@AssignmentDesc,@AssignmentPoints,@AssignmentDueDate,@AssignmentFile,@classroomID,@username)", cn);
                cm.Parameters.AddWithValue("@AssignmentDesc", AssignmentDesc);
                cm.Parameters.AddWithValue("@AssignmentDueDate", AssignmentDueDate);
                cm.Parameters.AddWithValue("@AssignmentFile", AssignmentFile);
                cm.Parameters.AddWithValue("@AssignmentPoints", AssignmentPoints);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                cm.Parameters.AddWithValue("@username", teacherUsername);
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

        private void assignmentsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void load_Assignments(object sender, EventArgs e)
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
                string assignmentDescription = modifyDescBox.Text;
                string assignmentPoints = modifyAssignmentPointsBox.Text;
                string assignmentDueDate = modifyDueDateBox.Value.ToString("yyyy-MM-dd");
                string assignmentFile = modifyAssignmentFileBox.Text;
                string assignmentID = textBoxAssID.Text;
                //dont allow due date to be before today
                if (modifyDueDateBox.Value < DateTime.Today)
                {
                    MessageBox.Show("Due date cannot be before today");
                    return;
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

                // Execute the necessary SQL query to update the record in the database
                cn.Open();
                //if data is empty, set it to null run query with dat

                cm = new SqlCommand("UPDATE Assignment SET assignmentDescription = @assignmentDescription, assignmentPoints = @assignmentPoints, assignmentDueDate = @assignmentDueDate, assignmentFile = @assignmentFile WHERE assignmentID = @assignmentID", cn);
                cm.Parameters.AddWithValue("@assignmentDescription", assignmentDescription);
                cm.Parameters.AddWithValue("@assignmentPoints", assignmentPoints);
                cm.Parameters.AddWithValue("@assignmentDueDate", assignmentDueDate);
                cm.Parameters.AddWithValue("@assignmentFile", assignmentFile);
                cm.Parameters.AddWithValue("@assignmentID", assignmentID);
                cm.ExecuteNonQuery();
                cn.Close();

                // Display a success message or perform any other action upon successful modification
                MessageBox.Show("Assignment modified successfully.");

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

                    changeModifyAssignmentTab();
                }
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void changeModifyAssignmentTab()
        {
            //make the assignmentsList invisible
            assignmentsListForModification.Visible = false;
            //delete selectButton
            selectButton.Visible = false;
            //make all textboxes visible
            modifyDescBox.Visible = true;
            modifyAssignmentPointsBox.Visible = true;
            modifyDueDateBox.Visible = true;
            modifyAssignmentFileBox.Visible = true;
            //make all labels visible
            label14.Visible = true;
            label13.Visible = true;
            label12.Visible = true;
            label11.Visible = true;
            labelAssiID.Visible = true;
            textBoxAssID.Visible = true;
            //make the modify button visible
            modifyButton.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class classForm = new Class(teacherName,teacherUsername,classroomID);
            classForm.Show();
        }
    }
}
