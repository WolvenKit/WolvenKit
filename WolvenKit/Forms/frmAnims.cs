using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParserLTK;
using WolvenKit.CR2W;
using WolvenKit.Render;

namespace WolvenKit
{
    public partial class frmAnims : Form
    {
        private CR2WFile animsFile;
        private ExportAnimation exportAnims { get; set; }

        public frmAnims(string w2animsFilePath = null, string w2rigFilePath = null)
        {
            InitializeComponent();
            //var config = MainController.Get().Configuration;
            txw2rig.Text = w2rigFilePath;//config.ExecutablePath;
            txw2anims.Text = w2animsFilePath;//config.WccLite;
            //comboBoxAnim.Items.AddRange(Enum.GetValues(typeof(EColorThemes)).Cast<object>().ToArray());
            //comboBoxTheme.SelectedItem = config.ColorTheme;
            btSave.Enabled =
                (File.Exists(txw2anims.Text) && Path.GetExtension(txw2anims.Text) == ".w2anims" || Path.GetExtension(txw2anims.Text) == ".w2cutscene") &&
                (File.Exists(txw2rig.Text) && Path.GetExtension(txw2rig.Text) == ".w2rig");
            setupcomboBox();
        }

        /// <summary>
        /// setup visibility of rendere context menu
        /// </summary>
        private void setupcomboBox()
        {
            if (File.Exists(txw2anims.Text))
            {
                {
                    string w2rigFilePath = txw2rig.Text;
                    string w2animsFilePath = txw2anims.Text;

                    exportAnims = new ExportAnimation();
                    byte[] animsData;
                    animsData = File.ReadAllBytes(w2animsFilePath);
                    using (MemoryStream ms = new MemoryStream(animsData))
                    using (BinaryReader br = new BinaryReader(ms))
                    {
                        animsFile = new CR2WFile(br)
                        {
                            FileName = w2animsFilePath
                        };
                        exportAnims.LoadData(animsFile);
                    }
                    comboBoxAnim.Items.Clear();
                    for (int i = 0; i < ExportAnimation.AnimationNames.Count; i++)
                        comboBoxAnim.Items.Add(ExportAnimation.AnimationNames[i].Key);
                    comboBoxAnim.SelectedItem = ExportAnimation.AnimationNames[0].Key;
                }
            }
            else
            {
                //loadAnimToolStripMenuItem.Enabled = true;
            }
        }

        private void btnBrowseRig_Click(object sender, EventArgs e)
        {
            var dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.Title = "Select Witcher 3 Rig File.";
            dlg.FileName = txw2rig.Text;
            dlg.Filter = "Witcher 3 Rig File (*.w2rig)|*.w2rig";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txw2rig.Text = dlg.FileName;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txw2rig.Text))
            {
                DialogResult = DialogResult.None;
                txw2rig.Focus();
                MessageBox.Show("Invalid path", "failed to save.");
                return;
            }

            if (!File.Exists(txw2anims.Text))
            {
                DialogResult = DialogResult.None;
                txw2anims.Focus();
                MessageBox.Show("Invalid path", "failed to save.");
                return;
            }
            using (var sf = new SaveFileDialog())
            {
                sf.Filter = "W3 json | *.json";
                sf.FileName = Path.GetFileName(txw2anims.Text) + ".json";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    CommonData cdata = new CommonData();
                    Rig exportRig = new Rig(cdata);
                    byte[] data;
                    data = File.ReadAllBytes(txw2rig.Text);
                    using (MemoryStream ms = new MemoryStream(data))
                    using (BinaryReader br = new BinaryReader(ms))
                    {
                        CR2WFile rigFile = new CR2WFile(br);
                        exportRig.LoadData(rigFile);
                    }
                    exportAnims.Apply(exportRig);
                    exportAnims.SaveJson(sf.FileName);
                    MessageBox.Show(this, "Sucessfully wrote file!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btBrowseAnims_Click(object sender, EventArgs e)
        {
            var dlg = new System.Windows.Forms.OpenFileDialog
            {
                Title = "Select Witcher 3 Animation File.",
                FileName = txw2rig.Text,
                Filter = "Witcher 3 Animation File (*.w2anims)|*.w2anims|Witcher 3 Cutscene File (*.w2cutscene)|*.w2cutscene"
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txw2anims.Text = dlg.FileName;
            }
        }

        private void txWCC_Lite_TextChanged(object sender, EventArgs e)
        {
            var path = txw2anims.Text;
            if (File.Exists(path) && (Path.GetExtension(path) == ".w2anims" || Path.GetExtension(path) == ".w2cutscene"))
            {
                WCCexeTickLBL.Text = "✓";
                WCCexeTickLBL.ForeColor = Color.Green;
            }
            else
            {
                WCCexeTickLBL.Text = "X";
                WCCexeTickLBL.ForeColor = Color.Red;
            }
            btSave.Enabled =
                (File.Exists(txw2anims.Text) && (Path.GetExtension(txw2anims.Text) == ".w2anims" || Path.GetExtension(txw2anims.Text) == ".w2cutscene")) &&
                (File.Exists(txw2rig.Text) && Path.GetExtension(txw2rig.Text) == ".w2rig");
            setupcomboBox();
        }

        private void txExecutablePath_TextChanged(object sender, EventArgs e)
        {
            var path = txw2rig.Text;
            if (File.Exists(path) && Path.GetExtension(path) == ".w2rig")
            {
                W3exeTickLBL.Text = "✓";
                W3exeTickLBL.ForeColor = Color.Green;
            }
            else
            {
                W3exeTickLBL.Text = "X";
                W3exeTickLBL.ForeColor = Color.Red;
            }
            btSave.Enabled =
                (File.Exists(txw2anims.Text) && (Path.GetExtension(txw2anims.Text) == ".w2anims" || Path.GetExtension(txw2anims.Text) == ".w2cutscene")) &&
                (File.Exists(txw2rig.Text) && Path.GetExtension(txw2rig.Text) == ".w2rig");
        }

        private void comboBoxAnim_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxAnim = (ComboBox)sender;
            int resultIndex = -1;
            string selectedAnim = (string)comboBoxAnim.SelectedItem;
            resultIndex = comboBoxAnim.FindStringExact(selectedAnim);
            exportAnims.SelectAnimation(animsFile, resultIndex);
        }
    }
}