using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Types;
using static WolvenKit.frmChunkProperties;

namespace WolvenKit.Forms
{

    public partial class frmCR2WtoText : Form
    {
        private IEnumerable<string> files;
        StreamWriter outputFile;

        public frmCR2WtoText()
        {
            InitializeComponent();
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
            var outputText = txtOutputFile.Text;

            btnRun.Enabled = false;
            using (outputFile = new StreamWriter(outputText, true))
            {
                if (files.Count() > 0)
                {
                    txtOutput.Clear();

                    foreach (string fileName in files)
                    {
                        writeText("FILE", fileName);
                        int level = 1;
                        try
                        {
                            var cf = new LoggerCR2W(fileName);
                            string fileBaseName = Path.GetFileName(fileName);
                            processCR2W(cf, fileBaseName, level);
                        }
                        catch (FormatException fe)
                        {
                            writeText(fileName, "Not a valid CR2W file, or file is damaged.");
                        }
                        catch (Exception ex)
                        {
                            writeText(fileName, "Exception: " + ex.ToString());
                        }
                    }
                }
            }
            btnRun.Enabled = true;
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

        private IEnumerable<string> GetFiles(string path, params string[] extExclude)
        {
            return Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                            .Where(file => !extExclude.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase)));
        }

        private bool writeText(string prefix, string text, int level = 0)
        {
            string line;
            string indent = "";
            if (level > 0)
            {
                for (int i = 0; i < level; i++)
                {
                    indent += "    ";
                }
            }
            line = prefix + ":" + indent + text + "\r\n";
            if (txtOutputFile.Text == "")
                txtOutput.AppendText(line);
            else
                outputFile.Write(line);

            return true;
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            var path = txtPath.Text;
            string[] extExclude = new[] { ".txt", ".json", ".csv", ".xml", ".jpg", ".png", ".wem", ".dds", ".bnk", ".xbm" };
            files = GetFiles(path, extExclude);

            labFileCount.Text = files.Count().ToString();
        }

        private void btnPickFile_Click(object sender, EventArgs e)
        {
            var sf = new SaveFileDialog
            {
                Title = "Select a file to output to.",
                Filter = "TXT Files | *.txt"
            };
            if (sf.ShowDialog() == DialogResult.OK)
                txtOutputFile.Text = sf.FileName;
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
                try
                {
                    cr2w = new CR2WFile(reader);
                    chunks = cr2w.chunks;
                }
                catch (FormatException fe)
                {
                    throw;
                    //writeText(filePathAndName, "Not a CR2W file, or damaged file.", 1);
                }
                fs.Close();
            }
        }

        internal LoggerCR2W(CR2WFile cr2wFile)
        {
            cr2w = cr2wFile;
            chunks = cr2w.chunks;
        }

        public VariableListNode getNodes(CR2WExportWrapper chunk)
        {
            return AddListViewItems((IEditableVariable)chunk);
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
