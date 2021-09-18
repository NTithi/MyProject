using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        private void addNewDonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDoner an = new AddNewDoner();
            an.Show();
        }

        private void updateNewDonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDoner ud = new UpdateDoner();
            ud.Show();
        }

        private void deleteDonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDoner dd = new DeleteDoner();
            dd.Show();
        }

        private void allListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllList al = new AllList();
            al.Show();
        }
    }
}
