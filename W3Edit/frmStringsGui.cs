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
        int modID = 0;

        bool noPrefix = false;

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

        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonGenerateXML_Click(object sender, EventArgs e)
        {
            if (textBoxModID.Text != "" && FillModIDIfValid())
                ReadXML();
            else
            {
                MessageBox.Show("Enter mod ID.", "Wolven Kit",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxModID.Text = "";
            }
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
            if (textBoxModID.Text != "" && FillModIDIfValid())
                ReadXML();
            else
            {
                MessageBox.Show("Enter mod ID.", "Wolven Kit",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxModID.Text = "";
            }
        }

        private void fromScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*
            End of events
        */

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

                // vars displayNames
                foreach (var vars in doc.Descendants("UserConfig").Descendants("Group").Descendants("VisibleVars"))
                {
                    foreach (var var in vars.Descendants("Var"))
                    {
                        String name = var.Attribute("displayName").Value;
                        dataGridViewStrings.Rows.Add(counter + 2110000000 + modID * 1000, DisplayNameToKey(name, EDisplayNameType.VAR), name);
                        ++counter;
                    }
                }
                // optionsArray vars displayNames
                foreach (var vars in doc.Descendants("UserConfig").Descendants("Group").Descendants("VisibleVars").Descendants("OptionsArray"))
                {
                    foreach (var var in vars.Descendants("Option"))
                    {
                        String name = var.Attribute("displayName").Value;
                        dataGridViewStrings.Rows.Add(counter + 2110000000 + modID * 1000, DisplayNameToKey(name, EDisplayNameType.VAR), name);
                        ++counter;
                    }
                }

                // groups displayNames
                foreach (var vars in doc.Descendants("UserConfig"))
                {
                    foreach (var var in vars.Descendants("Group"))
                    {
                        String name = var.Attribute("displayName").Value;
                        dataGridViewStrings.Rows.Add(counter + 2110000000 + modID * 1000, DisplayNameToKey(name, EDisplayNameType.GROUP), name);
                        ++counter;
                    }
                }
            }

        }

        private string GetXMLPath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return openFileDialog.FileName;
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
            }
            if (validCharCount == idLength)
                return true;

            return false;
        }
        private bool FillModIDIfValid()
        {
            if (!IsIDValid(textBoxModID.Text))
            {
                MessageBox.Show("Invalid Mod ID.", "Wolven Kit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxModID.Text = "";
                return false;
            }
            else
                modID = Convert.ToInt32(textBoxModID.Text);
            return true;
        }
    }
}
