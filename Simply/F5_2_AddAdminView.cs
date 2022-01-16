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
    public partial class F5_2_AddAdminView : Form
    {
        MySqlConnection ViewInfo = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=simply;");
        public static string creds = "datasource=localhost;username=root;password=;database=simply;";
        public static string teacher1 = "";
        public static string subject1 = "";
        public static string teacher2 = "";
        public static string subject2 = "";
        public static string teacher3 = "";
        public static string subject3 = "";

        public F5_2_AddAdminView()
        {
            InitializeComponent();
            FillComboSubjects();
            FillComboTeachers();

            //set parent to background
            btn_Back.Parent = pictureBox1;
            btn_Submit.Parent = pictureBox1;
            lbl_MenuType.Parent = pictureBox1;
            lbl_Sub1.Parent = pictureBox1;
            lbl_Sub2.Parent = pictureBox1;
            lbl_Sub3.Parent = pictureBox1;
            lbl_Teach1.Parent = pictureBox1;
            lbl_Teach2.Parent = pictureBox1;
            lbl_Teach3.Parent = pictureBox1;
            lbl_First.Parent = pictureBox1;
            lbl_Email.Parent = pictureBox1;
            lbl_Password.Parent = pictureBox1;

            //set backcolor to allow transparency to actual background
            btn_Back.BackColor = Color.Transparent;
            btn_Submit.BackColor = Color.Transparent;
            lbl_MenuType.BackColor = Color.Transparent;
            lbl_Sub1.BackColor = Color.Transparent;
            lbl_Sub2.BackColor = Color.Transparent;
            lbl_Sub3.BackColor = Color.Transparent;
            lbl_Teach1.BackColor = Color.Transparent;
            lbl_Teach2.BackColor = Color.Transparent;
            lbl_Teach3.BackColor = Color.Transparent;
            lbl_First.BackColor = Color.Transparent;
            lbl_Email.BackColor = Color.Transparent;
            lbl_Password.BackColor = Color.Transparent;
        }

        private void F5_2_AddAdminView_Load(object sender, EventArgs e)
        {
            lbl_MenuType.Text = F3_3_AdminDashboard.Option;

            DataBase verify = new DataBase();

            //DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (lbl_MenuType.Text == "STUDENTS")
            {
                lbl_MenuType.Location = new Point(409, 32);
                lbl_First.Text = "Full Name:";
                txt_Subject3.Hide();
            }
            else if (lbl_MenuType.Text == "TEACHERS")
            {
                lbl_MenuType.Location = new Point(405, 32);
                lbl_First.Text = "Full Name:";
                txt_Subject3.Hide();
                lbl_Sub2.Hide();
                cmb_Sub2.Hide();
                lbl_Sub3.Hide();
                cmb_Sub3.Hide();
                lbl_Teach1.Hide();
                cmb_Teach1.Hide();
                lbl_Teach2.Hide();
                cmb_Teach2.Hide();
                lbl_Teach3.Hide();
                cmb_Teach3.Hide();
            }
            else if (lbl_MenuType.Text == "SUBJECTS")
            {
                lbl_MenuType.Location = new Point(411, 32);
                lbl_First.Text = "Subject:";
                txt_lName.Hide();
                txt_Subject3.Hide();
                lbl_Email.Hide();
                txt_Email.Hide();
                txt_Password.Hide();
                lbl_Password.Hide();
                lbl_Sub1.Hide();
                cmb_Sub1.Hide();
                lbl_Sub2.Hide();
                cmb_Sub2.Hide();
                lbl_Sub3.Hide();
                cmb_Sub3.Hide();
                lbl_Teach1.Hide();
                cmb_Teach1.Hide();
                lbl_Teach2.Hide();
                cmb_Teach2.Hide();
                lbl_Teach3.Hide();
                cmb_Teach3.Hide();
            }
            else
            {
                string message = "An error occured. Please try again.";
                MessageBox.Show(message);
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            F5_2_AdminView F5_2 = new F5_2_AdminView();
            this.Hide();
            F5_2.ShowDialog();
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(lbl_MenuType.Text == "STUDENTS")
            {
                string query = "insert into studentform(EmailAddress, Password, fName, lName, Subject1, Subject2, Subject3, Teacher1, Teacher2, Teacher3)" +
                    " values('" + this.txt_Email.Text + "','" + this.txt_Password.Text + "','" + this.txt_fName.Text + "'," +
                    "'" + this.txt_lName.Text + "','" + this.cmb_Sub1.Text + "','" + this.cmb_Sub2.Text + "','" + this.cmb_Sub3.Text + "'," +
                    "'" + teacher1 + "','" + teacher2 + "','" + teacher3 + "');";
                MySqlConnection creds2 = new MySqlConnection(F5_2_AddAdminView.creds);
                MySqlCommand senddata = new MySqlCommand(query, creds2);
                MySqlDataReader ReceiveData;
                creds2.Open();
                ReceiveData = senddata.ExecuteReader();
                creds2.Close();
                F5_2_AdminView F5_2 = new F5_2_AdminView();
                this.Hide();
                F5_2.ShowDialog();
                this.Close();
            }
            else if (lbl_MenuType.Text == "TEACHERS")
            {
                string query = "insert into teacherform(EmailAddress, Password, fName, lName, Subject)" +
                    " values('" + this.txt_Email.Text + "','" + this.txt_Password.Text + "','" + this.txt_fName.Text + "'," +
                    "'" + this.txt_lName.Text + "','" + this.cmb_Sub1.Text + "');";
                MySqlConnection creds2 = new MySqlConnection(F5_2_AddAdminView.creds);
                MySqlCommand senddata = new MySqlCommand(query, creds2);
                MySqlDataReader ReceiveData;
                creds2.Open();
                ReceiveData = senddata.ExecuteReader();
                creds2.Close();
                F5_2_AdminView F5_2 = new F5_2_AdminView();
                this.Hide();
                F5_2.ShowDialog();
                this.Close();
            }
            else if (lbl_MenuType.Text == "SUBJECTS")
            {
                string query = "insert into subjectform(Subjects) values('" + this.txt_fName.Text + "');";
                MySqlConnection creds2 = new MySqlConnection(F5_2_AddAdminView.creds);
                MySqlCommand senddata = new MySqlCommand(query, creds2);
                MySqlDataReader ReceiveData;
                creds2.Open();
                ReceiveData = senddata.ExecuteReader();
                creds2.Close();
                F5_2_AdminView F5_2 = new F5_2_AdminView();
                this.Hide();
                F5_2.ShowDialog();
                this.Close();
            }
            else
            {
                string message = "An error occured. Please try again.";
                MessageBox.Show(message);
            }
        }

        public void FillComboSubjects()
        {
            string Query = "SELECT * FROM subjectform";
            MySqlConnection conDataBase = new MySqlConnection(creds);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader MyReader;
            conDataBase.Open();
            MyReader = cmdDataBase.ExecuteReader();
            cmb_Sub1.Items.Add("None");
            cmb_Sub2.Items.Add("None");
            cmb_Sub3.Items.Add("None");
            while (MyReader.Read())
            {
                string Subjects = MyReader.GetString("Subjects");
                cmb_Sub1.Items.Add(Subjects);
                cmb_Sub2.Items.Add(Subjects);
                cmb_Sub3.Items.Add(Subjects);
            }
        }

        public void FillComboTeachers()
        {
            string Query = "SELECT * FROM teacherform";
            MySqlConnection conDataBase = new MySqlConnection(creds);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader MyReader;
            conDataBase.Open();
            MyReader = cmdDataBase.ExecuteReader();
            while (MyReader.Read())
            {
                string fName = MyReader.GetString("fName");
                string lName = MyReader.GetString("lName");
                cmb_Teach1.Items.Add(fName + " " + lName);
                cmb_Teach2.Items.Add(fName + " " + lName);
                cmb_Teach3.Items.Add(fName + " " + lName);
            }
        }

        private void cmb_Sub1_DropDownClosed(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM teacherform WHERE Subject = '" + this.cmb_Sub1.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(creds);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader MyReader;
            conDataBase.Open();
            MyReader = cmdDataBase.ExecuteReader();
            cmb_Teach1.Items.Clear();
            cmb_Teach1.Items.Add("None");
            while (MyReader.Read())
            {
                string fName = MyReader.GetString("fName");
                string lName = MyReader.GetString("lName");
                cmb_Teach1.Items.Add(fName + " " + lName);
            }
        }

        private void cmb_Sub2_DropDownClosed(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM teacherform WHERE Subject = '" + this.cmb_Sub2.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(creds);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader MyReader;
            conDataBase.Open();
            MyReader = cmdDataBase.ExecuteReader();
            cmb_Teach2.Items.Clear();
            cmb_Teach2.Items.Add("None");
            while (MyReader.Read())
            {
                string fName = MyReader.GetString("fName");
                string lName = MyReader.GetString("lName");
                cmb_Teach2.Items.Add(fName + " " + lName);
            }
        }

        private void cmb_Sub3_DropDownClosed(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM teacherform WHERE Subject = '" + this.cmb_Sub3.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(creds);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader MyReader;
            conDataBase.Open();
            MyReader = cmdDataBase.ExecuteReader();
            cmb_Teach3.Items.Clear();
            cmb_Teach3.Items.Add("None");
            while (MyReader.Read())
            {
                string fName = MyReader.GetString("fName");
                string lName = MyReader.GetString("lName");
                cmb_Teach3.Items.Add(fName + " " + lName);
            }
        }

        private void cmb_Teach1_DropDownClosed(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM teacherform WHERE Subject = '" + this.cmb_Sub1.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(creds);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader MyReader;
            conDataBase.Open();
            MyReader = cmdDataBase.ExecuteReader();
            while (MyReader.Read())
            {
                string fName = MyReader.GetString("fName");
                string lName = MyReader.GetString("lName");
                cmb_Teach1.Items.Add(fName + " " + lName);
                if (cmb_Teach1.Text == fName + " " + lName)
                {
                    teacher1 = MyReader.GetString("EmailAddress");
                }
            }
        }

        private void cmb_Teach2_DropDownClosed(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM teacherform WHERE Subject = '" + this.cmb_Sub2.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(creds);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader MyReader;
            conDataBase.Open();
            MyReader = cmdDataBase.ExecuteReader();
            while (MyReader.Read())
            {
                string fName = MyReader.GetString("fName");
                string lName = MyReader.GetString("lName");
                cmb_Teach2.Items.Add(fName + " " + lName);
                if (cmb_Teach2.Text == fName + " " + lName)
                {
                    teacher2 = MyReader.GetString("EmailAddress");
                }
            }
        }

        private void cmb_Teach3_DropDownClosed(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM teacherform WHERE Subject = '" + this.cmb_Sub3.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(creds);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader MyReader;
            conDataBase.Open();
            MyReader = cmdDataBase.ExecuteReader();
            while (MyReader.Read())
            {
                string fName = MyReader.GetString("fName");
                string lName = MyReader.GetString("lName");
                cmb_Teach3.Items.Add(fName + " " + lName);
                if (cmb_Teach3.Text == fName + " " + lName)
                {
                    teacher3 = MyReader.GetString("EmailAddress");
                }
            }
        }
    }
}