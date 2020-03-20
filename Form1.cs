using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        private int height = 30;
        private int width = 60;
        private String text = "Button";
        private static int x = 0;
        private static int y = 0;
        private static Point pointt = new Point(0,0);
        private int space = 5;
        List<Button> listbutt;
        public Form1()
        {
            InitializeComponent();
            listbutt = new List<Button>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button butt = new Button();
            butt.Text = text;
            butt.Width = width;
            butt.Height = height;
            butt.Location = pointt;
            panel1.Controls.Add(butt);
            listbutt.Add(butt);
            if(y+height*2 + space*2> panel1.Height)
            {
                x = x + width + space;
                y = 0;
            }
            else
            {
                y = y + height + space;
            }
            pointt = new Point(x, y);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listbutt.Count > 1)
            {
                Button butt = listbutt[listbutt.Count - 1];
                Console.WriteLine(butt.Text);
                listbutt.RemoveAt(listbutt.Count - 1);
                panel1.Controls.Remove(butt);
                x = listbutt[listbutt.Count - 1].Location.X;
                y = listbutt[listbutt.Count - 1].Location.Y;
                pointt = new Point(x, y);
            }
            else if(listbutt.Count == 1)
            {
                Button butt = listbutt[listbutt.Count - 1];
                Console.WriteLine(butt.Text);
                listbutt.RemoveAt(listbutt.Count - 1);
                panel1.Controls.Remove(butt);
                x = 0;
                y = 0;
                pointt = new Point(x, y);
            }
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button butt = new Button();
            butt.Text = text;
            butt.Width = width;
            butt.Height = height;
            butt.Location = pointt;
            panel1.Controls.Add(butt);
            listbutt.Add(butt);
            if (y + height * 2 + space * 2 > panel1.Height)
            {
                x = x + width + space;
                y = 0;
            }
            else
            {
                y = y + height + space;
            }
            pointt = new Point(x, y);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listbutt.Count > 1)
            {
                Button butt = listbutt[listbutt.Count - 1];
                Console.WriteLine(butt.Text);
                listbutt.RemoveAt(listbutt.Count - 1);
                panel1.Controls.Remove(butt);
                x = listbutt[listbutt.Count - 1].Location.X;
                y = listbutt[listbutt.Count - 1].Location.Y;
                pointt = new Point(x, y);
            }
            else if (listbutt.Count == 1)
            {
                Button butt = listbutt[listbutt.Count - 1];
                Console.WriteLine(butt.Text);
                listbutt.RemoveAt(listbutt.Count - 1);
                panel1.Controls.Remove(butt);
                x = 0;
                y = 0;
                pointt = new Point(x, y);
            }
        }
    }
}
