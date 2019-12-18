using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Hexagone
    {
        int colorR;
        int colorG;
        int colorB;
        private System.Drawing.PointF[] points;
        float side;
        float area;
        float high;
        float ray;
        float border;
        float x;
        float y;

        public float Y { get => y; set => y = value; }
        public int ColorR { get => colorR; set => colorR = value; }
        public int ColorG { get => colorG; set => colorG = value; }
        public int ColorB { get => colorB; set => colorB = value; }
        public float Side { get => side; set => side = value; }
        public float Area { get => area; set => area = value; }
        public float High { get => high; set => high = value; }
        public float Ray { get => ray; set => ray = value; }
        public float Border { get => border; set => border = value; }
        public float X { get => x; set => x = value; }
        public PointF[] Points { get => points; set => points = value; }

        public Hexagone(float x, float y, float s)
        {
            this.x = x;
            this.y = y;

            side = s;
            high = CalculateH(side);
            ray = CalculateR(side);
            border = side + 2 * high;
            area = 2 * ray;
            CalculateVertices();
        }

        private void CalculateVertices()
        {

                    //x,y coordinates are top center point
                    points = new System.Drawing.PointF[6];
                    points[0] = new PointF(x, y);
                    points[1] = new PointF(x + ray, y + high);
                    points[2] = new PointF(x + ray, y + side + high);
                    points[3] = new PointF(x, y + side + high + high);
                    points[4] = new PointF(x - ray, y + side + high);
                    points[5] = new PointF(x - ray, y + high);
        }

        public static float CalculateH(float side)
        {
            return (float)System.Math.Sin(DegreesToRadians(30)) * side;
        }

        public static float CalculateR(float side)
        {
            return (float)System.Math.Cos(DegreesToRadians(30)) * side;
        }
        public static float DegreesToRadians(double degrees)
        {
            return (float)(degrees * System.Math.PI / 180);
        }

    }
}
