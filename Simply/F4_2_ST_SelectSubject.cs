using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simply
{
    public partial class F4_2_ST_SelectSubject : Form
    {
        public F4_2_ST_SelectSubject()
        {
            InitializeComponent();

            lbl_SubType.Parent = pictureBox1;
            btn_Back = pictureBox1;
            Button_Subject1.Parent = pictureBox1;
            Button_Subject2.Parent = pictureBox1;
            Button_Subject3.Parent = pictureBox1;

            lbl_SubType.Parent = pictureBox1;
            btn_Back.BackColor = Color.Transparent;

            lbl_SubType.BackColor = Color.Transparent;
            btn_Back.BackColor = Color.Transparent;
            Button_Subject1.BackColor = Color.Transparent;
            Button_Subject2.BackColor = Color.Transparent;
            Button_Subject3.BackColor = Color.Transparent;

        }

        private void F4_2_SelectSubject_Load(object sender, EventArgs e)
        {
            if (F1_UserSelect.UserType == "STUDENT")
            {
                lbl_SubType.Text = F3_1_StudentDashboard.Option;
                if (lbl_SubType.Text == "QUIZZES")
                {
                    lbl_SubType.Location = new Point(426, 71);
                }
                else if (lbl_SubType.Text == "LEARNING MATERIALS")
                {
                    lbl_SubType.Location = new Point(271, 71);
                }
                else if (lbl_SubType.Text == "SUBJECT MEETINGS")
                {
                    lbl_SubType.Location = new Point(301, 71);
                }
                else
                {
                    string message = "An error occured. Please try again.";
                    MessageBox.Show(message);
                }
            }
            else if (F1_UserSelect.UserType == "TEACHER")
            {
                lbl_SubType.Text = F3_2_TeacherDashboard.Option;
                if (lbl_SubType.Text == "QUIZZES")
                {
                    lbl_SubType.Location = new Point(426, 71);
                }
                else if (lbl_SubType.Text == "LEARNING MATERIALS")
                {
                    lbl_SubType.Location = new Point(271, 71);
                }
                else if (lbl_SubType.Text == "SUBJECT MEETINGS")
                {
                    lbl_SubType.Location = new Point(301, 71);
                }
                else
                {
                    string message = "An error occured. Please try again.";
                    MessageBox.Show(message);
                }
            }
            else
            {
                string message = "An error occured. Please try again.";
                MessageBox.Show(message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (F1_UserSelect.UserType == "STUDENT")
            {
                F3_1_StudentDashboard F3_1 = new F3_1_StudentDashboard();
                this.Hide();
                F3_1.ShowDialog();
                this.Close();
            }
            else if (F1_UserSelect.UserType == "TEACHER")
            {
                F3_2_TeacherDashboard F3_1 = new F3_2_TeacherDashboard();
                this.Hide();
                F3_1.ShowDialog();
                this.Close();
            }
            else if (F1_UserSelect.UserType == "ADMIN")
            {
                F3_3_AdminDashboard F3_1 = new F3_3_AdminDashboard();
                this.Hide();
                F3_1.ShowDialog();
                this.Close();
            }
            else
            {
                string message = "An error occured. Please try again.";
                MessageBox.Show(message);
            }
        }
    }
}
