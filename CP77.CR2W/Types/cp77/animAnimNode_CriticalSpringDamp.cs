using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CriticalSpringDamp : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("inputNode")] public animFloatLink InputNode { get; set; }
		[Ordinal(1)]  [RED("rangeMax")] public CFloat RangeMax { get; set; }
		[Ordinal(2)]  [RED("rangeMin")] public CFloat RangeMin { get; set; }
		[Ordinal(3)]  [RED("smoothTime")] public CFloat SmoothTime { get; set; }
		[Ordinal(4)]  [RED("useRange")] public CBool UseRange { get; set; }

		public animAnimNode_CriticalSpringDamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
