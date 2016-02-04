using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskTrayApplication
{
    public partial class Pomodoro : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Timer pomodoroTimer;

        public int minutes;
        public int seconds = 59;

        public bool timerStarted;

        System.Media.SoundPlayer timeUpSound = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Unlock.wav");
        System.Media.SoundPlayer startSound = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Navigation Start.wav");
        

        public Pomodoro()
        {
            InitializeComponent();
            actionButton.Text = "START";
            pomodoroTime.Text = "25 : 00";
        }


        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            // If the user clicked "Save"
            if (this.DialogResult == DialogResult.OK)
            {
                TaskTrayApplication.Properties.Settings.Default.ShowMessage = true;
                TaskTrayApplication.Properties.Settings.Default.Save();
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button(object sender, EventArgs e)
        {
            
            if (actionButton.Text == "START")
            {
                StartTimer();
                actionButton.Text = "RESET";
                
            }
            else if (actionButton.Text == "RESET")
            {
                actionButton.Text = "START";
                pomodoroTimer.Stop();
                minutes = 25;
                seconds = 59;
                pomodoroTime.Text = "25 : 00";
            }
            
        }

        private void StartTimer()
        {
            startSound.Play();
            minutes = 25;
            minutes--;
            pomodoroTimer = new System.Windows.Forms.Timer();
            pomodoroTimer.Tick += new EventHandler(PomodoroTick);
            pomodoroTimer.Interval = 1000;
            pomodoroTimer.Start();

            actionButton.Text = "RESET";
            pomodoroTime.Text = minutes.ToString() + " : " + seconds.ToString();

            timerStarted = true;
        }

      
        private void PomodoroTick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds == -1)
            {
                minutes--;
                seconds = 59;
                
            }

            if(minutes == -1 && timerStarted)
            {
                minutes = 4;
                timeUpSound.Play();
                timerStarted = false;
            }
            else if (minutes == -1 && !timerStarted)
            {
                minutes = 24;
                timeUpSound.Play();
            }

            pomodoroTime.Text = minutes.ToString() + " : " + seconds.ToString();
        }

    }
}