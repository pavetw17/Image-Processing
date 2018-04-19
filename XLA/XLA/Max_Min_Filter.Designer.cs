namespace Anh_Xam
{
    partial class Max_Min_Filter
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
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_xl5x5 = new System.Windows.Forms.Button();
            this.btn_xuly = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_min5x5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(12, 316);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(91, 44);
            this.btn_open.TabIndex = 13;
            this.btn_open.Text = "Open Image";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_xl5x5
            // 
            this.btn_xl5x5.Location = new System.Drawing.Point(169, 19);
            this.btn_xl5x5.Name = "btn_xl5x5";
            this.btn_xl5x5.Size = new System.Drawing.Size(104, 42);
            this.btn_xl5x5.TabIndex = 12;
            this.btn_xl5x5.Text = "Xu Ly 5x5";
            this.btn_xl5x5.UseVisualStyleBackColor = true;
            this.btn_xl5x5.Click += new System.EventHandler(this.btn_xl5x5_Click);
            // 
            // btn_xuly
            // 
            this.btn_xuly.Location = new System.Drawing.Point(6, 19);
            this.btn_xuly.Name = "btn_xuly";
            this.btn_xuly.Size = new System.Drawing.Size(100, 42);
            this.btn_xuly.TabIndex = 11;
            this.btn_xuly.Text = "Xu Ly 3x3";
            this.btn_xuly.UseVisualStyleBackColor = true;
            this.btn_xuly.Click += new System.EventHandler(this.btn_xuly_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(351, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 280);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Anh_Xam.Properties.Resources.maybay_noise;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xuly);
            this.groupBox1.Controls.Add(this.btn_xl5x5);
            this.groupBox1.Location = new System.Drawing.Point(351, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 67);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Max Filter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_min5x5);
            this.groupBox2.Controls.Add(this.btn_min);
            this.groupBox2.Location = new System.Drawing.Point(688, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 64);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Min Filter";
            // 
            // btn_min
            // 
            this.btn_min.Location = new System.Drawing.Point(7, 19);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(99, 38);
            this.btn_min.TabIndex = 0;
            this.btn_min.Text = "Xu Ly 3x3";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_min5x5
            // 
            this.btn_min5x5.Location = new System.Drawing.Point(169, 19);
            this.btn_min5x5.Name = "btn_min5x5";
            this.btn_min5x5.Size = new System.Drawing.Size(99, 38);
            this.btn_min5x5.TabIndex = 1;
            this.btn_min5x5.Text = "Xu Ly 5x5";
            this.btn_min5x5.UseVisualStyleBackColor = true;
            this.btn_min5x5.Click += new System.EventHandler(this.btn_min5x5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(688, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(317, 280);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // Max_Min_Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 392);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Max_Min_Filter";
            this.Text = "Max_Min_Filter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_xl5x5;
        private System.Windows.Forms.Button btn_xuly;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_min5x5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}