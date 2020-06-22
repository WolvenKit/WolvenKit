using System.Collections.Generic;
using System.Windows.Forms;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.FlowTreeEditors;

namespace WolvenKit
{
    public class QuestLinkEditor : ChunkEditor
    {
        public override void UpdateView()
        {
            base.UpdateView();

            lblTitle.Text = Chunk.REDName + " : " + Chunk.Preview;
            Size = TextRenderer.MeasureText(lblTitle.Text, lblTitle.Font) + Margin.Size;
        }

        public override List<IPtrAccessor> GetConnections()
        {
            var list = new List<IPtrAccessor>();

            if (Chunk.data is CQuestGraphBlock graphBlock)
            {
                CArray<SCachedConnections> cachedConnections = graphBlock.CachedConnections;
                if (cachedConnections != null)
                {
                    foreach (SCachedConnections conn in cachedConnections.elements)
                    {
                        CName socketId = conn.SocketId;
                        CArray<SBlockDesc> blocks = conn.Blocks;

                        if (blocks != null)
                        {
                            foreach (SBlockDesc block in blocks.elements)
                            {
                                CPtr<CQuestGraphBlock> graphpointer = block.Ock;
                                if (graphpointer.Reference != null)
                                {
                                    list.Add(graphpointer);
                                }
                            }
                        }
                    }
                }
            }
            else if (Chunk.data is CStorySceneLinkElement linkElement)
            {
                CPtr<CStorySceneLinkElement> nextLinkElementPtr = linkElement.NextLinkElement;
                if (nextLinkElementPtr != null)
                {
                    if (nextLinkElementPtr.Reference != null)
                    {
                        list.Add(nextLinkElementPtr);
                    }
                }
            }
            else
            {

            }
                       

            return list;
        }
    }
}