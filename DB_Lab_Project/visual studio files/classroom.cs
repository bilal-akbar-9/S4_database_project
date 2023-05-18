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

    public partial class classroom : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        String teacherUsername;
        String teacherName;
        public classroom()
        {
            InitializeComponent();
        }
        public classroom(String teacherName, String teacherUsername)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.teacherName = teacherName;
            this.teacherUsername = teacherUsername;

        }
        private void classCode_GotFocus(object sender, EventArgs e)
        {
            if (classCodeField1.Text == "Enter class code here...")
            {
                classCodeField1.ForeColor = SystemColors.WindowText;
                classCodeField1.Text = "";
            }
        }

        private void classCode_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(classCodeField1.Text))
            {
                classCodeField1.ForeColor = Color.Gray;
                classCodeField1.Text = "Enter class code here...";
            }
        }
        //create a random picker color function
        private Color RandomColor(int classCounter)
        {
            //the colors: 138, 197, 255 ,, 209, 236, 241 ,, 233, 233, 233
            if (classCounter > 3)
                classCounter = 1;
            if (classCounter == 1)
                return Color.FromArgb(138, 197, 255);
            else if (classCounter == 2)
                return Color.FromArgb(209, 236, 241);
            else
                return Color.FromArgb(233, 233, 233);
        }
        private void classroom_Load(object sender, EventArgs e)
        {
            //Clear the flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();
            //Check if the teacher is associated to any class
            try
            {
                teacherNameLabel.Text = "Welcome " + teacherName + "!";
                cn.Open();
                cm = new SqlCommand("select * from Classroom where teacherUsername = @teacherUsername", cn);
                cm.Parameters.AddWithValue("@teacherUsername", teacherUsername);
                dr = cm.ExecuteReader();
                dr.Read();
                // if the teacher is not associated to any class, then change the noClassLabel to "You are not associated to any class"
                if (!dr.HasRows)
                {
                    noClassLabel.Visible = true;
                    noClassLabel.Text = "You are not associated to any class";
                }
                else
                {
                    noClassLabel.Visible = false;
                    flowLayoutPanel1.Visible = true;
                    int classCounter = 1;
                    do
                    {
                        Panel panel = new Panel();
                        panel.Size = new Size(200, 100);
                        panel.BackColor = RandomColor(classCounter);
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Margin = new Padding(10, 10, 10, 10);
                        panel.Padding = new Padding(10, 10, 10, 10);
                        panel.Name = dr["classroomID"].ToString();
                        panel.AutoScroll = true;
                        panel.AutoSize = false;
                        //ClassName Label
                        Label className = new Label();
                        className.Text = dr["classroomName"].ToString();
                        className.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        className.AutoSize = true;
                        className.Location = new Point(10, 10);
                        className.Size = new Size(180, 50);
                        className.AutoEllipsis = true;
                        className.AutoSize = true;
                        panel.Controls.Add(className);
                        //ClassCode Label
                        Label classCode = new Label();
                        classCode.Text = dr["classroomCode"].ToString();
                        classCode.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        classCode.Location = new Point(10, 30);
                        classCode.Size = new Size(180, 50);
                        classCode.AutoSize = true;
                        panel.Controls.Add(classCode);
                        flowLayoutPanel1.Controls.Add(panel);
                        //create new form on a click of a class inside a panel and pass the id of class as a parameter
                        panel.Click += (s, ev) =>
                        {
                            this.Hide();
                            Class teacherClassroom = new Class(teacherName, teacherUsername, panel.Name);
                            teacherClassroom.Show();
                        };
                        classCounter++;
                        
                    } while (dr.Read());

                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void classroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //add new class with the className and classCode
            try
            {
                cn.Open();
                cm = new SqlCommand("insert into Classroom (classroomName, classroomCode, teacherUsername) values (@classroomName, @classroomCode, @teacherUsername)", cn);
                cm.Parameters.AddWithValue("@classroomName", classNameField1.Text);
                cm.Parameters.AddWithValue("@classroomCode", classCodeField1.Text);
                cm.Parameters.AddWithValue("@teacherUsername", teacherUsername);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Classroom added successfully");
                classroom_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            //change the class Name using classCode
            try
            {
                cn.Open();
                cm = new SqlCommand("update Classroom set classroomName = @classroomName where classroomCode = @classroomCode", cn);
                cm.Parameters.AddWithValue("@classroomName", classNameField2.Text);
                cm.Parameters.AddWithValue("@classroomCode", classCodeField1.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Classroom updated successfully");
                classroom_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            //remove the class using classCode
            try
            {
                cn.Open();
                cm = new SqlCommand("delete from Classroom where classroomCode = @classroomCode", cn);
                cm.Parameters.AddWithValue("@classroomCode", classCodeField3.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Classroom removed successfully");
                classroom_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teacherNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
