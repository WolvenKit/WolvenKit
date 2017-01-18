using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W;
using W3Edit.CR2W.Types;

namespace W3Edit.FlowTreeEditors
{
    public partial class SceneLinkEditor : ChunkEditor
    {
        public SceneLinkEditor()
        {
            InitializeComponent();
        }

        public override List<CPtr> GetConnections()
        {
            var list = new List<CPtr>();

            if (Chunk != null)
            {
                var nextLinkElementObj = Chunk.GetVariableByName("nextLinkElement");
                if (nextLinkElementObj != null && nextLinkElementObj is CPtr)
                {
                    var nextLinkElementPtr = ((CPtr)nextLinkElementObj);
                    if (nextLinkElementPtr.PtrTarget != null)
                    {
                        list.Add(nextLinkElementPtr);
                    }
                }

                //var trueLinkObj = Chunk.GetVariableByName("trueLink");
                //if (trueLinkObj != null && trueLinkObj is CPtr)
                //{
                //    var nextLinkElementPtr = ((CPtr)trueLinkObj);
                //    if (nextLinkElementPtr.PtrTarget != null)
                //    {
                //        list.Add(nextLinkElementPtr);
                //    }
                //}

                //var falseLinkObj = Chunk.GetVariableByName("falseLink");
                //if (falseLinkObj != null && falseLinkObj is CPtr)
                //{
                //    var nextLinkElementPtr = ((CPtr)falseLinkObj);
                //    if (nextLinkElementPtr.PtrTarget != null)
                //    {
                //        list.Add(nextLinkElementPtr);
                //    }
                //}
            }

            return list;
        }
    }
}
