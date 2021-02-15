using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkShapePresetWraper : ISerializable
	{
		[Ordinal(0)] [RED("shapePreset")] public inkShapePreset ShapePreset { get; set; }

		public inkShapePresetWraper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
