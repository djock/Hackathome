using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string pauseSecText
        {
            get
            {
                return this.pause_sec.Text;
            }
            set
            {
                this.pause_sec.Text = value;
            }
        }

        public string pauseMinText
        {
            get
            {
                return this.pause_min.Text;
            }
            set
            {
                this.pause_min.Text = value;
            }
        }

        public void callClock()
        {
            this.Close();
            System.Drawing.Size windowSize =
                SystemInformation.PrimaryMonitorMaximizedWindowSize;
            Form1 skip_break = new Form1();
            skip_break.Show();
            skip_break.StartPosition = FormStartPosition.Manual;
            skip_break.SetDesktopLocation(windowSize.Width - 270, windowSize.Height - 220);
            skip_break.ShowInTaskbar = true;
            skip_break.WindowState = FormWindowState.Normal;
            skip_break.Height = 200;
            skip_break.Width = 250;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pause_min.Text = "1";
            pause_sec.Text = "00";
            timer2.Start();
            timer2.Interval = (1000); // 45 mins
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int min1, sec1;
            int.TryParse(pause_min.Text, out min1);
            int.TryParse(pause_sec.Text, out sec1);

            if (min1 == 0 && sec1 == 0)
            {
                callClock();
            }
            if (sec1 < 1)
            {
                sec1 = 59;
                min1--;
            }
            else
            {
                sec1--;
            }
            if (min1 < 10)
                pause_min.Text = "0" + min1.ToString();
            else
                pause_min.Text = min1.ToString();
            if (sec1 < 10)
                pause_sec.Text = "0" + sec1.ToString();
            else
                pause_sec.Text = sec1.ToString();


        }

        private void pause_Click(object sender, EventArgs e)
        {
            callClock();
        }
    }
}
