using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Something
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Text = "Zehrs Market";

            Graphics g = this.CreateGraphics();
            Pen orangePen = new Pen(Color.Orange, 5);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Font titleFont = new Font("Gabriola", 100, FontStyle.Bold);
            Font subtitleFont = new Font("Times New Roman", 55, FontStyle.Bold);

            g.Clear(Color.White);

            g.DrawLine(orangePen, 250, 250, 620, 250);

            //g.DrawRectangle(redPen, 30, 30, 100, 200);
            //g.FillRectangle(blueBrush, 30, 30, 100, 200);

            //g.DrawEllipse(redPen, 25, 25, 200, 200);
            //g.FillEllipse(blueBrush, 25, 25, 200, 200);

            //g.DrawArc(redPen, 250, 20, 50, 50, 30, 300);
            //g.DrawPie(redPen, 250, 20, 50, 50, 30, 300);
            //g.FillPie(blueBrush, 250, 20, 50, 50, 120, 300);

            g.DrawString("ZEHRS", titleFont, orangeBrush, 250, 80);
            g.DrawString("MARKETS", subtitleFont, greenBrush, 240, 165);
        }
    }
}
