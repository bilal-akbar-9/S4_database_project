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
    public partial class Announcement : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        String teacherName;
        String teacherUsername;
        String classroomID;
        SqlDataAdapter adapter;
        String announcementID;

        public Announcement()
        {
            InitializeComponent();
        }
        public Announcement(String teacherName, String teacherUsername, String classroomID)
        {
            InitializeComponent();
            this.teacherName = teacherName;
            this.teacherUsername = teacherUsername;
            this.classroomID = classroomID;
        }
        private Color RandomColor(int assignmentCounter)
        {
            //the colors: 138, 197, 255 ,, 209, 236, 241 ,, 233, 233, 233
            if (assignmentCounter > 3)
                assignmentCounter = 1;
            if (assignmentCounter == 1)
                return Color.FromArgb(138, 197, 255);
            else if (assignmentCounter == 2)
                return Color.FromArgb(209, 236, 241);
            else
                return Color.FromArgb(233, 233, 233);
        }
        private void loadAnnouncementsAtStartPage(object sender, EventArgs e)
        {
            flowLayoutAnnouncement.Controls.Clear();
            flowLayoutAnnouncement.Controls.Add(new Label());
            flowLayoutAnnouncement.Visible = true;
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from Announcement where classroomID = @classroomID and  username_Teacher = @teacherUsername", cn);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                cm.Parameters.AddWithValue("@teacherUsername", teacherUsername);
                dr = cm.ExecuteReader();
                if (!dr.HasRows)
                {
                    noClassLabel.Visible = true;
                    noClassLabel.Text = "No Announcement Found";
                }
                else
                {
                    noClassLabel.Visible = false;
                    int assignmentCounter = 1;
                    while (dr.Read())
                    {
                        teacherNameLabel.Text = teacherName;
                        //Panel
                        Panel panel = new Panel();
                        panel.Size = new Size(691, 100);
                        panel.BackColor = RandomColor(assignmentCounter);
                        assignmentCounter++;
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
                        announcementDate.Location = new Point(400, 60);

                        panel.Controls.Add(announcementDescription);
                        panel.Controls.Add(announcementTitle);
                        panel.Controls.Add(announcementDate);
                        flowLayoutAnnouncement.Controls.Add(panel);
                        panel.Click += (s, ev) =>
                        {
                            this.Hide();
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
            Class classPage = new Class(teacherName, teacherUsername, classroomID);
        }
        private void CreateAnnouncement_Click(object sender, EventArgs e)
        {
            string announcementTitle = txtAnnounceTitle.Text;
            string announcementDescription = txtAnnounceDesc.Text;
            string announcementDate = DateTime.Now.ToString("yyyy-MM-dd");
            string announcementFile = txtAnnounceFile.Text;
            try
            {
                cn.Open();
                cm = new SqlCommand("insert into Announcement(announcementTitle, announcementDescription, announcementDate, username_Teacher, classroomID) values(@announcementTitle, @announcementDescription, @announcementDate, @username_Teacher, @classroomID)", cn);
                cm.Parameters.AddWithValue("@announcementTitle", announcementTitle);
                cm.Parameters.AddWithValue("@announcementDescription", announcementDescription);
                cm.Parameters.AddWithValue("@announcementDate", announcementDate);
                cm.Parameters.AddWithValue("@username_Teacher", teacherUsername);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                cm.ExecuteNonQuery();
                cn.Close(); 
                MessageBox.Show("Announcement Added Successfully");
                txtAnnounceTitle.Clear();
                txtAnnounceDesc.Clear();
                txtAnnounceFile.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get the assignment ID from the selected row
                int announcementID = Convert.ToInt32(announcementListForModification.SelectedRows[0].Cells["announcementID"].Value);
                this.announcementID = announcementID.ToString();
                //fetch the data from the database using the assignment ID
                cn.Open();
                cm = new SqlCommand("select * from Announcement where announcementID = @announcementID", cn);
                cm.Parameters.AddWithValue("@announcementID", announcementID);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    //display the data in the textboxes
                    txtAnnounceTitle.Text = dr["announcementTitle"].ToString();
                    txtAnnounceDesc.Text = dr["announcementDescription"].ToString();
                    txtAnnounceFile.Text = dr["announcementFile"].ToString();
                }
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
             try
            {
                // Retrieve the modified values from the controls or fields
                string announcementTitle = modifyTitleBox.Text;
                string announcementDescription = modifyDescBox.Text;
                string announcementFile = modifyAnnouncementFileBox.Text;
                //Validate assignmentTitle and prompt user if it's empty
                if (string.IsNullOrEmpty(announcementTitle))
                {
                    MessageBox.Show("Please enter a value for Assignment Title.");
                    return; // Stop further execution
                }
                // Validate assignmentDescription and prompt user if it's empty
                if (string.IsNullOrEmpty(announcementDescription))
                {
                    MessageBox.Show("Please enter a value for Assignment Description.");
                    return; // Stop further execution
                }

                //if file is empty, set it to null
                if (string.IsNullOrEmpty(announcementFile))
                {
                    announcementFile = null;
                    cm.Parameters.AddWithValue("@assignmentFile", DBNull.Value);
                }

                // Execute the necessary SQL query to update the record in the database
                cn.Open();
                //if data is empty, set it to null run query with dat
                
                cm = new SqlCommand("update Announcement set announcementTitle = @announcementTitle, announcementDescription = @announcementDescription, announcementFile = @announcementFile where announcementID = @announcementID", cn);
                cm.Parameters.AddWithValue("@assignmentDescription", announcementTitle);
                cm.Parameters.AddWithValue("@assignmentFile", announcementFile);
                cm.Parameters.AddWithValue("@assignmentTitle", announcementTitle);
                cm.Parameters.AddWithValue("@announcementID", this.announcementID);
                cm.ExecuteNonQuery();
                cn.Close();
                // Display a success message or perform any other action upon successful modification
                MessageBox.Show("Assignment modified successfully.");
                // AssignmentloadForUpdateDelete(sender, e);
                toggleUpdateAnnouncementTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         private void toggleUpdateAnnouncementTab(){
            
            if (announcementListForModification.Visible == true){
            //make the assignmentsList invisible
            announcementListForModification.Visible = false;
            //hide the selectButton
            selectButton.Visible = false;
            //make all textboxes visible
            modifyDescBox.Visible = true;
            modifyAnnouncementFileBox.Visible = true;
            modifyTitleBox.Visible = true;
            //make all labels visible
            label14.Visible = true;
            label13.Visible = true;
            label15.Visible = true;
            // labelAssiID.Visible = true;
            // textBoxAssID.Visible = true;
            //make the modify button visible
            modifyButton.Visible = true;
            }
            else if (announcementListForModification.Visible == false)
            {
                //make the assignmentsList visible
                announcementListForModification.Visible = true;
                //make the selectButton visible
                selectButton.Visible = true;
                //make all textboxes invisible
                modifyDescBox.Visible = false;
                modifyTitleBox.Visible = false;
                //make all labels invisible
                label14.Visible = false;
                label13.Visible = false;
                label15.Visible = false;
                // labelAssiID.Visible = false;
                // textBoxAssID.Visible = false;
                //make the modify button invisible
                modifyButton.Visible = false;
            }
         }

        private void AnnouncementLoadForUpdateDelete(object sender, EventArgs e)
        {
             try
            {
                if (AnnouncementTABS.SelectedTab.Name == "RemoveAnnounceTab")
                {
                    DataTable dt = new DataTable();
                    cn.Open();
                    cm = new SqlCommand("select * from Announcement where classroomID=@classroomID", cn);
                    cm.Parameters.AddWithValue("@classroomID", classroomID);
                    adapter = new SqlDataAdapter(cm);
                    adapter.Fill(dt);
                    announcementList.DataSource = dt;
                    cn.Close();
                }
                else if (AnnouncementTABS.SelectedTab.Name == "UpdateAnnounceTab")
                {
                    DataTable dt = new DataTable();
                    cn.Open();
                    cm = new SqlCommand("select * from Announcement where classroomID=@classroomID", cn);
                    cm.Parameters.AddWithValue("@classroomID", classroomID);
                    adapter = new SqlDataAdapter(cm);
                    adapter.Fill(dt);
                    announcementListForModification.DataSource = dt;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteAnnouncementButton_Click(object sender, EventArgs e)
        {
             try
            {
                // Check if there are any selected rows
                if (announcementList.SelectedRows.Count == 0 || announcementList.SelectedRows[0].IsNewRow)
                {
                    MessageBox.Show("No announcement selected.");
                    return;
                }

                // Display a confirmation dialog box
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected announcement?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms the deletion, proceed with deletion
                if (result == DialogResult.Yes)
                {
                    // Iterate over the selected rows in the GridView
                    foreach (DataGridViewRow row in announcementList.SelectedRows)
                    {
                        // Get the assignment ID from the selected row
                        int announcementID = Convert.ToInt32(row.Cells["announcementID"].Value);

                        // Execute the delete query using the assignment ID
                        cm = new SqlCommand("DELETE FROM Assignment WHERE announcementID = @announcementID", cn);
                        cm.Parameters.AddWithValue("@announcementID", announcementID);
                        cn.Open();
                        cm.ExecuteNonQuery();
                    }

                    // Refresh the GridView after deletion
                    DataTable dt = (DataTable)announcementList.DataSource;
                    dt.Clear();
                    adapter.Fill(dt);
                    cn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
