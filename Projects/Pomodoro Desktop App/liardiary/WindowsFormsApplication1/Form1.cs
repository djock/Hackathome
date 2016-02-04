using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string secText
        {
            get
            {
                return this.sec.Text;
            }
            set
            {
                this.sec.Text = value;
            }
        }

        public string minText
        {
            get
            {
                return this.min.Text;
            }
            set
            {
                this.min.Text = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            min.Text = "00";
            sec.Text = "10";
            timer1.Interval = (1000); // 45 mins
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int min1, sec1;
            int.TryParse(min.Text, out min1);
            int.TryParse(sec.Text, out sec1);

            if (min1 == 0 && sec1 == 0)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                simpleSound.Play();
                this.Close();
                System.Drawing.Size windowSize =
                    SystemInformation.PrimaryMonitorMaximizedWindowSize;
                Form2 pause = new Form2();
                pause.Show();
                pause.StartPosition = FormStartPosition.Manual;
                pause.SetDesktopLocation(windowSize.Width - 270, windowSize.Height - 220);
                pause.ShowInTaskbar = true;
                pause.WindowState = FormWindowState.Normal;
                pause.Height = 200;
                pause.Width = 250;
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
                min.Text = "0" + min1.ToString();
            else
                min.Text = min1.ToString();
            if (sec1 < 10)
                sec.Text = "0" + sec1.ToString();
            else
                sec.Text = sec1.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Reset")
            {
                timer1.Stop();
                min.Text = "02";
                sec.Text = "00";
                button1.Text = "Start";
            }
            else
            {
                timer1.Start();
                button1.Text = "Reset";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 editClock = new Form3();
            editClock.Show();
        }
    }
}
