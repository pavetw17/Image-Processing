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
    public partial class Histogram : Form
    {
        public Histogram()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void btn_openImage_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"E:\Codes\XLA\XLA\XLA\Resources";
            ofd.Filter = "Image|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            Bitmap bm= new Bitmap(pictureBox1.Image);

            int x, y;
            int[] h = new int[256];

            for (y = 0; y < bm.Height; y++)              //Đếm số lượng số các mức xám từ 0->255
            {
                for (x = 0; x < bm.Width; x++)
                    h[bm.GetPixel(x, y).R]++;
            }
       
            int max = h[0];
            for (int j = 1; j <= 255; j++)           // Tìm mức xám lớn nhất
                if (max < h[j])
                    max = h[j];

            int Height = 421;

            Bitmap bmHistogram = new Bitmap(292, Height);
            Graphics gp = Graphics.FromImage(bmHistogram);
            gp.FillRectangle(Brushes.White, new Rectangle(0, 0, bmHistogram.Width, bmHistogram.Height));  //to màu trang truóc
            //Rectangle: hcn
           
            //code ben duoi ve bieu do
            int n;
            for (int i = 0; i <= 255; i++)
            {
                n = (h[i] * Height) / max;      //số điểm ảnh trung bình của mỗi mức xám        
                gp.DrawLine(new Pen(Color.Teal), i, Height, i, Height-n);  // pen, x1,y1,x2,y2; ve tu x1,y1 den x2,y2
            }

            pictureBox2.Image = bmHistogram;
        }

        private void btn_canbang_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);
            int w = bm.Width * bm.Height;                   // == w           //Tổng số điểm ảnh của bitmap
            //Tinh to chuc do  
            int[] h = new int[256];                       //Mảng lưu Số điểm ảnh từ 0->255 trong bitmap
            double[] hN = new double[256];                //Mảng chứa giá trị sau khi chuẩn hóa

            for (int i = 0; i < bm.Height; i++)         
                for (int j = 0; j < bm.Width; j++)
                    h[bm.GetPixel(j, i).R]++;               //==dem

            //Chuan hoa to chuc do  ứa ca
            for (int i = 0; i <= 255; i++)             //Lấy số giá pixel 0->255 chia cho tổng số điểm ảnh
            {
                hN[i] = (double)h[i] / w;                   //==dem/w   (w=w*h)
            }
            //Tinh ham mat do xac Suat  
            double[] Z = new double[256];
            Z[0] = hN[0];
            for (int i = 1; i <= 255; i++)
            {
                Z[i] = Z[i - 1] + hN[i];                    //
            }
            int x, y, c;
            for (y = 0; y < bm.Height; y++)
            {
                for (x = 0; x < bm.Width; x++)
                {
                    c = bm.GetPixel(x, y).R;
                    c = (int)Math.Round(Z[c] * 255);
                    bm.SetPixel(x, y, Color.FromArgb(c, c, c));
                }
            }
            pic_canbang.Image = bm;
        }

        ImageFormat img = ImageFormat.Png;
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pic_canbang.Image);

            int x, y;
            int[] h = new int[256];

            for (y = 0; y < bm.Height; y++)              //Đếm số lượng số các mức xám từ 0->255
            {
                for (x = 0; x < bm.Width; x++)
                    h[bm.GetPixel(x, y).R]++;
            }

            int max = h[0];
            for (int j = 1; j <= 255; j++)           // Tìm mức xám lớn nhất
                if (max < h[j])
                    max = h[j];

            int Height = 421;

            Bitmap bmHistogram = new Bitmap(292, Height);
            Graphics gp = Graphics.FromImage(bmHistogram);
            gp.FillRectangle(Brushes.White, new Rectangle(0, 0, bmHistogram.Width, bmHistogram.Height));  //to màu trang truóc
            //Rectangle: hcn

            //code ben duoi ve bieu do
            int n;
            for (int i = 0; i <= 255; i++)
            {
                n = (h[i] * Height) / max;      //số điểm ảnh trung bình của mỗi mức xám        
                gp.DrawLine(new Pen(Color.Teal), i, Height, i, Height - n);  // pen, x1,y1,x2,y2; ve tu x1,y1 den x2,y2
            }

            pic_mix_canbang.Image = bmHistogram;
        }

    }
}
