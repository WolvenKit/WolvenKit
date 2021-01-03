using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldFoliageRawItem : ISerializable
	{
		[Ordinal(0)]  [RED("Mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(1)]  [RED("MeshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(2)]  [RED("Position")] public Vector3 Position { get; set; }
		[Ordinal(3)]  [RED("Rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(4)]  [RED("Scale")] public CFloat Scale { get; set; }

		public worldFoliageRawItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
