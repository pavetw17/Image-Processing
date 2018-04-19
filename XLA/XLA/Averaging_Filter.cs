using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anh_Xam
{
    public partial class Averaging_Filter : Form
    {
        public Averaging_Filter()
        {
            InitializeComponent();
        }

        private void btn_xuly_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);
            Bitmap bmkq = new Bitmap(bm.Width, bm.Height);
            //Rectangle rec = new Rectangle(0, 0, bm.Width, bm.Height);
            //System.Drawing.Imaging.BitmapData bmpData = bm.LockBits(rec, System.Drawing.Imaging.ImageLockMode.ReadWrite, bm.PixelFormat);
            //int stride = bmpData.Stride;


            //Rectangle rec1 = new Rectangle(0, 0, bmkq.Width, bmkq.Height);
            //System.Drawing.Imaging.BitmapData bmpData1 = bmkq.LockBits(rec1, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmkq.PixelFormat); 
        
            
            int R, G, B;
            for (int y = 1; y < bm.Height - 1; y++)
            {
                for (int x = 1; x < bm.Width - 1; x++)
                {
                    R = (bm.GetPixel(x - 1, y - 1).R + bm.GetPixel(x, y - 1).R + bm.GetPixel(x + 1, y - 1).R +
                                bm.GetPixel(x - 1, y).R + bm.GetPixel(x, y).R + bm.GetPixel(x + 1, y).R +
                                bm.GetPixel(x - 1, y + 1).R + bm.GetPixel(x, y + 1).R + bm.GetPixel(x + 1, y + 1).R) / 9;

                    G = (bm.GetPixel(x - 1, y - 1).G + bm.GetPixel(x, y - 1).G + bm.GetPixel(x + 1, y - 1).G +
                               bm.GetPixel(x - 1, y).G + bm.GetPixel(x, y).G + bm.GetPixel(x + 1, y).G +
                               bm.GetPixel(x - 1, y + 1).G + bm.GetPixel(x, y + 1).G + bm.GetPixel(x + 1, y + 1).G) / 9;

                    B = (bm.GetPixel(x - 1, y - 1).B + bm.GetPixel(x, y - 1).B + bm.GetPixel(x + 1, y - 1).B +
                               bm.GetPixel(x - 1, y).B + bm.GetPixel(x, y).B + bm.GetPixel(x + 1, y).B +
                               bm.GetPixel(x - 1, y + 1).B + bm.GetPixel(x, y + 1).B + bm.GetPixel(x + 1, y + 1).B) / 9;


                    bmkq.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }
            
            //bmkq.UnlockBits(bmpData1);
            //bm.UnlockBits(bmpData); 
           
            pictureBox2.Image = bmkq;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);
            Bitmap bmkq = new Bitmap(bm.Width, bm.Height);
            int R,G,B;
            for (int y = 2; y < bm.Height - 2; y++)
            {
                for (int x = 2; x < bm.Width - 2; x++)
                {
                    R = (bm.GetPixel(x - 2, y - 2).R + bm.GetPixel(x - 1, y - 2).R + bm.GetPixel(x, y - 2).R + bm.GetPixel(x + 1, y - 2).R + bm.GetPixel(x + 2, y - 2).R +
                          bm.GetPixel(x - 2, y - 1).R + bm.GetPixel(x - 1, y - 1).R + bm.GetPixel(x, y - 1).R + bm.GetPixel(x + 1, y - 1).R + bm.GetPixel(x + 2, y - 1).R +
                          bm.GetPixel(x - 2, y).R + bm.GetPixel(x - 1, y).R + bm.GetPixel(x, y).R + bm.GetPixel(x + 1, y).R + bm.GetPixel(x + 2, y).R +
                          bm.GetPixel(x - 2, y + 1).R + bm.GetPixel(x - 1, y + 1).R + bm.GetPixel(x, y + 1).R + bm.GetPixel(x + 1, y + 1).R + bm.GetPixel(x + 2, y + 1).R +
                          bm.GetPixel(x - 2, y + 2).R + bm.GetPixel(x - 1, y + 1).R + bm.GetPixel(x, y + 2).R + bm.GetPixel(x + 1, y + 2).R + bm.GetPixel(x + 2, y + 2).R) / 25;

                    G = (bm.GetPixel(x - 2, y - 2).G + bm.GetPixel(x - 1, y - 2).G + bm.GetPixel(x, y - 2).G + bm.GetPixel(x + 1, y - 2).G + bm.GetPixel(x + 2, y - 2).G +
                      bm.GetPixel(x - 2, y - 1).G + bm.GetPixel(x - 1, y - 1).G + bm.GetPixel(x, y - 1).G + bm.GetPixel(x + 1, y - 1).G + bm.GetPixel(x + 2, y - 1).G +
                      bm.GetPixel(x - 2, y).R + bm.GetPixel(x - 1, y).R + bm.GetPixel(x, y).R + bm.GetPixel(x + 1, y).R + bm.GetPixel(x + 2, y).G +
                      bm.GetPixel(x - 2, y + 1).G + bm.GetPixel(x - 1, y + 1).G + bm.GetPixel(x, y + 1).G + bm.GetPixel(x + 1, y + 1).G + bm.GetPixel(x + 2, y + 1).G +
                      bm.GetPixel(x - 2, y + 2).G + bm.GetPixel(x - 1, y + 1).G + bm.GetPixel(x, y + 2).G + bm.GetPixel(x + 1, y + 2).G + bm.GetPixel(x + 2, y + 2).G) / 25;

                    B = (bm.GetPixel(x - 2, y - 2).B + bm.GetPixel(x - 1, y - 2).B + bm.GetPixel(x, y - 2).B + bm.GetPixel(x + 1, y - 2).B + bm.GetPixel(x + 2, y - 2).B +
                      bm.GetPixel(x - 2, y - 1).B + bm.GetPixel(x - 1, y - 1).B + bm.GetPixel(x, y - 1).B + bm.GetPixel(x + 1, y - 1).B + bm.GetPixel(x + 2, y - 1).B +
                      bm.GetPixel(x - 2, y).R + bm.GetPixel(x - 1, y).B + bm.GetPixel(x, y).R + bm.GetPixel(x + 1, y).R + bm.GetPixel(x + 2, y).B +
                      bm.GetPixel(x - 2, y + 1).B + bm.GetPixel(x - 1, y + 1).B + bm.GetPixel(x, y + 1).B + bm.GetPixel(x + 1, y + 1).B + bm.GetPixel(x + 2, y + 1).B +
                      bm.GetPixel(x - 2, y + 2).B + bm.GetPixel(x - 1, y + 1).B + bm.GetPixel(x, y + 2).B + bm.GetPixel(x + 1, y + 2).B + bm.GetPixel(x + 2, y + 2).B) / 25;

                    bmkq.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }
            pictureBox2.Image = bmkq;
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void btn_open_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"E:\Codes\XLA\XLA\XLA\Resources";  //:\ là dấu đặt biêt nên ta cho @
            ofd.Filter = "Image|*.png;*.jpg;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                //pictureBox1.ImageLocation = ofd.FileName;  //cách 2
            }
        }
    }
}
