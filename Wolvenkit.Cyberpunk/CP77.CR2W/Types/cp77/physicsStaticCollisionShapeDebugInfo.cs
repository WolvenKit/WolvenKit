using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsStaticCollisionShapeDebugInfo : CVariable
	{
		[Ordinal(0)]  [RED("nodeNameHash")] public CUInt64 NodeNameHash { get; set; }
		[Ordinal(1)]  [RED("prefabPathHash")] public CUInt64 PrefabPathHash { get; set; }
		[Ordinal(2)]  [RED("sourceMeshPathHash")] public CUInt64 SourceMeshPathHash { get; set; }

		public physicsStaticCollisionShapeDebugInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
