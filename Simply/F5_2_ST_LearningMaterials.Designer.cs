
namespace Simply
{
    partial class F5_2_ST_LearningMaterials
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Back = new System.Windows.Forms.PictureBox();
            this.lbl_SubType = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Delete = new System.Windows.Forms.PictureBox();
            this.LearningMaterialsData = new System.Windows.Forms.DataGridView();
            this.btn_Download = new System.Windows.Forms.PictureBox();
            this.btn_Upload = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningMaterialsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Upload)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Simply.Properties.Resources.Background_Menu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Image = global::Simply.Properties.Resources.Button_Back;
            this.btn_Back.Location = new System.Drawing.Point(79, 32);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(111, 50);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Back.TabIndex = 25;
            this.btn_Back.TabStop = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_SubType
            // 
            this.lbl_SubType.AutoSize = true;
            this.lbl_SubType.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SubType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_SubType.Location = new System.Drawing.Point(275, 32);
            this.lbl_SubType.Name = "lbl_SubType";
            this.lbl_SubType.Size = new System.Drawing.Size(513, 56);
            this.lbl_SubType.TabIndex = 26;
            this.lbl_SubType.Text = "- insert subject type -";
            this.lbl_SubType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Simply.Properties.Resources.Button_SubBlank;
            this.pictureBox2.Location = new System.Drawing.Point(79, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Image = global::Simply.Properties.Resources.Button_Delete;
            this.btn_Delete.Location = new System.Drawing.Point(610, 568);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(111, 50);
            this.btn_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Delete.TabIndex = 28;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // LearningMaterialsData
            // 
            this.LearningMaterialsData.AllowUserToAddRows = false;
            this.LearningMaterialsData.AllowUserToDeleteRows = false;
            this.LearningMaterialsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LearningMaterialsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LearningMaterialsData.Location = new System.Drawing.Point(365, 154);
            this.LearningMaterialsData.Name = "LearningMaterialsData";
            this.LearningMaterialsData.ReadOnly = true;
            this.LearningMaterialsData.RowTemplate.Height = 25;
            this.LearningMaterialsData.Size = new System.Drawing.Size(596, 376);
            this.LearningMaterialsData.TabIndex = 29;
            this.LearningMaterialsData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LearningMaterialsData_CellContentClick);
            // 
            // btn_Download
            // 
            this.btn_Download.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Download.Image = global::Simply.Properties.Resources.Button_Download;
            this.btn_Download.Location = new System.Drawing.Point(475, 568);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(111, 50);
            this.btn_Download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Download.TabIndex = 30;
            this.btn_Download.TabStop = false;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Upload.Image = global::Simply.Properties.Resources.Button_Upload;
            this.btn_Upload.Location = new System.Drawing.Point(746, 568);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(111, 50);
            this.btn_Upload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Upload.TabIndex = 31;
            this.btn_Upload.TabStop = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // F5_2_ST_LearningMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.LearningMaterialsData);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_SubType);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "F5_2_ST_LearningMaterials";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F5_2_ST_LearningMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningMaterialsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Upload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_Back;
        private System.Windows.Forms.Label lbl_SubType;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btn_Delete;
        private System.Windows.Forms.DataGridView LearningMaterialsData;
        private System.Windows.Forms.PictureBox btn_Download;
        private System.Windows.Forms.PictureBox btn_Upload;
    }
}