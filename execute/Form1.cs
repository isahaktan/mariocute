using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace execute
{
    public partial class Form1 : Form
    {
        public Form1()
        {



            InitializeComponent();

            timer1.Tick += timer1_Tick;
            timer1.Interval = 6000; //microsecond


            axWindowsMediaPlayer1.URL = Application.StartupPath +"/tekrar.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            



            

        }
        private void timer1_Tick(object sender, EventArgs e)
        {


            //MessageBox.Show("Timer tetiklendi. Şu anki zaman: " + DateTime.Now);



            Process.Start("shutdown", " -s -t 0");
        }



    }
}
