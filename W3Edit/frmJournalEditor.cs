using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W;
using W3Edit.CR2W.Types;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmJournalEditor : DockContent
    {
        private CR2WFile file;

        public frmJournalEditor()
        {
            InitializeComponent();
        }

        public CR2WFile File
        {
            get { return file; }
            set
            {
                file = value;
                ParseJournal();
            }
        }

        public void ParseJournal()
        {
            var basenode = File.chunks[0];

            if (File != null && File.chunks.Count > 0)
            {
                switch (basenode.Type)
                {
                    case "CJournalResource":
                        ParseJournalType((CPtr)File.chunks[0].GetVariableByName("entry"));
                        break;
                    default:
                        break;
                }
            }
        }

        public void ParseJournalType(CPtr pointer)
        {
            var typenode = pointer.PtrTarget;
            switch (pointer.PtrTargetType)
            {
                case "CJournalCreature":
                {
                    ParseUsedAgainst((CArray)typenode.GetVariableByName("itemsUsedAgainstCreature"));
                    break;
                }
            }

        }

        public void ParseUsedAgainst(CArray infos)
        {
            descriptionbox.AppendText("Items used against:\n");
            foreach (var info in infos)
            {
                descriptionbox.AppendText(info.ToString() + "\n");
                var infolabel = new Label {Text = info.ToString()};
                splitContainer2.Panel2.Controls.Add(infolabel);
            }
        }
    }
}
