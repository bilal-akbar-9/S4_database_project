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
    public partial class assignmentPanel : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        SqlDataAdapter adapter;

        string teacherUserName;
        string classroomID;
        String teacherName;
        String assignmentID;

        //private object assignmentList;
        public assignmentPanel()
        {
            InitializeComponent();
        }

        public assignmentPanel(string teacherName, string teacherUsername, string classroomID, string assignmentID)
        {
            InitializeComponent();
            this.teacherUserName = teacherUsername;
            this.classroomID = classroomID;
            this.teacherName = teacherName;
            this.assignmentID = assignmentID;
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;

        }
        private void viewProgressButton_Clicked(object sender, EventArgs e)
        {
            // get all the assignments submission for this classroom
            try
            {
                SqlConnection cn = new SqlConnection();
                cn = new SqlConnection(dbcon.MyConnection());
                cn.Open();
                cm = new SqlCommand("select * from submissions where assignmentID in (select assignmentID from assignment where classroomID = @classroomID)", cn);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                adapter = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ViewProgressDatagridView.DataSource = dt;

                // add total count of assignments to the label
                cm = new SqlCommand("select count(*) from submissions where assignmentID in (select assignmentID from assignment where classroomID = @classroomID)", cn);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                int count = (int)cm.ExecuteScalar();
                countlabel.Visible = true;
                countlabel.Text = "Total Count: " + count.ToString();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }
        private void addCommentButton_Clicked(object sender, EventArgs e)
        {
            string CommentDesc = txtCommentDesc.Text;
            string CommentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                cn.Open();
                cm = new SqlCommand("insert into Comment (commentDescription,commentDate,assignmentID) values (@CommentDesc,@CommentDate,@AssignmentID)", cn);
                cm.Parameters.AddWithValue("@CommentDesc", CommentDesc);
                cm.Parameters.AddWithValue("@CommentDate", CommentDate);
                cm.Parameters.AddWithValue("@AssignmentID", this.assignmentID);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Comment Added Successfully", "Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCommentDesc.Clear();
                txtCommentDesc.Focus();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // Global variable to store the selected assignment 
       

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assignments assignments = new Assignments(teacherName, teacherUserName, classroomID);
            assignments.Show();
        }


        private void assignmentPanel_Load(object sender, EventArgs e)
        {
            //get the assignmentData from the database
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Assignment where assignmentID=@AssignmentID", cn);
                cm.Parameters.AddWithValue("@AssignmentID", assignmentID);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txtAssTitle.Text = dr["assignmentTitle"].ToString();
                    txtAssDesc.Text = dr["assignmentDescription"].ToString();
                    txtAssPoints.Text = dr["assignmentPoints"].ToString();
                    txtAssignmetFile.Text = dr["assignmentFile"].ToString();
                    dueDateLabel.Text = dr["assignmentDueDate"].ToString();
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

        private void loadCommentsToDeleteOrUpdate(object sender, EventArgs e)
        {

                try
                {
                    if(commentTABS.SelectedTab.Name == "deleteCommentTab") {
                        DataTable dt = new DataTable();
                        cn.Open();
                        cm = new SqlCommand("select * from Comment where assignmentID=@AssignmentID", cn);
                        cm.Parameters.AddWithValue("@AssignmentID", assignmentID);
                        int commentCount = Convert.ToInt32(cm.ExecuteScalar());
                        //if there is no comment for this assignment, then label will be shown to the user, else the grid will be shown
                        if (commentCount == 0)
                        {
                            noCommentToDelete_Label.Visible = true;
                            noCommentToDelete_Label.Text = "No comments for this assignment";
                            noCommentToDelete_Label.ForeColor = Color.Red;

                        }
                        else
                        {
                            
                            noCommentToDelete_Label.Visible = false;
                            adapter = new SqlDataAdapter(cm);
                            adapter.Fill(dt);
                            //make delete button and grid visible
                            Deletebutton.Visible = true;
                            commentListGridForDeletion.Visible = true;
                            commentListGridForDeletion.DataSource = dt;
                        }
                        //close the connection
                        cn.Close();
                    } 
                     else if(commentTABS.SelectedTab.Name == "updateCommentTab")
                    {
                        DataTable dt = new DataTable();
                        cn.Open();
                        cm = new SqlCommand("select * from Comment where assignmentID=@AssignmentID", cn);
                        cm.Parameters.AddWithValue("@AssignmentID", assignmentID);
                        int commentCount = Convert.ToInt32(cm.ExecuteScalar());
                        //if there is no comment for this assignment, then label will be shown to the user, else the grid will be shown
                        if (commentCount == 0)
                        {
                            noCommentToUpdateLabel.Visible = true;
                            noCommentToUpdateLabel.Text = "No Comments for this assignment";
                            noCommentToUpdateLabel.ForeColor = Color.Red;
                        //select button and grid will be hidden
                            SelectButton.Visible = false;
                            commentListForUpdation.Visible = false;
                        }
                        else
                        {
                            SelectButton.Visible = true;
                            commentListForUpdation.Visible = true;
                            noCommentToUpdateLabel.Visible = false;
                            adapter = new SqlDataAdapter(cm);
                            adapter.Fill(dt);
                            commentListForUpdation.DataSource = dt;
                        }
                        
                        cn.Close();
                    }
                    else if(commentTABS.SelectedTab.Name == "viewCommentsTab") {
                        //if no row is selected then commentslist
                         DataTable dt = new DataTable();
                        cn.Open();
                        cm = new SqlCommand("select * from Comment where assignmentID=@AssignmentID", cn);
                        cm.Parameters.AddWithValue("@AssignmentID", assignmentID);
                        int commentCount = Convert.ToInt32(cm.ExecuteScalar());
                        //if there is no comment for this assignment, then label will be shown to the user, else the grid will be shown
                        if (commentCount == 0)
                        {
                            noCommentToViewLabel.Visible = true;
                            noCommentToViewLabel.Text = "No comments to view";
                            noCommentToViewLabel.ForeColor = Color.Red;
                            allCommentsList.Visible = false;
                        }
                        else
                        {
                            allCommentsList.Visible = true;
                            noCommentToViewLabel.Visible = false;
                            adapter = new SqlDataAdapter(cm);
                            adapter.Fill(dt);
                            allCommentsList.DataSource = dt;
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

        private void DeleteCommentButtonClicked(object sender, EventArgs e)
        {
            //check if the comment is selected or not
            if (commentListGridForDeletion.SelectedRows.Count == 0 || commentListGridForDeletion.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Please select a comment to delete");
                return;
            }
            //ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected comment(s)?", "Confirmation", MessageBoxButtons.YesNo);
            //delete all the select comments
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in commentListGridForDeletion.SelectedRows)
                {
                    try
                    {   
                        int commentID = Convert.ToInt32(row.Cells["commentID"].Value);
                        cm = new SqlCommand("delete from Comment where commentID=@CommentID", cn);
                        cm.Parameters.AddWithValue("@CommentID", commentID);
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
                DataTable dt = (DataTable)commentListGridForDeletion.DataSource;
                dt.Clear();
                adapter.Fill(dt);
                cn.Close();
               //if grid is empty then hide the delete button
                if (dt.Rows.Count == 0)
                {
                    Deletebutton.Visible = false;
                    commentListGridForDeletion.Visible = false;
                    noCommentToDelete_Label.Visible = true;
                    noCommentToDelete_Label.Text = "No comments for this assignment";
                    noCommentToDelete_Label.ForeColor = Color.Red;
                }
            }
        }

        private void toggleUpdateCommentTab() {
            if(commentListForUpdation.Visible == true)
            {
                commentListForUpdation.Visible = false;
                SelectButton.Visible = false;
                txtCommentDescUPDAtE.Visible = true;
                updateButton.Visible = true;
                labelCommentDescUpdate.Visible = true;
            }
            else
            {
                commentListForUpdation.Visible = true;
                SelectButton.Visible = true;
                txtCommentDescUPDAtE.Visible = false;
                updateButton.Visible = false;
                labelCommentDescUpdate.Visible = false;
            }
        }
        private void selectCommentsButtonClicked(object sender, EventArgs e)
        {
            try {
                //check if the comment is selected or not
                if (commentListForUpdation.SelectedRows.Count == 0 || commentListForUpdation.SelectedRows[0].IsNewRow)
                {
                    MessageBox.Show("Please select a comment to update");
                    return;
                }
                int commentID = Convert.ToInt32(commentListForUpdation.SelectedRows[0].Cells["commentID"].Value);

                //get the comment data from the database
                cn.Open();
                cm = new SqlCommand("select * from Comment where commentID=@CommentID", cn);
                cm.Parameters.AddWithValue("@CommentID", commentID);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txtCommentDescUPDAtE.Text = dr["commentDescription"].ToString();
                    toggleUpdateCommentTab();
                }
                dr.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateCommentButtonClicked(object sender, EventArgs e)
        {
            try
            {
            string CommentDesc = txtCommentDescUPDAtE.Text;
            string CommentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //store the comment id from the selected row
            int commentID = Convert.ToInt32(commentListForUpdation.SelectedRows[0].Cells["commentID"].Value);
            //handle null value with messagebox
            if (CommentDesc == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            
                cn.Open();
                cm = new SqlCommand("update Comment set commentDescription=@CommentDesc, commentDate=@CommentDate where commentID=@CommentID", cn);
                cm.Parameters.AddWithValue("@CommentDesc", CommentDesc);
                cm.Parameters.AddWithValue("@CommentDate", CommentDate);
                cm.Parameters.AddWithValue("@CommentID", commentID);
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Comment Updated Successfully with ID: ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadCommentsToDeleteOrUpdate(sender, e);
                toggleUpdateCommentTab();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }
    }
}
