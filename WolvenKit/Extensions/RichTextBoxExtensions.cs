using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Extensions
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color, bool appendTime = true)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            if (appendTime)
                box.AppendText("[" + DateTime.Now.ToString("G") + "]: " + text);
            else
                box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }

    
}
