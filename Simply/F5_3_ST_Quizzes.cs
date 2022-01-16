using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simply
{
    public partial class F5_3_ST_Quizzes : Form
    {
        public F5_3_ST_Quizzes()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            F4_2_ST_SelectSubject F4_2_ST = new F4_2_ST_SelectSubject();
            this.Hide();
            F4_2_ST.ShowDialog();
            this.Close();
        }
    }
}
