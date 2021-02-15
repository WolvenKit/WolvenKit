using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entDebug_ShapeComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("shape")] public CEnum<entDebug_ShapeType> Shape { get; set; }
		[Ordinal(9)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(10)] [RED("halfHeight")] public CFloat HalfHeight { get; set; }
		[Ordinal(11)] [RED("color")] public CColor Color { get; set; }
		[Ordinal(12)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public entDebug_ShapeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
