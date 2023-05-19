using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginFormExample
{
    public partial class LoginForm : Form
    {
        private const string connectionString = "YourConnectionString"; // Replace with your SQL connection string

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = GetSelectedRole();

            // Validate the user's credentials and role
            if (ValidateCredentials(username, password, role))
            {
                MessageBox.Show("Login successful. Role: " + role);
                // Proceed with the appropriate functionality based on the role
                if (role == "Student")
                {
                    // Perform student-related tasks
                }
                else if (role == "Teacher")
                {
                    // Perform teacher-related tasks
                }
                else if (role == "Admin")
                {
                    // Perform admin-related tasks
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials or role.");
            }
        }

        private string GetSelectedRole()
        {
            if (radioButtonStudent.Checked)
            {
                return "Student";
            }
            else if (radioButtonTeacher.Checked)
            {
                return "Teacher";
            }
            else if (radioButtonAdmin.Checked)
            {
                return "Admin";
            }
            else
            {
                return string.Empty;
            }
        }

        private bool ValidateCredentials(string username, string password, string role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
    }
}