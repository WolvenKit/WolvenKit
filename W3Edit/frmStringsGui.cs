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

namespace WolvenKit
{
	public partial class frmStringsGui : Form
	{
		int counter = 0;
		int modID = 666;

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
			ReadXML();
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
			ReadXML();
		}

		private void fromScriptsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		/*
			End of events
		*/

		private void ReadXML()
		{
			XDocument doc = XDocument.Load(GetXMLPath());
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
	}
}
