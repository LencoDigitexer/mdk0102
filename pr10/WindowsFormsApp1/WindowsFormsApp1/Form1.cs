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
    public partial class Form1 : Form
    {   //описываем переменные достыпные в любом обработчике событий класса Form1     
        private int x1, y1, x2, y2, r;
        private double a;
        private Pen pen = new Pen(Color.DarkRed, 2);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(pen, x1, y1, x2, y2); //рисуем секундную стрелку  
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            a -= 0.1;//уменьшаем угол на 0,1 радиану 
                     //определяем конец часовой стрелки с учетом центра экрана       
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            Invalidate(); //вынудительный вызов перерисовки (Paint) 

        }
    }

}
