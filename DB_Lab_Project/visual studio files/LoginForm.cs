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
using System.Xml.Linq;
using MyApplication;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace intial_form_1_
{
    public partial class LoginForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public string _pass, _username = "";
        public bool _isactive = false;
        public LoginForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        

        private void Login_Click(object sender, EventArgs e)
        {
            string _role= "", _name = "";
            try
            {
                bool found = false;
                cn.Open();
                cm = new SqlCommand("select * from tblUser where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", username.Text);
                cm.Parameters.AddWithValue("@password", password.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _role = dr["role"].ToString();
                    _name = dr["name"].ToString();
                    _pass = dr["password"].ToString();
                    _isactive = bool.Parse(dr["isActive"].ToString());

                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();
                if (found == true)
                {
                    if (_isactive == false)
                    {
                        MessageBox.Show("Account is inactive.Unable to Login ", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (_role == "Student")
                    {
                        MessageBox.Show("Welcome(Student) " + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        username.Clear();
                        password.Clear();
                    }
                    else if (_role == "Admin")
                    {
                        MessageBox.Show("Welcome(Admin) " + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        username.Clear();
                        password.Clear();
                        this.Hide();
                        AdminForm form2 = new AdminForm();
                        form2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome(Teacher) " + _name + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        password.Clear();
                        username.Clear();
                        this.Hide();
                        //open classroom
                        classroom classroomForm = new classroom(_name, _username);
                        classroomForm.ShowDialog();
                        
                    }
                }
                else
                {
                    MessageBox.Show(" Invalid Username or Password! " , "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                }
            }
            catch (Exception ex)
            {
                cn.Close() ;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
