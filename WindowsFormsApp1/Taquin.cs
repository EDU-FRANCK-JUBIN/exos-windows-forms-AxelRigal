using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Taquin : Form
    {
        System.Diagnostics.Stopwatch timer;
        List<Bitmap> lsOriginalPictureList = new List<Bitmap>();
        List<int> maListe = new List<int>();
        public Taquin()
        {
            InitializeComponent();
        }



        private void btShuffle_Click(object sender, EventArgs e)
        {
            timer = new System.Diagnostics.Stopwatch();
            timer.Start();

            lsOriginalPictureList.Add(Properties.Resources._1);
            lsOriginalPictureList.Add(Properties.Resources._2);
            lsOriginalPictureList.Add(Properties.Resources._3);
            lsOriginalPictureList.Add(Properties.Resources._4);
            lsOriginalPictureList.Add(Properties.Resources._5);
            lsOriginalPictureList.Add(Properties.Resources._6);
            lsOriginalPictureList.Add(Properties.Resources._7);
            lsOriginalPictureList.Add(Properties.Resources._8);
            //lsOriginalPictureList.Add(Properties.Resources._9);
            lsOriginalPictureList.Add(Properties.Resources._null);

            for(int i = 0; i < gPuzzleBox.Controls.Count; i++)
            {
                Random r = new Random();
                int ind = r.Next(0, lsOriginalPictureList.Count);
                ((PictureBox)gPuzzleBox.Controls[i]).Image = lsOriginalPictureList[ind];
                lsOriginalPictureList.RemoveAt(ind);
                maListe.Add(ind);
            }
                
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = timer.Elapsed.ToString();
        }
        private void pb1_Click(object sender, EventArgs e)
        {

            if(pb2.Image == (Bitmap)Properties.Resources._null)
            {
                pb2.Image = pb1.Image;
                pb1.Image = Properties.Resources._null;
            }
            else if( pb4.Image.Equals(Properties.Resources._null))
            {
                pb4.Image = pb1.Image;
                pb1.Image = Properties.Resources._null;
            }
        }
        private void pb2_Click(object sender, EventArgs e)
        {
            if(pb1.Image.Equals(Properties.Resources._null))
            {
                pb1.Image = pb2.Image;
                pb2.Image = Properties.Resources._null;
            }else if (pb3.Image.Equals(Properties.Resources._null))
            {
                pb3.Image = pb2.Image;
                pb2.Image = Properties.Resources._null;
            }else if(pb5.Image.Equals(Properties.Resources._null))
            {
                pb5.Image = pb2.Image;
                pb2.Image = Properties.Resources._null;
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (pb2.Image.Equals(Properties.Resources._null))
            {
                pb2.Image = pb3.Image;
                pb3.Image = Properties.Resources._null;
            }
            else if (pb6.Image.Equals(Properties.Resources._null))
            {
                pb6.Image = pb3.Image;
                pb3.Image = Properties.Resources._null;
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (pb1.Image.Equals(Properties.Resources._null))
            {
                pb1.Image = pb4.Image;
                pb4.Image = Properties.Resources._null;
            }
            else if (pb5.Image.Equals(Properties.Resources._null))
            {
                pb5.Image = pb4.Image;
                pb4.Image = Properties.Resources._null;
            }
            else if (pb7.Image.Equals(Properties.Resources._null))
            {
                pb7.Image = pb4.Image;
                pb4.Image = Properties.Resources._null;
            }

        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (pb2.Image.Equals(Properties.Resources._null))
            {
                pb2.Image = pb5.Image;
                pb5.Image = Properties.Resources._null;
            }
            else if (pb4.Image.Equals(Properties.Resources._null))
            {
                pb4.Image = pb5.Image;
                pb5.Image = Properties.Resources._null;
            }
            else if (pb6.Image.Equals(Properties.Resources._null))
            {
                pb6.Image = pb5.Image;
                pb5.Image = Properties.Resources._null;
            }
            else if (pb8.Image.Equals(Properties.Resources._null))
            {
                pb8.Image = pb5.Image;
                pb5.Image = Properties.Resources._null;
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (pb3.Image.Equals(Properties.Resources._null))
            {
                pb3.Image = pb6.Image;
                pb6.Image = Properties.Resources._null;
            }
            else if (pb9.Image.Equals(Properties.Resources._null))
            {
                pb9.Image = pb6.Image;
                pb6.Image = Properties.Resources._null;
            }
            else if (pb5.Image.Equals(Properties.Resources._null))
            {
                pb5.Image = pb6.Image;
                pb6.Image = Properties.Resources._null;
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (pb4.Image.Equals(Properties.Resources._null))
            {
                pb4.Image = pb7.Image;
                pb7.Image = Properties.Resources._null;
            }
            else if (pb8.Image.Equals(Properties.Resources._null))
            {
                pb8.Image = pb7.Image;
                pb7.Image = Properties.Resources._null;
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (pb5.Image .Equals(Properties.Resources._null))
            {
                pb5.Image = pb8.Image;
                pb8.Image = Properties.Resources._null;
            }
            else if (pb9.Image.Equals(Properties.Resources._null))
            {
                pb9.Image = pb8.Image;
                pb8.Image = Properties.Resources._null;
            }
            else if (pb7.Image.Equals(Properties.Resources._null))
            {
                pb7.Image = pb8.Image;
                pb8.Image = Properties.Resources._null;
            }  
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (pb6.Image == Properties.Resources._null)
            {

            }
            else if (pb8.Image == Properties.Resources._null)
            {

            }
        }
    }
}
