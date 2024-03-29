﻿using MyApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intial_form_1_
{
    public partial class studentAssignments : Form
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

        String studentName;
        String Studentusername;
        String studentID;


        String assignmentDescription;

        String assignmentTitleSubmission;

        public studentAssignments()
        {
            InitializeComponent();
        }

        public studentAssignments(String studentName, String studentusername, String classroomID, String teacherName, String teacherUsername )
        {
            InitializeComponent();
            this.studentName = studentName;
            this.Studentusername = studentusername;
            this.studentID = studentID;
            this.teacherName = teacherName;
            this.teacherUsername = teacherUsername;
            this.classroomID = classroomID;
            cn = new SqlConnection(dbcon.MyConnection());
        }

          private Color RandomColor(int announcementCounter)
        {
            //the colors: 138, 197, 255 ,, 209, 236, 241 ,, 233, 233, 233
            if (announcementCounter > 3)
                announcementCounter = 1;
            if (announcementCounter == 1)
                return Color.FromArgb(138, 197, 255);
            else if (announcementCounter == 2)
                return Color.FromArgb(209, 236, 241);
            else
                return Color.FromArgb(233, 233, 233);
        }

        private void loadAssignmentAtStartPageStudentClas(object sender, EventArgs e)
        {
            flowLayoutStudentAssignment.Controls.Clear();
            flowLayoutStudentAssignment.Controls.Add(new Label());
            flowLayoutStudentAssignment.Visible = true;

            try
            {
                cn.Open();
                // cm = new SqlCommand("select * from Assignment where classroomID = @classroomID and studentusername in (select studentusername from ClassroomAndStudent where classroomID = @classroomID and studentusername = @Studentusername)", cn);
                cm = new SqlCommand("select * from Assignment where classroomID = @classroomID and classroomID in (select classroomID from ClassroomAndStudent where classroomID = @classroomID and studentusername = @Studentusername)", cn);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                cm.Parameters.AddWithValue("@studentusername", Studentusername);
                dr = cm.ExecuteReader();
                if (!dr.HasRows)
                {
                    noClassLabelStu.Visible = true;
                    noClassLabelStu.Text = "No Assignments Found";
                }
                else
                {
                    noClassLabelStu.Visible = false;
                    int assignmentCounter = 1;

                    while (dr.Read())
                    {
                        teacherNameStudentLabel.Text = teacherName;

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
                        flowLayoutStudentAssignment.Controls.Add(panel);

                        string assignmentDescriptionString = assignmentDescription.Text;
                        string assignmentTitleString = assignmentTitle.Text;
                        string DueDateString = DueDate.Text;
                        string assignmentIDString = panel.Name;
                        string submissionPoints = dr["assignmentPoints"].ToString();
                        
                        panel.Click += (s, ev) =>
                        {
                            this.Hide();
                            Submission submission = new Submission(Studentusername,assignmentIDString,submissionPoints,assignmentTitleString,assignmentDescriptionString,DueDateString,studentName,classroomID,teacherName,teacherUsername);
                            submission.Show();
                        };
                    }
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class classForm = new Class(studentName, Studentusername, classroomID, 1);
            classForm.Show();
        }

        private void flowLayoutStudentAssignment_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
