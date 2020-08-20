using System.Collections.Generic;
using System.Linq;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit {
    public class QuestPhaseEditor: QuestLinkEditor {
        public override List<CPtr> GetConnections() {
            List<CPtr> connections = new List<CPtr>();
            var graphObj = Chunk.GetVariableByName("embeddedGraph");
            if (graphObj != null && graphObj is CPtr && ((CPtr) graphObj).Reference != null)
            {
                var graphBlocks = ((CPtr)graphObj).Reference.GetVariableByName("graphBlocks");
                if (graphBlocks != null && graphBlocks is CArray)
                {
                    var controlParts = (CArray) graphBlocks;
                    connections.AddRange(from part in controlParts.OfType<CPtr>() where part != null && part.GetPtrTargetType() == "CQuestPhaseInputBlock" select part);
                }
            }

            return connections;
        }
    }
}