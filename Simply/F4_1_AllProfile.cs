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
    public partial class F4_1_AllProfile : Form
    {
        MySqlConnection editInfo = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=simply;");
        public static string Email = "";

        public F4_1_AllProfile()
        {
            InitializeComponent();

            btn_Back.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;
            lbl_fName.Parent = pictureBox1;
            lbl_lName.Parent = pictureBox1;
            lbl_Email.Parent = pictureBox1;
            lbl_Password.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;

            btn_Back.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            lbl_fName.BackColor = Color.Transparent;
            lbl_lName.BackColor = Color.Transparent;
            lbl_Email.BackColor = Color.Transparent;
            lbl_Password.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }

        private void F4_1_Profile_Load(object sender, EventArgs e)
        {
            DataBase verify = new DataBase();

            Email = lbl_Email.Text;
            string Password = lbl_Password.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (F1_UserSelect.UserType == "STUDENT")
            {
                MySqlCommand command = new MySqlCommand("SELECT EmailAddress, Password, fName, lName from adminform where EmailAddress = @email", editInfo);
                editInfo.Open();
                command.Parameters.AddWithValue("@email", F2_Login.Email);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Email.Text = row.GetValue(0).ToString();
                    lbl_Password.Text = row.GetValue(1).ToString();
                    lbl_fName.Text = row.GetValue(2).ToString();
                    lbl_lName.Text = row.GetValue(3).ToString();
                }
                editInfo.Close();
            }
            else if (F1_UserSelect.UserType == "TEACHER")
            {
                MySqlCommand command = new MySqlCommand("SELECT EmailAddress, Password, fName, lName from adminform where EmailAddress = @email", editInfo);
                editInfo.Open();
                command.Parameters.AddWithValue("@email", F2_Login.Email);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Email.Text = row.GetValue(0).ToString();
                    lbl_Password.Text = row.GetValue(1).ToString();
                    lbl_fName.Text = row.GetValue(2).ToString();
                    lbl_lName.Text = row.GetValue(3).ToString();
                }
                editInfo.Close();
            }
            else if (F1_UserSelect.UserType == "ADMIN")
            {
                MySqlCommand command = new MySqlCommand("SELECT EmailAddress, Password, fName, lName from adminform where EmailAddress = @email", editInfo);
                editInfo.Open();
                command.Parameters.AddWithValue("@email", F2_Login.Email);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Email.Text = row.GetValue(0).ToString();
                    lbl_Password.Text = row.GetValue(1).ToString();
                    lbl_fName.Text = row.GetValue(2).ToString();
                    lbl_lName.Text = row.GetValue(3).ToString();
                }
                editInfo.Close();
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
