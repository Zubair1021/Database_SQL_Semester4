using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace HomeTaskL1
{
    public partial class Coursesform : Form
    {
        public Coursesform()
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
            SqlCommand cmd = new SqlCommand("Select * from Course ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Courseid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CourseName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            studentname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            teachername.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            semester.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Course values (@CourseID, @CourseName, @StudentName ,@TeacherName,@Semester)", con);
                cmd.Parameters.AddWithValue("@CourseID", Courseid.Text);
                cmd.Parameters.AddWithValue("@CourseName", CourseName.Text);
                cmd.Parameters.AddWithValue("@StudentName", studentname.Text);
                cmd.Parameters.AddWithValue("@TeacherName", teachername.Text);
                cmd.Parameters.AddWithValue("@Semester", semester.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Successfully saved");
                dataload();
                Courseid.Clear();
                CourseName.Clear();
                studentname.Clear();
                teachername.Clear();
                semester.Clear();

            }
            else
                MessageBox.Show("All Field are required");


        }
        public bool isValid()
        {
            if (Courseid.Text == string.Empty || CourseName.Text == string.Empty || teachername.Text == string.Empty || studentname.Text == string.Empty || semester.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Update Course set CourseID=@CourseID, CourseName=@CourseName, StudentName=@StudentName ,TeacherName=@TeacherName,Semester=@Semester where CourseID=@CourseID", con);
                cmd.Parameters.AddWithValue("@CourseID", Courseid.Text);
                cmd.Parameters.AddWithValue("@CourseName", CourseName.Text);
                cmd.Parameters.AddWithValue("@StudentName", studentname.Text);
                cmd.Parameters.AddWithValue("@TeacherName", teachername.Text);
                cmd.Parameters.AddWithValue("@Semester", semester.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Successfully Updated");
                dataload();
                Courseid.Clear();
                CourseName.Clear();
                studentname.Clear();
                teachername.Clear();
                semester.Clear(); 

            }
            else
                MessageBox.Show("Without Select any row Update operation is Not working");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Delete Course where CourseID=@CourseID ", con);
                cmd.Parameters.AddWithValue("@CourseID", Courseid.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Successfully Deleted");
                dataload();
                Courseid.Clear();
                CourseName.Clear();
                studentname.Clear();
                teachername.Clear();
                semester.Clear(); 

            }
            else
                MessageBox.Show("Without Select any row Delete operation is Not working");

        }
    }
}
