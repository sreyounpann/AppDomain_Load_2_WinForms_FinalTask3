using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BtnLeft()
        {
            pictureBox1.Invoke((Action)(() => pictureBox1.Left -= 10));
        }

        public void BtnRight()
        {
            pictureBox1.Invoke((Action)(() => pictureBox1.Left += 10));
        }

        public void BtnUp()
        {
            pictureBox1.Invoke((Action)(() => pictureBox1.Top -= 10));
        }


        public void BtnDown()
        {
            pictureBox1.Invoke((Action)((() => pictureBox1.Top += 10)));
        }

    
        public void MoveMe(Point newLocation, int width)
        {
            this.Invoke(new Action(() =>
            {
                this.Location = newLocation;
                this.Width = width;
            }));

        }
    }
}
