namespace Anh_Xam
{
    partial class Median_Filter
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_xuly = new System.Windows.Forms.Button();
            this.btn_xl5x5 = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Anh_Xam.Properties.Resources.salt_noise;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(377, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 280);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_xuly
            // 
            this.btn_xuly.Location = new System.Drawing.Point(160, 321);
            this.btn_xuly.Name = "btn_xuly";
            this.btn_xuly.Size = new System.Drawing.Size(100, 44);
            this.btn_xuly.TabIndex = 2;
            this.btn_xuly.Text = "Xu Ly 3x3";
            this.btn_xuly.UseVisualStyleBackColor = true;
            this.btn_xuly.Click += new System.EventHandler(this.btn_xuly_Click);
            // 
            // btn_xl5x5
            // 
            this.btn_xl5x5.Location = new System.Drawing.Point(326, 321);
            this.btn_xl5x5.Name = "btn_xl5x5";
            this.btn_xl5x5.Size = new System.Drawing.Size(104, 44);
            this.btn_xl5x5.TabIndex = 3;
            this.btn_xl5x5.Text = "Xu Ly 5x5";
            this.btn_xl5x5.UseVisualStyleBackColor = true;
            this.btn_xl5x5.Click += new System.EventHandler(this.btn_xl5x5_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(12, 321);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(91, 44);
            this.btn_open.TabIndex = 8;
            this.btn_open.Text = "Open Image";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Median_Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 373);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_xl5x5);
            this.Controls.Add(this.btn_xuly);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Median_Filter";
            this.Text = "Median_Filter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_xuly;
        private System.Windows.Forms.Button btn_xl5x5;
        private System.Windows.Forms.Button btn_open;
    }
}