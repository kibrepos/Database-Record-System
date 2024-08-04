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
    public partial class FormEditrecord : Form
    {
        public FormEditrecord()
        {
            InitializeComponent();
        }

        private void kBrecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kBrecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormEditrecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.KBrecords' table. You can move, or remove it, as needed.
            this.kBrecordsTableAdapter.Fill(this.database1DataSet.KBrecords);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        /*public void edit(string UserEmail, string FirstName, string LastName, string AccountType, string InitialDeposit, string Password)
        {
            MyCon.Open();
            SqlCommand SaveCMD = new SqlCommand("EditRecord", MyCon);
            SaveCMD.CommandType = CommandType.StoredProcedure;
            SaveCMD.Parameters.Add("UserEmail", SqlDbType.NVarChar).Value = UserEmail;
            SaveCMD.Parameters.Add("FirstName", SqlDbType.NVarChar).Value = FirstName;
            SaveCMD.Parameters.Add("LastName", SqlDbType.NVarChar).Value = LastName;
            SaveCMD.Parameters.Add("AccountType", SqlDbType.NVarChar).Value = AccountType;
            SaveCMD.Parameters.Add("InitialDeposit", SqlDbType.NVarChar).Value = InitialDeposit;
            SaveCMD.Parameters.Add("Password", SqlDbType.NVarChar).Value = Password;

            SaveCMD.ExecuteNonQuery();
            MyCon.Close();
        }
        */
    }
}
