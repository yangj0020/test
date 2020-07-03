using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Graphics graphics;

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2 = x0 + leng * Form1.k * Math.Cos(th);
            double y2 = y0 + leng * Form1.k * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, Form1.per1 * leng, th + Form1.th1);
            drawCayleyTree(n - 1, x2, y2, Form1.per2 * leng, th - Form1.th2);
        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(Form1.pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 300, 320, 80, -Math.PI / 2);
        }
    }
}
