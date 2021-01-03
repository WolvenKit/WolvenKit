using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entDebug_ShapeComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(1)]  [RED("halfHeight")] public CFloat HalfHeight { get; set; }
		[Ordinal(2)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(4)]  [RED("shape")] public CEnum<entDebug_ShapeType> Shape { get; set; }

		public entDebug_ShapeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
