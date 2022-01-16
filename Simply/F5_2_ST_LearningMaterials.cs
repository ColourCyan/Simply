using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Simply
{
    public partial class F5_2_ST_LearningMaterials : Form
    {
        public static string LearningMaterials = "datasource=localhost;username=root;password=;database=simply;";

        public F5_2_ST_LearningMaterials()
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
        public void AutoUpdate()
        {
            try
            {
                if (F1_UserSelect.UserType == "STUDENT")
                {
                    string query = "SELECT File FROM lmform";
                    MySqlConnection LearningMaterials2 = new MySqlConnection(LearningMaterials);
                    MySqlCommand showdata = new MySqlCommand(query, LearningMaterials2);
                    MySqlDataAdapter ShowData = new MySqlDataAdapter();
                    ShowData.SelectCommand = showdata;
                    DataTable dtable = new DataTable();
                    ShowData.Fill(dtable);
                    LearningMaterialsData.DataSource = dtable;
                }
                else if (F1_UserSelect.UserType == "TEACHER")
                {
                    string query = "SELECT StudentEmail, File FROM lmform";
                    MySqlConnection LearningMaterials2 = new MySqlConnection(LearningMaterials);
                    MySqlCommand showdata = new MySqlCommand(query, LearningMaterials2);
                    MySqlDataAdapter ShowData = new MySqlDataAdapter();
                    ShowData.SelectCommand = showdata;
                    DataTable dtable = new DataTable();
                    ShowData.Fill(dtable);
                    LearningMaterialsData.DataSource = dtable;
                }
                else
                {
                    string message = "An error occured. Please try again.";
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
