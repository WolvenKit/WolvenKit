using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Forms
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
        }

        public bool Cancel { get; set; } = false;

        public void SetTitle(string title) => this.Text = title;

        public void SetProgressBarValue(int percentValue, object userState)
        {
            progressBar1.Value = percentValue;
            if (userState is string)
                labelDescription.Text = userState as string;
        }
    }
}
