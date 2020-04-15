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
        Button again = new Button();
        Button focus = new Button();

        List<Button> buttons = new List<Button>();
        List<Point> positions = new List<Point>();
        ProgressBar progress = new ProgressBar();
        int order = 0;

        public void Tab2()
        {
                      

            #region Buttons

            for (int i = 0, count = 1, y = 40; i < 4; i++, y += 40)
            {
                for (int j = 0, x = 70; j < 4; j++, x += 40)
                {
                    positions.Add(new Point(x, y));

                    Button btn = new Button();
                    btn.Text = count.ToString();
                    btn.Size = new Size(40, 40);
                    btn.Location = new Point(x, y);
                    btn.Click += Btn_Click;

                    buttons.Add(btn);
                    tabPage2.Controls.Add(btn);
                    count++;
                }
            }

            //Finish
            buttons[15].VisibleChanged += Form1_VisibleChanged;

            //Try again
            again.Size = new Size(60, 24);
            again.Location = new Point(120, 100);
            again.Text = "Try Again";
            again.Click += Again_Click;

            
            tabPage2.Controls.Add(again);
            


            //For focus
            focus.Size = new Size(0, 0);
            tabPage2.Controls.Add(focus);

            #endregion


            #region Progress Bar

            progress.Style = ProgressBarStyle.Continuous;
            progress.Location = new Point(6, 235);
            progress.Maximum = buttons.Count*2;
            progress.Size = new Size(288, 20);

            tabPage2.Controls.Add(progress);


            #endregion

        }

        private void Again_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Location = positions[i];
                buttons[i].Show();
            }
            order = 0;
            progress.Value = 0;
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (!(sender as Button).Visible)
                again.Show();
            else
                again.Hide();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == (order+1).ToString())
            {
                (sender as Button).Hide();
                order++;
                Randomize();

                progress.Value+= 2;
            }
            else
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].Location = positions[i];
                    buttons[i].Show();
                }
                order = 0;
                progress.Value = 0;
            }

            focus.Focus();
        }

        private void Randomize()
        {
            int[] nums = new int[positions.Count];
            for (int i = 0; i < positions.Count; i++)
                nums[i] = i;

            Random rnd = new Random();
            for(int i = 0, t; i < positions.Count; i++)
            {
                int j = rnd.Next(positions.Count);
                t = nums[i];
                nums[i] = nums[j];
                nums[j] = t;
            }

            for(int i = 0;i<buttons.Count;i++)
            {
                buttons[i].Location = positions[nums[i]];
            }
        }
    }
}