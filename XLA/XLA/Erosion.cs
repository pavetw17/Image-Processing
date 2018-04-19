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
    public partial class Erosion : Form
    {
        public Erosion()
        {
            InitializeComponent();
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

        private void btn_xuly_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);
            Bitmap bmkq = new Bitmap(bm.Width, bm.Height);
          
            int C;
            for (int y = 1; y < bm.Height - 1; y++)
                for (int x = 1; x < bm.Width - 1; x++)
                {
                    if (
                      //  bm.GetPixel(x - 1, y - 1).R == 255 &&
                        bm.GetPixel(x, y - 1).R == 255 &&
                      //  bm.GetPixel(x + 1, y - 1).R == 255 &&

                        bm.GetPixel(x - 1, y).R == 255 &&
                        bm.GetPixel(x, y).R == 255 &&
                        bm.GetPixel(x + 1, y).R == 255 &&

                    //    bm.GetPixel(x - 1, y + 1).R == 255 &&
                        bm.GetPixel(x, y + 1).R == 255 // &&
                     //   bm.GetPixel(x + 1, y + 1).R == 255
                        )
                    {
                        C = 255;
                    }
                    else
                    {
                        C = 0;
                    }
                    bmkq.SetPixel(x, y, Color.FromArgb(C, C, C));
                }

            pictureBox2.Image = bmkq;

        }

        private void btn_xl5x5_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);
            Bitmap bmkq = new Bitmap(bm.Width, bm.Height);
            int C;
            for (int y = 2; y < bm.Height - 2; y++)
                for (int x = 2; x < bm.Width - 2; x++)
                {

                    if (
                 //       bm.GetPixel(x - 2, y - 2).R == 255 &&
                 //       bm.GetPixel(x - 1, y - 2).R == 255 &&
                        bm.GetPixel(x, y - 2).R == 255 &&
                 //       bm.GetPixel(x + 1, y - 2).R == 255 &&
                 //       bm.GetPixel(x + 2, y - 2).R == 255 &&

                  //      bm.GetPixel(x - 2, y - 1).R == 255 &&
                  //      bm.GetPixel(x - 1, y - 1).R == 255 &&
                        bm.GetPixel(x, y - 1).R == 255 &&
                   //     bm.GetPixel(x + 1, y - 1).R == 255 &&
                   //     bm.GetPixel(x + 2, y - 1).R == 255 &&

                        bm.GetPixel(x - 2, y).R == 255 &&
                        bm.GetPixel(x - 1, y).R == 255 &&
                        bm.GetPixel(x, y).R == 255 &&
                        bm.GetPixel(x + 1, y).R == 255 &&
                        bm.GetPixel(x + 2, y).R == 255 &&

                    //    bm.GetPixel(x - 2, y + 1).R == 255 &&
                    //    bm.GetPixel(x - 1, y + 1).R == 255 &&
                        bm.GetPixel(x, y + 1).R == 255 &&
                    //    bm.GetPixel(x + 1, y + 1).R == 255 &&
                     //   bm.GetPixel(x + 2, y + 1).R == 255 &&

                     //   bm.GetPixel(x - 2, y + 2).R == 255 &&
                    //    bm.GetPixel(x - 1, y + 1).R == 255 &&
                        bm.GetPixel(x, y + 2).R == 255    //&&
                     //   bm.GetPixel(x + 1, y + 2).R == 255 &&
                    //    bm.GetPixel(x + 2, y + 2).R == 255
                        )
                    {
                        C = 255;
                    }
                    else
                    {
                        C = 0;
                    }
                    bmkq.SetPixel(x, y, Color.FromArgb(C, C, C));
                }

            pictureBox2.Image = bmkq;
        }
    }
}
