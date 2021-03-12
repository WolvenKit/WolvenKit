using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldGeometryShapeNode : worldNode
	{
		[Ordinal(4)] [RED("color")] public CColor Color { get; set; }
		[Ordinal(5)] [RED("shape")] public CHandle<GeometryShape> Shape { get; set; }

		public worldGeometryShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
