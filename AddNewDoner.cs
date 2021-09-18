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
    public partial class AddNewDoner : Form
    {
        function fn = new function();
        string query;
        
        public AddNewDoner()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      private void AddNewDoner_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName1.Text;
            String fname = txtFName.Text;
            String mname = txtMName.Text;
            String bday = txtBDay.Text;
            String gender = txtGender.Text;
            String blood = txtBloodGroup.Text;
            String adres = txtAddress.Text;
            query = "insert into btable (name,fname,mname,bday,gender,blood,adres) values('"+name+ "','" + fname + "','" + mname + "','" + bday + "','" + gender + "','" + blood + "','" + adres + "')";
            fn.setData(query, "Added.");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
        }

        private void labelNewID_Click(object sender, EventArgs e)
        {

        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}