using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DampFloat : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("defaultIncreaseSpeed")] public CFloat DefaultIncreaseSpeed { get; set; }
		[Ordinal(12)] [RED("defaultDecreaseSpeed")] public CFloat DefaultDecreaseSpeed { get; set; }
		[Ordinal(13)] [RED("startFromDefaultValue")] public CBool StartFromDefaultValue { get; set; }
		[Ordinal(14)] [RED("defaultInitialValue")] public CFloat DefaultInitialValue { get; set; }
		[Ordinal(15)] [RED("wrapAroundRange")] public CBool WrapAroundRange { get; set; }
		[Ordinal(16)] [RED("rangeMin")] public CFloat RangeMin { get; set; }
		[Ordinal(17)] [RED("rangeMax")] public CFloat RangeMax { get; set; }
		[Ordinal(18)] [RED("inputNode")] public animFloatLink InputNode { get; set; }
		[Ordinal(19)] [RED("increaseSpeedNode")] public animFloatLink IncreaseSpeedNode { get; set; }
		[Ordinal(20)] [RED("decreaseSpeedNode")] public animFloatLink DecreaseSpeedNode { get; set; }

		public animAnimNode_DampFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
