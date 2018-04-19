namespace Anh_Xam
{
    partial class Histogram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.]
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
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_openImage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_canbang = new System.Windows.Forms.Button();
            this.pic_canbang = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pic_mix_canbang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_canbang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mix_canbang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(297, 262);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(87, 40);
            this.btn_xem.TabIndex = 2;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_openImage
            // 
            this.btn_openImage.Location = new System.Drawing.Point(12, 262);
            this.btn_openImage.Name = "btn_openImage";
            this.btn_openImage.Size = new System.Drawing.Size(126, 40);
            this.btn_openImage.TabIndex = 3;
            this.btn_openImage.Text = "Open Image";
            this.btn_openImage.UseVisualStyleBackColor = true;
            this.btn_openImage.Click += new System.EventHandler(this.btn_openImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(13, 308);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Anh_Xam.Properties.Resources._3;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_canbang
            // 
            this.btn_canbang.Location = new System.Drawing.Point(466, 262);
            this.btn_canbang.Name = "btn_canbang";
            this.btn_canbang.Size = new System.Drawing.Size(123, 40);
            this.btn_canbang.TabIndex = 5;
            this.btn_canbang.Text = "Cân bằng";
            this.btn_canbang.UseVisualStyleBackColor = true;
            this.btn_canbang.Click += new System.EventHandler(this.btn_canbang_Click);
            // 
            // pic_canbang
            // 
            this.pic_canbang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_canbang.Location = new System.Drawing.Point(466, 13);
            this.pic_canbang.Name = "pic_canbang";
            this.pic_canbang.Size = new System.Drawing.Size(356, 241);
            this.pic_canbang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_canbang.TabIndex = 6;
            this.pic_canbang.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xem 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_mix_canbang
            // 
            this.pic_mix_canbang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_mix_canbang.Location = new System.Drawing.Point(466, 308);
            this.pic_mix_canbang.Name = "pic_mix_canbang";
            this.pic_mix_canbang.Size = new System.Drawing.Size(356, 182);
            this.pic_mix_canbang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mix_canbang.TabIndex = 8;
            this.pic_mix_canbang.TabStop = false;
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 509);
            this.Controls.Add(this.pic_mix_canbang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_canbang);
            this.Controls.Add(this.btn_canbang);
            this.Controls.Add(this.btn_openImage);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Histogram";
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_canbang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mix_canbang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_openImage;
        private System.Windows.Forms.Button btn_canbang;
        private System.Windows.Forms.PictureBox pic_canbang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic_mix_canbang;
    }
}