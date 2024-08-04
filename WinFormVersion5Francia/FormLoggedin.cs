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
    public partial class FormLoggedin : Form
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\8th Gen\\Downloads\\WINDOWS DATABASE\\WinFormVersion4\\WinFormVersion5Francia\\WinFormVersion5Francia\\Database1.mdf\";Integrated Security=True";
        private string userEmail;

        public FormLoggedin(string email)
        {
            InitializeComponent();
            userEmail = email;
            UpdateEmailLabel();
        }

        private void UpdateEmailLabel()
        {
            // Assuming your label is named emailLabel
            emailLabel.Text = userEmail;
        }

        private void kBrecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kBrecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void kBrecordsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.kBrecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void FormLoggedin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.KBrecords' table. You can move, or remove it, as needed.
            this.kBrecordsTableAdapter.Fill(this.database1DataSet.KBrecords);
        }

        private bool TransferMoney(string sender, string receiver, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("TransferMoney", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Sender", sender);
                        command.Parameters.AddWithValue("@Receiver", receiver);
                        command.Parameters.AddWithValue("@Amount", amount);

                        connection.Open();

                        int result = (int)command.ExecuteScalar();

                        if (result == 1)
                        {
                            MessageBox.Show("Transfer successful!");
                            return true;
                        }
                        else if (result == 0)
                        {
                            MessageBox.Show("Insufficient funds!");
                        }
                        else
                        {
                            MessageBox.Show("Error during transfer!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return false;
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            string receiver = transfertextbox.Text;
            decimal amount = numericUpDown1.Value;

            if (TransferMoney(userEmail, receiver, amount))
            {
                // Refresh data or perform any other actions after successful transfer
                this.kBrecordsTableAdapter.Fill(this.database1DataSet.KBrecords);
            }
        }
    }
}
