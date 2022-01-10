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
    public partial class F2_Login : Form
    {
        public static string creds = "datasource=localhost;username=root;password=;database=simply;";
        public static string Email = "";

        public void F2_Login_Load(object sender, EventArgs e)
        {
            lbl_UserType.Text = F1_UserSelect.UserType;
        }

        public F2_Login()
        {
            InitializeComponent();

            //set parent to background
            label1.Parent = pictureBox1;
            lbl_UserType.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;
            btn_Back.Parent = pictureBox1;

            //set backcolor to allow transparency to actual background
            label1.BackColor = Color.Transparent;
            lbl_UserType.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text != "" && txt_Password.Text != "")
            {
                DataBase verify = new DataBase();

                Email = txt_Email.Text;
                string Password = txt_Password.Text;

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                if (lbl_UserType.Text == "STUDENT")
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `studentform` WHERE `EmailAddress`= @email and `Password` = @pass", verify.getConnection());

                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                }
                else if (lbl_UserType.Text == "TEACHER")
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `teacherform` WHERE `EmailAddress`= @email and `Password` = @pass", verify.getConnection());

                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                }
                else if (lbl_UserType.Text == "ADMIN")
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `adminform` WHERE `EmailAddress`= @email and `Password` = @pass", verify.getConnection());

                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                }
                else
                {
                    string message = "An error occured. Please try again.";
                    MessageBox.Show(message);
                }

                if (table.Rows.Count > 0)
                {
                    if (lbl_UserType.Text == "STUDENT")
                    {
                        F3_1_StudentDashboard F3_1 = new F3_1_StudentDashboard();
                        this.Hide();
                        F3_1.ShowDialog();
                        this.Close();
                    }
                    else if (lbl_UserType.Text == "TEACHER")
                    {
                        F3_2_TeacherDashboard F3_1 = new F3_2_TeacherDashboard();
                        this.Hide();
                        F3_1.ShowDialog();
                        this.Close();
                    }
                    else if (lbl_UserType.Text == "ADMIN")
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
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            else if (txt_Email.Text == "" && txt_Password.Text != "")
            {
                MessageBox.Show("PLEASE INSERT YOUR EMAIL", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_Email.Text != "" && txt_Password.Text == "")
            {
                MessageBox.Show("PLEASE INSERT YOUR PASSWORD", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("PLEASE INSERT YOUR EMAIL AND PASSWORD", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            F1_UserSelect F1 = new F1_UserSelect();
            this.Hide();
            F1.ShowDialog();
            this.Close();
        }
    }
}
