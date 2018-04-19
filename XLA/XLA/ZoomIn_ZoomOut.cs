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
    public partial class ZoomIn_ZoomOut : Form
    {
        public ZoomIn_ZoomOut()
        {
            InitializeComponent();
        }

        private void btn_zoomIn_laplai_Click(object sender, EventArgs e)
        {
            //phuong phap lap
            Bitmap bm = new Bitmap(pictureBox1.Image);
            int so1 = int.Parse(numericUpDown1.Value.ToString());
            int so2 = int.Parse(numericUpDown2.Value.ToString());  //nhỏ hơn sẽ bị lớn hơn ảnh kq

            Bitmap bmkq = new Bitmap(bm.Width * so1, bm.Height * so2); //phong to len n lan
            
            //đổ nền đẹp vào cho đẹp
            Graphics gp = Graphics.FromImage(bmkq);
            gp.FillRectangle(Brushes.Black, new Rectangle(0, 0, bmkq.Width, bmkq.Height));
            Color C;

            for (int y = 0; y < bm.Height; y++)
                for (int x = 0; x < bm.Width; x++)
                {
                    C = bm.GetPixel(x, y);
                    bmkq.SetPixel(x * so1, y * so2, C);   //diem dau tien
                    //3 diem xung quanh
                    bmkq.SetPixel(x * so1 + 1, y * so2, C);
                    bmkq.SetPixel(x * so1, y * so2 + 1, C);
                    bmkq.SetPixel(x * so1 + 1, y * so2 + 1, C);
                }
             pictureBox2.Image = bmkq;
        }



          private void btn_In_tt_Click(object sender, EventArgs e)
          {
              //phuong phap tuyen tinh
              Bitmap bm = new Bitmap(pictureBox1.Image);
              int so1 = int.Parse(numericUpDown1.Value.ToString());
              int so2 = int.Parse(numericUpDown2.Value.ToString());
              //thuoc tinh bm chỉ cho phép đọc nên phải gán

              Bitmap bmkq = new Bitmap(bm.Width * so1, bm.Height * so2);
              Color s1, s2, s3, s4;
              int R, G, B;

              //đổ nền đẹp vào cho đẹp
              Graphics gp = Graphics.FromImage(bmkq);
              gp.FillRectangle(Brushes.Black, new Rectangle(0, 0, bmkq.Width, bmkq.Height));
              for (int y = 0; y < bm.Height - 1; y++)
              {
                  for (int x = 0; x < bm.Width - 1; x++)
                  {
                      //tránh lỗi < width
                      s1 = bm.GetPixel(x, y);
                      s2 = bm.GetPixel(x + 1, y);
                      s3 = bm.GetPixel(x, y + 1);
                      s4 = bm.GetPixel(x + 1, y + 1);

                      //note: color  .r .g. .b co the cong
                      //diem dau tien
                      bmkq.SetPixel(x * so1, y * so2, s1);

                      //3 diem xung quanh
                      //diem thu 2 chéo xiên
                      R = (s1.R + s2.R + s3.R + s4.R) / 4; 
                      G = (s1.G + s2.G + s3.G + s4.G) / 4;
                      B = (s1.B + s2.B + s3.B + s4.B) / 4;
                      bmkq.SetPixel(x * so1 + 1, y * so2 + 1, Color.FromArgb(R, G, B));

                      //diem thu 1 ben phai
                      R = (s1.R + s2.R) / 2;
                      G = (s1.G + s2.G) / 2;
                      B = (s1.B + s2.B) / 2;
                      bmkq.SetPixel(x * so1 + 1, y * so2, Color.FromArgb(R, G, B));

                      //diem thu 3 ben duoi
                      R = (s1.R + s3.R) / 2;
                      G = (s1.G + s3.G) / 2;
                      B = (s1.B + s3.B) / 2;
                      bmkq.SetPixel(x * so1, y * so2 + 1, Color.FromArgb(R, G, B));

                      R = (s2.R + s4.R) / 2;
                      G = (s2.G + s4.G) / 2;
                      B = (s2.B + s4.B) / 2;
                      bmkq.SetPixel(x * so1 + 2, y * so2 + 1, Color.FromArgb(R, G, B));

                      R = (s3.R + s4.R) / 2;
                      G = (s3.G + s4.G) / 2;
                      B = (s3.B + s4.B) / 2;
                      bmkq.SetPixel(x * so1 + 1, y * so2 + 2, Color.FromArgb(R, G, B));

                  }
              }
              pictureBox2.Image = bmkq;
          }

          private void btn_zoomOut_laplai_Click(object sender, EventArgs e)
          {
              Bitmap bm = new Bitmap(pictureBox1.Image);
              int w = bm.Width;
              int h = bm.Height;

              int so1 = int.Parse(numericUpDown1.Value.ToString());
              int so2 = int.Parse(numericUpDown2.Value.ToString());

              w = (w % so1 == 0) ? (w = w / so1) : (w = w / so1 + 1);
              h = (h % so2 == 0) ? (h = h / so2) : (h = h / so2 + 1); //để dễ dàng chia nhỏ pixel
             
              Bitmap bmkq = new Bitmap(w, h);
              Color C;

              //đổ nền đẹp vào cho đẹp
              Graphics gp = Graphics.FromImage(bmkq);
              gp.FillRectangle(Brushes.Black, new Rectangle(0, 0, bmkq.Width, bmkq.Height));

              //giam so lan tuong duong cho load nhanh hơn và bỏ qua nhưng diem ko can thiet
              for (int y = 0; y < bm.Height; y +=so2)
                  for (int x = 0; x < bm.Width; x +=so1)
                  {
                      C = bm.GetPixel(x, y);
                      bmkq.SetPixel(x / so1, y / so2, C); //ra đúng pixel tuong duong số lần thu nhỏ //vd: so1 =0 thi x=0/2=0|| so1=2 x=2/2=1||so1=4 x=4/2=2
                  }
              pictureBox2.Image = bmkq;
          }

          private void btn_Out_tt_Click(object sender, EventArgs e)
          {
              Bitmap bm = new Bitmap(pictureBox1.Image);
              int w = bm.Width;
              int h = bm.Height;

              int so1 = int.Parse(numericUpDown1.Value.ToString());
              int so2 = int.Parse(numericUpDown2.Value.ToString());

              w = (w % so1 == 0) ? (w = w / so1) : (w = w / so1 + 1);
              h = (h % so2 == 0) ? (h = h / so2) : (h = h / so2 + 1); //để dễ dàng chia nhỏ pixel
              Bitmap bmkq = new Bitmap(w, h);
              Color C;
              //đổ nền đẹp vào cho đẹp
              Graphics gp = Graphics.FromImage(bmkq);
              gp.FillRectangle(Brushes.Black, new Rectangle(0, 0, bmkq.Width, bmkq.Height));

              //giam so lan tuong duong cho load nhanh hơn và bỏ qua nhưng diem ko can thiet
              for (int y = 0; y < bm.Height; y += so2)
              {

                  for (int x = 0; x < bm.Width; x += so1)
                  {
                      C = bm.GetPixel(x, y);
                      bmkq.SetPixel(x / so1, y / so2, C);

                  }

              }
              pictureBox2.Image = bmkq;
    
          }
    }
}
