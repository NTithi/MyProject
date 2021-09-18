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
    public partial class DetailsAllDoner : Form

    {
        function fn = new function();
        String query;
        public DetailsAllDoner()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            query = "select * from btable";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            loadData();
        }

        private void DetailsAllDoner_Load(object sender, EventArgs e)
        {
            loadData();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
}
