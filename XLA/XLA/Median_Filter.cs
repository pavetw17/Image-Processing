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
    public partial class Median_Filter : Form
    {
        public Median_Filter()
        {
            InitializeComponent();
        }


        public static void SapXep(int[] a, int n)
        {
            int temp, j;
            for (int i = 0; i < n - 1; i++)
                for (j = n - 1; j > i; j--)
                    if (a[j] < a[j - 1])
                    {
                        temp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = temp;
                    }
        }


        private void btn_xuly_Click(object sender, EventArgs e)
        {
            // i=hight=y, j=width=x
            Bitmap bm = new Bitmap(pictureBox1.Image);
            Bitmap bmkq = new Bitmap(bm.Width, bm.Height);
            int[] R = new int[9];
            int[] G = new int[9];
            int[] B = new int[9];
            
            for (int y = 1; y < bm.Height - 1; y++)
            {
                for (int x = 1; x < bm.Width - 1; x++)
                {

                    R[0] = bm.GetPixel(x - 1, y - 1).R;
                    R[1] = bm.GetPixel(x, y - 1).R;
                    R[2] = bm.GetPixel(x + 1, y - 1).R;

                    R[3] = bm.GetPixel(x - 1, y).R;
                    R[4] = bm.GetPixel(x, y).R;
                    R[5] = bm.GetPixel(x + 1, y).R;

                    R[6] = bm.GetPixel(x - 1, y + 1).R;
                    R[7] = bm.GetPixel(x, y + 1).R;
                    R[8] = bm.GetPixel(x + 1, y + 1).R;

                    //sax xep
                    SapXep(R, 9);
                    //////////////////////////////////////
                    G[0] = bm.GetPixel(x - 1, y - 1).G;
                    G[1] = bm.GetPixel(x, y - 1).G;
                    G[2] = bm.GetPixel(x + 1, y - 1).G;

                    G[3] = bm.GetPixel(x - 1, y).G;
                    G[4] = bm.GetPixel(x, y).G;
                    G[5] = bm.GetPixel(x + 1, y).G;

                    G[6] = bm.GetPixel(x - 1, y + 1).G;
                    G[7] = bm.GetPixel(x, y + 1).G;
                    G[8] = bm.GetPixel(x + 1, y + 1).G;

                    SapXep(G, 9);
                    ////////////////////////////////////
                    B[0] = bm.GetPixel(x - 1, y - 1).B;
                    B[1] = bm.GetPixel(x, y - 1).B;
                    B[2] = bm.GetPixel(x + 1, y - 1).B;

                    B[3] = bm.GetPixel(x - 1, y).B;
                    B[4] = bm.GetPixel(x, y).B;
                    B[5] = bm.GetPixel(x + 1, y).B;

                    B[6] = bm.GetPixel(x - 1, y + 1).B;
                    B[7] = bm.GetPixel(x, y + 1).B;
                    B[8] = bm.GetPixel(x + 1, y + 1).B;

                    SapXep(B, 9);

                    bmkq.SetPixel(x, y, Color.FromArgb(R[4], G[4], B[4]));
                }
            }
            pictureBox2.Image = bmkq;
        }

        private void btn_xl5x5_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);
            Bitmap bmkq = new Bitmap(bm.Width, bm.Height);
            int[] R = new int[25];
            int[] G = new int[25];
            int[] B = new int[25];
            for (int y = 2; y < bm.Height - 2; y++)
            {
                for (int x = 2; x < bm.Width - 2; x++)
                {

                    R[0] = bm.GetPixel(x - 2, y - 2).R;
                    R[1] = bm.GetPixel(x - 1, y - 2).R;
                    R[2] = bm.GetPixel(x, y - 2).R;
                    R[3] = bm.GetPixel(x + 1, y - 2).R;
                    R[4] = bm.GetPixel(x + 2, y - 2).R;

                    R[5] = bm.GetPixel(x - 2, y - 1).R;
                    R[6] = bm.GetPixel(x - 1, y - 1).R;
                    R[7] = bm.GetPixel(x, y - 1).R;
                    R[8] = bm.GetPixel(x + 1, y - 1).R;
                    R[9] = bm.GetPixel(x + 2, y - 1).R;

                    R[10] = bm.GetPixel(x - 2, y).R;
                    R[11] = bm.GetPixel(x - 1, y).R;
                    R[12] = bm.GetPixel(x, y).R;
                    R[13] = bm.GetPixel(x + 1, y).R;
                    R[14] = bm.GetPixel(x + 2, y).R;

                    R[15] = bm.GetPixel(x - 2, y + 1).R;
                    R[16] = bm.GetPixel(x - 1, y + 1).R;
                    R[17] = bm.GetPixel(x, y + 1).R;
                    R[18] = bm.GetPixel(x + 1, y + 1).R;
                    R[19] = bm.GetPixel(x + 2, y + 1).R;

                    R[20] = bm.GetPixel(x - 2, y + 2).R;
                    R[21] = bm.GetPixel(x - 1, y + 2).R;
                    R[22] = bm.GetPixel(x, y + 2).R;
                    R[23] = bm.GetPixel(x + 1, y + 2).R;
                    R[24] = bm.GetPixel(x + 2, y + 2).R;

                    //sax xep
                    SapXep(R, 25);

                    ///////////////////////////////////
                    G[0] = bm.GetPixel(x - 2, y - 2).G;
                    G[1] = bm.GetPixel(x - 1, y - 2).G;
                    G[2] = bm.GetPixel(x, y - 2).G;
                    G[3] = bm.GetPixel(x + 1, y - 2).G;
                    G[4] = bm.GetPixel(x + 2, y - 2).G;

                    G[5] = bm.GetPixel(x - 2, y - 1).G;
                    G[6] = bm.GetPixel(x - 1, y - 1).G;
                    G[7] = bm.GetPixel(x, y - 1).G;
                    G[8] = bm.GetPixel(x + 1, y - 1).G;
                    G[9] = bm.GetPixel(x + 2, y - 1).G;

                    G[10] = bm.GetPixel(x - 2, y).G;
                    G[11] = bm.GetPixel(x - 1, y).G;
                    G[12] = bm.GetPixel(x, y).G;
                    G[13] = bm.GetPixel(x + 1, y).G;
                    G[14] = bm.GetPixel(x + 2, y).G;

                    G[15] = bm.GetPixel(x - 2, y + 1).G;
                    G[16] = bm.GetPixel(x - 1, y + 1).G;
                    G[17] = bm.GetPixel(x, y + 1).G;
                    G[18] = bm.GetPixel(x + 1, y + 1).G;
                    G[19] = bm.GetPixel(x + 2, y + 1).G;

                    G[20] = bm.GetPixel(x - 2, y + 2).G;
                    G[21] = bm.GetPixel(x - 1, y + 2).G;
                    G[22] = bm.GetPixel(x, y + 2).G;
                    G[23] = bm.GetPixel(x + 1, y + 2).G;
                    G[24] = bm.GetPixel(x + 2, y + 2).G;

                    //sax xep
                    SapXep(G, 25);

                    ///////////////////////////////////
                    B[0] = bm.GetPixel(x - 2, y - 2).B;
                    B[1] = bm.GetPixel(x - 1, y - 2).B;
                    B[2] = bm.GetPixel(x, y - 2).B;
                    B[3] = bm.GetPixel(x + 1, y - 2).B;
                    B[4] = bm.GetPixel(x + 2, y - 2).B;

                    B[5] = bm.GetPixel(x - 2, y - 1).B;
                    B[6] = bm.GetPixel(x - 1, y - 1).B;
                    B[7] = bm.GetPixel(x, y - 1).B;
                    B[8] = bm.GetPixel(x + 1, y - 1).B;
                    B[9] = bm.GetPixel(x + 2, y - 1).B;

                    B[10] = bm.GetPixel(x - 2, y).B;
                    B[11] = bm.GetPixel(x - 1, y).B;
                    B[12] = bm.GetPixel(x, y).B;
                    B[13] = bm.GetPixel(x + 1, y).B;
                    B[14] = bm.GetPixel(x + 2, y).B;

                    B[15] = bm.GetPixel(x - 2, y + 1).B;
                    B[16] = bm.GetPixel(x - 1, y + 1).B;
                    B[17] = bm.GetPixel(x, y + 1).B;
                    B[18] = bm.GetPixel(x + 1, y + 1).B;
                    B[19] = bm.GetPixel(x + 2, y + 1).B;

                    B[20] = bm.GetPixel(x - 2, y + 2).B;
                    B[21] = bm.GetPixel(x - 1, y + 2).B;
                    B[22] = bm.GetPixel(x, y + 2).B;
                    B[23] = bm.GetPixel(x + 1, y + 2).B;
                    B[24] = bm.GetPixel(x + 2, y + 2).B;

                    //sax xep
                    SapXep(B, 25);
                    bmkq.SetPixel(x, y, Color.FromArgb(R[12], G[12], B[12]));
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