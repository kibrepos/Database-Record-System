using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormVersion5Francia
{
    public partial class FormViewrecord : Form
    {
        public FormViewrecord()
        {
            InitializeComponent();
        }

        private void kBrecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kBrecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormViewrecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.KBrecords' table. You can move, or remove it, as needed.
            this.kBrecordsTableAdapter.Fill(this.database1DataSet.KBrecords);

        }
    }
}
