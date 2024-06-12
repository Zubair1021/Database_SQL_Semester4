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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeTaskL1
{
    public partial class StudentFormcs : Form
    {
        public StudentFormcs()
        {
            InitializeComponent();
            dataload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Student1 values (@RegNo, @Name, @Dept ,@Session,@Address)", con);
                cmd.Parameters.AddWithValue("@RegNo", regno.Text);
                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@Dept", dept.Text);
                cmd.Parameters.AddWithValue("@Session", int.Parse(session.Text));
                cmd.Parameters.AddWithValue("@Address", address.Text);

                cmd.ExecuteNonQuery();
                

                MessageBox.Show("Successfully saved");
                dataload();
                regno.Clear();
                name.Clear();
                dept.Clear();
                session.Clear();
                address.Clear();

            }
            else
                MessageBox.Show("All Field are Required");
        }

        public void dataload()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student1 ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public bool isValid()
        {
            if (regno.Text == string.Empty|| name.Text==string.Empty|| address.Text == string.Empty || session.Text == string.Empty || dept.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            regno.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dept.Text = dataGridView1.SelectedRows[0].Cells[2].Value. ToString();
            session.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            address.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Update Student1 set RegNo=@RegNo,Name=@Name,Dept=@Dept ,Session=@Session,Address=@Address where RegNo=@RegNo ", con);
                cmd.Parameters.AddWithValue("@RegNo", regno.Text);
                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@Dept", dept.Text);
                cmd.Parameters.AddWithValue("@Session", int.Parse(session.Text));
                cmd.Parameters.AddWithValue("@Address", address.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Successfully Updated");
                dataload();
                regno.Clear();
                name.Clear();
                dept.Clear();
                session.Clear();
                address.Clear();

            }
            else
                MessageBox.Show("Without Select any row Update operation is Not working");
        }

        private void delete_Click(object sender, EventArgs e)
        {
                if (isValid())
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Delete Student1 where RegNo=@RegNo ", con);
                    cmd.Parameters.AddWithValue("@RegNo", regno.Text);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Successfully Deleted");
                    dataload();
                    regno.Clear();
                    name.Clear();
                    dept.Clear();
                    session.Clear();
                    address.Clear();

                }
                else
                    MessageBox.Show("Without Select any row Delete operation is Not working");
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var newform = new Form1();
            newform.Show();
            
        }
    }
}
