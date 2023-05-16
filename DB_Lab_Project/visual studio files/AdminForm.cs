using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MyApplication;

namespace intial_form_1_
{
    public partial class AdminForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public string _pass, _username = "";
        public bool _isactive = false;
        public AdminForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // if pressed x button in the control box, open the login form

        }

        private void password1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel1_Click(object sender, EventArgs e)
        {

        }

        private void Role_Click(object sender, EventArgs e)
        {

        }

        private void role1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void retypePassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AccountRelated_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void isActive3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void username3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void save2_Click(object sender, EventArgs e)
        {
            //Changing the password of the user
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from tblUser where username like @username", cn);
                cm.Parameters.AddWithValue("@username", username2.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    cn.Close();
                    cn.Open();
                    if (newPassword2.Text == reTypePassword2.Text)
                    {
                        cm = new SqlCommand("update tblUser set password = @password where username like @username", cn);
                        cm.Parameters.AddWithValue("@password", newPassword2.Text);
                        cm.Parameters.AddWithValue("@username", username2.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Password Changed Successfully", "Save Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password didn't Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cn.Close();
                        return;
                    }

                }
                else
                {
                    cn.Close();
                    MessageBox.Show("Username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if pressed x button in the control box, open the login form
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void save3_Click_1(object sender, EventArgs e)
        {
            //Changing the status of the user
            try
            {
                //if isActive3 is checked, change the user status to active and vice versa
                cn.Open();
                cm = new SqlCommand("select * from tblUser where username like @username", cn);
                cm.Parameters.AddWithValue("@username", username3.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    cn.Close();
                    cn.Open();
                    if (isActive3.Checked == true)
                    {
                        cm = new SqlCommand("update tblUser set isActive = @isActive where username like @username", cn);
                        cm.Parameters.AddWithValue("@isActive", true);
                        cm.Parameters.AddWithValue("@username", username3.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("User Activated Successfully", "Save Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cm = new SqlCommand("update tblUser set isActive = @isActive where username like @username", cn);
                        cm.Parameters.AddWithValue("@isActive", false);
                        cm.Parameters.AddWithValue("@username", username3.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("User Deactivated Successfully", "Save Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    cn.Close();
                    MessageBox.Show("Username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkButton4_Click(object sender, EventArgs e)
        {
            //display the password of the user
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from tblUser where username like @username", cn);
                cm.Parameters.AddWithValue("@username", username4.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    passwordData.Text = "The password of \"" + username4.Text + "\" is " + dr["password"].ToString() + ".";
                    passwordData.Visible = true;
                    cn.Close();
                }
                else
                {
                    cn.Close();
                    MessageBox.Show("Username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
 
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void userField4_TextChanged(object sender, EventArgs e)
        {

        }

        private void save1_Click(object sender, EventArgs e)
        {
            try
            {
                if (password1.Text != retypePassword1.Text)
                {
                    MessageBox.Show("Password didn't Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                cn.Open();
                cm = new SqlCommand("Insert into tblUser(username,password,role,name,isActive) values (@username,@password,@role,@name,@isActive)", cn);
                cm.Parameters.AddWithValue("@username", username1.Text);
                cm.Parameters.AddWithValue("@password", password1.Text);
                cm.Parameters.AddWithValue("@role", role1.Text);
                cm.Parameters.AddWithValue("@name", Name1.Text);
                cm.Parameters.AddWithValue("@isActive", true);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New Account Created Successfully", "Save Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
