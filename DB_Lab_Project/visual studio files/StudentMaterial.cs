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
    public partial class StudentMaterial : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        String teacherName;
        String teacherUsername;
        String classroomID;
        SqlDataAdapter adapter;
        String MaterialID;

        String studentName;
        String Studentusername;
        String studentID;
        String materialDescription;
        String materialTitle;
        String materialType;
        public StudentMaterial()
        {
            InitializeComponent();
        }

        public StudentMaterial(String studentName, String studentusername, String classroomID, String teacherName, String teacherUsername )
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

        private void loadMaterialAtStartPageStudentClass(object sender, EventArgs e)
        {
            flowLayoutStudentMaterial.Controls.Clear();
            flowLayoutStudentMaterial.Controls.Add(new Label());
            flowLayoutStudentMaterial.Visible = true;

            try
            {
                cn.Open();
                // cm = new SqlCommand("select * from Material where classroomID = @classroomID and studentusername in (select studentusername from ClassroomAndStudent where classroomID = @classroomID and studentusername = @Studentusername)", cn);
                cm = new SqlCommand("select * from Material where username_Teacher = @teacherUsername and classroomID = @classroomID and classroomID in (select classroomID from ClassroomAndStudent where classroomID = @classroomID and studentusername = @Studentusername)", cn);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                cm.Parameters.AddWithValue("@studentusername", Studentusername);
                cm.Parameters.AddWithValue("@teacherUsername", teacherUsername);
                dr = cm.ExecuteReader();
                if (!dr.HasRows)
                {
                    stdNoMaterialLabel.Visible = true;
                    stdNoMaterialLabel.Text = "No Materials Found";
                }
                else
                {
                    stdNoMaterialLabel.Visible = false;
                    int MaterialCounter = 1;

                    while (dr.Read())
                    {
                        stdNamelabel.Text = teacherName;

                        Panel panel = new Panel();
                        panel.Size = new Size(691, 100);
                        panel.BackColor = RandomColor(MaterialCounter);
                        MaterialCounter++;
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Name = dr["MaterialID"].ToString();

                        //MaterialID Label
                        Label MaterialTitle = new Label();
                        MaterialTitle.Text = dr["MaterialTitle"].ToString();
                        MaterialTitle.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        MaterialTitle.Location = new Point(10, 10);
                        MaterialTitle.Size = new Size(300, 20);

                        //MaterialDescription Label
                        Label MaterialDescription = new Label();
                        MaterialDescription.Text = dr["MaterialDescription"].ToString();
                        MaterialDescription.Font = new Font("HP Simplified Hans", 12);
                        MaterialDescription.AutoSize = true;
                        MaterialDescription.Location = new Point(10, 40);

                        // Label DueDate = new Label();
                        // DueDate.Text = "Due Date: " + dr["MaterialDueDate"].ToString();
                        // DueDate.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        // DueDate.AutoSize = true;
                        // //DueDate should be at the bottom right of the panel
                        // DueDate.Location = new Point(400, 60);

                        panel.Controls.Add(MaterialDescription);
                        panel.Controls.Add(MaterialTitle);
                        flowLayoutStudentMaterial.Controls.Add(panel);

                        string MaterialDescriptionString = MaterialDescription.Text;
                        string MaterialTitleString = MaterialTitle.Text;
                        // string DueDateString = DueDate.Text;
                        string MaterialIDString = panel.Name;
                        // string submissionPoints = dr["MaterialPoints"].ToString();
                        
                        // panel.Click += (s, ev) =>
                        // {
                        //     this.Hide();
                        //     Submission submission = new Submission(Studentusername,MaterialIDString,submissionPoints,MaterialTitleString,MaterialDescriptionString,DueDateString);
                        //     submission.Show();
                        // };
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
    }
}
