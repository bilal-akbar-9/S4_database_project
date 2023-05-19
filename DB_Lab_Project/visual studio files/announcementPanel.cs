using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApplication;
using System.Data.SqlClient;

namespace intial_form_1_
{
    public partial class announcementPanel : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        SqlDataAdapter adapter;
        string teacherUserName;
        string classroomID;
        String teacherName;
        String announcementID;
        public announcementPanel()
        {
            InitializeComponent();
        }
        public announcementPanel(string teacherName, string teacherUsername, string classroomID, string announcementID)
        {
            InitializeComponent();
            this.teacherUserName = teacherUsername;
            this.classroomID = classroomID;
            this.teacherName = teacherName;
            this.announcementID = announcementID;
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;

        }
        private void announcementPanel_Load(object sender, EventArgs e)
        {
            //get the announcementData from the database
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from announcement where announcementID = @announcementID", cn);
                cm.Parameters.AddWithValue("@announcementID", this.announcementID);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txtAnnounceTitle.Text = dr["announcementTitle"].ToString();
                    txtAnnounceDesc.Text = dr["announcementDescription"].ToString();
                    txtAnnounceFile.Text = dr["announcementFile"].ToString();
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
                if (commentTABS.SelectedTab.Name == "deleteCommentTab")
                {
                    DataTable dt = new DataTable();
                    cn.Open();
                    cm = new SqlCommand("select * from announcementComment where announcementID=@announcementID", cn);
                    cm.Parameters.AddWithValue("@announcementID", this.announcementID);
                    int commentCount = Convert.ToInt32(cm.ExecuteScalar());
                    //if there is no comment for this announcement, then label will be shown to the user, else the grid will be shown
                    if (commentCount == 0)
                    {
                        noCommentToDelete_Label.Visible = true;
                        noCommentToDelete_Label.Text = "No comments for this announcement";
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
                else if (commentTABS.SelectedTab.Name == "updateCommentTab")
                {
                    DataTable dt = new DataTable();
                    cn.Open();
                    cm = new SqlCommand("select * from announcementComment where announcementID=@announcementID", cn);
                    cm.Parameters.AddWithValue("@announcementID", announcementID);
                    int commentCount = Convert.ToInt32(cm.ExecuteScalar());
                    //if there is no comment for this announcement, then label will be shown to the user, else the grid will be shown
                    if (commentCount == 0)
                    {
                        noCommentToUpdateLabel.Visible = true;
                        noCommentToUpdateLabel.Text = "No Comments for this announcement";
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
                else if (commentTABS.SelectedTab.Name == "viewCommentsTab")
                {
                    //if no row is selected then commentslist
                    DataTable dt = new DataTable();
                    cn.Open();
                    cm = new SqlCommand("select * from announcementComment where announcementID=@announcementID", cn);
                    cm.Parameters.AddWithValue("@announcementID", announcementID);
                    int commentCount = Convert.ToInt32(cm.ExecuteScalar());
                    //if there is no comment for this announcement, then label will be shown to the user, else the grid will be shown
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
                        int commentID = Convert.ToInt32(row.Cells["announcementCommentID"].Value);
                        cm = new SqlCommand("delete from announcementComment where announcementCommentID=@announcementCommentID", cn);
                        cm.Parameters.AddWithValue("@announcementCommentID", commentID);
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
                    noCommentToDelete_Label.Text = "No comments for this announcement";
                    noCommentToDelete_Label.ForeColor = Color.Red;
                }
            }
        }

        private void selectCommentsButtonClicked(object sender, EventArgs e)
        {
            try
            {
                //get the comment id from the selected row
                int commentID = Convert.ToInt32(commentListForUpdation.SelectedRows[0].Cells["announcementCommentID"].Value);

                //get the comment data from the database
                cn.Open();
                cm = new SqlCommand("select * from announcementComment where announcementCommentID=@announcementCommentID", cn);
                cm.Parameters.AddWithValue("@announcementCommentID", commentID);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txtCommentDescUpdate.Text = dr["commentDescription"].ToString();
                    toggleUpdateCommentTab();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void toggleUpdateCommentTab()
        {
            if (commentListForUpdation.Visible == true)
            {
                commentListForUpdation.Visible = false;
                SelectButton.Visible = false;
                txtCommentDescUpdate.Visible = true;
                updateButton.Visible = true;
                labelCommentDescUpdate.Visible = true;
            }
            else
            {
                commentListForUpdation.Visible = true;
                SelectButton.Visible = true;
                txtCommentDescUpdate.Visible = false;
                updateButton.Visible = false;
                labelCommentDescUpdate.Visible = false;
            }
        }

        private void updateCommentButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string CommentDesc = txtCommentDescUpdate.Text;
                string CommentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //store the comment id from the selected row
                int commentID = Convert.ToInt32(commentListForUpdation.SelectedRows[0].Cells["announcementCommentID"].Value);
                //handle null value with messagebox
                if (CommentDesc == "")
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

                cn.Open();
                cm = new SqlCommand("update announcementComment set commentDescription=@CommentDesc, commentDate=@CommentDate where announcementCommentID=@announcementCommentID", cn);
                cm.Parameters.AddWithValue("@CommentDesc", CommentDesc);
                cm.Parameters.AddWithValue("@CommentDate", CommentDate);
                cm.Parameters.AddWithValue("@announcementCommentID", commentID);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Comment Updated Successfully ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toggleUpdateCommentTab();
                loadCommentsToDeleteOrUpdate(sender, e);
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
            string CommentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                cn.Open();
                cm = new SqlCommand("insert into announcementComment (commentDescription,commentDate,announcementID) values (@CommentDesc,@CommentDate,@announcementID)", cn);
                cm.Parameters.AddWithValue("@CommentDesc", CommentDesc);
                cm.Parameters.AddWithValue("@CommentDate", CommentDate);
                cm.Parameters.AddWithValue("@announcementID", this.announcementID);
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
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Announcement announcement = new Announcement(teacherName, teacherUserName, classroomID);
            announcement.Show();
        }
    }
}
