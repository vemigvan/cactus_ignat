using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab01_calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        private double Result
        {
            get; set;
        }
        byte operation = 0;


        public Form1()
        {
            InitializeComponent();

           

            int startX = this.textBox1.Location.X;
            int startY = this.textBox1.Location.Y+textBox1.Size.Height+5;
            int nextX = startX;
            int nextY = startY;

            for (int i = 1; i<=9; i++)
            {
                Button btn = new Button();
                btn.Visible = true;
                btn.Size = new Size(30, 20);
                btn.Text = (i).ToString();
                btn.Location = new Point(nextX, nextY);
                btn.Click += Btn_Click;
                this.Controls.Add(btn);

                nextX = nextX + btn.Size.Width + 5;

                if(i % 3 == 0)
                {
                    nextX = startX;
                    nextY = nextY + btn.Size.Height + 5;
                }

            }


            Button zero = new Button();
            zero.Visible = true;
            zero.Size = new Size(30, 20);
            zero.Text = "0";
            zero.Location = new Point(nextX+zero.Size.Width+5, nextY);
            zero.Click += Btn_Click;
            this.Controls.Add(zero);



            int opX = startX + zero.Size.Width * 3 + 20;

            Button plus = new Button();
            plus.Visible = true;
            plus.Size = new Size(30, 20);
            plus.Text = "+";
            plus.Location = new Point(opX, startY);
            plus.Click += Upd;
            plus.Click += Plus_Click;
            this.Controls.Add(plus);

            Button minus = new Button();
            minus.Visible = true;
            minus.Size = new Size(30, 20);
            minus.Text = "-";
            minus.Location = new Point(opX, startY+minus.Size.Height + 5);
            minus.Click += Upd;
            minus.Click += Minus_Click;
            this.Controls.Add(minus);

            Button mult = new Button();
            mult.Visible = true;
            mult.Size = new Size(30, 20);
            mult.Text = "*";
            mult.Location = new Point(opX, startY + mult.Size.Height*2 + 10);
            mult.Click += Upd;
            mult.Click += Mult_Click;
            this.Controls.Add(mult);

            Button div = new Button();
            div.Visible = true;
            div.Size = new Size(30, 20);
            div.Text = "/";
            div.Location = new Point(opX, startY + div.Size.Height * 3 + 15);
            div.Click += Upd;
            div.Click += Div_Click;
            this.Controls.Add(div);

            Button equal = new Button();
            equal.Visible = true;
            equal.Size = new Size(30, 20);
            equal.Text = "=";
            equal.Location = new Point(startX + equal.Size.Width*3+20, startY-textBox1.Size.Height-5);
            equal.Click += Upd;
            equal.Click += Equal_Click;
            equal.Click += Upd;
            this.Controls.Add(equal);

            Button erase = new Button();
            erase.Visible = true;
            erase.Size = new Size(30, 20);
            erase.Text = "cc";
            erase.Location = new Point(startX + erase.Size.Width * 2 + 10, nextY);
            erase.Click += Erase_Click;
            this.Controls.Add(erase);

        }

        private void Erase_Click(object sender, EventArgs e)
        {
            result = 0;
            operation = 0;
            textBox1.Text = "";
        }

        private void Upd(object sender, EventArgs e)
        {
            double var;
            double.TryParse(textBox1.Text, out var);
            switch (operation)
            {
                case 0:
                    result = var;
                    textBox1.Text = "";
                    break;
                case 1:
                    result += var;
                    textBox1.Text = "";
                    break;
                case 2:
                    result -= var;
                    textBox1.Text = "";
                    break;
                case 3:
                    result *= var;
                    textBox1.Text = "";
                    break;
                case 4:
                    result /= var;
                    textBox1.Text = "";
                    break;
                default:
                    textBox1.Text = result.ToString();
                    result = 0;
                    break;
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            operation = 1;
        }
        private void Div_Click(object sender, EventArgs e)
        {
            operation = 4;
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            operation = 3;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            operation = 2;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            operation = 5;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += (sender as Button).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
