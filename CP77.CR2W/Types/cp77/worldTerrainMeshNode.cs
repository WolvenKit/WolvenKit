using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTerrainMeshNode : worldNode
	{
		[Ordinal(2)] [RED("mesh")] public CHandle<CMesh> Mesh { get; set; }
		[Ordinal(3)] [RED("meshRef")] public raRef<CMesh> MeshRef { get; set; }

		public worldTerrainMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
