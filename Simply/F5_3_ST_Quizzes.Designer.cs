
namespace Simply
{
    partial class F5_3_ST_Quizzes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Delete = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_SubType = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QuizData = new System.Windows.Forms.DataGridView();
            this.btn_Download = new System.Windows.Forms.PictureBox();
            this.btn_Upload = new System.Windows.Forms.PictureBox();
            this.btn_View = new System.Windows.Forms.PictureBox();
            this.btn_Hide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuizData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Upload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Image = global::Simply.Properties.Resources.Button_Delete;
            this.btn_Delete.Location = new System.Drawing.Point(685, 568);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(111, 50);
            this.btn_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Delete.TabIndex = 33;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Simply.Properties.Resources.Button_SubBlank;
            this.pictureBox2.Location = new System.Drawing.Point(79, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_SubType
            // 
            this.lbl_SubType.AutoSize = true;
            this.lbl_SubType.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SubType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_SubType.Location = new System.Drawing.Point(275, 32);
            this.lbl_SubType.Name = "lbl_SubType";
            this.lbl_SubType.Size = new System.Drawing.Size(513, 56);
            this.lbl_SubType.TabIndex = 31;
            this.lbl_SubType.Text = "- insert subject type -";
            this.lbl_SubType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Back
            // 
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Image = global::Simply.Properties.Resources.Button_Back;
            this.btn_Back.Location = new System.Drawing.Point(79, 32);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(111, 50);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Back.TabIndex = 30;
            this.btn_Back.TabStop = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Simply.Properties.Resources.Background_Menu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // QuizData
            // 
            this.QuizData.AllowUserToAddRows = false;
            this.QuizData.AllowUserToDeleteRows = false;
            this.QuizData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuizData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuizData.Location = new System.Drawing.Point(365, 154);
            this.QuizData.Name = "QuizData";
            this.QuizData.ReadOnly = true;
            this.QuizData.RowTemplate.Height = 25;
            this.QuizData.Size = new System.Drawing.Size(596, 376);
            this.QuizData.TabIndex = 34;
            this.QuizData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.QuizData_CellMouseClick);
            // 
            // btn_Download
            // 
            this.btn_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Download.Image = global::Simply.Properties.Resources.Button_Download;
            this.btn_Download.Location = new System.Drawing.Point(526, 568);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(111, 50);
            this.btn_Download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Download.TabIndex = 35;
            this.btn_Download.TabStop = false;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Upload.Image = global::Simply.Properties.Resources.Button_Upload;
            this.btn_Upload.Location = new System.Drawing.Point(847, 568);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(111, 50);
            this.btn_Upload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Upload.TabIndex = 36;
            this.btn_Upload.TabStop = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_View
            // 
            this.btn_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View.Image = global::Simply.Properties.Resources.Button_View1;
            this.btn_View.Location = new System.Drawing.Point(365, 568);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(111, 50);
            this.btn_View.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_View.TabIndex = 37;
            this.btn_View.TabStop = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hide.Image = global::Simply.Properties.Resources.Button_Hide;
            this.btn_Hide.Location = new System.Drawing.Point(365, 568);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(111, 50);
            this.btn_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Hide.TabIndex = 38;
            this.btn_Hide.TabStop = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // F5_3_ST_Quizzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.QuizData);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_SubType);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "F5_3_ST_Quizzes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F5_3_ST_Quizzes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuizData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Upload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Delete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_SubType;
        private System.Windows.Forms.PictureBox btn_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView QuizData;
        private System.Windows.Forms.PictureBox btn_Download;
        private System.Windows.Forms.PictureBox btn_Upload;
        private System.Windows.Forms.PictureBox btn_View;
        private System.Windows.Forms.PictureBox btn_Hide;
    }
}