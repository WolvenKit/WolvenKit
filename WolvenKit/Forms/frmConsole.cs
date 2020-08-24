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
        private delegate void logDelegate(string t, Logtype type);
        private string lastCommand;

        private readonly List<Type> supportedTypes = new List<Type>() { typeof(CUInt64), typeof(CUInt32), typeof(CUInt16), typeof(CUInt8),
            typeof(CInt64), typeof(CInt32), typeof(CInt16), typeof(CInt8),
            typeof(CBool), typeof(CString) };

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
            using (var sw = new StringWriter())
            {
                var result = new Parser(config => config.HelpWriter = sw)
                    .ParseArguments<BulkEditOptions>(_args)
                    .MapResult(
                        async (BulkEditOptions opts) => await RunBulkEdit(opts),
                        _ => Task.FromResult(1) /*1*/);

                AddTextStatic(sw.ToString(), Logtype.Important);
            }
        }


        private async Task<int> /*int*/ RunBulkEdit(BulkEditOptions opts)
        {
            return await Task.Run(() => RunBulkEditInternal(opts));
        }


        private async Task<int> /*int*/ RunBulkEditInternal(BulkEditOptions opts)
        {
            if (MainController.Get().ActiveMod == null)
                return 0;
            List<string> files = MainController.Get().ActiveMod.Files;
            if (opts.ext != null)
                files = MainController.Get().ActiveMod.Files.Where(_ => Path.GetExtension(_).Contains(opts.ext)).ToList();
            AddTextStatic($"Starting Bulk edit. Found {files.Count} files to edit. \r\n", Logtype.Success);

            foreach (var path in files)
            {
                var fullpath = Path.Combine(MainController.Get().ActiveMod.FileDirectory, path);

                CR2WFile cr2w;
                using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                {
                    cr2w = new CR2WFile(reader);
                    fs.Close();
                }
                //EditVariablesInFile(path, cr2w, chunk, var, type, val);
                await Task.Run(() => EditVariablesInFile(path, cr2w, opts))
                    .ContinueWith(antecedent =>
                {
                    using (var fs = new FileStream($"{fullpath}", FileMode.Create, FileAccess.ReadWrite))
                    using (var writer = new BinaryWriter(fs))
                    {
                        cr2w.Write(writer);
                    }
                });
            }

            return 0;
        }

        private void EditVariablesInFile(string path, CR2WFile file, BulkEditOptions opts)
        {
            if (file == null)
                return;
            if (opts.chunk != null && !file.chunks.Any(_ => opts.chunk.Contains(_.REDType)))
                return;

            var excludedvalues = opts.exc.ToList();
            var includedvalues = opts.inc.ToList();

            // get chunks that match chunkname
            List<CR2WExportWrapper> chunks = opts.chunk != null ? file.chunks.Where(_ => _.data.GetType().Name == opts.chunk).ToList() : file.chunks;
            //AddTextStatic($"Starting {path}... \r\n", Logtype.Success);
            foreach (var chunk in chunks.Select(_ => _.data))
            {
                CheckProperties(chunk);
            }
            AddTextStatic($"Finished {path}.\r\n", Logtype.Success);


            void CheckProperties(CVariable cvar)
            {
                // edit lists
                if (cvar is IList && cvar.GetType().IsGenericType)
                {
                    foreach (var listitem in (cvar as IList))
                    {
                        if (listitem is CVariable clistitem)
                            CheckProperties(clistitem);
                    }
                }
                else
                {
                    // try to set the value in the class
                    TrySetValue(cvar);

                    // goes through all properties
                    var props = cvar.GetEditableVariables();
                    foreach (var prop in props)
                    {
                        if (prop is CVariable cprop)
                        {
                            CheckProperties(cprop);
                        }
                    }
                }
            }
            
            void TrySetValue(CVariable cvar)
            {
                var propnameslist = cvar.accessor.GetMembers().Select(_ => _.Name).ToList();
                if (propnameslist.Contains(opts.varname))
                {
                    try
                    {
                        // check if type is supported
                        var proptoedit = cvar.GetEditableVariables().First(_ => _.REDName == opts.varname) as CVariable;
                        if (supportedTypes.Contains(proptoedit.GetType()))
                        {
                            // check the value 
                            dynamic dyn = proptoedit;
                            var x = dyn.val as string;
                            if (x == opts.val)
                                return;
                            if (excludedvalues.Count != 0 && excludedvalues.Contains(x))
                                return;
                            if (includedvalues.Count != 0 && !includedvalues.Contains(x))
                                return;

                            // access the val property of the CVariable baecause there's typecopnverters from string available
                            var value = proptoedit.accessor.GetMembers().First(_ => _.Name == "val");
                            var converter = TypeDescriptor.GetConverter(value.Type);
                            var result = converter.ConvertFrom(opts.val);

                            // set via reflection
                            proptoedit.accessor[proptoedit, "val"] = result;
                            AddTextStatic($"Succesfully edited a variable in {cvar.REDName}: {path}.\r\n", Logtype.Normal);
                        }
                        else
                            AddTextStatic($"{proptoedit.GetType()} not supported in {cvar.REDName}: {path}.\r\n", Logtype.Normal);
                    }
                    catch (Exception ex)
                    {
                        AddTextStatic($"Some error occored: {ex.Message}.\r\n", Logtype.Error);
                    }
                }
            }

        }
    }

    [Verb("bulkedit", HelpText = "Bulk edit cr2w files. \n\r" +
        "Example use: -v 9999 -n autohidedistance -c CMesh -t Uint16 --err=true --exc=0,1029")]
    class BulkEditOptions
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

        //[Option('t', HelpText = "Specify the variable type. \n\r" +
        //    "Available types are Bool, Uint64, Int64, Uint32, Int32, Uint16, Int16, Uint8, Int8\n\r" +
        //    "Example: -t Uint16"
        //    , Required = false)]
        //public string type { get; set; }

        //[Option('o', HelpText = "Specify the option type. Default is replace. This option requires a valid type to be set with -t !!\n\r" +
        //   "Available types are Multiplication (*), Division (/), Addition (+), Subtraction (-),\n\r" +
        //    "Example: -o + -t Uint16\n\r" +
        //    "Example: -o / -t Int32"
        //   , Required = false)]
        //public string option { get; set; }

        //[Option('p', HelpText = "Specify the parent name of the variable you want to edit.", Required = false)]
        //public string parent { get; set; }

        //[Option(HelpText = "Verbose errors.\n\r" +
        //    "Example: --err=true", Required = false)]
        //public string err { get; set; }

        // Optional lists
        [Option(Separator = ',', HelpText = "Exclude the following values.\n\r" +
            "Example: --exc=0,64,1028,2053", Required = false)]
        public IEnumerable<string> exc { get; set; }
        [Option(Separator = ',', HelpText = "Include only the following values.\n\r" +
            "Example: --inc=0,32,64", Required = false)]
        public IEnumerable<string> inc { get; set; }
    }

}