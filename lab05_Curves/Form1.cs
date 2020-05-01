using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Threading;

namespace lab05_Curves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            DrawCurve();
        }

        public void DrawCurve()
        { 
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);

            Pen pen = new Pen(Color.Red, 2F);

            g.TranslateTransform(0, pictureBox1.Size.Height);
            g.ScaleTransform(1, -1);

            g.DrawCoordinates(pictureBox1.Width, pictureBox1.Height, 10);

            g.Sin(new Pen(Color.FromArgb(106,235,232), 3F), pictureBox1.ClientRectangle.Width, 70);
            g.Sin(new Pen(Color.FromArgb(255, 211, 105), 3F), pictureBox1.ClientRectangle.Width, 60, 2);
            g.Sin(new Pen(Color.FromArgb(193, 134, 208), 3F), pictureBox1.ClientRectangle.Width, 100, 0.5F);
            g.Sin(new Pen(Color.FromArgb(168, 250, 140), 3F), pictureBox1.ClientRectangle.Width, 200, 1, 4);

            
            pictureBox1.Image = bmp;


        }
       

    }

    public static class GraphicsAdditional
    {
        public static bool DrawCoordinates(this Graphics g, int width, int height, int measure)
        {
            for (int i = measure; i < width; i += measure)
            {
                g.DrawLine(new Pen(Color.FromArgb(232, 245, 255), 2F), i, 0, i, height);
            }
            for (int i = measure; i < height; i += measure)
            {
                g.DrawLine(new Pen(Color.FromArgb(232, 245, 255), 2F), 0, i, width, i);
            }

            g.DrawLine(new Pen(Color.FromArgb(191, 222, 255), 8F), 0, 0, 0, height);
            g.DrawLine(new Pen(Color.FromArgb(191, 222, 255), 8F), 0, 0, width, 0);

            return true;
        }


        public static bool Sin(this Graphics g, Pen pen, int width, int ceil, float kx = 1, float ky = 1)
        {
            float x0 = 0, y0 = 0;
            int mul = 40;

            for (float x = 0, y = 0; x0 < width; x += 0.1F)
            {
                y = (float)(Math.Sin(x));

                g.DrawLine(pen, x0 * mul * kx, y0 * mul * ky + ceil, x * mul * kx, y * mul * ky + ceil);

                x0 = x;
                y0 = y;
            }

            return true;
        }
    }
}
