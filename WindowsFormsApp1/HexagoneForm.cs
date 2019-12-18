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
    public partial class HexagoneForm : Form
    {
        public HexagoneForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            var x_0 = panel1.Width / 2;
            var y_0 = panel1.Height / 2;
            float s = 20;
            Hexagone hex = new Hexagone(x_0, y_0, s);
            SolidBrush sb = new SolidBrush(Color.Black);
            graphics.DrawPolygon(Pens.Red, hex.Points);
            graphics.FillPolygon(sb, hex.Points);



            for(int i = 0 ; i < 6; i++)
            {
                x_0 = x_0 - (int)(s * 1.3);
                y_0 = y_0 - (int)(s * 1.3);
                hex = new Hexagone(x_0, y_0, s);
                sb = new SolidBrush(Color.Black);
                graphics.DrawPolygon(Pens.Red, hex.Points);
                graphics.FillPolygon(sb, hex.Points);
                Console.WriteLine(" i : " + i + " x 0 " + x_0);
                Console.WriteLine(" i : " + i + " x 0 " + y_0);
            }
        }

            

    }
}
