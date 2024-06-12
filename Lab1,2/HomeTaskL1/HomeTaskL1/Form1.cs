﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTaskL1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newform = new StudentFormcs();
            newform.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newform = new Coursesform();
            newform.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newform = new ResultForm();
            newform.Show();     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
