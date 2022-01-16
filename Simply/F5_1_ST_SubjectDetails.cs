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
    public partial class F5_1_ST_SubjectDetails : Form
    {
        MySqlConnection ViewInfo = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=simply;");
        public static string creds = "datasource=localhost;username=root;password=;database=simply;";

        public F5_1_ST_SubjectDetails()
        {
            InitializeComponent();

            label1.Parent = pictureBox1;
            lbl_Info.Parent = pictureBox1;
            lbl_Link.Parent = pictureBox1;
            Button_Back.Parent = pictureBox1;
            Button_Subject1.Parent = pictureBox1;
            lbl_Sub.Parent = pictureBox1;
            lbl_NewLink.Parent = pictureBox1;
            btn_Submit.Parent = pictureBox1;

            label1.BackColor = Color.Transparent;
            lbl_Info.BackColor = Color.Transparent;
            lbl_Link.BackColor = Color.Transparent;
            Button_Back.BackColor = Color.Transparent;
            Button_Subject1.BackColor = Color.Transparent;
            lbl_Sub.BackColor = Color.FromArgb(68, 114, 196);
            lbl_NewLink.BackColor = Color.Transparent;
            btn_Submit.BackColor = Color.Transparent;

            this.lbl_Sub.BringToFront();
        }

        private void F5_1_SubjectDetails_Load(object sender, EventArgs e)
        {
            this.lbl_Sub.Text = F4_2_ST_SelectSubject.Subject;
            if (F1_UserSelect.UserType == "STUDENT")
            {
                string Query = "SELECT * FROM studentform";
                MySqlConnection conDataBase = new MySqlConnection(creds);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader MyReader;
                conDataBase.Open();
                MyReader = cmdDataBase.ExecuteReader();
                while (MyReader.Read())
                {
                    string Subject1 = MyReader.GetString("Subject1");
                    string Subject2 = MyReader.GetString("Subject2");
                    string Subject3 = MyReader.GetString("Subject3");
                    string Teacher1 = MyReader.GetString("Teacher1");
                    string Teacher2 = MyReader.GetString("Teacher2");
                    string Teacher3 = MyReader.GetString("Teacher3");
                    if (F4_2_ST_SelectSubject.Subject == Subject1)
                    {
                        MySqlCommand command2 = new MySqlCommand("SELECT GLink from teacherform where EmailAddress = @email", ViewInfo);
                        ViewInfo.Open();
                        command2.Parameters.AddWithValue("@email", Teacher1);
                        MySqlDataReader row2 = command2.ExecuteReader();
                        while (row2.Read())
                        {
                            lbl_Link.Text = row2.GetValue(0).ToString();
                        }
                    }
                    else if (F4_2_ST_SelectSubject.Subject == Subject2)
                    {
                        MySqlCommand command2 = new MySqlCommand("SELECT GLink from teacherform where EmailAddress = @email", ViewInfo);
                        ViewInfo.Open();
                        command2.Parameters.AddWithValue("@email", Teacher2);
                        MySqlDataReader row2 = command2.ExecuteReader();
                        while (row2.Read())
                        {
                            lbl_Link.Text = row2.GetValue(0).ToString();
                        }
                    }
                    else if (F4_2_ST_SelectSubject.Subject == Subject3)
                    {
                        MySqlCommand command2 = new MySqlCommand("SELECT GLink from teacherform where EmailAddress = @email", ViewInfo);
                        ViewInfo.Open();
                        command2.Parameters.AddWithValue("@email", Teacher3);
                        MySqlDataReader row2 = command2.ExecuteReader();
                        while (row2.Read())
                        {
                            lbl_Link.Text = row2.GetValue(0).ToString();
                        }
                    }
                    else
                    {
                        string message = "An error occured. Please try again.";
                        MessageBox.Show(message);
                    }
                }
                ViewInfo.Close();
                lbl_Info.Text = "GMeet Link:";
                lbl_Info.Location = new Point(394, 304);
                lbl_Link.Location = new Point(394, 350);
                lbl_NewLink.Hide();
                txt_Link.Hide();
                btn_Submit.Hide();
            }
            else if (F1_UserSelect.UserType == "TEACHER")
            {
                MySqlCommand command = new MySqlCommand("SELECT GLink from teacherform where EmailAddress = @email", ViewInfo);
                ViewInfo.Open();
                command.Parameters.AddWithValue("@email", F2_Login.Email);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Link.Text = row.GetValue(0).ToString();
                }
                ViewInfo.Close();
                lbl_Info.Text = "Old Link:";
                lbl_Info.Location = new Point(394, 198);
                lbl_Link.Location = new Point(394, 244);
                lbl_NewLink.Show();
                txt_Link.Show();
                btn_Submit.Show();
            }
            else
            {
                string message = "An error occured. Please try again.";
                MessageBox.Show(message);
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            F4_2_ST_SelectSubject F4_2_ST = new F4_2_ST_SelectSubject();
            this.Hide();
            F4_2_ST.ShowDialog();
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (this.txt_Link.Text == "")
            {
                string message = "Error: Link cannot be empty.";
                MessageBox.Show(message);
            }
            else
            {
                UpdateForm();
            }
        }

        private void UpdateForm()
        {
            string query = "update teacherform set GLink = '" + this.txt_Link.Text + "' where EmailAddress = '" + F2_Login.Email + "';";
            MySqlConnection creds2 = new MySqlConnection(creds);
            MySqlCommand senddata = new MySqlCommand(query, creds2);
            MySqlDataReader ReceiveData;
            creds2.Open();
            ReceiveData = senddata.ExecuteReader();
            creds2.Close();
            F5_1_ST_SubjectDetails F5_1 = new F5_1_ST_SubjectDetails();
            this.Hide();
            F5_1.ShowDialog();
            ViewInfo.Close();
        }
    }
}
