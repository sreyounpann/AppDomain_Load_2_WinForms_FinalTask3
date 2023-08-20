using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlButton
{
    public partial class Form1 : Form
    {

        public Module ButtonWindow { get; set; }
        object ButtonWinForm;
        public Form1(Module module, object ButtonForm)
        {
            InitializeComponent();
            ButtonWindow = module;
            ButtonWinForm = ButtonForm;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            ButtonWindow.GetType("Button.Form1")
                .GetMethod("BtnUp")
                ?.Invoke(ButtonWinForm, new object[] { });

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (ButtonWindow != null && ButtonWinForm != null)
            {
                ButtonWindow.GetType("Button.Form1")
                    .GetMethod("BtnDown")
                    ?.Invoke(ButtonWinForm, new object[] { });
            }
        }


        private void btnLeft_Click(object sender, EventArgs e)
        {
            ButtonWindow.GetType("Button.Form1")
                .GetMethod("BtnLeft")
                ?.Invoke(ButtonWinForm, new object[] { });
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ButtonWindow.GetType("Button.Form1")
                .GetMethod("BtnRight")
                ?.Invoke(ButtonWinForm, new object[] { });
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                return;
            }

            ButtonWindow.GetType("Button.Form1")
                .GetMethod("MoveMe")
                .Invoke(ButtonWinForm, new object[] { new Point(this.Location.X, this.Location.Y + this.Height), this.Width });
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
