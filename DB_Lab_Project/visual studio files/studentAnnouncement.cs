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
    public partial class studentAnnouncement : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        String classroomID;
        SqlDataAdapter adapter;
        String assignmentID;
        String studentName;
        String studentUsername;
        String studentID;

        public studentAnnouncement()
        {
            InitializeComponent();
        }
        public studentAnnouncement(String studentName, String studentUsername, String classroomID)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.studentName = studentName;
            this.studentUsername = studentUsername;
            this.classroomID = classroomID;
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
        private void studentAnnouncement_Load(object sender, EventArgs e)
        {
            flowLayoutAnnouncement.Controls.Clear();
            flowLayoutAnnouncement.Controls.Add(new Label());
            flowLayoutAnnouncement.Visible = true;
            try

            {

                cn.Open();
                cm = new SqlCommand("select * from Announcement where classroomID in (select classroomID from ClassroomAndStudent where studentusername = @studentUsername)", cn);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                cm.Parameters.AddWithValue("@studentUsername", studentUsername);
                dr = cm.ExecuteReader();
                if (!dr.HasRows)
                {
                    noAnnouncementLabel.Visible = true;
                    noAnnouncementLabel.Text = "No Announcement Found";
                }
                else
                {
                    noAnnouncementLabel.Visible = false;
                    int announcementCounter = 1;
                    while (dr.Read())
                    {
                        studentNameLabel.Text = studentName;
                        //Panel
                        Panel panel = new Panel();
                        panel.Size = new Size(691, 100);
                        panel.BackColor = RandomColor(announcementCounter);
                        announcementCounter++;
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Name = dr["announcementID"].ToString();

                        //assignmentID Label
                        Label announcementTitle = new Label();
                        announcementTitle.Text = dr["announcementTitle"].ToString();
                        announcementTitle.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        announcementTitle.Location = new Point(10, 10);
                        announcementTitle.Size = new Size(300, 20);

                        //announcementDescription Label
                        Label announcementDescription = new Label();
                        announcementDescription.Text = dr["announcementDescription"].ToString();
                        announcementDescription.Font = new Font("HP Simplified Hans", 12);
                        announcementDescription.AutoSize = true;
                        announcementDescription.Location = new Point(10, 40);

                        //announcementDate Label 
                        Label announcementDate = new Label();
                        announcementDate.Text = dr["announcementDate"].ToString();
                        announcementDate.Font = new Font("HP Simplified Hans", 12, FontStyle.Bold);
                        announcementDate.AutoSize = true;
                        //announcementDate should be at the bottom right of the panel
                        announcementDate.Location = new Point(430, 60);

                        panel.Controls.Add(announcementDescription);
                        panel.Controls.Add(announcementTitle);
                        panel.Controls.Add(announcementDate);
                        flowLayoutAnnouncement.Controls.Add(panel);
                        panel.Click += (s, ev) =>
                        {
                            this.Hide();
                            announcementPanel announcementPanel = new announcementPanel(studentName, studentUsername, classroomID, panel.Name, true);
                            announcementPanel.Show();
                        };
                    }
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class classForm = new Class(studentName, studentUsername, classroomID, 1);
            classForm.Show();
        }
    }
}
