using System.Collections.Generic;
using System.Linq;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit {
    public class QuestPhaseEditor: QuestLinkEditor {
        public override List<IPtrAccessor> GetConnections()
        {
            var connections = new List<IPtrAccessor>();

            CQuestPhaseBlock phaseBlock = (CQuestPhaseBlock)Chunk.data;

            CPtr<CQuestGraph> graphObj = phaseBlock.EmbeddedGraph;
            if (graphObj != null && graphObj.Reference != null)
            {
                CArray<CPtr<CGraphBlock>> graphBlocks = (graphObj.Reference.data as CQuestGraph).GraphBlocks;
                if (graphBlocks != null)
                {
                    connections.AddRange(graphBlocks.Elements.Where(_ => _.GetPtrTargetType() == "CQuestPhaseInputBlock"));
                }
            }

            return connections;
        }
    }
}