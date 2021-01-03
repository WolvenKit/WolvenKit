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
using WolvenKit;
using System.ComponentModel;
using WolvenKit.ViewModels;
using WolvenKit.Commands;

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
            this.txOutput.BackColor = UIController.GetBackColor();
            this.txOutput.ForeColor = UIController.GetForeColor();
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

#pragma warning disable CS1998
        internal async Task /*void*/ Parse(string[] _args)
#pragma warning restore CS1998
        {
            using (var sw = new StringWriter())
            {
                var result = new Parser(config => config.HelpWriter = sw)
                    .ParseArguments<ConsoleBulkEditOptions>(_args)
                    .MapResult(
                        async (ConsoleBulkEditOptions opts) => await RunBulkEdit(opts),
                        _ => Task.FromResult(1) /*1*/);

                AddTextStatic(sw.ToString(), Logtype.Important);
            }
        }

        private async Task<int> /*int*/ RunBulkEdit(ConsoleBulkEditOptions opts)
        {
            var vm = MockKernel.Get().GetBulkEditorViewModel();

            // Bool, Uint64, Int64, Uint32, Int32, Uint16, Int16, Uint8, Int8
            BulkEditOptions.AvailableTypes type = BulkEditOptions.AvailableTypes.ANY;
            if (opts.type == "Bool")
                type = BulkEditOptions.AvailableTypes.CBool;
            else if (opts.type == "Uint64")
                type = BulkEditOptions.AvailableTypes.CUInt64;
            else if (opts.type == "Int64")
                type = BulkEditOptions.AvailableTypes.CInt64;
            else if (opts.type == "Uint32")
                type = BulkEditOptions.AvailableTypes.CUInt32;
            else if (opts.type == "Int32")
                type = BulkEditOptions.AvailableTypes.CInt32;
            else if (opts.type == "Uint16")
                type = BulkEditOptions.AvailableTypes.CUInt16;
            else if (opts.type == "Int16")
                type = BulkEditOptions.AvailableTypes.CInt16;
            else if (opts.type == "Uint8")
                type = BulkEditOptions.AvailableTypes.CUInt8;
            else if (opts.type == "Int8")
                type = BulkEditOptions.AvailableTypes.CInt8;
            else if (opts.type == "String")
                type = BulkEditOptions.AvailableTypes.CString;

            var operation = BulkEditOptions.AvailableOperations.Replace;
            if (opts.option == "*")
                operation = BulkEditOptions.AvailableOperations.Multiply;
            if (opts.option == "/")
                operation = BulkEditOptions.AvailableOperations.Divide;
            if (opts.option == "+")
                operation = BulkEditOptions.AvailableOperations.Add;
            if (opts.option == "-")
                operation = BulkEditOptions.AvailableOperations.Subtract;

            var _opts = new BulkEditOptions()
            {
                Name = opts.varname,
                Value = opts.val,
                ChunkName = opts.chunk,
                Type = type,
                Extension = opts.ext,
                Operation = operation
            };
            if (opts.exc.Count() != 0)
                _opts.Exclude = string.Join(",", opts.exc.ToArray());
            if (opts.inc.Count() != 0)
                _opts.Include = string.Join(",", opts.inc.ToArray());

            return await Task.Run(() => vm.RunBulkEditInternal(_opts));
        }



    }

    [Verb("bulkedit", HelpText = "Bulk edit cr2w files. \n\r" +
       "Example use: -v 9999 -n autohidedistance -c CMesh -t Uint16 --err=true --exc=0,1029")]
    class ConsoleBulkEditOptions
    {
        // Required
        [Option('n', HelpText = "Specify the variable name. \n\r" +
            "Example: -n autohidedistance", Required = true)]
        public string varname { get; set; }

        [Option('v', HelpText = "Specify the new variable value. \n\r" +
            "Example: -v 9999", Required = true)]
        public string val { get; set; }

        // Optional string
        [Option('e', HelpText = "Specify the file extension to edit. \n\r" +
            "Example: -e w2mesh", Required = false)]
        public string ext { get; set; }

        [Option('c', HelpText = "Specify the chunk name. \n\r" +
            "Example: -c CMesh", Required = false)]
        public string chunk { get; set; }

        [Option('t', HelpText = "Specify the variable type. \n\r" +
            "Available types are Bool, Uint64, Int64, Uint32, Int32, Uint16, Int16, Uint8, Int8\n\r" +
            "Example: -t Uint16"
            , Required = false)]
        public string type { get; set; }

        [Option('o', HelpText = "Specify the option type. Default is replace.\n\r" +
           "Available types are Multiplication (*), Division (/), Addition (+), Subtraction (-),\n\r" +
            "Example: -o + \n\r" +
            "Example: -o / "
           , Required = false)]
        public string option { get; set; }


        // Optional lists
        [Option(Separator = ',', HelpText = "Exclude the following values.\n\r" +
            "Example: --exc=0,64,1028,2053", Required = false)]
        public IEnumerable<string> exc { get; set; }
        [Option(Separator = ',', HelpText = "Include only the following values.\n\r" +
            "Example: --inc=0,32,64", Required = false)]
        public IEnumerable<string> inc { get; set; }
    }
}