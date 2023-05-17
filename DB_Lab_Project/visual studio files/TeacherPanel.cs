using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApplication;

namespace intial_form_1_
{
    public partial class TeacherPanel : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        SqlDataAdapter adapter;

        string teacherUserName;
        string classroomID;
        String teacherName;

        //private object assignmentList;
        public TeacherPanel()
        {
            InitializeComponent();
        }

        public TeacherPanel(string teacherName, string teacherUsername, string classroomID)
        {
            InitializeComponent();
            this.teacherUserName = teacherUsername;
            this.classroomID = classroomID;
            this.teacherName = teacherName;
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;

        }


        private void CreateAssignment_Click(object sender, EventArgs e)
        {
            string AssignmentDesc = txtAssDesc.Text;
            string AssignmentDueDate = txtAssDueDate.Value.ToString("yyyy-MM-dd");
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
                cm.Parameters.AddWithValue("@username", teacherUserName);
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


        private void viewProgressButton_Clicked(object sender, EventArgs e)
        {
            // string StudentID = txtStudentsID.Text;
            string AssignmentNumber = txtAssNo2.Text;


            // get all the assignments submission for a specific assignment
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Submissions where assignmentID=@AssignmentNumber", cn);
                cm.Parameters.AddWithValue("@AssignmentNumber", AssignmentNumber);
                adapter = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ViewProgressDatagridView.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void addCommentButton_Clicked(object sender, EventArgs e)
        {
            string CommentDesc = txtCommentDesc.Text;
            string CommentDate = txtCommentDate.Text;
            string AssignmentID = txtAssignmentID.Text;

            try
            {
                cn.Open();
                cm = new SqlCommand("insert into Comment (commentDescription,commentDate,assignmentID) values (@CommentDesc,@CommentDate,@AssignmentID)", cn);
                cm.Parameters.AddWithValue("@CommentDesc", CommentDesc);
                cm.Parameters.AddWithValue("@CommentDate", CommentDate);
                cm.Parameters.AddWithValue("@AssignmentID", AssignmentID);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Comment Added Successfully with ID: " + AssignmentID, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCommentDesc.Clear();
                txtCommentDate.Clear();
                txtAssignmentID.Clear();
                txtCommentDesc.Focus();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteCommentButton(object sender, EventArgs e)
        {
            string CommentID = txtCommentID.Text;

            try
            {
                cn.Open();
                cm = new SqlCommand("delete from Comment where commentID=@CommentID", cn);
                cm.Parameters.AddWithValue("@CommentID", CommentID);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Comment Deleted Successfully with ID: " + CommentID, "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCommentID.Clear();
                txtCommentID.Focus();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCOmmentButton(object sender, EventArgs e)
        {
            string CommentDesc = txtCommentDescUPDAtE.Text;
            string CommentDate = txtCommentDateUpdate.Text;
            string AssignmentID = txtAssIDUpdate.Text;
            string CommentID = txtCOmmentIDUpdate.Text;

            try
            {
                cn.Open();
                cm = new SqlCommand("update Comment set commentDescription=@CommentDesc,commentDate=@CommentDate,assignmentID=@AssignmentID where commentID=@CommentID", cn);
                cm.Parameters.AddWithValue("@CommentDesc", CommentDesc);
                cm.Parameters.AddWithValue("@CommentDate", CommentDate);
                cm.Parameters.AddWithValue("@AssignmentID", AssignmentID);
                cm.Parameters.AddWithValue("@CommentID", CommentID);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Comment Updated Successfully with ID: " + CommentID, "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCommentDescUPDAtE.Clear();
                txtCommentDateUpdate.Clear();
                txtAssIDUpdate.Clear();
                txtCOmmentIDUpdate.Clear();
                txtCommentDescUPDAtE.Focus();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void load_Assignments(object sender, EventArgs e)
        {
            try
            {
                if (assignmentSubTabs.SelectedTab.Name == "deleteAssigmentTab")
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
                else if (assignmentSubTabs.SelectedTab.Name == "modifyAssignmentTab")
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


        private void deleteAssignmentButton_Clicked(object sender, EventArgs e)
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





        // Global variable to store the selected assignment ID
        private void assignmentSelectButton_Clicked(object sender, EventArgs e)
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
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            //make the modify button visible
            modifyButton.Visible = true;
        }

        private void assignmentModifyButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the modified values from the controls or fields
                string assignmentDescription = modifyDescBox.Text;
                string assignmentPoints = modifyAssignmentPointsBox.Text;
                string assignmentDueDate = modifyDueDateBox.Value.ToString("yyyy-MM-dd");
                string assignmentFile = modifyAssignmentFileBox.Text;

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
                cm.Parameters.AddWithValue("@assignmentID", assignmentsListForModification.SelectedRows[0].Cells["AssignmentID"].Value);
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class classForm = new Class(teacherName, teacherUserName, classroomID);
            classForm.Show();
        }

        private void assignmentsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
