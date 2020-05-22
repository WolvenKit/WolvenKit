using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Editors;
using static WolvenKit.frmChunkProperties;

namespace WolvenKit.Forms
{

    public partial class frmCR2WtoText : Form
    {

        private IEnumerable<string> _files;
        private IEnumerable<string> files
        {
            get => _files;
            set
            {
                _files = value;
                if (files.Count() > 0)
                {
                    string count = files.Count().ToString();
                    labFileCount.Text = count;
                    pnlFileCount.Visible = true;
                    prgProgressBar.Maximum = files.Count();
                    prgProgressBar.Step = 1;
                    prgProgressBar.Value = 1;
                }
            }
        }
        StreamWriter outputFile;

        private bool _outputSingleFile = true;
        private bool outputSingleFile
        {
            get => _outputSingleFile;
            set
            {
                _outputSingleFile = value;
                txtOutputDestination.Clear();
            }
        }
        private string outputDestination;

        private bool existingOverwrite = true;

        private bool running = false;

        public frmCR2WtoText()
        {
            InitializeComponent();
            setDefaults();
        }

        private void setDefaults()
        {
            radExistingOverwrite.Checked = existingOverwrite;
            radExistingSkip.Checked = !existingOverwrite;
            radOutputModeSingleFile.Checked = outputSingleFile;
            radOutputModeSeparateFiles.Checked = !outputSingleFile;
            chkDumpSDB.Checked = true;
            chkDumpFCD.Checked = false;
        }

        // Thread safe methods to update the processed counts while dumping async.
        private delegate void setProcessedDelegate(int total, int count);
        private void setProcessedStatic(int count, int total)
        {
            Invoke(new setProcessedDelegate(setProcessed), count, total);
        }

        private void setProcessed(int count, int total)
        {
            labProcessedCount.Text = count.ToString();
            labProcessedTotal.Text = total.ToString();
            if (count>0)
                prgProgressBar.PerformStep();
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog
            {
                Description = "Choose path containing unbundled CR2W files."
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                startRun();
            }
            else
            {
                btnRun.Text = "Stopping...";
                running = false;
            }
        }

        private void controlsEnabledDuringRun(bool b)
        {
            // During run, all controls are disabled, and the run button changes to abort
            foreach (Control ctrl in pnlControls.Controls)
                ctrl.Enabled = b;
            btnRun.Text = b ? "Run CR2W Dump" : "Abort";
            // During run, progress bar, and processed files count/totals are made visible.
            prgProgressBar.Visible = !b;
            if (prgProgressBar.Visible) // reset progress bar each time it's made visible.
                prgProgressBar.Value = 1;
            pnlProcessedFiles.Visible = !b;
        }
        private async void startRun()
        {
            controlsEnabledDuringRun(false);
            running = true;

            await Task<bool>.Run(doRun);

            running = false;
            controlsEnabledDuringRun(true);
        }
        private async Task doRun()
        {
            setProcessedStatic(0, files.Count());

            if (files.Count() > 0)
            {
                int fileCount = 1;
                foreach (string fileName in files)
                {
                    if (!running)
                        break; // Abort button was pressed.

                    string fileBaseName = Path.GetFileName(fileName);

                    if (outputSingleFile)
                        outputDestination = txtOutputDestination.Text;
                    else
                        outputDestination = txtOutputDestination.Text + "\\" + fileBaseName + ".txt";

                    using (outputFile = new StreamWriter(outputDestination, true))
                    {
                        writeText("FILE", fileName);
                        int level = 1;
                        try
                        {
                            var cf = new LoggerCR2W(fileName);
                            processCR2W(cf, fileBaseName, level);
                        }
                        catch (FormatException fe)
                        {
                            if (outputSingleFile)
                                writeText(fileName, "Not a valid CR2W file, or file is damaged.");
                        }
                        catch (Exception ex)
                        {
                            writeText(fileName, "Exception: " + ex.ToString());
                        }
                        setProcessedStatic(fileCount++, files.Count());
                    }
                }
            }
        }

        private void processCR2W(LoggerCR2W lc, string fileName, int level)
        {
            foreach (var chunk in lc.chunks)
            {
                writeText(fileName, chunk.Name + " (" + chunk.Type + ") : " + chunk.Preview, level);
                var node = lc.getNodes(chunk);
                processNode(fileName, node, level);
            }
        }

        private void processNode(string fileName, VariableListNode node, int level)
        {
            if (node.Name == "unknownBytes" && node.Value == "0 bytes"
                || node.Name == "unk1" && node.Value == "0")
                return;

            if (node.Name == "Parent" && node.Value == "NULL")
                return;

            if (node.Name != node.Value) // Chunk node is already printed in processCR2W
                writeText(fileName, node.Name + " (" + node.Type + ") : " + node.Value, level);

            if (node.ChildCount > 0)
                foreach (var child in node.Children)
                {
                    processNode(fileName, child, level + 1);
                }

            if (node.Type == "SharedDataBuffer") // || node.Name == "flatCompiledData" )
            {
                CR2WFile embedcr2w = new CR2WFile(((IByteSource)node.Variable).Bytes);
                var lc = new LoggerCR2W(embedcr2w);
                processCR2W(lc, fileName, level + 1);
            }
        }
        private bool writeText(string prefix, string text, int level = 0)
        {
            string line;
            string indent = "";

            for (int i = 0; i < level; i++)
                indent += "    ";

            line = prefix + ":" + indent + text + "\r\n";
            outputFile.Write(line);

            return true;
        }
        private void enableRunButton()
        {
            btnRun.Enabled = txtPath.Text != "" && txtOutputDestination.Text != "" && files.Count() > 0;
        }
        private IEnumerable<string> GetFiles(string path, params string[] extExclude)
        {
            return Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                            .Where(file => !extExclude.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase)));
        }
        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            var path = txtPath.Text;
            string[] extExclude = new[] { ".txt", ".json", ".csv", ".xml", ".jpg", ".png",
                                          ".wem", ".dds", ".bnk", ".xbm", ".bundle", ".w3strings", ".store" };

            files = GetFiles(path, extExclude);
            enableRunButton();
        }
        private void txtOutputDestination_TextChanged(object sender, EventArgs e)
        {
            enableRunButton();
        }
        private void btnPickOutput_Click(object sender, EventArgs e)
        {
            CommonDialog dlg;
            if (outputSingleFile)
                dlg = new SaveFileDialog
                {
                    Title = "Select a file to output to.",
                    Filter = "TXT Files | *.txt"
                };
            else
                dlg = new FolderBrowserDialog
                {
                    Description = "Choose output folder."
                };

            if (dlg.ShowDialog() == DialogResult.OK)
                txtOutputDestination.Text = outputSingleFile ? ((SaveFileDialog)dlg).FileName : ((FolderBrowserDialog)dlg).SelectedPath;
        }
        private void radOutputModeSingleFile_CheckedChanged(object sender, EventArgs e)
        {
            outputSingleFile = radOutputModeSingleFile.Checked;
        }
        private void radOutputModeSeparateFiles_CheckedChanged(object sender, EventArgs e)
        {
            outputSingleFile = radOutputModeSingleFile.Checked;
        }
    }
    internal class LoggerCR2W
    {
        private CR2WFile cr2w;
        public List<CR2WExportWrapper> chunks { get; private set; }
        internal LoggerCR2W(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                cr2w = new CR2WFile(reader);
                chunks = cr2w.chunks;
            }
        }

        internal LoggerCR2W(CR2WFile cr2wFile)
        {
            cr2w = cr2wFile;
            chunks = cr2w.chunks;
        }

        public VariableListNode getNodes(CR2WExportWrapper chunk)
        {
            return AddListViewItems(chunk);
        }

        private VariableListNode AddListViewItems(IEditableVariable v, VariableListNode parent = null,
            int arrayindex = 0)
        {
            // This function is 100% copied from frmChunkProperties.cs !
            var node = new VariableListNode()
            {
                Variable = v,
                Children = new List<VariableListNode>(),
                Parent = parent
            };
            var vars = v.GetEditableVariables();
            if (vars != null)
            {
                for (var i = 0; i < vars.Count; i++)
                {
                    node.Children.Add(AddListViewItems(vars[i], node, i));
                }
            }

            return node;
        }
    }
}
