using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTrackModifierMarkUnstable : animAnimNode_FloatTrackModifier
	{
		[Ordinal(6)] [RED("requiredQualityDistanceCategory")] public CUInt32 RequiredQualityDistanceCategory { get; set; }

		public animAnimNode_FloatTrackModifierMarkUnstable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
