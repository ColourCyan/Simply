﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Simply
{
    public partial class F5_2_AdminView : Form
    {
        MySqlConnection ViewInfo = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=simply;");
        public static string creds = "datasource=localhost;username=root;password=;database=simply;";
        public static string Email = "";

        public F5_2_AdminView()
        {
            InitializeComponent();

            if (lbl_Status.Text == "Enrolled")
            {
                this.btn_Enroll_Drop.Image = ((System.Drawing.Image)(Properties.Resources.Button_Drop));
            }
            else
            {
                this.btn_Enroll_Drop.Image = ((System.Drawing.Image)(Properties.Resources.Button_Enrol));
            }
            //set parent to background
            lbl_MenuType.Parent = pictureBox1;
            lbl_First.Parent = pictureBox1;
            lbl_Second.Parent = pictureBox1;
            lbl_Third.Parent = pictureBox1;
            lbl_Email.Parent = pictureBox1;
            lbl_Fourth.Parent = pictureBox1;
            lbl_Fifth.Parent = pictureBox1;
            lbl_Sixth.Parent = pictureBox1;
            lbl_Seventh.Parent = pictureBox1;
            lbl_Status.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;
            btn_Back.Parent = pictureBox1;
            btn_Add.Parent = pictureBox1;
            btn_Enroll_Drop.Parent = pictureBox1;
            lbl_Status.Parent = pictureBox1;
            btn_Search.Parent = pictureBox1;

            //set backcolor to allow transparency to actual background
            lbl_MenuType.BackColor = Color.Transparent;
            lbl_First.BackColor = Color.Transparent;
            lbl_Second.BackColor = Color.Transparent;
            lbl_Third.BackColor = Color.Transparent;
            lbl_Email.BackColor = Color.Transparent;
            lbl_Fourth.BackColor = Color.Transparent;
            lbl_Fifth.BackColor = Color.Transparent;
            lbl_Sixth.BackColor = Color.Transparent;
            lbl_Seventh.BackColor = Color.Transparent;
            lbl_Status.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            btn_Back.BackColor = Color.Transparent;
            btn_Add.BackColor = Color.Transparent;
            btn_Enroll_Drop.BackColor = Color.Transparent;
            lbl_Status.BackColor = Color.Transparent;
            btn_Search.BackColor = Color.Transparent;
        }

        private void F5_2_AdminView_Load(object sender, EventArgs e)
        {
            lbl_MenuType.Text = F3_3_AdminDashboard.Option;

            DataBase verify = new DataBase();

            //DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (lbl_MenuType.Text == "STUDENTS")
            {
                lbl_MenuType.Location = new Point(409, 32);
                lbl_First.Text = "Full Name:";
                lbl_Fourth.Text = "Subjects Taken:";
                MySqlCommand command = new MySqlCommand("SELECT fName, lName, Subject1, ID, EmailAddress, Status from studentform where ID = @id", ViewInfo);
                ViewInfo.Open();
                command.Parameters.AddWithValue("@id", txt_Page.Text);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Second.Text = row.GetValue(0).ToString();
                    lbl_Third.Text = row.GetValue(1).ToString();
                    lbl_Fifth.Text = row.GetValue(2).ToString();
                    txt_Page.Text = row.GetValue(3).ToString();
                    lbl_Email.Text = row.GetValue(4).ToString();
                    lbl_Status.Text = row.GetValue(5).ToString();
                }
                ViewInfo.Close();
            }
            else if (lbl_MenuType.Text == "TEACHERS")
            {
                lbl_MenuType.Location = new Point(405, 32);
                lbl_First.Text = "Full Name:";
                lbl_Fourth.Text = "Subject Handled:";
                lbl_Sixth.Hide();
                lbl_Seventh.Hide();
                MySqlCommand command = new MySqlCommand("SELECT fName, lName, Subject, ID, EmailAddress, Status from teacherform where ID = @id", ViewInfo);
                ViewInfo.Open();
                command.Parameters.AddWithValue("@id", txt_Page.Text);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Second.Text = row.GetValue(0).ToString();
                    lbl_Third.Text = row.GetValue(1).ToString();
                    lbl_Fifth.Text = row.GetValue(2).ToString();
                    txt_Page.Text = row.GetValue(3).ToString();
                    lbl_Email.Text = row.GetValue(4).ToString();
                    lbl_Status.Text = row.GetValue(5).ToString();
                }
                ViewInfo.Close();
            }
            else if (lbl_MenuType.Text == "SUBJECTS")
            {
                lbl_MenuType.Location = new Point(411, 32);
                lbl_First.Text = "Subject:";
                lbl_Email.Hide();
                lbl_Third.Hide();
                lbl_Fourth.Hide();
                lbl_Fifth.Hide();
                lbl_Sixth.Hide();
                lbl_Seventh.Hide();
                MySqlCommand command = new MySqlCommand("SELECT Subjects, ID, Status from subjectform where ID = @id", ViewInfo);
                ViewInfo.Open();
                command.Parameters.AddWithValue("@id", txt_Page.Text);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Second.Text = row.GetValue(0).ToString();
                    txt_Page.Text = row.GetValue(1).ToString();
                    lbl_Status.Text = row.GetValue(2).ToString();
                }
                ViewInfo.Close();
            }
            else
            {
                string message = "An error occured. Please try again.";
                MessageBox.Show(message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            F3_3_AdminDashboard F3_1 = new F3_3_AdminDashboard();
            this.Hide();
            F3_1.ShowDialog();
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            F5_2_AddAdminView F5_2 = new F5_2_AddAdminView();
            this.Hide();
            F5_2.ShowDialog();
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            lbl_MenuType.Text = F3_3_AdminDashboard.Option;

            if (lbl_MenuType.Text == "STUDENTS")
            {
                MySqlCommand command = new MySqlCommand("SELECT fName, lName, Subject1, ID, EmailAddress, Status  from studentform where ID = @id", ViewInfo);
                ViewInfo.Open();
                command.Parameters.AddWithValue("@id", txt_Page.Text);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Second.Text = row.GetValue(0).ToString();
                    lbl_Third.Text = row.GetValue(1).ToString();
                    lbl_Fifth.Text = row.GetValue(2).ToString();
                    txt_Page.Text = row.GetValue(3).ToString();
                    lbl_Email.Text = row.GetValue(4).ToString();
                    lbl_Status.Text = row.GetValue(5).ToString();
                }
                ViewInfo.Close();
            }
            else if (lbl_MenuType.Text == "TEACHERS")
            {
                MySqlCommand command = new MySqlCommand("SELECT fName, lName, Subject, ID, EmailAddress, Status from teacherform where ID = @id", ViewInfo);
                ViewInfo.Open();
                command.Parameters.AddWithValue("@id", txt_Page.Text);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Second.Text = row.GetValue(0).ToString();
                    lbl_Third.Text = row.GetValue(1).ToString();
                    lbl_Fifth.Text = row.GetValue(2).ToString();
                    txt_Page.Text = row.GetValue(3).ToString();
                    lbl_Email.Text = row.GetValue(4).ToString();
                    lbl_Status.Text = row.GetValue(5).ToString();
                }
                ViewInfo.Close();
            }
            else if (lbl_MenuType.Text == "SUBJECTS")
            {
                MySqlCommand command = new MySqlCommand("SELECT Subjects, ID, Status from subjectform where ID = @id", ViewInfo);
                ViewInfo.Open();
                command.Parameters.AddWithValue("@id", txt_Page.Text);
                MySqlDataReader row = command.ExecuteReader();
                while (row.Read())
                {
                    lbl_Second.Text = row.GetValue(0).ToString();
                    txt_Page.Text = row.GetValue(1).ToString();
                    lbl_Status.Text = row.GetValue(2).ToString();
                }
                ViewInfo.Close();
            }
            else
            {
                string message = "An error occured. Please try again.";
                MessageBox.Show(message);
            }
        }

        private void btn_Enroll_Drop_Click(object sender, EventArgs e)
        {
            if (lbl_Status.Text == "Enrolled")
            {
                this.btn_Enroll_Drop.Image = ((System.Drawing.Image)(Properties.Resources.Button_Drop));
                DialogResult Save = MessageBox.Show(lbl_MenuType.Text + " Dropped.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Save == DialogResult.OK)
                {
                    lbl_Status.Text = "Dropped";
                    if (lbl_MenuType.Text == "STUDENTS")
                    {
                        string query = "update studentform set Status = '" + this.lbl_Status.Text + "', ID = '" + this.txt_Page.Text + "' where ID = @id; ;";
                        MySqlConnection creds2 = new MySqlConnection(creds);
                        MySqlCommand senddata = new MySqlCommand(query, creds2);
                        MySqlDataReader ReceiveData;
                        creds2.Open();
                        ReceiveData = senddata.ExecuteReader();
                        creds2.Close();
                        F5_2_AdminView F5_2 = new F5_2_AdminView();
                        this.Hide();
                        F5_2.ShowDialog();
                        ViewInfo.Close();
                    }
                    else if (lbl_MenuType.Text == "TEACHERS")
                    {
                        string query = "update teacherform set Status='" + this.lbl_Status.Text + "', ID = '" + this.txt_Page.Text + "' where ID = @id; ;";
                        MySqlConnection creds2 = new MySqlConnection(creds);
                        MySqlCommand senddata = new MySqlCommand(query, creds2);
                        MySqlDataReader ReceiveData;
                        creds2.Open();
                        ReceiveData = senddata.ExecuteReader();
                        creds2.Close();
                        F5_2_AdminView F5_2 = new F5_2_AdminView();
                        this.Hide();
                        F5_2.ShowDialog();
                    }
                    else if (lbl_MenuType.Text == "SUBJECTS")
                    {
                        string query = "update subjectform set Status='" + this.lbl_Status.Text + "', ID = '" + this.txt_Page.Text + "' where ID = @id; ;";
                        MySqlConnection creds2 = new MySqlConnection(creds);
                        MySqlCommand senddata = new MySqlCommand(query, creds2);
                        MySqlDataReader ReceiveData;
                        creds2.Open();
                        ReceiveData = senddata.ExecuteReader();
                        creds2.Close();
                        F5_2_AdminView F5_2 = new F5_2_AdminView();
                        this.Hide();
                        F5_2.ShowDialog();
                    }
                    else
                    {
                        string message = "An error occured. Please try again.";
                        MessageBox.Show(message);
                    }
                }
            }
            else if (lbl_Status.Text == "Dropped")
            {
                this.btn_Enroll_Drop.Image = ((System.Drawing.Image)(Properties.Resources.Button_Enrol));
                DialogResult Save = MessageBox.Show("Student Reenlisted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Save == DialogResult.OK)
                {
                    lbl_Status.Text = "Enrolled";
                    if (lbl_MenuType.Text == "STUDENTS")
                    {
                        string query = "update studentform set Status='" + this.lbl_Status.Text + "'; ;";
                        MySqlConnection creds2 = new MySqlConnection(creds);
                        MySqlCommand senddata = new MySqlCommand(query, creds2);
                        MySqlDataReader ReceiveData;
                        creds2.Open();
                        ReceiveData = senddata.ExecuteReader();
                        creds2.Close();
                        F5_2_AdminView F5_2 = new F5_2_AdminView();
                        this.Hide();
                        F5_2.ShowDialog();
                    }
                    else if (lbl_MenuType.Text == "TEACHERS")
                    {
                        string query = "update teacherform set Status='" + this.lbl_Status.Text + "'; ;";
                        MySqlConnection creds2 = new MySqlConnection(creds);
                        MySqlCommand senddata = new MySqlCommand(query, creds2);
                        MySqlDataReader ReceiveData;
                        creds2.Open();
                        ReceiveData = senddata.ExecuteReader();
                        creds2.Close();
                        F5_2_AdminView F5_2 = new F5_2_AdminView();
                        this.Hide();
                        F5_2.ShowDialog();
                    }
                    else if (lbl_MenuType.Text == "SUBJECTS")
                    {
                        string query = "update subjectform set Status='" + this.lbl_Status.Text + "'; ;";
                        MySqlConnection creds2 = new MySqlConnection(creds);
                        MySqlCommand senddata = new MySqlCommand(query, creds2);
                        MySqlDataReader ReceiveData;
                        creds2.Open();
                        ReceiveData = senddata.ExecuteReader();
                        creds2.Close();
                        F5_2_AdminView F5_2 = new F5_2_AdminView();
                        this.Hide();
                        F5_2.ShowDialog();
                    }
                    else
                    {
                        string message = "An error occured. Please try again.";
                        MessageBox.Show(message);
                    }
                }
            }
        }
    }
}