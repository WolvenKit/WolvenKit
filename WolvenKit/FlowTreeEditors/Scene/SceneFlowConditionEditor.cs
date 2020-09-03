using System;
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

            CStorySceneFlowCondition resource = (CStorySceneFlowCondition)Chunk.data;

            CPtr<IQuestCondition> questCondition = resource.QuestCondition;
            if (questCondition != null)
            {
                if (questCondition.Reference != null)
                {
                    lblCondition.Click += delegate { FireSelectEvent(questCondition.Reference); };

                    // put something in the tex field:
                    dynamic IQuestCondition = questCondition.Reference.data; //FIXME dynamic 
                    try
                    {
                        var factIdObj = IQuestCondition.FactId;
                        if (factIdObj != null && factIdObj is CString)
                        {
                            lblCondition.Text = ((CString)factIdObj).val;
                        }
                    }
                    catch (Exception)
                    {
                        lblCondition.Text = questCondition.Reference.REDName;
                    }
                }
            }

            var commentObj = resource.Comment;
            if (commentObj != null && commentObj is CString)
            {
                lblCondition.Text = ((CString)commentObj).val;
            }
        }

        public override List<IPtrAccessor> GetConnections()
        {
            var list = new List<IPtrAccessor>();
            CStorySceneFlowCondition resource = (CStorySceneFlowCondition)Chunk.data;

            if (Chunk != null)
            {
                CPtr<CStorySceneLinkElement> trueLink = resource.TrueLink;
                if (trueLink != null)
                {
                    if (trueLink.Reference != null)
                    {
                        list.Add(trueLink);
                    }
                }

                CPtr<CStorySceneLinkElement> falseLink = resource.FalseLink;
                if (falseLink != null)
                {
                    if (falseLink.Reference != null)
                    {
                        list.Add(falseLink);
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