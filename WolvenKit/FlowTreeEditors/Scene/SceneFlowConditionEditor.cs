using System.Collections.Generic;
using System.Drawing;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.FlowTreeEditors
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
                var questCondition = (CPtr) questConditionObj;
                if (questCondition.Reference != null)
                {
                    lblCondition.Click += delegate { FireSelectEvent(questCondition.Reference); };

                    var factIdObj = questCondition.Reference.GetVariableByName("factId");
                    if (factIdObj != null && factIdObj is CString)
                    {
                        lblCondition.Text = ((CString) factIdObj).val;
                    }
                    else
                    {
                        lblCondition.Text = questCondition.Reference.Name;
                    }
                }
            }

            var commentObj = Chunk.GetVariableByName("comment");
            if (commentObj != null && commentObj is CString)
            {
                lblCondition.Text = ((CString) commentObj).val;
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
                    var nextLinkElementPtr = ((CPtr) trueLinkObj);
                    if (nextLinkElementPtr.Reference != null)
                    {
                        list.Add(nextLinkElementPtr);
                    }
                }

                var falseLinkObj = Chunk.GetVariableByName("falseLink");
                if (falseLinkObj != null && falseLinkObj is CPtr)
                {
                    var nextLinkElementPtr = ((CPtr) falseLinkObj);
                    if (nextLinkElementPtr.Reference != null)
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
                return new Point(0, lblTrue.Top + lblTrue.Height/2);
            if (i == 1)
                return new Point(0, lblFalse.Top + lblFalse.Height/2);

            return new Point(0, i*20 + 21 + 10);
        }
    }
}