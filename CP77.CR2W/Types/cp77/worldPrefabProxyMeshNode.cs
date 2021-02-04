using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPrefabProxyMeshNode : worldMeshNode
	{
		[Ordinal(0)]  [RED("nearAutoHideDistance")] public CFloat NearAutoHideDistance { get; set; }
		[Ordinal(1)]  [RED("ancestorPrefabProxyMeshNodeID")] public worldGlobalNodeID AncestorPrefabProxyMeshNodeID { get; set; }
		[Ordinal(2)]  [RED("ownerPrefabNodeId")] public worldGlobalNodeID OwnerPrefabNodeId { get; set; }
		[Ordinal(3)]  [RED("nbNodesUnderProxy")] public CUInt32 NbNodesUnderProxy { get; set; }

		public worldPrefabProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
