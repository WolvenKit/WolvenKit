using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTerrainMeshNode : worldNode
	{
		[Ordinal(0)]  [RED("mesh")] public CHandle<CMesh> Mesh { get; set; }
		[Ordinal(1)]  [RED("meshRef")] public raRef<CMesh> MeshRef { get; set; }

		public worldTerrainMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
