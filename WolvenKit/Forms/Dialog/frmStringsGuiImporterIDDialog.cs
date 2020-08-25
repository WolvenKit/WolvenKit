using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit
{
    public partial class frmStringsGuiImporterIDDialog : Form
    {
        Dictionary<int, string> strings;
    
        public frmStringsGuiImporterIDDialog()
        {
            InitializeComponent();
        }

        public void PassStrings(Dictionary<int, string> strings)
        {
            this.strings = strings;
        }

        public void FillDataGridView()
        {
            foreach (var str in strings)
            {
                dataGridView1.Rows.Add(str.Key, str.Value);
            }
        }
    }
}
