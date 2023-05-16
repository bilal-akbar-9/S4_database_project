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

        string username;
        public TeacherPanel(string teacherUsername)
        {
            InitializeComponent();
            this.username=teacherUsername;
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void TeacherPanel_Load(object sender, EventArgs e)
        {

        }

        private void CreateAssignment_Click(object sender, EventArgs e)
        {
            string AssignmentDesc = txtAssDesc.Text;
            string AssignmentDueDate = txtAssDueDate.Text;
            string AssingmentFile = txtAssignmetFile.Text;
            string AssignmentPoints = txtAssPoints.Text;


            try {
                cn.Open();
                cm = new SqlCommand("insert into Assignment (assignmentDescription,assignmentDueDate,assignmentPoints,assignmentFile,username_Teacher) values (@AssignmentDesc,@AssignmentDueDate,@AssingmentFile,@AssignmentPoints,@username)", cn);
                cm.Parameters.AddWithValue("@AssignmentDesc", AssignmentDesc);
                cm.Parameters.AddWithValue("@AssignmentDueDate", AssignmentDueDate);
                cm.Parameters.AddWithValue("@AssingmentFile", AssingmentFile);
                cm.Parameters.AddWithValue("@AssignmentPoints", AssignmentPoints);
                cm.Parameters.AddWithValue("@username", username);
                cm.ExecuteNonQuery();
                cn.Close();
                string AssignmentID = dr["assignmentID"].ToString();
                MessageBox.Show("Assignment Added Successfully with ID: " + AssignmentID, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAssDesc.Clear();
                txtAssDueDate.Clear();
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

        private void txtAssDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetDeadline_Click(object sender, EventArgs e)
        {
            string AssignmentDueDate = txtAssDue.Text;
            string AssignmentID = txtAssNo.Text;

            try
            {
                cn.Open();
                cm = new SqlCommand("update Assignment set assignmentDueDate=@AssignmentDueDate where assignmentID=@AssignmentID", cn);
                cm.Parameters.AddWithValue("@AssignmentDueDate", AssignmentDueDate);
                cm.Parameters.AddWithValue("@AssignmentID", AssignmentID);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Assignment Deadline Updated Successfully");
                txtAssDue.Clear();
                txtAssNo.Clear();
                txtAssDue.Focus();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void viewProgressButton_Clicked(object sender, EventArgs e)
        {
            string StudentID = txtStudentsID.Text;
            string AssignmentNumber = txtAssNo2.Text;

            // get total count of Assignment submitted in AssignmentSubmission
            try{
                cn.Open();
                cm = new SqlCommand("select count(*) from Submissions where assignmentID=@AssignmentNumber", cn);
                cm.Parameters.AddWithValue("@AssignmentNumber", AssignmentNumber);
                int count = Convert.ToInt32(cm.ExecuteScalar());
                cn.Close();

                MessageBox.Show("Total Assignment Submitted: " + count.ToString());
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

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

        private void label1_Click_6(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

    }
}
