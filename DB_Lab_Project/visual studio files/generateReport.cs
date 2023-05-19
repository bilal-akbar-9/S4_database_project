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
using Microsoft.Reporting.WinForms;

namespace intial_form_1_
{
    public partial class generateReport : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        String teacherUsername;
        String teacherName;
        String classroomID;
        public generateReport()
        {
            InitializeComponent();
        }
        public generateReport(String teacherName, String teacherUsername, String classroomID)
        {
            InitializeComponent();
            this.teacherUsername = teacherUsername;
            this.classroomID = classroomID;
            this.teacherName = teacherName;
            cn = new SqlConnection(dbcon.MyConnection());
        }
        private void generateReport_Load(object sender, EventArgs e)
        {

            //Get the student in this class and generate the report using reportViewer
            try
            {
                //Generating the first Report
                cn.Open();
                cm = new SqlCommand("select * from tblUser where role = 'Student' and username in (select studentusername from ClassroomAndStudent where classroomID = @classroomID)", cn);
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                SqlDataAdapter d = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                d.Fill(dt);
                // Adding the first report to the reportViewer
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
                this.studentReport.LocalReport.DataSources.Clear();
                this.studentReport.LocalReport.DataSources.Add(reportDataSource);
                this.studentReport.RefreshReport();
                //Generating the second Report
                //Select the submissions of the students in this class
                cm = new SqlCommand("select * from Submissions where assignmentID in (select assignmentID from Assignment where classroomID = @classroomID)", cn );
                cm.Parameters.AddWithValue("@classroomID", classroomID);
                SqlDataAdapter d2 = new SqlDataAdapter(cm);
                DataTable dt2 = new DataTable();
                d2.Fill(dt2);
                // Adding the second report to the reportViewer
                ReportDataSource reportDataSource2 = new ReportDataSource("DataSet1", dt2);
                this.assignmentReport.LocalReport.DataSources.Clear();
                this.assignmentReport.LocalReport.DataSources.Add(reportDataSource2);
                this.assignmentReport.RefreshReport();
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
            Class classForm = new Class(teacherName, teacherUsername, classroomID);
            classForm.Show();
        }
    }
}
