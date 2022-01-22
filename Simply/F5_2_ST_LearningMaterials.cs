using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;

namespace Simply
{
    public partial class F5_2_ST_LearningMaterials : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=simply;");
        public static string Display = "datasource=localhost;username=root;password=;database=simply;";
        public static string ID;
        public static string TeacherEmail1;
        public static string TeacherEmail2;
        public static string TeacherEmail3;
        public static string Subject1;
        public static string Subject2;
        public static string Subject3;

        public F5_2_ST_LearningMaterials()
        {
            InitializeComponent();
            btn_Back.Parent = pictureBox1;
            lbl_SubType.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            btn_Download.Parent = pictureBox1;
            btn_Delete.Parent = pictureBox1;
            btn_Upload.Parent = pictureBox1;

            btn_Back.BackColor = Color.Transparent;
            lbl_SubType.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            btn_Download.BackColor = Color.Transparent;
            btn_Delete.BackColor = Color.Transparent;
            btn_Upload.BackColor = Color.Transparent;

            lbl_SubType.Text = F4_2_ST_SelectSubject.Subject;
        }

        private void F5_2_ST_LearningMaterials_Load(object sender, EventArgs e)
        {
            AutoUpdate();
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
                if (F1_UserSelect.UserType == "TEACHER")
                {
                    try
                    {
                        btn_Upload.Show();
                        btn_Delete.Show();
                        btn_Download.Location = new Point(475, 568);
                        string query = "SELECT ID, File FROM lmform WHERE TeacherEmail = '" + F2_Login.Email + "';";
                        MySqlConnection Display2 = new MySqlConnection(Display);
                        MySqlCommand showdata = new MySqlCommand(query, Display2);
                        MySqlDataAdapter ShowData = new MySqlDataAdapter();
                        ShowData.SelectCommand = showdata;
                        DataTable dtable = new DataTable();
                        ShowData.Fill(dtable);
                        LearningMaterialsData.DataSource = dtable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (F1_UserSelect.UserType == "STUDENT")
                {
                    btn_Upload.Hide();
                    btn_Delete.Hide();
                    btn_Download.Location = new Point(610, 568);
                    try
                    {
                        DataBase verify = new DataBase();
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        MySqlCommand command = new MySqlCommand("SELECT Teacher1, Teacher2, Teacher3, Subject1, " +
                            "Subject2, Subject3 FROM studentform WHERE EmailAddress = @email", con);
                        con.Open();
                        command.Parameters.AddWithValue("@email", F2_Login.Email);
                        MySqlDataReader row = command.ExecuteReader();
                        while (row.Read())
                        {
                            TeacherEmail1 = row.GetValue(0).ToString();
                            TeacherEmail2 = row.GetValue(1).ToString();
                            TeacherEmail3 = row.GetValue(2).ToString();
                            Subject1 = row.GetValue(3).ToString();
                            Subject2 = row.GetValue(4).ToString();
                            Subject3 = row.GetValue(5).ToString();
                        }
                        con.Close();
                        if (F4_2_ST_SelectSubject.Subject == Subject1)
                        {
                            string query = "SELECT ID, File FROM lmform WHERE TeacherEmail = '" + TeacherEmail1 + "';";
                            MySqlConnection Display2 = new MySqlConnection(Display);
                            MySqlCommand showdata = new MySqlCommand(query, Display2);
                            MySqlDataAdapter ShowData = new MySqlDataAdapter();
                            ShowData.SelectCommand = showdata;
                            DataTable dtable = new DataTable();
                            ShowData.Fill(dtable);
                            LearningMaterialsData.DataSource = dtable;
                        }
                        else if (F4_2_ST_SelectSubject.Subject == Subject2)
                        {
                            string query = "SELECT ID, File FROM lmform WHERE TeacherEmail = '" + TeacherEmail2 + "';";
                            MySqlConnection Display2 = new MySqlConnection(Display);
                            MySqlCommand showdata = new MySqlCommand(query, Display2);
                            MySqlDataAdapter ShowData = new MySqlDataAdapter();
                            ShowData.SelectCommand = showdata;
                            DataTable dtable = new DataTable();
                            ShowData.Fill(dtable);
                            LearningMaterialsData.DataSource = dtable;
                        }
                        else if (F4_2_ST_SelectSubject.Subject == Subject3)
                        {
                            string query = "SELECT ID, File FROM lmform WHERE TeacherEmail = '" + TeacherEmail3 + "';";
                            MySqlConnection Display2 = new MySqlConnection(Display);
                            MySqlCommand showdata = new MySqlCommand(query, Display2);
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

        private void LearningMaterialsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.LearningMaterialsData.Rows[e.RowIndex];
                F5_3_ST_Quizzes.ID = row.Cells["ID"].Value.ToString();
                //For Checking Purposes
                //MessageBox.Show("File Selected: ID #" + F5_3_ST_Quizzes.ID);
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            string message = "It appears that this button is unset as of the moment. Stay tuned for future updates ^=^";
            MessageBox.Show(message);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string message = "This button has been disabled for the purpose of this demo presentation";
            MessageBox.Show(message);
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            if (F1_UserSelect.UserType == "TEACHER")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "PDF files (*.pdf)|*.pdf*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        {
                            fileContent = openFileDialog.FileName;
                        }
                        string[] FullFileName = openFileDialog.FileName.Split('\\');
                        string FileName = FullFileName.Last().ToString();
                        byte[] FileContent;
                        FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                        BinaryReader bs = new BinaryReader(fs);
                        FileContent = bs.ReadBytes(Convert.ToInt32(fs.Length));
                        fs.Close();
                        bs.Close();
                        string Query = "insert into quizform (TeacherEmail, Subject, File, Data) values (@Email, @Subject, @File, @Data)";
                        MySqlCommand cmd = new MySqlCommand(Query, con);
                        con.Open();
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Email", F2_Login.Email);
                        cmd.Parameters.AddWithValue("@Subject", F4_2_ST_SelectSubject.Subject);
                        cmd.Parameters.AddWithValue("@File", FileName);
                        cmd.Parameters.AddWithValue("@Data", FileContent);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("File Uploaded!");
                        con.Close();
                    }
                }
            }
            else if (F1_UserSelect.UserType == "STUDENT")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "PDF files (*.pdf)|*.pdf*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        {
                            fileContent = openFileDialog.FileName;
                        }
                        string[] FullFileName = openFileDialog.FileName.Split('\\');
                        string FileName = FullFileName.Last().ToString();
                        byte[] FileContent;
                        FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                        BinaryReader bs = new BinaryReader(fs);
                        FileContent = bs.ReadBytes(Convert.ToInt32(fs.Length));
                        fs.Close();
                        bs.Close();

                        //retrieve data to check which teacher to upload to

                        DataBase verify = new DataBase();
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        MySqlCommand command = new MySqlCommand("SELECT Teacher1, Teacher2, Teacher3, Subject1, " +
                            "Subject2, Subject3 FROM studentform WHERE EmailAddress = @email", con);
                        con.Open();
                        command.Parameters.AddWithValue("@email", F2_Login.Email);
                        MySqlDataReader row = command.ExecuteReader();
                        while (row.Read())
                        {
                            TeacherEmail1 = row.GetValue(0).ToString();
                            TeacherEmail2 = row.GetValue(1).ToString();
                            TeacherEmail3 = row.GetValue(2).ToString();
                            Subject1 = row.GetValue(3).ToString();
                            Subject2 = row.GetValue(4).ToString();
                            Subject3 = row.GetValue(5).ToString();
                        }
                        con.Close();

                        //END retrieve data to check which teacher to upload to

                        string Query = "insert into submissionquizform (StudentEmail, TeacherEmail, Subject, File, Data) " +
                            "values (@StudentEmail, @TeacherEmail, @Subject, @File, @Data)";
                        MySqlCommand cmd = new MySqlCommand(Query, con);
                        con.Open();
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@StudentEmail", F2_Login.Email);

                        //Subject has to match with selected subject prior to this form

                        if (F4_2_ST_SelectSubject.Subject == Subject1)
                        {
                            cmd.Parameters.AddWithValue("@TeacherEmail", TeacherEmail1);
                        }
                        else if (F4_2_ST_SelectSubject.Subject == Subject2)
                        {
                            cmd.Parameters.AddWithValue("@TeacherEmail", TeacherEmail2);
                        }
                        else if (F4_2_ST_SelectSubject.Subject == Subject3)
                        {
                            cmd.Parameters.AddWithValue("@TeacherEmail", TeacherEmail3);
                        }
                        else
                        {
                            string message = "Error: No Teacher found on certain subject";
                            MessageBox.Show(message);
                        }

                        //END Subject has to match with selected subject prior to this form

                        cmd.Parameters.AddWithValue("@Subject", F4_2_ST_SelectSubject.Subject);
                        cmd.Parameters.AddWithValue("@File", FileName);
                        cmd.Parameters.AddWithValue("@Data", FileContent);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("File Uploaded!");
                        con.Close();
                    }
                }
            }
            AutoUpdate();
        }
    }
}
