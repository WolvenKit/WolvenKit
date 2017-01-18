using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3Edit.CR2W.Editors
{
    public partial class PtrEditor : UserControl
    {
        public TextBox Flags { get { return txFlags; }  }
        public TextBox HandlePath { get { return txHandle; } }
        public TextBox FileType { get { return txType; }  }

        public PtrEditor()
        {
            InitializeComponent();
        }
    }
}
