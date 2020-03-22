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

namespace WolvenKit
{
    public partial class frmConsole : DockContent, IThemedContent
    {
        private delegate void logDelegate(string t, Logtype type);
        private string lastCommand;

        public frmConsole()
        {
            InitializeComponent();
            ApplyCustomTheme();
        }


        private void AddTextStatic(string text, Logtype type = Logtype.Normal)
        {
            Invoke(new logDelegate(AddText), text, type);
        }

        private void AddText(string text, Logtype type = Logtype.Normal)
        {
            switch (type)
            {
                case Logtype.Error:
                    txOutput.AppendText(text,Color.Red, false);
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
                    File.WriteAllLines(sf.FileName,txOutput.Lines);
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Clear();
        }
        
        public void ApplyCustomTheme()
        {
            this.txOutput.BackColor = MainController.Get().GetTheme().ColorPalette.ToolWindowTabSelectedInactive.Background;
            this.txOutput.ForeColor = MainController.Get().GetTheme().ColorPalette.CommandBarMenuDefault.Text;
        }

        private void txOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string line = txOutput.Lines.Last();
                lastCommand = line;
                AddText("\r\n", Logtype.Important);

                if (!string.IsNullOrEmpty(line))
                {
                    Parse(line.Split(' '));
                }

            }
            if (e.KeyCode == Keys.Up)
            {
                AddText(lastCommand, Logtype.Important);
            }
        }

        internal async Task Parse(string[] _args)
        {
            using (var sw = new StringWriter())
            {
                var result = new Parser(config => config.HelpWriter = sw)
                    .ParseArguments<BulkEditOptions>(_args)
                    .MapResult(
                        async (BulkEditOptions opts) => await RunBulkEdit(opts),
                        //errs => 1,
                        _ => Task.FromResult(1));

                AddText(sw.ToString(), Logtype.Important);
            }
        }


        private async Task<int> RunBulkEdit(BulkEditOptions opts)
        {
            return await Task.Run(() => RunBulkEdit(opts.ext, opts.chunk, opts.var, opts.type, opts.val));
        }


        private async Task<int> RunBulkEdit(
           string ext,
           string chunk,
           string var,
           string type,
           string val)
        {

            List<string> files = MainController.Get().ActiveMod.Files;

            foreach (var path in files)
            {
                var fullpath = Path.Combine(MainController.Get().ActiveMod.FileDirectory, path);
                if (ext != null && !Path.GetExtension(fullpath).Contains(ext))
                    continue;


                CR2WFile cr2w;
                using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                {
                    cr2w = new CR2WFile(reader);
                    fs.Close();
                }
                var task = Task.Run(() => EditVariablesInFile(path, cr2w, chunk, var, type, val));
                await task.ContinueWith(antecedent =>
                {
                    using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.ReadWrite))
                    using (var writer = new BinaryWriter(fs))
                    {
                        cr2w.Write(writer);
                    }
                });
            }

            return 0;
        }

        private async Task EditVariablesInFile(string path,
            CR2WFile file,
            string chunk,
            string var,
            string type,
            string val
            )
        {
            if (file == null)
                return;
            if (chunk != null && !file.chunks.Any(_ => chunk.Contains(_.Type)))
                return;

            // get chunks that match chunkname
            List<CR2WExportWrapper> chunks = chunk != null ? file.chunks.Where(_ => chunk.Contains(_.Type)).ToList() : file.chunks;

            foreach (CR2WExportWrapper c in chunks)
            {
                EditVariables(c.data);
            }

            // local 
            void EditVariables(CVariable vec)
            {
                if (vec == null)
                    return;

                TryEditVariable(vec);

                //check children
                FieldInfo[] fields = vec.GetType().GetFields();
                foreach (var f in fields)
                {
                    if (f.Name == "cr2w")
                        continue;

                    var v = f.GetValue(vec);
                    if (v is IList && v.GetType().IsGenericType)
                    {
                        foreach (var listitem in (v as IList))
                        {
                            if (listitem is CVariable)
                                EditVariables(listitem as CVariable);
                        }
                    }
                    if (v is CVariable)
                    {
                        TryEditVariable(v as CVariable);
                        // check if variable has more children
                        EditVariables(((CVariable)v));
                    }
                }
            }

            void TryEditVariable(CVariable v)
            {
                if (v == null)
                    return;
                // is a match
                if (((CVariable)v).Name == var)
                {
                    // is not of type
                    if (type != null && ((CVariable)v).Type != type)
                    {
                        return;
                    }
                    // edit value
                    ((CVariable)v).SetValue(val);
                    AddTextStatic($"Succesfully edited a variable in {path}.\r\n", Logtype.Success);
                }
            }

        }
    }

    [Verb("bulkedit", HelpText = "Bulk edit cr2w files.")]
    class BulkEditOptions
    {

        [Option(HelpText = "Specify the file extension to edit.", Required = false)]
        public string ext { get; set; }

        [Option(HelpText = "Specify the chunk name.", Required = false)]
        public string chunk { get; set; }


        [Option(HelpText = "Specify the variable name.", Required = true)]
        public string var { get; set; }

        [Option(HelpText = "Specify the variable type.", Required = false)]
        public string type { get; set; }

        [Option(HelpText = "Specify the new variable value.", Required = true)]
        public string val { get; set; }


    }

}