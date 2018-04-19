using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Anh_Xam
{
    public partial class Anh_Xam : Form
    {
        public Anh_Xam()
        {
            InitializeComponent();
        }

        private void btn_anhxam_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);
            int x, y;
            Color c;
            Byte gray;

            for (y = 0; y < bm.Height - 1; y++)
            {
                for (x = 0; x < bm.Width - 1; x++)
                {
                    c = bm.GetPixel(x, y);
                    gray = Convert.ToByte((c.R + c.G + c.B) / 3);
                    bm.SetPixel(x,y,Color.FromArgb(gray,gray,gray));
                }
            }
            pictureBox2.Image =bm;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void btn_OpenImage_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"E:\";  //:\ là dấu đặt biêt nên ta cho @
            ofd.Filter = "Image|*.png;*.jpg;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                //pictureBox1.ImageLocation = ofd.FileName;  //cách 2
            }
        }

        ImageFormat img = ImageFormat.Png;
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"E:\Codes\XLA\XLA\XLA\Resources";
            sfd.Filter = "PNG|*.png|JPG|*.jpg";
            int index = 0;
            index = sfd.FilterIndex;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (index)
                {
                    case 0: img = ImageFormat.Png;
                        break;
                    case 1: img = ImageFormat.Jpeg;
                        break;
                    default: img = ImageFormat.Png;
                        break;
                }
                pictureBox2.Image.Save(sfd.FileName, img);

            }
        }
    }
}
