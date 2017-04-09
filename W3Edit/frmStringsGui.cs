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
    public partial class frmStringsGui : Form
    {
        int counter = 0;
        int modID = 0;

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
            if (textBoxModID.Text != "")
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
            if(textBoxModID.Text != "")
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
            string path = GetXMLPath();

            if (path != "")
            {
                //Fix encoding
                File.WriteAllLines(path, new string[] { "<?xml version=\"1.0\" encoding=\"utf-8\"?>" }.ToList().Concat(File.ReadAllLines(path).Skip(1).ToArray()));

                XDocument doc = XDocument.Load(path);
                foreach (var vars in doc.Descendants("UserConfig").Descendants("Group").Descendants("VisibleVars"))
                {
                    foreach (var var in vars.Descendants("Var"))
                    {
                        String name = var.Attribute("displayName").Value;
                        dataGridViewStrings.Rows.Add(counter + 2110000000 + modID, DisplayNameToKey(name), name);
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

        private string DisplayNameToKey(string name)
        {
            char[] nameConverted = name.ToCharArray(0, name.Length);
            string stringKey = "";
            for (int i = 0; i < nameConverted.Length; ++i)
                if (nameConverted[i] == ' ')
                {
                    nameConverted[i] = '_';
                    stringKey += nameConverted[i];
                }
                else
                    stringKey += nameConverted[i];

            return stringKey;
        }

        private void textBoxModID_Leave(object sender, EventArgs e)
        {
            if (!IsIDValid(textBoxModID.Text))
            {
                MessageBox.Show("Invalid Mod ID.", "Wolven Kit",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxModID.Text = "";
            }
            else
                modID = Convert.ToInt32(textBoxModID.Text);
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
    }
}
