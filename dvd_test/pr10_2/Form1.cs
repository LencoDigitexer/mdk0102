using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr10_2
{
    public partial class Form1 : Form
    {   //описываем переменные достыпные в любом обработчике событий класса Form1
        //
        private Point PreviousPoint, point; //Точка до перемещения курсора мыши и текущая точка
        private Graphics g;
        private int x1, y1, x2, y2, r;
        private Point center;
        private float diameter = 30f;
        private double a;
        int x, y;
        int xspeed = 11, yspeed = 11;
        
        private Pen pen = new Pen(Color.DarkRed, 2);

        

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
            g.DrawLine(pen, 30+x, 30 + y, 60 + x, 30 + y);
            g.DrawLine(pen, 60+x, 30 + y, 70 + x, 40 + y);
            g.DrawLine(pen, 70+x, 40 + y, 70 + x, 50 + y);
            g.DrawLine(pen, 70+x, 50 + y, 60 + x, 60 + y);
            g.DrawLine(pen, 60+x, 60 + y, 30 + x, 60 + y);
            g.DrawLine(pen, 30+x, 60 + y, 20 + x, 50 + y);
            g.DrawLine(pen, 20+x, 50 + y, 20 + x, 40 + y);
            g.DrawLine(pen, 20+x, 40 + y, 30 + x, 30 + y);

           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = x.ToString() + " " + y.ToString();

            x = x + xspeed;
            y = y + yspeed;
            Invalidate();

            if (x + 80 > this.Width || x == 0)
            {
                xspeed = xspeed * -1;
            }

            if(y + 100 > this.Height || y == 0) { 
                yspeed = yspeed * -1;
                
            }
            

            /*
            if (x==y)
            {
                x++;
                y++;
                Invalidate();

            }

            if ((x==400))
            {
                x++;
                y--;
                Invalidate();
            }
            if ((x >y))
            {
                x++;
                y--;
                Invalidate();
            }

            if(x == 720)
            {
                x--;
                y--;
                Invalidate();
            }
            if(y<(x-600))
            {
                x--;
                y--;
                Invalidate();
            }
            if(y<0)
            {
                x--;
                y++;
                Invalidate();
            }
            
            if ((x+y) > 600 && (x>y))
            {
                x--;
                y--;
                Invalidate();
            }
            if (x>800 && y)
            {
                x--;
                y++;
                Invalidate();
            }*/
        }
    }

}
