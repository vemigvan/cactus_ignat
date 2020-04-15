using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03_listAndGame
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "lab3_lychanyi";
            this.Size = new Size(350, 350);


            tabControl1.Location = new Point(12, 12);
            tabControl1.Size = new Size(this.ClientSize.Width - 24, this.ClientSize.Height - 24);

            tabPage1.Text = "task1";
            tabPage2.Text = "task2";

            Tab1();
            Tab2();
        }
    }
}
