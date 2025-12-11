using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sekiro_stalin
{
    public partial class Samurai : Form
    {
        private Random rnd = new Random();
        private Random randompos = new Random();
        private int deltaX;
        private int deltaY;

        private int RandXPos = 0;
        private int RandYPos = 0;

        private int width = Screen.PrimaryScreen.WorkingArea.Width;
        private int height = Screen.PrimaryScreen.WorkingArea.Height;

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        public Samurai()
        {
            InitializeComponent();

            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            deltaX = rnd.Next(-15, 16);
            deltaY = 10;

            RandXPos = randompos.Next(100, (width - this.Width)-50);
            RandYPos = randompos.Next(100, (height - this.Height) - 50);
        }

        private void Samurai_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(RandXPos, RandYPos);    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int newX = this.Location.X + deltaX;
            int newY = this.Location.Y + deltaY;

            if (newX < 0 || newX + this.Width > Screen.PrimaryScreen.WorkingArea.Width)
                deltaX = -deltaX;

            if (newY < 0 || newY + this.Height > Screen.PrimaryScreen.WorkingArea.Height)
                deltaY = -deltaY;

            this.Location = new Point(newX, newY);
        }

        private void Samurai_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
