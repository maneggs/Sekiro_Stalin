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
    public partial class Form1 : Form
    {
        public static SoundPlayer sssr = new SoundPlayer(Properties.Resources.sssr);
        private int TotalSamurai = 5;
        private int NowSamurais = 0;

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        private async void SpawnSamurais()
        {
            await Task.Delay(2000);
            while(true)
            {
                await Task.Delay(100);
                NowSamurais++;
                if(NowSamurais <= TotalSamurai)
                {
                    Samurai samurai = new Samurai();
                    samurai.Show();
                }
                else
                {
                    break;
                }
            }
        }

        private async void SpawnStalin()
        {
            await Task.Delay(3000);
            Stalin stalin = new Stalin();
            stalin.Show();
        }
        public Form1()
        {
            InitializeComponent();
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            SpawnSamurais();
            SpawnStalin();
            sssr.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
