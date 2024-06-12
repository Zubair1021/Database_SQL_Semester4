namespace HomeTaskL1
{
    partial class Coursesform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teachername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Courseid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(354, 233);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(80, 33);
            this.update.TabIndex = 30;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(517, 233);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(80, 33);
            this.Delete.TabIndex = 29;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(182, 233);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(80, 33);
            this.Add.TabIndex = 28;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 286);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(768, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 254);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(194, 8);
            this.label6.MinimumSize = new System.Drawing.Size(685, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(685, 43);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cousres CRUD";
            // 
            // semester
            // 
            this.semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.Location = new System.Drawing.Point(137, 178);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(198, 22);
            this.semester.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Semester";
            // 
            // studentname
            // 
            this.studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentname.Location = new System.Drawing.Point(517, 131);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(198, 22);
            this.studentname.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Student Name";
            // 
            // teachername
            // 
            this.teachername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachername.Location = new System.Drawing.Point(517, 84);
            this.teachername.Name = "teachername";
            this.teachername.Size = new System.Drawing.Size(198, 22);
            this.teachername.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Teacher Name";
            // 
            // CourseName
            // 
            this.CourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName.Location = new System.Drawing.Point(137, 131);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(198, 22);
            this.CourseName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Course Name";
            // 
            // Courseid
            // 
            this.Courseid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courseid.Location = new System.Drawing.Point(137, 80);
            this.Courseid.Name = "Courseid";
            this.Courseid.Size = new System.Drawing.Size(198, 22);
            this.Courseid.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Course ID";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightYellow;
            this.button2.Location = new System.Drawing.Point(694, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 31;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Coursesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teachername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Courseid);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(816, 592);
            this.Name = "Coursesform";
            this.Text = "Coursesform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox semester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teachername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Courseid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}