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

namespace HomeTaskL1
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            dataload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newform = new Form1();
            newform.Show();
        }

        public void dataload()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Result ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
