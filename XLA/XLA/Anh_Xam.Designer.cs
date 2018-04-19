namespace Anh_Xam
{
    partial class Anh_Xam
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
            this.btn_anhxam = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_OpenImage = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Anh_Xam.Properties.Resources._01;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_anhxam
            // 
            this.btn_anhxam.Location = new System.Drawing.Point(441, 56);
            this.btn_anhxam.Name = "btn_anhxam";
            this.btn_anhxam.Size = new System.Drawing.Size(91, 202);
            this.btn_anhxam.TabIndex = 1;
            this.btn_anhxam.Text = "Mau Xam";
            this.btn_anhxam.UseVisualStyleBackColor = true;
            this.btn_anhxam.Click += new System.EventHandler(this.btn_anhxam_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(550, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btn_OpenImage
            // 
            this.btn_OpenImage.Location = new System.Drawing.Point(312, 326);
            this.btn_OpenImage.Name = "btn_OpenImage";
            this.btn_OpenImage.Size = new System.Drawing.Size(112, 41);
            this.btn_OpenImage.TabIndex = 3;
            this.btn_OpenImage.Text = "Open Image";
            this.btn_OpenImage.UseVisualStyleBackColor = true;
            this.btn_OpenImage.Click += new System.EventHandler(this.btn_OpenImage_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(550, 326);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 41);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Anh_Xam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 406);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_OpenImage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_anhxam);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Anh_Xam";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_anhxam;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_OpenImage;
        private System.Windows.Forms.Button btn_save;
    }
}

