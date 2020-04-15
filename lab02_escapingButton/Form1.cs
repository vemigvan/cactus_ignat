using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab02_escapingButton
{
    public partial class Form1 : Form
    {
        Point a, b;
        int cnt=0;
        
        public Form1()
        {
            InitializeComponent();

            this.button1.Text = "нет";
            this.button2.Text = "Конечно!";
            this.Text = "Поставить Лычаному автомат?";

            this.timer1.Start();

            this.MouseMove += Form1_MouseMove;
            this.button1.MouseEnter += Button1_MouseEnter;
            this.button1.GotFocus += Button1_GotFocus;
            this.button1.LocationChanged += Button1_LocationChanged;
            a = new Point(button1.Location.X, button1.Location.Y);
            b = new Point(button1.Location.X + button1.Size.Width, button1.Location.Y+ button1.Size.Height);

            this.button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чего и следовало ожидать!", "Спасибо!");
        }

        private void Button1_LocationChanged(object sender, EventArgs e)
        {
            cnt++;
            if (cnt >= 40)
            {
                cnt = 0;
                button1.Size = new Size(button1.Size.Width-1, button1.Size.Height-1);
            }
        }

        private void Button1_GotFocus(object sender, EventArgs e)
        {
            this.button2.Focus();
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();

            this.button1.Location = new Point(rnd.Next(0, this.Size.Width), rnd.Next(0, this.Size.Height));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Text == "Поставить Лычаному автомат?")
                this.Text = "A? A? A?";
            else
                this.Text = "Поставить Лычаному автомат?";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            

            if (Math.Abs(a.X - e.X) < 15 && Math.Abs(a.Y-e.Y) < 15)
            {
                button1.Left++;
                button1.Top++;

            }
            if ((a.X < e.X) && (e.X < b.X) && Math.Abs(a.Y - e.Y) < 15)
            {
                button1.Top++;
            }
            if (Math.Abs(e.X - b.X) < 15 && Math.Abs(a.Y - e.Y) < 15)
            {
                button1.Left--;
                button1.Top++;
            }
            if (Math.Abs(a.X - e.X) < 15 && (a.Y < e.Y) && (e.Y < b.Y))
            {
                button1.Left++;
            }
            if (Math.Abs(e.X-b.X) < 15 && (a.Y < e.Y) && (e.Y < b.Y))
            {
                button1.Left--;
            }
            if (Math.Abs(a.X - e.X) < 15 && Math.Abs(e.Y - b.Y) < 15)
            {
                button1.Left++;
                button1.Top--;
            }
            if ((a.X < e.X) && (e.X < b.X) && Math.Abs(e.Y - b.Y) < 15)
            {
                button1.Top--;
            }
            if (Math.Abs(e.X - b.X) < 10 && Math.Abs(e.Y - b.Y) < 10)
            {
                button1.Left--;
                button1.Top--;
            }

            

            if (button1.Location.X == 0)
                button1.Left += button1.Size.Width + Cursor.Size.Width;
            if (button1.Location.Y == 0)
                button1.Top += button1.Size.Height + Cursor.Size.Height;
            if (this.Width - button1.Location.X < button1.Size.Width)
                button1.Left -= button1.Size.Width + Cursor.Size.Width;
            if (this.Height - button1.Location.Y < button1.Size.Height)
                button1.Top -= button1.Size.Height + Cursor.Size.Height;

            a = new Point(button1.Location.X, button1.Location.Y);
            b = new Point(button1.Location.X + button1.Size.Width, button1.Location.Y + button1.Size.Height);
        }
    }
}
