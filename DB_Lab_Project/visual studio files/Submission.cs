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
    public partial class Submission : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        String studentusername;
        String assignmentID;
        String submissionPoints;
        String assignmentTitleSubmissions;

        String assignmentDescription;

        String DueDate; //studentName, studentusername, classroomID, teacherName, teacherUsername
        String studentName;
        String classroomID;
        String teacherName;
        String teacherUsername;


        public Submission()
        {
            InitializeComponent();
        }

        public Submission(String studentusername, String assignmentID, String submissionPoints, String assignmentTitleSubmission, String assignmentDescription, String DueDate, String studentName, String classroomID, String teacherName, String teacherUsername)
        {
            InitializeComponent();
            this.studentusername = studentusername;
            this.assignmentID = assignmentID;
            this.submissionPoints = submissionPoints;
            this.assignmentTitleSubmissions = assignmentTitleSubmission;
            this.assignmentDescription = assignmentDescription;
            this.DueDate = DueDate;
            this.studentName = studentName;
            this.classroomID = classroomID;
            this.teacherName = teacherName;
            this.teacherUsername = teacherUsername;
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void Submission_Load(object sender, EventArgs e)
        {
            txtAssTitleSUbmission.Text = assignmentTitleSubmissions;
            txtAssDescsubmission.Text = assignmentDescription;
            dueDateLabelsubmission.Text = DueDate;
            //show the submission if the student has submitted before
            cn.Open();
            cm = new SqlCommand("SELECT submissionFile FROM Submissions WHERE studentUsername = @studentusername AND assignmentID = @assignmentID", cn);
            cm.Parameters.AddWithValue("@studentusername", studentusername);
            cm.Parameters.AddWithValue("@assignmentID", assignmentID);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                textBoxsubmission.Text = dr["submissionFile"].ToString();
                SubmitButton.Visible = false;
            }
            else
            {
                textBoxsubmission.Text = "";
                SubmitButton.Visible = true;
            }
            dr.Close();
            cn.Close();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (textBoxsubmission.Text == "")
            {
                MessageBox.Show("Please enter a submission");
            }
            else
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string textBoxsubmissionnew = textBoxsubmission.Text;
                cn.Open();
                string submissionPointsEmpty = "";
                cm = new SqlCommand("INSERT INTO Submissions (studentUsername, assignmentID, submissionFile, submissionDate, submissionPoints) VALUES (@studentUsername, @assignmentID, @textBoxsubmissionnew, @date, @submissionPointsEmpty)", cn);
                cm.Parameters.AddWithValue("@studentUsername", studentusername);
                cm.Parameters.AddWithValue("@assignmentID", assignmentID);
                cm.Parameters.AddWithValue("@date", date);
                cm.Parameters.AddWithValue("@submissionPointsEmpty", submissionPointsEmpty);
                cm.Parameters.AddWithValue("@textBoxsubmissionnew", textBoxsubmissionnew);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Submission has been added");

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentAssignments studentAssignments = new studentAssignments(studentName, studentusername, classroomID, teacherName, teacherUsername);
            studentAssignments.Show();
            
        }
    }
}
