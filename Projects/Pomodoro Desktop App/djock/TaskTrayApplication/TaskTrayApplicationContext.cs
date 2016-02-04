using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TaskTrayApplication
{
    public class TaskTrayApplicationContext : ApplicationContext
    {
        NotifyIcon pomodoroIcon = new NotifyIcon();
        Pomodoro pomodoroWindow = new Pomodoro();

        System.Drawing.Size windowSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;

        public bool pomodoroVisible;

        public TaskTrayApplicationContext()
        {

            //MenuItem configMenuItem = new MenuItem("Settings", new EventHandler(ShowConfig));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));
            

            pomodoroIcon.Icon = TaskTrayApplication.Properties.Resources.AppIcon;

            pomodoroIcon.Click += new EventHandler(ShowPomodoro);



            pomodoroIcon.ContextMenu = new ContextMenu(new MenuItem[] {  exitMenuItem });
            pomodoroIcon.Visible = true;
        }

        private void ShowPomodoro(Object sender, EventArgs e)
        {
            if (!pomodoroVisible)
            {
                pomodoroWindow.Show();
                pomodoroWindow.TopMost = true;
                pomodoroVisible = true;
                pomodoroWindow.SetDesktopLocation(windowSize.Width - 300, windowSize.Height - 210);
            }
            else {
                pomodoroWindow.Hide();
                pomodoroVisible = false;
            }
        }

        void ShowConfig(object sender, EventArgs e)
        {
            if (pomodoroWindow.Visible)
                pomodoroWindow.Focus();
            else
                pomodoroWindow.ShowDialog();
        }

        void Exit(object sender, EventArgs e)
        {
            pomodoroIcon.Visible = false;

            Application.Exit();
        }
    }
}
