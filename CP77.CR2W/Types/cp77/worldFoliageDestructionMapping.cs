using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldFoliageDestructionMapping : ISerializable
	{
		[Ordinal(0)]  [RED("baseMesh")] public raRef<CMesh> BaseMesh { get; set; }
		[Ordinal(1)]  [RED("destructibleMesh")] public raRef<CMesh> DestructibleMesh { get; set; }
		[Ordinal(2)]  [RED("meshAppearance")] public CName MeshAppearance { get; set; }

		public worldFoliageDestructionMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
