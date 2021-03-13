using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ValueBySpeed : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("defaultValue")] public CFloat DefaultValue { get; set; }
		[Ordinal(12)] [RED("clampType")] public CEnum<animClampType> ClampType { get; set; }
		[Ordinal(13)] [RED("rangeMin")] public CFloat RangeMin { get; set; }
		[Ordinal(14)] [RED("rangeMax")] public CFloat RangeMax { get; set; }
		[Ordinal(15)] [RED("resetOnActivation")] public CBool ResetOnActivation { get; set; }
		[Ordinal(16)] [RED("speed")] public animFloatLink Speed { get; set; }

		public animAnimNode_ValueBySpeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
