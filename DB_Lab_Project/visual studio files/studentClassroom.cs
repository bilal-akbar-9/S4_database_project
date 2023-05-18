using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyApplication;

namespace intial_form_1_
{
    public partial class studentClassroom : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string studentName;
        string studentUsername;
        public studentClassroom(string studentName, string studentUsername)
        {
            InitializeComponent();
            this.studentName = studentName;
            this.studentUsername = studentUsername;
            cn = new SqlConnection(dbcon.MyConnection());

        }

        private void enrollRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (enrollRadioButton.Checked)
            {
                enrollUnenrollButton.Text = "Enroll";
                enrollUnenrollButton.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.HotTrack);
            }
        }
        private void unenrollRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (unenrollRadioButton.Checked)
            {
                enrollUnenrollButton.Text = "Unenroll";
                enrollUnenrollButton.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Red);
            }
        }

        private void enrollUnenrollButton_Click(object sender, EventArgs e)
        {

            if (enrollRadioButton.Checked)
            {
                //enroll
                try
                {
                    //Taking the classroomID from the Classroom table
                    cn.Open();
                    cm = new SqlCommand("select * from Classroom where classroomCode = @classroomCode", cn);
                    cm.Parameters.AddWithValue("@classroomCode", classCodeField.Text);
                    dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        //Reading and closing the reader
                        dr.Read();
                        int classroomID = int.Parse(dr["classroomID"].ToString());
                        string classroomName = dr["classroomName"].ToString();
                        //Confirmation
                        DialogResult dialogResult2 = MessageBox.Show("Are you sure you want to enroll in " + classroomName + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        dr.Close();
                        if (dialogResult2 == DialogResult.No)
                            return;
                        //insert into ClassroomAndStudent
                        cm = new SqlCommand("insert into ClassroomAndStudent values(@studentusername, @classroomID)", cn);
                        cm.Parameters.AddWithValue("@studentusername", studentUsername);
                        cm.Parameters.AddWithValue("@classroomID", classroomID);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        //The MessageBox
                        MessageBox.Show("Enrolled Successfully");
                        studentClassroom_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }

            }
            else if (unenrollRadioButton.Checked)
            {
                //unenroll
                //Confirmation 
                try
                {
                    //Taking the classroomID from the Classroom table
                    cn.Open();
                    cm = new SqlCommand("select * from Classroom where classroomCode = @classroomCode", cn);
                    cm.Parameters.AddWithValue("@classroomCode", classCodeField.Text);
                    dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        //Reading and closing the reader
                        dr.Read();
                        int classroomID = int.Parse(dr["classroomID"].ToString());
                        string classroomName = dr["classroomName"].ToString();
                        //Confirmation
                        DialogResult dialogResult2 = MessageBox.Show("Are you sure you want to unenroll from " + classroomName + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        dr.Close();
                        //delete from ClassroomAndStudent
                        cm = new SqlCommand("delete from ClassroomAndStudent where studentusername = @studentusername and classroomID = @classroomID", cn);
                        cm.Parameters.AddWithValue("@studentusername", studentUsername);
                        cm.Parameters.AddWithValue("@classroomID", classroomID);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        //The MessageBox
                        MessageBox.Show("Unenrolled Successfully");
                        studentClassroom_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private Color RandomColor(int classCounter)
        {
            //the colors: 138, 197, 255 ,, 209, 236, 241 ,, 233, 233, 233
            if (classCounter > 3)
                classCounter = 1;
            if (classCounter == 0)
                return Color.FromArgb(138, 197, 255);
            else if (classCounter == 1)
                return Color.FromArgb(209, 236, 241);
            else
                return Color.FromArgb(233, 233, 233);
        }
        private void studentClassroom_Load(object sender, EventArgs e)
        {
            String teacherName;
            String teacherUsername;
            String classroomID;


            //Clear the flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();
            try
            {
                studentNameLabel.Text = "Welcome " + studentName + "!";
                cn.Open();
                cm = new SqlCommand("select * from ClassroomAndStudent join Classroom on ClassroomAndStudent.classroomID = Classroom.classroomID where studentusername = @studentusername", cn);
                cm.Parameters.AddWithValue("@studentusername", studentUsername);
                dr = cm.ExecuteReader();
                dr.Read();
                if (!dr.HasRows)
                {
                    noClassLabel.Text = "You are not enrolled in any class";
                    noClassLabel.Visible = true;
                }
                else
                {
                    noClassLabel.Visible = false;
                    flowLayoutPanel1.Visible = true;
                    int classCounter = 1;
                    do
                    {
                        //Create a panel
                        Panel panel = new Panel();
                        panel.Size = new Size(200, 100);
                        panel.BackColor = RandomColor(classCounter);
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Margin = new Padding(10, 10, 10, 10);
                        panel.Padding = new Padding(10, 10, 10, 10);
                        panel.Name = dr["classroomID"].ToString();
                        //ClassName Label
                        Label className = new Label();
                        className.Text = dr["classroomName"].ToString();
                        className.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        className.AutoSize = true;
                        className.Location = new Point(10, 10);
                        panel.Controls.Add(className);
                        //ClassCode Label
                        Label classCode = new Label();
                        classCode.Text = dr["classroomCode"].ToString();
                        classCode.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        classCode.AutoSize = true;
                        classCode.Location = new Point(10, 30);
                        panel.Controls.Add(classCode);
                        flowLayoutPanel1.Controls.Add(panel);

                        //Click event
                        panel.Click += (s, ev) =>
                        {
                            //Open the classroom
                            this.Hide();
                            Class classForm = new Class(studentName, studentUsername, panel.Name,1);
                            classForm.Show();
                        };
                    } while (dr.Read());

                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentClassroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
