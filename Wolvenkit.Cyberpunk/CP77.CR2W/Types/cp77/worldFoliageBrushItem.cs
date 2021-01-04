using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldFoliageBrushItem : ISerializable
	{
		[Ordinal(0)]  [RED("Mesh")] public rRef<CMesh> Mesh { get; set; }
		[Ordinal(1)]  [RED("MeshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(2)]  [RED("Params")] public worldFoliageBrushParams Params { get; set; }
		[Ordinal(3)]  [RED("Selected")] public CBool Selected { get; set; }

		public worldFoliageBrushItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
