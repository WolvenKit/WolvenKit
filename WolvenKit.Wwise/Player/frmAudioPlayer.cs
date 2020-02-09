using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Wwise.Player
{
    public partial class frmAudioPlayer : Form
    {
        public frmAudioPlayer(string file)
        {
            InitializeComponent();
            this.audioPlaybackPanel1.fileName = file;
        }
    }
}
