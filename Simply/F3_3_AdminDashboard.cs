using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simply
{
    public partial class F3_3_AdminDashboard : Form
    {
        public static string Option = "";

        public F3_3_AdminDashboard()
        {
            InitializeComponent();

            //set parent to background
            label1.Parent = pictureBox1;
            Button_Manual.Parent = pictureBox1;
            btn_LogOut.Parent = pictureBox1;
            btn_Profile.Parent = pictureBox1;
            btn_Teachers.Parent = pictureBox1;
            btn_Students.Parent = pictureBox1;
            btn_Subjects.Parent = pictureBox1;

            //set backcolor to allow transparency to actual background
            label1.BackColor = Color.Transparent;
            Button_Manual.BackColor = Color.Transparent;
            btn_LogOut.BackColor = Color.Transparent;
            btn_Profile.BackColor = Color.Transparent;
            btn_Teachers.BackColor = Color.Transparent;
            btn_Students.BackColor = Color.Transparent;
            btn_Subjects.BackColor = Color.Transparent;
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            F2_Login F2 = new F2_Login();
            this.Hide();
            F2.ShowDialog();
            this.Close();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            F4_1_AllProfile F4_1 = new F4_1_AllProfile();
            this.Hide();
            F4_1.ShowDialog();
            this.Close();
        }

        private void btn_Teachers_Click(object sender, EventArgs e)
        {
            F5_2_AdminView F5_2 = new F5_2_AdminView();
            Option = "TEACHERS";
            this.Hide();
            F5_2.ShowDialog();
            this.Close();
        }

        private void btn_Students_Click(object sender, EventArgs e)
        {
            F5_2_AdminView F5_2 = new F5_2_AdminView();
            Option = "STUDENTS";
            this.Hide();
            F5_2.ShowDialog();
            this.Close();
        }

        private void btn_Subjects_Click(object sender, EventArgs e)
        {
            F5_2_AdminView F5_2 = new F5_2_AdminView();
            Option = "SUBJECTS";
            this.Hide();
            F5_2.ShowDialog();
            this.Close();
        }
    }
}
