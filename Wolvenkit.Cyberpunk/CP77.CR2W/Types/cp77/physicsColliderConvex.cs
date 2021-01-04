using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsColliderConvex : physicsICollider
	{
		[Ordinal(0)]  [RED("compiledGeometryBuffer")] public DataBuffer CompiledGeometryBuffer { get; set; }
		[Ordinal(1)]  [RED("indexBuffer")] public CArray<CUInt8> IndexBuffer { get; set; }
		[Ordinal(2)]  [RED("polygonVertices")] public CArray<CUInt16> PolygonVertices { get; set; }
		[Ordinal(3)]  [RED("vertices")] public CArray<Vector3> Vertices { get; set; }

		public physicsColliderConvex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
