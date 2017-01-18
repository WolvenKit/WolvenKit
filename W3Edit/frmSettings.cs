using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.W3Strings;

namespace W3Edit
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {

            InitializeComponent();

            var config = MainController.Get().Configuration;
            txExecutablePath.Text = config.ExecutablePath;
            txTextLanguage.Text = config.TextLanguage;
            txVoiceLanguage.Text = config.VoiceLanguage;
            txWCC_Lite.Text = config.WCC_Lite;
            cbFlowDiagram.Checked = config.EnableFlowTreeEditor;
        }

        private void btnBrowseExe_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Select Witcher 3 Executable.";
            dlg.FileName = txExecutablePath.Text;
            dlg.Filter = "witcher3.exe|witcher3.exe";
            if(dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                txExecutablePath.Text = dlg.FileName;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txExecutablePath.Text))
            {
                DialogResult = System.Windows.Forms.DialogResult.None;
                txExecutablePath.Focus();
                MessageBox.Show("Invalid witcher3.exe path", "failed to save.");
                return;
            }

            if (!File.Exists(txWCC_Lite.Text))
            {
                DialogResult = System.Windows.Forms.DialogResult.None;
                txWCC_Lite.Focus();
                MessageBox.Show("Invalid wcc_lite.exe path", "failed to save.");
                return;
            }
            var config = MainController.Get().Configuration;
            config.ExecutablePath = txExecutablePath.Text;
            config.WCC_Lite = txWCC_Lite.Text;
            config.TextLanguage = txTextLanguage.Text;
            config.VoiceLanguage = txVoiceLanguage.Text;
            config.EnableFlowTreeEditor = cbFlowDiagram.Checked;

            MainController.Get().ReloadStringManager();

            config.Save();
        }

        private void btBrowseWCC_Lite_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Select wcc_lite.exe.";
            dlg.FileName = txExecutablePath.Text;
            dlg.Filter = "wcc_lite.exe|wcc_lite.exe";
            if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                txWCC_Lite.Text = dlg.FileName;
            }
        }

        private void cbFlowDiagram_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
