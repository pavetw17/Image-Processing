namespace Anh_Xam
{
    partial class ZoomIn_ZoomOut
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
            this.btn_zoomIn_laplai = new System.Windows.Forms.Button();
            this.btn_zoomOut_laplai = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Out_tt = new System.Windows.Forms.Button();
            this.btn_In_tt = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_zoomIn_laplai
            // 
            this.btn_zoomIn_laplai.Location = new System.Drawing.Point(6, 16);
            this.btn_zoomIn_laplai.Name = "btn_zoomIn_laplai";
            this.btn_zoomIn_laplai.Size = new System.Drawing.Size(119, 31);
            this.btn_zoomIn_laplai.TabIndex = 0;
            this.btn_zoomIn_laplai.Text = "Zoom In";
            this.btn_zoomIn_laplai.UseVisualStyleBackColor = true;
            this.btn_zoomIn_laplai.Click += new System.EventHandler(this.btn_zoomIn_laplai_Click);
            // 
            // btn_zoomOut_laplai
            // 
            this.btn_zoomOut_laplai.Location = new System.Drawing.Point(154, 16);
            this.btn_zoomOut_laplai.Name = "btn_zoomOut_laplai";
            this.btn_zoomOut_laplai.Size = new System.Drawing.Size(108, 31);
            this.btn_zoomOut_laplai.TabIndex = 1;
            this.btn_zoomOut_laplai.Text = "Zoom Out";
            this.btn_zoomOut_laplai.UseVisualStyleBackColor = true;
            this.btn_zoomOut_laplai.Click += new System.EventHandler(this.btn_zoomOut_laplai_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(334, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 500);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Anh_Xam.Properties.Resources._1352414;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "High";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_zoomIn_laplai);
            this.groupBox1.Controls.Add(this.btn_zoomOut_laplai);
            this.groupBox1.Location = new System.Drawing.Point(16, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 53);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lặp Lại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Out_tt);
            this.groupBox2.Controls.Add(this.btn_In_tt);
            this.groupBox2.Location = new System.Drawing.Point(16, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 59);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tuyến Tính";
            // 
            // btn_Out_tt
            // 
            this.btn_Out_tt.Location = new System.Drawing.Point(154, 15);
            this.btn_Out_tt.Name = "btn_Out_tt";
            this.btn_Out_tt.Size = new System.Drawing.Size(108, 34);
            this.btn_Out_tt.TabIndex = 1;
            this.btn_Out_tt.Text = "Zoom Out";
            this.btn_Out_tt.UseVisualStyleBackColor = true;
            this.btn_Out_tt.Click += new System.EventHandler(this.btn_Out_tt_Click);
            // 
            // btn_In_tt
            // 
            this.btn_In_tt.Location = new System.Drawing.Point(6, 15);
            this.btn_In_tt.Name = "btn_In_tt";
            this.btn_In_tt.Size = new System.Drawing.Size(119, 34);
            this.btn_In_tt.TabIndex = 0;
            this.btn_In_tt.Text = "Zoom In";
            this.btn_In_tt.UseVisualStyleBackColor = true;
            this.btn_In_tt.Click += new System.EventHandler(this.btn_In_tt_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 266);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(214, 266);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(73, 20);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ZoomIn_ZoomOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 533);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ZoomIn_ZoomOut";
            this.Text = "ZoomIN_ZoomOut";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_zoomIn_laplai;
        private System.Windows.Forms.Button btn_zoomOut_laplai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_In_tt;
        private System.Windows.Forms.Button btn_Out_tt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}