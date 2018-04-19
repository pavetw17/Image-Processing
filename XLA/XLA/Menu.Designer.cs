namespace Anh_Xam
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_chuongtrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_anhxam = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_histogram = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averagingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zomInZomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_gioithieu = new System.Windows.Forms.ToolStripMenuItem();
            this.maxMinFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_chuongtrinh,
            this.menu_gioithieu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_chuongtrinh
            // 
            this.menu_chuongtrinh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_anhxam,
            this.menu_histogram,
            this.medianFilterToolStripMenuItem,
            this.averagingToolStripMenuItem,
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.maxMinFilterToolStripMenuItem,
            this.zomInZomOutToolStripMenuItem});
            this.menu_chuongtrinh.Name = "menu_chuongtrinh";
            this.menu_chuongtrinh.Size = new System.Drawing.Size(84, 20);
            this.menu_chuongtrinh.Text = "Chương Trình";
            // 
            // menu_anhxam
            // 
            this.menu_anhxam.Name = "menu_anhxam";
            this.menu_anhxam.Size = new System.Drawing.Size(161, 22);
            this.menu_anhxam.Text = "Ảnh Xám";
            this.menu_anhxam.Click += new System.EventHandler(this.menu_anhxam_Click);
            // 
            // menu_histogram
            // 
            this.menu_histogram.Name = "menu_histogram";
            this.menu_histogram.Size = new System.Drawing.Size(161, 22);
            this.menu_histogram.Text = "Histogram";
            this.menu_histogram.Click += new System.EventHandler(this.menu_histogram_Click);
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.medianFilterToolStripMenuItem.Text = "Median Filter";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // averagingToolStripMenuItem
            // 
            this.averagingToolStripMenuItem.Name = "averagingToolStripMenuItem";
            this.averagingToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.averagingToolStripMenuItem.Text = "Averaging Filter";
            this.averagingToolStripMenuItem.Click += new System.EventHandler(this.averagingToolStripMenuItem_Click);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // zomInZomOutToolStripMenuItem
            // 
            this.zomInZomOutToolStripMenuItem.Name = "zomInZomOutToolStripMenuItem";
            this.zomInZomOutToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.zomInZomOutToolStripMenuItem.Text = "ZomIn_ZomOut";
            this.zomInZomOutToolStripMenuItem.Click += new System.EventHandler(this.zomInZomOutToolStripMenuItem_Click);
            // 
            // menu_gioithieu
            // 
            this.menu_gioithieu.Name = "menu_gioithieu";
            this.menu_gioithieu.Size = new System.Drawing.Size(65, 20);
            this.menu_gioithieu.Text = "Giới Thiệu";
            // 
            // maxMinFilterToolStripMenuItem
            // 
            this.maxMinFilterToolStripMenuItem.Name = "maxMinFilterToolStripMenuItem";
            this.maxMinFilterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.maxMinFilterToolStripMenuItem.Text = "Max Min Filter";
            this.maxMinFilterToolStripMenuItem.Click += new System.EventHandler(this.maxMinFilterToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 269);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử Lý Ảnh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_chuongtrinh;
        private System.Windows.Forms.ToolStripMenuItem menu_anhxam;
        private System.Windows.Forms.ToolStripMenuItem menu_histogram;
        private System.Windows.Forms.ToolStripMenuItem menu_gioithieu;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averagingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zomInZomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxMinFilterToolStripMenuItem;

    }
}