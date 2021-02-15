using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ValueBySpeed : animAnimNode_FloatValue
	{
		[Ordinal(1)] [RED("defaultValue")] public CFloat DefaultValue { get; set; }
		[Ordinal(2)] [RED("clampType")] public CEnum<animClampType> ClampType { get; set; }
		[Ordinal(3)] [RED("rangeMin")] public CFloat RangeMin { get; set; }
		[Ordinal(4)] [RED("rangeMax")] public CFloat RangeMax { get; set; }
		[Ordinal(5)] [RED("resetOnActivation")] public CBool ResetOnActivation { get; set; }
		[Ordinal(6)] [RED("speed")] public animFloatLink Speed { get; set; }

		public animAnimNode_ValueBySpeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
