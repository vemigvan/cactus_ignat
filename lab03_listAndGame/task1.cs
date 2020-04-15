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
        TextBox input = new TextBox();
        Button addBtn = new Button();
        Button delBtn = new Button();
        ComboBox list = new ComboBox();

        public void Tab1()
        {
            
            #region Textbox

            input.Location = new Point(6, 6);
            input.Size = new Size(120, 20);

            this.tabPage1.Controls.Add(input);


            #endregion


            #region Buttons

            addBtn.Location = new Point(input.Location.X + input.Size.Width + 6, input.Location.Y - 1);
            addBtn.Size = new Size((int)(input.Size.Height * 1.5), input.Size.Height + 2);
            addBtn.Text = "+";
            addBtn.Click += AddItem;

            delBtn.Location = new Point(input.Location.X + input.Size.Width + 6, input.Location.Y + input.Size.Height + 5);
            delBtn.Size = new Size((int)(input.Size.Height * 1.5), input.Size.Height + 3);
            delBtn.Text = "-";
            delBtn.Click += RemoveItem; ;

            tabPage1.Controls.Add(addBtn);
            tabPage1.Controls.Add(delBtn);

            #endregion


            #region ComboBox

            list.Location = new Point(input.Location.X, input.Location.Y + input.Size.Height + 6);
            list.Size = input.Size;

            tabPage1.Controls.Add(list);
            #endregion
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            if (list.Items.Count>0)
            list.Items.RemoveAt(list.Items.Count - 1);

        }

        private void AddItem(object sender, EventArgs e)
        {
            if (input.Text != "")
                list.Items.Add(input.Text);
            input.Text = "";
            input.Focus();

        }
    }
}
