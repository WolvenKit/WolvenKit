using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;
using System.IO;
using System.Diagnostics;

namespace WolvenKit
{
    enum EDisplayNameType
    {
        VAR,
        GROUP
    }
    public partial class frmStringsGui : Form
    {
        int counter = 0;
        List<int> modIDs = new List<int> { 0 };

        bool noPrefix = false;
        bool fileOpened = false;
        bool multipleIDs = false;
        bool addMods = false;

        int idsLimit = 1000;

        string[] languages = new string[16] {"ar", "br", "cz", "de", "en", "es", "esMX", "fr", "hu", "it", "jp", "kr", "pl", "ru", "tr", "zh"};

        public frmStringsGui()
        {
            InitializeComponent();

            comboBoxLanguagesMode.SelectedIndex = 0;
        }

        private void comboBoxLanguagesMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
            Events
        */

        /*
            toolStrip Buttons
        */

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewStrings.Rows.Count != 1)
                SaveCSV();
            else
                MessageBox.Show("Current file is empty.", "Wolven Kit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenCSV();
        }

        private void toolStripButtonGenerateXML_Click(object sender, EventArgs e)
        {
            GenerateFromXML();
        }

        private void toolStripButtonGenerateScripts_Click(object sender, EventArgs e)
        {

        }

        /*
            toolStrip Menus
        */

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateFromXML();
        }

        private void fromScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /*
            Other 
        */
        private void textBoxModID_Leave(object sender, EventArgs e)
        {
            FillModIDIfValid();
        }
        private void textBoxModID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dataGridViewStrings.Focus();
            }
        }

        /*
            End of events
        */

        private void GenerateFromXML()
        {
            DialogResult result;
            if (textBoxModID.Text != "" && FillModIDIfValid() && dataGridViewStrings.Rows.Count != 1)
                ReadXML();
            else if (textBoxModID.Text == "" || !FillModIDIfValid() && dataGridViewStrings.Rows.Count != 1)
            {
                MessageBox.Show("Enter mod ID.", "Wolven Kit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxModID.Text = "";
            }
            else if (textBoxModID.Text != "" && FillModIDIfValid() && dataGridViewStrings.Rows.Count == 1)
            {
                result = MessageBox.Show("Add 'panel_Mods'?.", "Wolven Kit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    addMods = true;
                ReadXML();
            }
        }

        private void ReadXML()
        {
            // to do: check tags for custom display names, add prefixes to keys
            string path = GetXMLPath();

            // to prevent ID being 0 when Leave event for text box wasn't triggered
            FillModIDIfValid();

            if (path != "")
            {
                //Fix encoding
                File.WriteAllLines(path, new string[] { "<?xml version=\"1.0\" encoding=\"utf-8\"?>" }.ToList().Concat(File.ReadAllLines(path).Skip(1).ToArray()));

                XDocument doc = XDocument.Load(path);

                if (addMods)
                {
                    dataGridViewStrings.Rows.Add(counter + 2110000000 + modIDs[0] * 1000, "panel_Mods", "Mods");
                    ++counter;
                }
                

                // vars displayNames
                foreach (var vars in doc.Descendants("UserConfig").Descendants("Group").Descendants("VisibleVars"))
                {
                    foreach (var var in vars.Descendants("Var"))
                    {
                        String name = var.Attribute("displayName").Value;
                        if (!multipleIDs)
                            dataGridViewStrings.Rows.Add(counter + 2110000000 + modIDs[0] * 1000, DisplayNameToKey(name, EDisplayNameType.VAR), name);
                        else if (counter > idsLimit)
                            dataGridViewStrings.Rows.Add(counter + 2110000000 + modIDs[1] * 1000, DisplayNameToKey(name, EDisplayNameType.VAR), name);
                        else
                            dataGridViewStrings.Rows.Add(counter + 2110000000 + modIDs[0] * 1000, DisplayNameToKey(name, EDisplayNameType.VAR), name);

                        ++counter;
                    }
                }
                // optionsArray vars displayNames
                foreach (var vars in doc.Descendants("UserConfig").Descendants("Group").Descendants("VisibleVars").Descendants("OptionsArray"))
                {
                    foreach (var var in vars.Descendants("Option"))
                    {
                        String name = var.Attribute("displayName").Value;
                        if (!multipleIDs)
                            dataGridViewStrings.Rows.Add(counter + 2110000000 + modIDs[0] * 1000, DisplayNameToKey(name, EDisplayNameType.VAR), name);
                        else if (counter > idsLimit)
                            dataGridViewStrings.Rows.Add(counter + 2110000000 + modIDs[1] * 1000, DisplayNameToKey(name, EDisplayNameType.VAR), name);
                        else
                            dataGridViewStrings.Rows.Add(counter + 2110000000 + modIDs[0] * 1000, DisplayNameToKey(name, EDisplayNameType.VAR), name);

                        ++counter;
                    }
                }

                // groups displayNames
                foreach (var vars in doc.Descendants("UserConfig"))
                {
                    foreach (var var in vars.Descendants("Group"))
                    {
                        String name = var.Attribute("displayName").Value;
                        if (!multipleIDs)
                            dataGridViewStrings.Rows.Add(counter + 2110000000 + modIDs[0] * 1000, DisplayNameToKey(name, EDisplayNameType.GROUP), name);
                        else if (counter > idsLimit)
                            dataGridViewStrings.Rows.Add(counter + 2110000000 + modIDs[1] * 1000, DisplayNameToKey(name, EDisplayNameType.GROUP), name);
                        else
                            dataGridViewStrings.Rows.Add(counter + 2110000000 + modIDs[0] * 1000, DisplayNameToKey(name, EDisplayNameType.GROUP), name);

                        ++counter;
                    }
                }
            }

        }

        private string GetXMLPath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML | *.xml;";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return ofd.FileName;
            }
            else
                return "";
        }

        private string DisplayNameToKey(string name, EDisplayNameType nameType)
        {
            char[] nameConverted = name.ToCharArray(0, name.Length);
            string stringKey = "";

            if (nameType == EDisplayNameType.VAR && !noPrefix)
                stringKey += "option_";

            for (int i = 0; i < nameConverted.Length; ++i)
                if (nameConverted[i] == ' ')
                {
                    nameConverted[i] = '_';
                    stringKey += nameConverted[i];
                }
                else
                    stringKey += nameConverted[i];

            if (nameType == EDisplayNameType.GROUP && !noPrefix)
            {
                string[] stringKeySplitted = stringKey.Split('.');
                stringKey = "panel_" + stringKeySplitted[stringKeySplitted.Length - 1];
            }

            return stringKey;
        }


        private bool IsIDValid(string id)
        {
            char[] digits = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };
            char[] convertedId = id.ToCharArray();
            int validCharCount = 0;
            int idLength = id.Length;
            for (int i = 0; i < idLength; ++i)
            {
                for (int j = 0; j < 10; ++j)
                    if (convertedId[i] == digits[j])
                    {
                        ++validCharCount;
                        break;
                    }
                    else if (convertedId[i] == ';')
                    {
                        multipleIDs = true;
                        ++validCharCount;
                        break;
                    }
            }
            if (validCharCount == idLength && validCharCount != 0)
                return true;

            return false;
        }
        private bool FillModIDIfValid()
        {
            modIDs.Clear();
            string[] splittedIDs;
            if (!IsIDValid(textBoxModID.Text))
            {
                MessageBox.Show("Invalid Mod ID.", "Wolven Kit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxModID.Text = "";
                return false;
            }
            else
            {
                if (!multipleIDs)
                    modIDs.Add(Convert.ToInt32(textBoxModID.Text));
                else
                {
                    splittedIDs = textBoxModID.Text.Split(';');
                    foreach (var id in splittedIDs)
                        modIDs.Add(Convert.ToInt32(id));
                }
                    
            }
                
            return true;
        }

        // save without .csv extension to create proper w3string name
        private void SaveCSVForEncoding(string outputPath)
        {
            var sb = new StringBuilder();

            foreach (DataGridViewRow row in dataGridViewStrings.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join("|", cells.Select(cell => cell.Value).ToArray()));
            }
                      
            int languagesCount = languages.Count();

            for (int i = 0; i < languagesCount; ++i)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputPath + "\\" + languages[i]))
                {
                    file.WriteLine(";meta[language=" + languages[i] + "]");
                    file.WriteLine("; id | key(hex) | key(str) | text");

                    string csv = sb.ToString();

                    // leaving space for the hex key empty
                    if (!fileOpened)
                    {
                        List<string> splittedCsv = csv.Split('\n').ToList();
                        int splittedCsvLength = splittedCsv.Count();
                        for (int j = 0; j < splittedCsvLength; ++j)
                            if (splittedCsv[j].Length >= 10)
                                splittedCsv[j] = splittedCsv[j].Insert(10, "|");
                            else if (splittedCsv[j] == "\r" || splittedCsv[j] == "")
                            //else if (splittedCsv[j] == "")
                            { 
                                // remove empty rows
                                splittedCsv.RemoveAt(j);
                                --splittedCsvLength;
                                --j;
                            }

                        csv = String.Join("\n", splittedCsv);
                    }

                    file.WriteLine(csv);
                }
                
            }
        }

        private void SaveCSV()
        {
            var sb = new StringBuilder();

            foreach (DataGridViewRow row in dataGridViewStrings.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join("|", cells.Select(cell => cell.Value).ToArray()));
            }

            int languagesCount = languages.Count();
            string outputPath = GetCSVOutputPath();

            if (outputPath != "")
            {
                for (int i = 0; i < languagesCount; ++i)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputPath + languages[i] + ".csv"))
                    {
                        file.WriteLine(";meta[language=" + languages[i] + "]");
                        file.WriteLine("; id | key(hex) | key(str) | text");

                        string csv = sb.ToString();

                        // leaving space for the hex key empty
                        if (!fileOpened)
                        {
                            List<string> splittedCsv = csv.Split('\n').ToList();
                            int splittedCsvLength = splittedCsv.Count();
                            for (int j = 0; j < splittedCsvLength; ++j)
                                if (splittedCsv[j].Length >= 10)
                                    splittedCsv[j] = splittedCsv[j].Insert(10, "|");
                                else if (splittedCsv[j] == "\r" || splittedCsv[j] == "")
                                //else if (splittedCsv[j] == "")
                                {
                                    // remove empty rows
                                    splittedCsv.RemoveAt(j);
                                    --splittedCsvLength;
                                    --j;
                                }

                            csv = String.Join("\n", splittedCsv);
                        }

                        file.WriteLine(csv);
                    }
                }
                MessageBox.Show("Files saved.", "Wolven Kit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private string GetCSVOutputPath()
        {
            FolderBrowserDialog fbw = new FolderBrowserDialog();
            if (fbw.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return fbw.SelectedPath + "//";
            }
            else
                return "";
        }

        private void OpenCSV()
        {
            string filePath;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV | *.csv;";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = ofd.FileName;
                List<string[]> rows = File.ReadAllLines(filePath).Select(x => x.Split('|')).ToList();
                DataTable dt = new DataTable();

                dataGridViewStrings.Columns.Clear();

                dt.Columns.Add("ID");
                dt.Columns.Add("Hex key placeholder");
                dt.Columns.Add("String Key");
                dt.Columns.Add("Localisation");

                for (int i = 0; i < rows.Count(); ++i)
                    if (rows[i].Length == 1)
                    {
                        rows.RemoveAt(i);
                        --i;
                    }
                    else if (rows[i][0][0] == ';') // need to be separated in two statements so this won't compare an empty row
                    {
                        rows.RemoveAt(i);
                        --i;
                    }

                modIDs.Clear();
                modIDs.Add((Convert.ToInt32(rows[0][0]) - 2110000000) / 1000);

                // get multiple ids
                foreach (var row in rows)
                {
                    int currentRowID = Convert.ToInt32((Convert.ToInt32(row[0]) - 2110000000) / 1000);
                    foreach (var addedID in modIDs.ToList()) // to prevent modified collection exception
                        if (currentRowID != addedID)
                            if (!multipleIDs)
                            {
                                multipleIDs = true;
                                modIDs.Add(currentRowID);
                            }

                }

                textBoxModID.Text = "";
                if (multipleIDs)
                {
                    foreach (var id in modIDs)
                        textBoxModID.Text += Convert.ToString(id) + ";";
                    // delete last ;
                    textBoxModID.Text = textBoxModID.Text.Remove(textBoxModID.Text.Length - 1);
                }
                    
                else
                    textBoxModID.Text = Convert.ToString(modIDs[0]);

                rows.ForEach(x => {
                    dt.Rows.Add(x);
                });
                
                dataGridViewStrings.DataSource = dt;
                dataGridViewStrings.Columns["Hex key placeholder"].Visible = false;
                fileOpened = true;
            }
            
        }

        private void toolStripButtonEncode_Click(object sender, EventArgs e)
        {
            if (dataGridViewStrings.Rows.Count != 1)
                EncodeCSV();
            else
                MessageBox.Show("Current file is empty.", "Wolven Kit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);         
        }

        private void EncodeCSV()
        {
            string outputPath = GetEncodedOutputPath();

            List<string> csvFiles = new List<string>();

            for (int i = 0; i < languages.Count(); ++i)
                csvFiles.Add(outputPath + "\\" + languages[i]);

            if (outputPath != "")
            {
                SaveCSVForEncoding(outputPath);
                foreach (var file in csvFiles)
                {
                    Process encoderProc = new Process();

                    encoderProc.StartInfo.Arguments = "--encode " + "\"" + file + "\"" + " --id-space " + Convert.ToString(modIDs[0]);
                    encoderProc.StartInfo.FileName = Environment.CurrentDirectory + "\\w3strings.exe";
                    encoderProc.EnableRaisingEvents = true;
                    encoderProc.StartInfo.RedirectStandardOutput = true;
                    encoderProc.StartInfo.UseShellExecute = false;
                    encoderProc.StartInfo.CreateNoWindow = true;
                    encoderProc.Start();
                    string test = encoderProc.StandardOutput.ReadToEnd();
                    encoderProc.WaitForExit();
                }
                MessageBox.Show("Files encoded.", "Wolven Kit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
                
        }

        private string GetEncodedOutputPath()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            return "";
        }
    }
}
