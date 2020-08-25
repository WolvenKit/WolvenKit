using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Common.Services;
using WolvenKit.Services;
using WolvenKit.Extensions;
using System.Linq;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using CommandLine;
using WolvenKit.App;
using System.ComponentModel;

namespace WolvenKit
{
    public partial class frmConsole : DockContent, IThemedContent
    {

        private string lastCommand;

        private readonly List<Type> supportedTypes = new List<Type>() { typeof(CUInt64), typeof(CUInt32), typeof(CUInt16), typeof(CUInt8),
            typeof(CInt64), typeof(CInt32), typeof(CInt16), typeof(CInt8),
            typeof(CBool), typeof(CString) };

        public frmConsole()
        {
            InitializeComponent();
            ApplyCustomTheme();
        }

        private delegate void logDelegate(string t, Logtype type);
        private void AddTextStatic(string text, Logtype type = Logtype.Normal)
        {
            Invoke(new logDelegate(AddText), text, type);
        }
        private void AddText(string text, Logtype type = Logtype.Normal)
        {
            switch (type)
            {
                case Logtype.Error:
                    txOutput.AppendText(text, Color.Red, false);
                    break;
                case Logtype.Important:
                    txOutput.AppendText(text, Color.Orange, false);
                    break;
                case Logtype.Wcc:
                    txOutput.AppendText(text);
                    break;
                case Logtype.Success:
                    txOutput.AppendText(text, Color.LimeGreen, false);
                    break;
                default:
                    txOutput.AppendText("[" + DateTime.Now.ToString("G") + "]: " + text);
                    break;
            }
            txOutput.ScrollToCaret();
        }

        internal void Clear()
        {
            txOutput.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(txOutput.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (var sf = new SaveFileDialog())
            {
                sf.Title = "Choose a location to save the log to.";
                sf.Filter = "Text file (.txt) | *.txt";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(sf.FileName, txOutput.Lines);
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
        }

        public void ApplyCustomTheme()
        {
            this.txOutput.BackColor = UIController.Get().GetTheme().ColorPalette.ToolWindowTabSelectedInactive.Background;
            this.txOutput.ForeColor = UIController.Get().GetTheme().ColorPalette.CommandBarMenuDefault.Text;
        }

        private async void txOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string line = txOutput.Lines.Last();
                lastCommand = line;
                AddTextStatic("\r\n", Logtype.Important);

                if (!string.IsNullOrEmpty(line))
                {
                    //await Task.Run(() => Parse(line.Split(' ')));
                    await Task.Run(() => Parse(line.Split(' ')));
                }

            }
            if (e.KeyCode == Keys.Up)
            {
                AddTextStatic(lastCommand, Logtype.Important);
            }
        }

        internal async Task /*void*/ Parse(string[] _args)
        {
            //using (var sw = new StringWriter())
            //{
            //    var result = new Parser(config => config.HelpWriter = sw)
            //        .ParseArguments<BulkEditOptions>(_args)
            //        .MapResult(
            //            async (BulkEditOptions opts) => await RunBulkEdit(opts),
            //            _ => Task.FromResult(1) /*1*/);

            //    AddTextStatic(sw.ToString(), Logtype.Important);
            //}
        }
    }
}