using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Forms.Editors
{
    public partial class IdTagEditor : UserControl
    {
        public TextBox IdType;
        public TextBox IdGuid;

        public IdTagEditor()
        {
            InitializeComponent();
        }
    }
}
