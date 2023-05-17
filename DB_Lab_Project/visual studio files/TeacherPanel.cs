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









        // Global variable to store the selected assignment 
       

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class classForm = new Class(teacherName, teacherUserName, classroomID);
            classForm.Show();
        }

        private void assignmentsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifyDescBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void assignmentsListForModification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
