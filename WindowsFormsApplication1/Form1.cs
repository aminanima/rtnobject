using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer t = new Timer(); //new timer
            t.Interval = 30; //Each point will be drawen after 100 ms 
            t.Tick += timer1_Tick;
            t.Start();
        }

        Point pnt = new Point();
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillEllipse(new SolidBrush(Color.Violet), pnt.X, pnt.Y, 40, 40);
           
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
             timer1.Stop();
        }
        double t = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            t += 0.04;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = (int)(200 * Math.Cos(t) + (this.ClientRectangle.Width / 2));
            int y = (int)(200 * Math.Sin(t) + (this.ClientRectangle.Height / 2));
            pnt = new Point(x, y);
            panel1.Invalidate();
        }
    }
}
