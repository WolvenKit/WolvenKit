using System.Collections.Generic;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.FlowTreeEditors
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
                    var nextLinkElementPtr = ((CPtr) nextLinkElementObj);
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