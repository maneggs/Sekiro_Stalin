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
    public partial class Stalin : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        public Stalin()
        {
            InitializeComponent();

            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Молитва Сталину оформлена", "Сталин", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1.sssr.Stop();
            this.Hide();
            LastDialog lastDialog = new LastDialog();
            lastDialog.Show();
        }

        private void Stalin_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(10, 10);
        }

        private void Stalin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
