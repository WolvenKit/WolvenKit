using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CriticalSpringDamp : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("smoothTime")] public CFloat SmoothTime { get; set; }
		[Ordinal(12)] [RED("useRange")] public CBool UseRange { get; set; }
		[Ordinal(13)] [RED("rangeMin")] public CFloat RangeMin { get; set; }
		[Ordinal(14)] [RED("rangeMax")] public CFloat RangeMax { get; set; }
		[Ordinal(15)] [RED("inputNode")] public animFloatLink InputNode { get; set; }

		public animAnimNode_CriticalSpringDamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
