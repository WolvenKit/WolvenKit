using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3Edit
{
    public partial class frmWCCPatch : Form
    {
        public frmWCCPatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var of = new OpenFileDialog())
            {
                of.Title = @"Select wcc_lite.exe";
                of.Filter = @"wcc_lite.exe | wcc_lite.exe";
                if (of.ShowDialog() == DialogResult.OK)
                    textBox1.Text = of.FileName;
            }
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox1.Text) || Path.GetExtension(textBox1.Text) != ".exe")
            {
                MessageBox.Show("Please select wcc_lite.exe before attempting to patch it!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var filepath = '"' + textBox1.Text + '"';
            try
            {
                using (var wc = new WebClient())
                {
                    wc.DownloadFile("http://skacik.pl/downloads/tw3/rdkt2/patch", "wccpatch");
                    wc.DownloadFile("http://skacik.pl/downloads/tw3/rdkt2/xdelta3.exe", "patcher.exe");
                    var proc = new ProcessStartInfo
                    {
                        FileName = "patcher.exe",
                        Arguments = $" -s {filepath} wccpatch wcc_patched.exe",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true
                    };
                    var pc = new Process {StartInfo = proc};
                    pc.Start();
                    pc.WaitForExit(100000);
                    File.Delete("wccpatch");
                    File.Delete("patcher.exe");
                    File.Delete(textBox1.Text);
                    if (File.Exists("wcc_patched.exe"))
                    {
                        File.Move("wcc_patched.exe", textBox1.Text);
                        MessageBox.Show("Patched!\n" + textBox1.Text, @"Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to patch!Please try reinstalling wcc_lite!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
               
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to patch! Please try reinstalling wcc_lite!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://forums.cdprojektred.com/forum/en/the-witcher-series/the-witcher-3-wild-hunt/mod-discussions/6883680-patched-wcc_lite-for-faster-startup");
        }
    }
}
