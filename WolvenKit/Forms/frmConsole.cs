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
            //return RunBulkEdit(opts.ext, opts.chunk, opts.var, opts.type, opts.val);
        }


        private async Task<int> /*int*/ RunBulkEditInternal(BulkEditOptions opts)
        {

            List<string> files = MainController.Get().ActiveMod.Files;

            foreach (var path in files)
            {
                var fullpath = Path.Combine(MainController.Get().ActiveMod.FileDirectory, path);
                if (opts.ext != null && !Path.GetExtension(fullpath).Contains(opts.ext))
                    continue;


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

        private void EditVariablesInFile(string path,
            CR2WFile file,
            BulkEditOptions opts
            )
        {
            if (file == null)
                return;
            if (opts.chunk != null && !file.chunks.Any(_ => opts.chunk.Contains(_.REDType)))
                return;

            // get chunks that match chunkname
            List<CR2WExportWrapper> chunks = opts.chunk != null ? file.chunks.Where(_ => opts.chunk.Contains(_.REDType)).ToList() : file.chunks;

            foreach (CR2WExportWrapper c in chunks)
            {
                EditVariables(c.data);
            }
            AddTextStatic($"Finished {path}.\r\n", Logtype.Success);

            // local 
            void EditVariables(CVariable vec)
            {
                if (vec == null)
                    return;

                TryEditVariable(vec, vec.REDName);

                //check children
                FieldInfo[] fields = vec.GetType().GetFields();
                foreach (var f in fields)
                {
                    // exclude the cr2w parent variable 
                    if (f.Name == "cr2w")
                        continue;

                    // edit lists
                    var v = f.GetValue(vec);
                    if (v is IList && v.GetType().IsGenericType)
                    {
                        foreach (var listitem in (v as IList))
                        {
                            if (listitem is CVariable)
                                EditVariables(listitem as CVariable);
                        }
                    }
                    if (v is CVariable variable)
                    {
                        if (!TryEditVariable(v as CVariable, vec.REDName))
                            EditVariables(variable);      // check if variable has more children
                    }
                }
            }

            bool TryEditVariable(CVariable v, string parentname)
            {
                if (v == null)
                    return false;
                // is a match for name
                if (v.REDName == opts.var)
                {
                    // is not of type
                    if (opts.type != null && v.REDType != opts.type)
                        return false;
                    // exclude values
                    if (opts.exc != null && opts.exc.Count() > 0 && opts.exc.Contains(v.ToString()))
                        return false;
                    if (opts.inc != null && opts.inc.Count() > 0 && !opts.inc.Contains(v.ToString()))
                        return false;
                    // edit value
                    try
                    {
                        // check option 
                        switch (opts.option)
                        {
                            case "*":
                                {
                                    switch (opts.type)
                                    {
                                        case "Uint64": ((CUInt64)v).val *= ulong.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int64": ((CInt64)v).val *= long.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Uint32": ((CUInt32)v).val *= uint.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int32": ((CInt32)v).val *= int.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Uint16": ((CUInt16)v).val *= ushort.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int16": ((CInt16)v).val *= short.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Uint8": ((CUInt8)v).val *= byte.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int8": ((CInt8)v).val *= sbyte.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        default: break;
                                    }
                                    break;
                                }
                            case "/":
                                {
                                    switch (opts.type)
                                    {
                                        case "Uint64": ((CUInt64)v).val /= ulong.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int64": ((CInt64)v).val /= long.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Uint32": ((CUInt32)v).val /= uint.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int32": ((CInt32)v).val /= int.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Uint16": ((CUInt16)v).val /= ushort.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int16": ((CInt16)v).val /= short.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Uint8": ((CUInt8)v).val /= byte.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int8": ((CInt8)v).val /= sbyte.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        default: break;
                                    }
                                    break;
                                }
                            case "+":
                                {
                                    switch (opts.type)
                                    {
                                        case "Uint64": ((CUInt64)v).val += ulong.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int64": ((CInt64)v).val += long.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Uint32": ((CUInt32)v).val += uint.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int32": ((CInt32)v).val += int.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Uint16": ((CUInt16)v).val += ushort.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int16": ((CInt16)v).val += short.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Uint8": ((CUInt8)v).val += byte.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "Int8": ((CInt8)v).val += sbyte.Parse(opts.val); AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal); break;
                                        case "String": ((CString)v).val += opts.val; break;

                                        default: break;
                                    }
                                    break;
                                }
                            case "-":
                                {
                                    switch (opts.type)
                                    {
                                        case "Uint64": ((CUInt64)v).val -= ulong.Parse(opts.val); break;
                                        case "Int64": ((CInt64)v).val -= long.Parse(opts.val); break;
                                        case "Uint32": ((CUInt32)v).val -= uint.Parse(opts.val); break;
                                        case "Int32": ((CInt32)v).val -= int.Parse(opts.val); break;
                                        case "Uint16": ((CUInt16)v).val -= ushort.Parse(opts.val); break;
                                        case "Int16": ((CInt16)v).val -= short.Parse(opts.val); break;
                                        case "Uint8": ((CUInt8)v).val -= byte.Parse(opts.val); break;
                                        case "Int8": ((CInt8)v).val -= sbyte.Parse(opts.val); break;

                                        default: break;
                                    }
                                    break;
                                }
                            default:
                                v.SetValue(opts.val);
                                AddTextStatic($"Succesfully edited a variable in {parentname}: {path}.\r\n", Logtype.Normal);
                                break;
                        }
                        return true;
                    }
                    catch (Exception ex)
                    {
                        bool errors;
                        bool.TryParse(opts.err, out errors);
                        if (errors)
                            AddTextStatic($"Some parsing error: {ex.Message}.\r\n", Logtype.Error);
                        return false;
                    }
                    
                }
                return false;
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
        public string var { get; set; }

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

        [Option('o', HelpText = "Specify the option type. Default is replace. This option requires a valid type to be set with -t !!\n\r" +
           "Available types are Multiplication (*), Division (/), Addition (+), Subtraction (-),\n\r" +
            "Example: -o + -t Uint16\n\r" +
            "Example: -o / -t Int32"
           , Required = false)]
        public string option { get; set; }

        //[Option('p', HelpText = "Specify the parent name of the variable you want to edit.", Required = false)]
        //public string parent { get; set; }

        [Option(HelpText = "Verbose errors.\n\r" +
            "Example: --err=true", Required = false)]
        public string err { get; set; }

        // Optional lists
        [Option(Separator = ',', HelpText = "Exclude the following values.\n\r" +
            "Example: --exc=0,64,1028,2053", Required = false)]
        public IEnumerable<string> exc { get; set; }
        [Option(Separator = ',', HelpText = "Include only the following values.\n\r" +
            "Example: --inc=0,32,64", Required = false)]
        public IEnumerable<string> inc { get; set; }
    }

}