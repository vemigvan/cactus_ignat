using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04_toManyWindows
{
    public partial class Form1 : Form
    {
        //menustrip
        MenuStrip menu = new MenuStrip();
        ToolStripMenuItem file = new ToolStripMenuItem();
        ToolStripMenuItem fileNew = new ToolStripMenuItem();
        ToolStripSeparator sep1 = new ToolStripSeparator();
        ToolStripSeparator sep2 = new ToolStripSeparator();
        ToolStripMenuItem empty = new ToolStripMenuItem();
        ToolStripMenuItem root1 = new ToolStripMenuItem();
        ToolStripMenuItem item1 = new ToolStripMenuItem();
        ToolStripMenuItem item2 = new ToolStripMenuItem();

        //toolstrip
        ToolStrip tools = new ToolStrip();
        ToolStripMenuItem altNew = new ToolStripMenuItem();
        ToolStripSeparator sep3 = new ToolStripSeparator();
        ToolStripTextBox tBox = new ToolStripTextBox();


        //statusstrip
        StatusStrip status = new StatusStrip();
        ToolStripLabel root = new ToolStripLabel();
        ToolStripLabel item = new ToolStripLabel();
        ToolStripProgressBar progress = new ToolStripProgressBar();

        //side
        ToolStrip group = new ToolStrip();
        ToolStripTextBox name = new ToolStripTextBox();
        ToolStripComboBox crem = new ToolStripComboBox();
        ToolStripTextBox currentNumberBox = new ToolStripTextBox();


        //counter
        ushort counter = 0;
        short number = 0;
        string sublabel = "";
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            #region SidePanel

            group.Location = new Point(0, menu.Size.Height + tools.Size.Height - 10);
            group.AutoSize = false;
            group.Dock = DockStyle.Left;
            group.Size = new Size(150, this.ClientRectangle.Height);
            group.GripStyle = ToolStripGripStyle.Hidden;

            name.Margin = new Padding(5,15,5,0);
            name.Text = "Child";
            group.Items.Add(name);

            currentNumberBox.KeyPress += CurrentNumberBox_KeyPress;
            currentNumberBox.Margin = new Padding(5, 15, 5, 0);
            group.Items.Add(currentNumberBox);

            crem.Margin = new Padding(5, 15, 5, 0);
            crem.Items.Add("Increment");
            crem.Items.Add("Decrement");
            crem.Items.Add("Same");
            crem.SelectedIndex = 0;
            group.Items.Add(crem);

            this.Controls.Add(group);

            #endregion 

            #region Tools

            tools.Location = new Point(6, 12);

            altNew.Text = " + ";
            altNew.Click += FileNew_Click;
            tools.Items.Add(altNew);

            tools.Items.Add(sep3);

            tBox.Size = new Size(30, 8);
            tools.Items.Add(tBox);

            this.Controls.Add(tools);

            #endregion

            #region menu

            menu.Location = new Point(6, 6);
            menu.Items.Add(file);
            menu.Items.Add(root1);

            file.DropDownItems.Add(fileNew);
            file.DropDownItems.Add(sep1);
            file.DropDownItems.Add(sep2);
            file.DropDownItems.Add(empty);

            file.Text = "File";
            file.Click += ChangeStatus;
            fileNew.Text = "New";
            fileNew.ShortcutKeys = (Keys.Control | Keys.N);
            fileNew.ShortcutKeyDisplayString = "Ctrl+N";
            fileNew.Click += FileNew_Click;
            fileNew.Click += ChangeStatus;
            empty.Text = "Empty";
            empty.Click += ChangeStatus;


            root1.DropDownItems.Add(item1);
            root1.DropDownItems.Add(item2);

            root1.Text = "Root1";
            root1.Click += ChangeStatus;
            item1.Text = "Item1";
            item1.Click += ChangeStatus;
            item2.Text = "Item2";
            item2.Click += ChangeStatus;


            this.Controls.Add(menu);

            #endregion

            #region StatusStrip

            root.Text = file.Text+":";
            status.Items.Add(root);

            item.Text = fileNew.Text;
            status.Items.Add(item);

            progress.Maximum = 10;
            status.Items.Add(progress);

            this.Controls.Add(status);

            #endregion



        }

        private void CurrentNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void ChangeStatus(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).HasDropDownItems)
            {
                sublabel = (sender as ToolStripMenuItem).Text;
            }
            else
            {
                root.Text = sublabel + ":";
                item.Text = (sender as ToolStripMenuItem).Text;
            }
        }

        private void FileNew_Click(object sender, EventArgs e)
        {
            short.TryParse(currentNumberBox.Text, out number);
            counter++;
            tBox.Text = counter.ToString();
            if (progress.Value == 10)
                progress.Value = 0;
            else
                progress.Value++;



            Form2 form = new Form2();
            form.MdiParent = this;
            form.Left = 400;
            switch(crem.SelectedIndex){
                case 0:
                    number++;
                    break;
                case 1:
                    number--;
                    break;
                case 2:
                    break;

            }
            form.Text = name.Text+" "+ number.ToString();

            currentNumberBox.Text = number.ToString();

            form.Show();

        }

    }
}
