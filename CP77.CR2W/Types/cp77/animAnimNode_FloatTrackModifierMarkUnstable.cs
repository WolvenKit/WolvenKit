using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTrackModifierMarkUnstable : animAnimNode_FloatTrackModifier
	{
		[Ordinal(0)]  [RED("requiredQualityDistanceCategory")] public CUInt32 RequiredQualityDistanceCategory { get; set; }

		public animAnimNode_FloatTrackModifierMarkUnstable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
