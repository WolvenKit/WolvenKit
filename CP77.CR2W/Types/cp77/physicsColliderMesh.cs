using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsColliderMesh : physicsICollider
	{
		[Ordinal(0)]  [RED("faceMaterials")] public CArray<CName> FaceMaterials { get; set; }
		[Ordinal(1)]  [RED("compiledGeometryBuffer")] public DataBuffer CompiledGeometryBuffer { get; set; }

		public physicsColliderMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
