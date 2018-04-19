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
    public partial class Dilation : Form
    {
        public Dilation()
        {
            InitializeComponent();
        }

        private void btn_xuly_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);
            Bitmap bmkq = new Bitmap(bm.Width, bm.Height);
     
            int c, cong;
      
            for (int y = 1; y < bm.Height - 1; y++)
                for (int x = 1; x < bm.Width - 1; x++)
                {
                    
                        cong = (
                          //  bm.GetPixel(x - 1, y - 1).R + 
                            bm.GetPixel(x, y - 1).R + 
                          //  bm.GetPixel(x + 1, y - 1).R +
                                   
                            bm.GetPixel(x - 1, y).R + 
                            bm.GetPixel(x, y).R + 
                            bm.GetPixel(x + 1, y).R +
                                   
                          //  bm.GetPixel(x, y - 1).R + 
                            bm.GetPixel(x, y + 1).R   //+ 
                          //  bm.GetPixel(x, y - 1).R
                          
                          );
                    
                   
                    //ban dau : 255: white và 0:black
                    if (cong > 0)  //dilation 0: trang va 1 : den
                        c = 255; //trang
                    else
                        c = 0;  //den   //cho white thanh black

                    bmkq.SetPixel(x, y, Color.FromArgb(c, c, c)); //Dilation (hit) khi gap giao diem giua đen và trắng, thì nó lấy điểm trung tâm
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

        private void btn_xl5x5_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);
            Bitmap bmkq = new Bitmap(bm.Width, bm.Height);
        
            int c, cong;
        
            for (int y = 2; y < bm.Height - 2; y++)
                for (int x = 2; x < bm.Width - 2; x++)
                {
                      cong = (
                              //bm.GetPixel(x - 2, y - 2).R +
                              //bm.GetPixel(x - 1, y - 2).R +
                              bm.GetPixel(x, y - 2).R +
                              //bm.GetPixel(x + 1, y - 2).R +
                              //bm.GetPixel(x + 2, y - 2).R +
                              //bm.GetPixel(x - 2, y - 1).R +
                              //bm.GetPixel(x - 1, y - 1).R +
                              bm.GetPixel(x, y - 1).R +
                              //bm.GetPixel(x + 1, y - 1).R +
                              //bm.GetPixel(x + 2, y - 1).R +

                              bm.GetPixel(x - 2, y).R +
                              bm.GetPixel(x - 1, y).R +
                              bm.GetPixel(x, y).R +
                              bm.GetPixel(x + 1, y).R +
                              bm.GetPixel(x + 2, y).R +

                              //bm.GetPixel(x - 2, y + 1).R +
                              //bm.GetPixel(x - 1, y + 1).R +
                              bm.GetPixel(x, y + 1).R +
                              //bm.GetPixel(x + 1, y + 1).R +
                              //bm.GetPixel(x + 2, y + 1).R +

                              //bm.GetPixel(x - 2, y + 2).R +
                              //bm.GetPixel(x - 1, y + 2).R +
                              bm.GetPixel(x, y + 2).R           //+
                              //bm.GetPixel(x + 1, y + 2).R +
                              //bm.GetPixel(x + 2, y + 2).R
                              );
                    
                    if (cong > 0)  // 0: trang va 1 : den
                        c = 255; //trang
                    else
                        c = 0;  //den   //cho white thanh black

                    bmkq.SetPixel(x, y, Color.FromArgb(c, c, c));
                }

            pictureBox2.Image = bmkq;
        }
    }
}
