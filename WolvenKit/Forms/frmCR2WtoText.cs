using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualPlus.Extensibility;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Editors;
using static WolvenKit.frmChunkProperties;

namespace WolvenKit.Forms
{

    public partial class frmCR2WtoText : Form
    {
        private List<string> Files = new List<string>();

        private bool _outputSingleFile = false;
        private bool outputSingleFile
        {
            get => _outputSingleFile;
            set
            {
                _outputSingleFile = value;
                txtOutputDestination.Clear();
            }
        }
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
            chkDumpEmbedded.Checked = true;
        }
        // Thread safe methods to update the processed counts while dumping async.
        private delegate void setStatusDelegate(int count, int total, int nonCR2W, int exceptions);
        private void setStatusStatic(int count, int total, int nonCR2W, int exceptions)
        {
            Invoke(new setStatusDelegate(setStatus), count, total, nonCR2W, exceptions);
        }
        private void setStatus(int count, int processed, int nonCR2W, int exceptions)
        {
            string[] row = { count.ToString("N0"), processed.ToString("N0"), nonCR2W.ToString("N0"), exceptions.ToString("N0") };
            if (dataStatus.Rows.Count == 0)
                dataStatus.Rows.Add(row);
            else
                dataStatus.Rows[0].SetValues(row);

            if (processed > 0)
                updateProgressBarStatic(processed);
        }
        private delegate void updateProgressBarDelegate(int processed);
        private void updateProgressBarStatic(int processed)
        {
            Invoke(new updateProgressBarDelegate(updateProgressBar), processed);
        }
        private void updateProgressBar(int processed)
        {
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
            pnlControls.Enabled = b;
            btnRun.Text = b ? "Run CR2W Dump" : "Abort";
        }
        private async void startRun()
        {
            controlsEnabledDuringRun(false);
            prgProgressBar.Value = 0;
            prgProgressBar.Visible = true;
            running = true;

            await Task.Run(doRun);

            running = false;
            controlsEnabledDuringRun(true);
            prgProgressBar.Visible = false;
        }
        private StreamWriter getOutputSingleFile(string outputChosen)
        {
            string outputDestination;
            outputDestination = outputChosen;
            if (File.Exists(outputDestination))
                File.Delete(outputDestination);
            return new StreamWriter(outputDestination, false);
        }
        private StreamWriter getOutputSeparateFiles(string fileName, string sourcePath, string outputChosen, string fileBaseName)
        {
            string outputDestination;
            if (chkCreateFolders.Checked)
            {   // Recreate the file structure of the source folder in the destination folder.
                // Strip the sourcepath from the start of the filename, then create the remaining folders
                fileName.ReplaceFirst(sourcePath, "", out sourcePath);
                int i = sourcePath.LastIndexOf(fileBaseName);
                outputDestination = outputChosen + sourcePath.Substring(0, i);

                Directory.CreateDirectory(outputDestination);
            }
            else
                outputDestination = outputChosen;

            outputDestination = outputDestination + "\\" + fileBaseName + ".txt";

            if (File.Exists(outputDestination))
                if (radExistingOverwrite.Checked)
                    File.Delete(outputDestination);
                else
                    return null;

            return new StreamWriter(outputDestination, false);
        }
        private async Task doRun()
        {
            setStatusStatic(Files.Count(), 0, 0, 0);

            if (Files.Count() > 0)
            {
                int fileCount = 1;
                int nonCR2WCount = 0;
                int exceptionCount = 0;

                string sourcePath = txtPath.Text;
                string outputChosen = txtOutputDestination.Text;
                StreamWriter outputFile = null;

                var loggerOptions = new LoggerCR2WOptions
                {
                    startingIndentLevel = 1,
                    listEmbedded = chkDumpEmbedded.Checked,
                    dumpFCD = chkDumpFCD.Checked,
                    dumpSDB = chkDumpSDB.Checked
                };

                if (outputSingleFile)
                    outputFile = getOutputSingleFile(outputChosen);

                foreach (string fileName in Files)
                {
                    if (!running)
                        break; // Abort button was pressed.

                    string fileBaseName = Path.GetFileName(fileName);

                    if (!outputSingleFile)
                        outputFile = getOutputSeparateFiles(fileName, sourcePath, outputChosen, fileBaseName);

                    if (outputFile != null)
                    {
                        try
                        {
                            doDump(outputFile, fileName, fileBaseName, loggerOptions);
                        }
                        catch (FormatException fe)
                        {
                            if (outputSingleFile)
                                outputFile.WriteLine(fileName + ": Not a valid CR2W file, or file is damaged.");
                            nonCR2WCount++;
                        }
                        catch (Exception ex)
                        {
                            outputFile.WriteLine(fileName + ": Exception: " + ex.ToString());
                            exceptionCount++;
                        }
                        if (!outputSingleFile)
                            outputFile.Close();
                    }

                    setStatusStatic(Files.Count(), fileCount++, nonCR2WCount, exceptionCount);
                }
                if (outputSingleFile)
                    outputFile.Close();
            }
        }
        private async Task doRunOLD()
        {
            setStatusStatic(Files.Count(), 0, 0, 0);

            if (Files.Count() > 0)
            {
                int fileCount = 1;
                int nonCR2WCount = 0;
                int exceptionCount = 0;

                string outputDestination = "";
                string sourcePath = txtPath.Text;
                string outputChosen = txtOutputDestination.Text;
                StreamWriter outputFile;

                if (outputSingleFile)
                {
                    outputDestination = outputChosen;
                    if (File.Exists(outputDestination))
                        File.Delete(outputDestination);
                    outputFile = new StreamWriter(outputDestination, false);
                }

                foreach (string fileName in Files)
                {
                    if (!running)
                        break; // Abort button was pressed.

                    string fileBaseName = Path.GetFileName(fileName);

                    bool skip = false;
                    if (!outputSingleFile)
                    {
                        if (chkCreateFolders.Checked)
                        {   // Recreate the file structure of the source folder in the destination folder.
                            // Strip the sourcepath from the start of the filename, then create the remaining folders
                            fileName.ReplaceFirst(sourcePath, "", out sourcePath);
                            int i = sourcePath.LastIndexOf(fileBaseName);
                            outputDestination = outputChosen + sourcePath.Substring(0, i);

                            Directory.CreateDirectory(outputDestination);
                        }
                        else
                            outputDestination = outputChosen;

                        outputDestination = outputDestination + "\\" + fileBaseName + ".txt";

                        if (File.Exists(outputDestination))
                            if (radExistingOverwrite.Checked)
                                File.Delete(outputDestination);
                            else
                                skip = true;
                        outputFile = new StreamWriter(outputDestination, false);
                    }

                    // If "Overwrite existing" set (and we're in separate files mode), delete existing file, otherwise skip it.

                    if (!skip)
                        // Open output file for writing. Set append to true if we're in single file mode.
                        try
                        {
                            //doDump(outputFile, fileName, fileBaseName);
                        }
                        catch (FormatException fe)
                        {
                            if (outputSingleFile)
                                //outputFile.WriteLine(fileName + ": Not a valid CR2W file, or file is damaged.");
                            nonCR2WCount++;
                        }
                        catch (Exception ex)
                        {
                            //outputFile.WriteLine(fileName + ": Exception: " + ex.ToString());
                            exceptionCount++;
                        }
                    //outputFile.Close();
                    setStatusStatic(Files.Count(), fileCount++, nonCR2WCount, exceptionCount);
                }
            }
        }
        private void doDump(StreamWriter outputFile, string fileName, string fileBaseName, LoggerCR2WOptions options)
        {
            var writer = new LoggerWriter(outputFile, chkPrefixFileName.Checked ? fileBaseName : null);
            outputFile.WriteLine("FILE: " + fileName);
            var cf = new LoggerCR2W(fileName, writer, options);
            cf.processCR2W();
        }

        private void checkEnableRunButton()
        {
            btnRun.Enabled = txtPath.Text != "" && txtOutputDestination.Text != "" && Files.Count() > 0;
        }
        private async Task updateSourceFolder(string path)
        {
            string[] extExclude = new[] { ".txt", ".json", ".csv", ".xml", ".jpg", ".png",
                                          ".wem", ".dds", ".bnk", ".xbm", ".bundle", ".w3strings", ".store" };

            Files.Clear();
            if (Directory.Exists(path))
            {
                btnRun.Enabled = false;
                pnlControls.Enabled = false;
                await Task.Run(() =>
                {
                    int fileCounter = 1;
                    foreach (var file in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                                                  .Where(file => !extExclude.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase))))
                    {
                        Files.Add(file);
                        if (fileCounter % 100 == 0) // Only update status for every 100 files
                            setStatusStatic(fileCounter, 0, 0, 0);
                        fileCounter++;
                    }
                });

                int count = Files.Count();
                setStatusStatic(count, 0, 0, 0);
                resetProgressBar(count);

                pnlControls.Enabled = true;
                checkEnableRunButton();
            }
            else
            {
                Files.Clear();
                setStatusStatic(0, 0, 0, 0);
            }

        }
        private void resetProgressBar(int count)
        {
            prgProgressBar.Maximum = count;
            prgProgressBar.Step = 1;
        }
        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            updateSourceFolder(txtPath.Text);
        }
        private void txtOutputDestination_TextChanged(object sender, EventArgs e)
        {
            checkEnableRunButton();
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
        private void radioOututModeChanged(object sender, EventArgs e)
        {
            outputSingleFile = radOutputModeSingleFile.Checked;
            // Create intermediate folders only enabled if Separate Files output selected.
            chkCreateFolders.Enabled = radOutputModeSeparateFiles.Checked;
            // Overwrite mode radio only enabled if Separate Files output selected.
            grpExistingFiles.Enabled = radOutputModeSeparateFiles.Checked;
        }
    }
    internal class LoggerWriter
    {
        StreamWriter outputFile { get; set; }
        bool usePrefix { get; set; }
        string prefix { get; set; }
        internal LoggerWriter(StreamWriter file, string prefix = null)
        {
            this.outputFile = file;
            if (prefix != null)
            {
                this.usePrefix = true;
                this.prefix = prefix;
            }
        }
        public bool writeText(string text, int level = 0)
        {
            string line;
            string indent = "";

            for (int i = 0; i < level; i++)
                indent += "    ";

            if (usePrefix)
                line = prefix + ":" + indent + text + "\r\n";
            else
                line = indent + text + "\r\n";

            outputFile.Write(line);

            return true;
        }
    }
    internal struct LoggerCR2WOptions
    {
        public int startingIndentLevel { get; set; }
        public bool listEmbedded { get; set; }
        public bool dumpSDB { get; set; }
        public bool dumpFCD { get; set; }
    }
    internal class LoggerCR2W
    {
        private CR2WFile cr2w;
        private CR2WFile CR2W
        { 
            get => cr2w;
            set
            {
                cr2w = value;
                chunks = CR2W.chunks;
                embedded = CR2W.embedded;
            }
        }
        private LoggerWriter writer { get; set; }
        private LoggerCR2WOptions options { get; set; }
        public List<CR2WExportWrapper> chunks { get; private set; }
        public List<CR2WEmbeddedWrapper> embedded { get; private set; }
        internal LoggerCR2W(string fileName, LoggerWriter writer, LoggerCR2WOptions options)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                    CR2W = new CR2WFile(reader);

            this.writer = writer;
            this.options = options;
        }
        internal LoggerCR2W(CR2WFile cr2wFile, LoggerWriter writer, LoggerCR2WOptions options)
        {
            CR2W = cr2wFile;
            this.writer = writer;
            this.options = options;
        }
        public void processCR2W(int overrideLevel = 0)
        {
            int level = (overrideLevel > 0) ? overrideLevel : options.startingIndentLevel;
            if (options.listEmbedded && embedded != null && embedded.Count() > 0)
            {
                writer.writeText("Embedded files:", level);
                processEmbedded(level);
            }
            writer.writeText("Chunks:", level);
            foreach (var chunk in chunks)
            {
                writer.writeText(chunk.Name + " (" + chunk.Type + ") : " + chunk.Preview, level);
                var node = getNodes(chunk);
                processNode(node, level + 1);
            }
        }
        private void processEmbedded(int level)
        {
            //TODO: Also dump the embedded files? (optionally)
            int fileCounter = 1;
            foreach (CR2WEmbeddedWrapper embed in embedded)
            {
                writer.writeText("(" + fileCounter++ + "):", level);
                writer.writeText("Index: " + embed.Embedded.importIndex, level + 1);
                writer.writeText("ImportPath: " + embed.ImportPath, level + 1);
                writer.writeText("ImportClass: " + embed.ImportClass, level + 1);
                writer.writeText("Size: " + embed.Embedded.dataSize, level + 1);
                writer.writeText("ClassName: " + embed.ClassName, level + 1);
                writer.writeText("Handle: " + embed.Handle, level + 1);
            }
        }
        private void processNode(VariableListNode node, int level)
        {
            if (node.Name == "unknownBytes" && node.Value == "0 bytes"
                || node.Name == "unk1" && node.Value == "0")
                return;

            if (node.Name == "Parent" && node.Value == "NULL")
                return;

            if (node.Name != node.Value) // Chunk node is already printed in processCR2W, so don't print it again.
            {
                writer.writeText(node.Name + " (" + node.Type + ") : " + node.Value, level);
                level++;
            }

            if (node.ChildCount > 0)
                foreach (var child in node.Children)
                    processNode(child, level);

            if (  (node.Type == "SharedDataBuffer" && options.dumpSDB) 
                || node.Type == "array:2,0,Uint8" )
            {   // Embedded CR2W dump:
                // Dump SharedDataBuffer if option is set.
                // Dump "array:2,0,Uint8", unless it's FCD in which case only dump if options.dumpFCD is set.
                if (node.Name != "flatCompiledData" || options.dumpFCD)
                {
                    CR2WFile embedcr2w = new CR2WFile(((IByteSource)node.Variable).Bytes);
                    var lc = new LoggerCR2W(embedcr2w, writer, options);
                    lc.processCR2W(level);
                }
            }
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
