using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_AxisRange : gameEffectObjectSingleFilter
	{
		[Ordinal(0)] [RED("axis")] public CEnum<gameEffectObjectFilter_AxisRangeAxis> Axis { get; set; }
		[Ordinal(1)] [RED("position")] public gameEffectInputParameter_Vector Position { get; set; }
		[Ordinal(2)] [RED("constraints")] public gameEffectInputParameter_Vector Constraints { get; set; }

		public gameEffectObjectFilter_AxisRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
