using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace WinFormVersion5Francia
{
    public partial class FormLogin : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\8th Gen\\Downloads\\WINDOWS DATABASE\\WinFormVersion4\\WinFormVersion5Francia\\WinFormVersion5Francia\\Database1.mdf\";Integrated Security=True";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            // Check the login credentials
            if (CheckLoginCredentials(email, password))
            {
                MessageBox.Show("Login successful!");

                // Open the next form (MainForm) and pass the email
                FormLoggedin mainForm = new FormLoggedin(email);
                mainForm.Show();

                // Optionally, hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }
        }


        private bool CheckLoginCredentials(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM KBrecords WHERE Email = @Email AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    Console.WriteLine($"Email: {email}, Password: {password}");

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    Console.WriteLine($"Result Count: {count}");

                    return count > 0; // If count is greater than 0, login is successful
                }
            }
        }
    }
}
