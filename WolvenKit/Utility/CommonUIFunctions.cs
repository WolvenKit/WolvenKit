using System;
using System.Drawing;
using System.Windows.Forms;

namespace WolvenKit
{
    public static class CommonUIFunctions
    {
        /// <summary>
        /// Send a popup notification.
        /// </summary>
        /// <param name="msg">The string to display in the notification.</param>
        public static void SendNotification(string msg)
        {
            Version win8version = new Version(6, 2, 9200, 0);

            if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version >= win8version)
            {
                // its win8 or higher so we can use toas notifications TODO: Add actual rich toast notifications
                using (var ni = new NotifyIcon())
                {
                    ni.Icon = SystemIcons.Information;
                    ni.Visible = true;
                    ni.ShowBalloonTip(3000, "WolvenKit", msg, ToolTipIcon.Info);
                }

            }
            else
            {
                using (var ni = new NotifyIcon())
                {
                    ni.Icon = SystemIcons.Information;
                    ni.Visible = true;
                    ni.ShowBalloonTip(3000, "WolvenKit", msg, ToolTipIcon.Info);
                }
            }
        }

        /// <summary>
        /// Show a messagebox that the feature is work in progress.
        /// </summary>
        public static void ShowWIPMessage()
        {
            MessageBox.Show("Work in progress.", "Coming soon(tm)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        
    }
}
