using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Check alignment if it is good
namespace Simply
{
    public partial class F1_UserSelect : Form
    {
        public static string UserType = "";

        public F1_UserSelect()
        {
            InitializeComponent();

            //set parent to background
            label1.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;

            //set backcolor to allow transparency to actual background
            label1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            F2_Login F2 = new F2_Login();
            UserType = btn_Student.Text;
            this.Hide();
            F2.ShowDialog();
            this.Close();
        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            F2_Login F2 = new F2_Login();
            UserType = btn_Teacher.Text;
            this.Hide();
            F2.ShowDialog();
            this.Close();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            F2_Login F2 = new F2_Login();
            UserType = btn_Admin.Text;
            this.Hide();
            F2.ShowDialog();
            this.Close();
        }
    }
}
