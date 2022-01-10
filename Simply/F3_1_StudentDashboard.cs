using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simply
{
    public partial class F3_1_StudentDashboard : Form
    {
        public static string Option = "";

        public F3_1_StudentDashboard()
        {
            InitializeComponent();

            //set parent to background
            label1.Parent = pictureBox1;
            Button_Manual.Parent = pictureBox1;
            btn_LogOut.Parent = pictureBox1;
            Button_Profile.Parent = pictureBox1;
            Button_SubjectMeetings.Parent = pictureBox1;
            Button_LearningMaterials.Parent = pictureBox1;
            Button_Quizzes.Parent = pictureBox1;

            //set backcolor to allow transparency to actual background
            label1.BackColor = Color.Transparent;
            Button_Manual.BackColor = Color.Transparent;
            btn_LogOut.BackColor = Color.Transparent;
            Button_Profile.BackColor = Color.Transparent;
            Button_SubjectMeetings.BackColor = Color.Transparent;
            Button_LearningMaterials.BackColor = Color.Transparent;
            Button_Quizzes.BackColor = Color.Transparent;
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            F2_Login F2 = new F2_Login();
            this.Hide();
            F2.ShowDialog();
            this.Close();
        }

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            F4_1_AllProfile F4_1 = new F4_1_AllProfile();
            this.Hide();
            F4_1.ShowDialog();
            this.Close();
        }

        private void Button_SubjectMeetings_Click(object sender, EventArgs e)
        {
            F4_2_ST_SelectSubject F4_2 = new F4_2_ST_SelectSubject();
            Option = "SUBJECT MEETINGS";
            this.Hide();
            F4_2.ShowDialog();
            this.Close();
        }

        private void Button_LearningMaterials_Click(object sender, EventArgs e)
        {
            F4_2_ST_SelectSubject F4_2 = new F4_2_ST_SelectSubject();
            Option = "LEARNING MATERIALS";
            this.Hide();
            F4_2.ShowDialog();
            this.Close();
        }

        private void Button_Quizzes_Click(object sender, EventArgs e)
        {
            F4_2_ST_SelectSubject F4_2 = new F4_2_ST_SelectSubject();
            Option = "QUIZZES";
            this.Hide();
            F4_2.ShowDialog();
            this.Close();
        }
    }
}
