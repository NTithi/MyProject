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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void lbtnHideshow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(btnHideshow.Text == "Show")
            {
                btnHideshow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnHideshow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked == true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "tithi" && txtPassword.Text =="tithi")
            {
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
        

            }
            else
            {
                MessageBox.Show("Enter valid UserName OR Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }
    }
}
