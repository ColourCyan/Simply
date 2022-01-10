using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simply
{
    public partial class F5_1_ST_SubjectDetails : Form
    {
        public F5_1_ST_SubjectDetails()
        {
            InitializeComponent();

            label1.Parent = pictureBox1;
            lbl_Info.Parent = pictureBox1;
            lbl_Link.Parent = pictureBox1;
            Button_Back.Parent = pictureBox1;
            Button_Subject1.Parent = pictureBox1;

            label1.BackColor = Color.Transparent;
            lbl_Info.BackColor = Color.Transparent;
            lbl_Link.BackColor = Color.Transparent;
            Button_Back.BackColor = Color.Transparent;
            Button_Subject1.BackColor = Color.Transparent;
        }

        private void F5_1_SubjectDetails_Load(object sender, EventArgs e)
        {
            if (F1_UserSelect.UserType == "STUDENT")
            {
                lbl_Info.Text = "GMeet Link:";
                lbl_Info.Location = new Point(394, 304);
                lbl_Link.Location = new Point(394, 350);
                lbl_NewLink.Hide();
                txt_Link.Hide();
                btn_Submit.Hide();
            }
            else if (F1_UserSelect.UserType == "TEACHER")
            {
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
    }
}
