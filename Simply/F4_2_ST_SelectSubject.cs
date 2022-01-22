using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Simply
{
    public partial class F4_2_ST_SelectSubject : Form
    {
        MySqlConnection ViewInfo = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=simply;");
        public static string creds = "datasource=localhost;username=root;password=;database=simply;";
        public static string Subject = "";
        public F4_2_ST_SelectSubject()
        {
            InitializeComponent();

            btn_Back.Parent = pictureBox1;
            lbl_SubType.Parent = pictureBox1;
            Button_Subject1.Parent = pictureBox1;
            Button_Subject2.Parent = pictureBox1;
            Button_Subject3.Parent = pictureBox1;
            lbl_Sub1.Parent = pictureBox1;
            lbl_Sub2.Parent = pictureBox1;
            lbl_Sub3.Parent = pictureBox1;
            lbl_SubType.Parent = pictureBox1;

            btn_Back.BackColor = Color.Transparent;
            lbl_SubType.BackColor = Color.Transparent;
            Button_Subject1.BackColor = Color.Transparent;
            Button_Subject2.BackColor = Color.Transparent;
            Button_Subject3.BackColor = Color.Transparent;
            lbl_Sub1.BackColor = Color.FromArgb(68, 114, 196);
            lbl_Sub2.BackColor = Color.FromArgb(68, 114, 196);
            lbl_Sub3.BackColor = Color.FromArgb(68, 114, 196);
            this.lbl_Sub1.BringToFront();
            this.lbl_Sub2.BringToFront();
            this.lbl_Sub3.BringToFront();
            lbl_SubType.BackColor = Color.Transparent;

        }

        private void F4_2_SelectSubject_Load(object sender, EventArgs e)
        {
            if (F1_UserSelect.UserType == "STUDENT")
            {
                DataBase verify = new DataBase();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT Subject1, Subject2, Subject3 from studentform where EmailAddress = @email", ViewInfo);
                ViewInfo.Open();
                command.Parameters.AddWithValue("@email", F2_Login.Email);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Sub1.Text = row.GetValue(0).ToString();
                    lbl_Sub2.Text = row.GetValue(1).ToString();
                    lbl_Sub3.Text = row.GetValue(2).ToString();
                }
                ViewInfo.Close();
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

                Button_Subject2.Hide();
                Button_Subject3.Hide();
                lbl_Sub2.Hide();
                lbl_Sub3.Hide();

                DataBase verify = new DataBase();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT Subject from teacherform where EmailAddress = @email", ViewInfo);
                ViewInfo.Open();
                command.Parameters.AddWithValue("@email", F2_Login.Email);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Sub1.Text = row.GetValue(0).ToString();
                }
                ViewInfo.Close();
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
            else
            {
                string message = "An error occured. Please try again.";
                MessageBox.Show(message);
            }
        }

        private void Button_Subject1_Click(object sender, EventArgs e)
        {
            Subject = this.lbl_Sub1.Text;
            OpenForm();
        }

        private void Button_Subject2_Click(object sender, EventArgs e)
        {
            Subject = this.lbl_Sub2.Text;
            OpenForm();
        }

        private void Button_Subject3_Click(object sender, EventArgs e)
        {
            Subject = this.lbl_Sub3.Text;
            OpenForm();
        }

        private void lbl_Sub1_Click(object sender, EventArgs e)
        {
            Subject = this.lbl_Sub1.Text;
            OpenForm();
        }

        private void lbl_Sub2_Click(object sender, EventArgs e)
        {
            Subject = this.lbl_Sub2.Text;
            OpenForm();
        }

        private void lbl_Sub3_Click(object sender, EventArgs e)
        {
            Subject = this.lbl_Sub3.Text;
            OpenForm();
        }

        private void OpenForm()
        {
            if (lbl_SubType.Text == "QUIZZES")
            {
                F5_3_ST_Quizzes F5_3 = new F5_3_ST_Quizzes();
                this.Hide();
                F5_3.ShowDialog();
                this.Close();
            }
            else if (lbl_SubType.Text == "LEARNING MATERIALS")
            {
                F5_2_ST_LearningMaterials F5_2 = new F5_2_ST_LearningMaterials();
                this.Hide();
                F5_2.ShowDialog();
                this.Close();
            }
            else if (lbl_SubType.Text == "SUBJECT MEETINGS")
            {
                F5_1_ST_SubjectDetails F5_1 = new F5_1_ST_SubjectDetails();
                this.Hide();
                F5_1.ShowDialog();
                this.Close();
            }
            else
            {
                string message = "You have no subject for this button.";
                MessageBox.Show(message);
            }
        }
    }
}
