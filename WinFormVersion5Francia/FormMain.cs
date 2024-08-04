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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void CloseCurrentChildForm()
        {
            // Close any currently open MDI child form
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();
            FormAddnewrecord childForm = new FormAddnewrecord();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();
            FormEditrecord childForm = new FormEditrecord();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void viewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();
            FormViewrecord childForm = new FormViewrecord();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();
            FormLogin childForm = new FormLogin();
            childForm.MdiParent = this;
            childForm.Show();
        }

        public void OpenChildForm(string email)
        {
            // Open the child form
            FormLoggedin mainForm = new FormLoggedin(email);
            mainForm.MdiParent = this;  // Set the MDI parent to FormMain
            mainForm.Show();
        }
    }
}
