using ClassLibrary1;
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

namespace WinFormVersion5Francia
{
    public partial class FormAddnewrecord : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\8th Gen\\Downloads\\WINDOWS DATABASE\\WinFormVersion4\\WinFormVersion5Francia\\WinFormVersion5Francia\\Database1.mdf\";Integrated Security=True";

        public FormAddnewrecord()
        {
            InitializeComponent();
        }

        private void kBrecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kBrecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormAddnewrecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.KBrecords' table. You can move, or remove it, as needed.
            this.kBrecordsTableAdapter.Fill(this.database1DataSet.KBrecords);

        }

        private void createrecordbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from textboxes
                string email = emailTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string accountType = accountTypeComboBox.Text;
                decimal initialDeposit = decimal.Parse(initialDepositNumericUpDown.Text); // Assuming the value is numeric
                string password = passwordTextBox.Text;
                string confirmPassword = passwordchecktxtbox.Text;

                // Validate email format
                try
                {
                    var mailAddress = new System.Net.Mail.MailAddress(email);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid email format. Please enter a valid email address.");
                    return;
                }

                // Check for duplicate email
                if (IsEmailAlreadyExists(email))
                {
                    MessageBox.Show("Email already exists. Please use a different email.");
                    return;
                }

                // Check if passwords match
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please enter matching passwords.");
                    return;
                }

                // Check if the initial deposit is at least 5000
                if (initialDeposit < 5000)
                {
                    MessageBox.Show("Minimum initial deposit is 5000. Please enter a higher amount.");
                    return;
                }

                // Proceed with adding the record to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("AddNewRecordProcedure", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@AccountType", accountType);
                        command.Parameters.AddWithValue("@Balance", initialDeposit);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                // Optionally, you can refresh the dataset to reflect the changes in the UI
                this.kBrecordsTableAdapter.Fill(this.database1DataSet.KBrecords);

                MessageBox.Show("Record added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding record: " + ex.Message);
            }
        }



        private bool IsEmailAlreadyExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM KBrecords WHERE Email = @Email", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    return count > 0; // If count is greater than 0, the email already exists
                }
            }
        }
    }
}
