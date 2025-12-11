using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace sekiro_stalin
{
    public partial class LastDialog : Form
    {
        [DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();

        public LastDialog()
        {
            InitializeComponent();

            if(Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
        }

        private void LastDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSOD bsod = new BSOD();
            bsod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BSOD bsod = new BSOD();
            bsod.Show();
        }

        private void LastDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
