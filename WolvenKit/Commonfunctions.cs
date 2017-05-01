using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit
{
    static class Commonfunctions
    {
        public static void SendNotification(string msg)
        {
            using (var ni = new NotifyIcon())
            {
                ni.Icon = SystemIcons.Information;
                ni.Visible = true;
                ni.ShowBalloonTip(3000, "WolvenKit", msg, ToolTipIcon.Info);
            }
        }
    }
}
