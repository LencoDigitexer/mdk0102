using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {   //описываем переменные достыпные в любом обработчике событий класса Form1     
        private int x1, y1, x2, y2, r;
        private double a;
        private Pen pen = new Pen(Color.DarkRed, 2);
        int y = 530;


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Graphics g1 = e.Graphics;
            Graphics g2 = e.Graphics;
            Graphics g3 = e.Graphics;
            g.Clear(Color.Blue);
            SolidBrush peg = new SolidBrush(Color.White);
            SolidBrush peg1 = new SolidBrush(Color.Yellow);
            SolidBrush peg2 = new SolidBrush(Color.Yellow);
            SolidBrush peg3 = new SolidBrush(Color.Blue);
            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            GraphicsPath gp1 = new GraphicsPath(FillMode.Winding);
            GraphicsPath gp2 = new GraphicsPath(FillMode.Winding);
            GraphicsPath gp3 = new GraphicsPath(FillMode.Winding);
            gp.AddPolygon(
                new Point[] { 
                    new Point(450, y), 
                    new Point(465, y + 100), 
                    new Point(485, y + 100), 
                    new Point(500, y), 
                    new Point(475, y - 20), 
                    new Point(450, y) 
                });
            gp1.AddPolygon(
                new Point[] { 
                    new Point(465, y + 100), 
                    new Point(445, y + 120), 
                    new Point(445, y + 90), 
                    new Point(460, y + 70), 
                    new Point(465, y + 100) 
                });
            gp2.AddPolygon(
                new Point[] { 
                    new Point(485, y + 100), 
                    new Point(505, y + 120), 
                    new Point(505, y + 90), 
                    new Point(490, y + 70), 
                    new Point(485, y + 100) 
                });
            gp3.AddEllipse(465, y + 5, 20, 20);
            g.FillPath(peg, gp);
            g1.FillPath(peg1, gp1);
            g2.FillPath(peg2, gp2);
            g3.FillPath(peg3, gp3);
        }
        private void Form1_Load(object sender, EventArgs e)
        {   //определяем цент экрана             
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            r = 150; //задаем радиус          
            a = 0;   //задаем угол поворота 
                     //определяем конец часовой стрелки с учетом центра экрана          
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
        }

        int H = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            y--;
            H++;
            Invalidate();
            //textBox1.Text = H.ToString();
        }
    }

}
