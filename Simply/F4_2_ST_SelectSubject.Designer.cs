
namespace Simply
{
    partial class F4_2_ST_SelectSubject
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
            this.Button_Subject1 = new System.Windows.Forms.PictureBox();
            this.Button_Subject2 = new System.Windows.Forms.PictureBox();
            this.Button_Subject3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Subject1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Subject2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Subject3)).BeginInit();
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
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Back
            // 
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Image = global::Simply.Properties.Resources.Button_Back;
            this.btn_Back.Location = new System.Drawing.Point(83, 71);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(111, 50);
            this.btn_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Back.TabIndex = 24;
            this.btn_Back.TabStop = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_SubType
            // 
            this.lbl_SubType.AutoSize = true;
            this.lbl_SubType.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SubType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_SubType.Location = new System.Drawing.Point(275, 71);
            this.lbl_SubType.Name = "lbl_SubType";
            this.lbl_SubType.Size = new System.Drawing.Size(513, 56);
            this.lbl_SubType.TabIndex = 25;
            this.lbl_SubType.Text = "- insert subject type -";
            this.lbl_SubType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Subject1
            // 
            this.Button_Subject1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Subject1.Image = global::Simply.Properties.Resources.Button_SubBlank;
            this.Button_Subject1.Location = new System.Drawing.Point(83, 196);
            this.Button_Subject1.Name = "Button_Subject1";
            this.Button_Subject1.Size = new System.Drawing.Size(235, 360);
            this.Button_Subject1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Subject1.TabIndex = 26;
            this.Button_Subject1.TabStop = false;
            // 
            // Button_Subject2
            // 
            this.Button_Subject2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Subject2.Image = global::Simply.Properties.Resources.Button_SubBlank;
            this.Button_Subject2.Location = new System.Drawing.Point(413, 196);
            this.Button_Subject2.Name = "Button_Subject2";
            this.Button_Subject2.Size = new System.Drawing.Size(235, 360);
            this.Button_Subject2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Subject2.TabIndex = 27;
            this.Button_Subject2.TabStop = false;
            // 
            // Button_Subject3
            // 
            this.Button_Subject3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Subject3.Image = global::Simply.Properties.Resources.Button_SubBlank;
            this.Button_Subject3.Location = new System.Drawing.Point(741, 196);
            this.Button_Subject3.Name = "Button_Subject3";
            this.Button_Subject3.Size = new System.Drawing.Size(235, 360);
            this.Button_Subject3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Subject3.TabIndex = 28;
            this.Button_Subject3.TabStop = false;
            // 
            // F4_2_SelectSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.Button_Subject3);
            this.Controls.Add(this.Button_Subject2);
            this.Controls.Add(this.Button_Subject1);
            this.Controls.Add(this.lbl_SubType);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "F4_2_SelectSubject";
            this.Text = "F5_1_SubjectMeetingsMenu";
            this.Load += new System.EventHandler(this.F4_2_SelectSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Subject1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Subject2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Subject3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_Back;
        private System.Windows.Forms.Label lbl_SubType;
        private System.Windows.Forms.PictureBox Button_Subject1;
        private System.Windows.Forms.PictureBox Button_Subject2;
        private System.Windows.Forms.PictureBox Button_Subject3;
    }
}