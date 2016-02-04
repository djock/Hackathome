using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace MyTrayApp
{
    public class SysTrayApp : Form
    {
        [STAThread]
        public static void Main()
        {
            Application.Run(new SysTrayApp());
        }

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

 //       public SysTrayApp()
 //       {
            // Create a simple tray menu with only one item.

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.

 //       }
        // Initalize the NofifyIcon object's shortcut menu.
        public SysTrayApp()
        {
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);
            trayIcon = new NotifyIcon();
            trayIcon.Text = "MyTrayApp";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);

            // Add menu to tray icon and show it.
            //trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            MenuItem[] menuList = new MenuItem[]{new MenuItem("Sign In"),
		new MenuItem("Get Help"), new MenuItem("Open")};
            trayMenu.MenuItems.AddRange(menuList);
            trayIcon.ContextMenu = trayMenu;

            // Associate the event-handling method with 
            // the NotifyIcon object's click event.
            trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(trayIcon1_Click);
        }


        // When user clicks the left mouse button display the shortcut menu.  
        // Use the SystemInformation.PrimaryMonitorMaximizedWindowSize property
        // to place the menu at the lower corner of the screen.
        private void trayIcon1_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            /*
            System.Drawing.Size windowSize =
                SystemInformation.PrimaryMonitorMaximizedWindowSize;
            System.Drawing.Point menuPoint =
                new System.Drawing.Point(windowSize.Width - 360,
                windowSize.Height - 5);
            menuPoint = this.PointToClient(menuPoint);

            trayIcon.ContextMenu.Show(this, menuPoint);
            */
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                System.Drawing.Size windowSize =
                    SystemInformation.PrimaryMonitorMaximizedWindowSize;
                Form1 clock = new Form1();
                clock.Show();
                clock.StartPosition = FormStartPosition.Manual;
                clock.SetDesktopLocation(windowSize.Width - 270, windowSize.Height - 220);
                clock.ShowInTaskbar = true;
                clock.WindowState = FormWindowState.Normal;
                trayIcon.Visible = false;
                clock.Height = 200;
                clock.Width = 250;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && cursorNotInBar)
            {
                this.ShowInTaskbar = false;
                trayIcon.Visible = true;
                this.Hide();
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnHello(object sender, EventArgs e)
        {
            
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                trayIcon.Dispose();
            }

            base.Dispose(isDisposing);
        }
    }
}
