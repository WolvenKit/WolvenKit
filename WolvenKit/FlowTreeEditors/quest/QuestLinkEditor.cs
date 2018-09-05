using System.Collections.Generic;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.FlowTreeEditors;

namespace WolvenKit {
    public class QuestLinkEditor : ChunkEditor {
        public override void UpdateView() {
            base.UpdateView();

            lblTitle.Text = Chunk.Name + " : " + Chunk.Preview;
        }        

        public override List<CPtr> GetConnections() {
            var list = new List<CPtr>();

              if (Chunk != null) {
                var cachedConnections = Chunk.GetVariableByName("cachedConnections");
                if (cachedConnections != null && cachedConnections is CArray) {
                    var cachedConnectionsArray = ((CArray) cachedConnections);
                    foreach (CVariable conn in cachedConnectionsArray) {
                         if (conn is CVector) {
                            CVector connection = (CVector) conn;
                            CName socketId = (CName) connection.GetVariableByName("socketId");
                            CArray blocks = (CArray) connection.GetVariableByName("blocks");
                             
                            if (blocks != null && blocks is CArray) {
                                foreach (CVariable block in blocks) {
                                    if (block is CVector) {
                                     
                                         foreach (CVariable blockVectorVariable in ((CVector)block).variables) {
                                             if (blockVectorVariable is CPtr) {
                                                 var nextLinkElementPtr = ((CPtr) blockVectorVariable);
                                                 if (nextLinkElementPtr.PtrTarget != null) {
                                                     list.Add(nextLinkElementPtr);
                                                 }
                                             }
                                         }
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return list;
        }
    }
}