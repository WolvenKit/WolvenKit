using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W.Types;
using W3Edit.CR2W;

namespace W3Edit.FlowTreeEditors
{
    public partial class SceneFlowConditionEditor : ChunkEditor
    {
        public SceneFlowConditionEditor()
        {
            InitializeComponent();
        }

        public override void UpdateView()
        {
            var height = Height;
            base.UpdateView();
            Height = height;

            lblCondition.Text = "";

            var questConditionObj = Chunk.GetVariableByName("questCondition");
            if (questConditionObj != null && questConditionObj is CPtr)
            {
                var questCondition = (CPtr)questConditionObj;
                if( questCondition.PtrTarget != null )
                {
                    lblCondition.Click += delegate(object sender, EventArgs e)
                    {
                        FireSelectEvent(questCondition.PtrTarget);
                    };

                    var factIdObj = questCondition.PtrTarget.GetVariableByName("factId");
                    if(factIdObj != null && factIdObj is CString)
                    {
                        lblCondition.Text = ((CString)factIdObj).val;
                    }
                    else
                    {
                        lblCondition.Text = questCondition.PtrTarget.Name;
                    }
                }
            }

            var commentObj = Chunk.GetVariableByName("comment");
            if(commentObj != null && commentObj is CString)
            {
                lblCondition.Text = ((CString)commentObj).val;
            }

            
        }

        public override List<CPtr> GetConnections()
        {
            var list = new List<CPtr>();

            if (Chunk != null)
            {
                var trueLinkObj = Chunk.GetVariableByName("trueLink");
                if (trueLinkObj != null && trueLinkObj is CPtr)
                {
                    var nextLinkElementPtr = ((CPtr)trueLinkObj);
                    if (nextLinkElementPtr.PtrTarget != null)
                    {
                        list.Add(nextLinkElementPtr);
                    }
                }

                var falseLinkObj = Chunk.GetVariableByName("falseLink");
                if (falseLinkObj != null && falseLinkObj is CPtr)
                {
                    var nextLinkElementPtr = ((CPtr)falseLinkObj);
                    if (nextLinkElementPtr.PtrTarget != null)
                    {
                        list.Add(nextLinkElementPtr);
                    }
                }
            }

            return list;
        }

        public override Point GetConnectionLocation(int i)
        {
            if (i == 0)
                return new Point(0, lblTrue.Top + lblTrue.Height / 2);
            if (i == 1)
                return new Point(0, lblFalse.Top + lblFalse.Height / 2);

            return new Point(0, i * 20 + 21 + 10);
        }
    }
}
