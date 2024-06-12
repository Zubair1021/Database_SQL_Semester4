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

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Studenttable values (@RegNo, @Name, @PhoneNo ,@Session)", con);
            cmd.Parameters.AddWithValue("@RegNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@PhoneNo", textBox3.Text);
            cmd.Parameters.AddWithValue("@Session", textBox4.Text);

            cmd.ExecuteNonQuery();
;
            MessageBox.Show("Successfully saved"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Studenttable ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
