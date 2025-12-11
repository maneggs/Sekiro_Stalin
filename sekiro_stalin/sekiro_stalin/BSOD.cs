using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sekiro_stalin
{
    public partial class BSOD : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        public BSOD()
        {
            InitializeComponent();

            if(Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Sleep();
        }

        private async void Sleep()
        {
            await Task.Delay(3000);
            this.Width = Width;
            this.Height = Height;
            pictureBox1.Width = Width;
            pictureBox1.Height = Height;
            pictureBox1.Location = new Point(-3, -3);
            pictureBox1.Image = Properties.Resources.bsod;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            await Task.Delay(15000);
            Environment.Exit(0);
        }

        private void BSOD_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void BSOD_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
