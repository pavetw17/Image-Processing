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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menu_anhxam_Click(object sender, EventArgs e)
        {
            Anh_Xam ax = new Anh_Xam();
            ax.Show();
        }

        private void menu_histogram_Click(object sender, EventArgs e)
        {
            Histogram his = new Histogram();
            his.Show();
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Median_Filter me = new Median_Filter();
            me.Show();
        }

        private void averagingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Averaging_Filter ave = new Averaging_Filter();
            ave.Show();
        }


        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilation dil = new Dilation();
            dil.Show();
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erosion ero = new Erosion();
            ero.Show();
        }

        private void zomInZomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomIn_ZoomOut io = new ZoomIn_ZoomOut();
            io.Show();
        }

        private void maxMinFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
