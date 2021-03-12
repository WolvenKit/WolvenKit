using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatComparator : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("firstValue")] public CFloat FirstValue { get; set; }
		[Ordinal(12)] [RED("secondValue")] public CFloat SecondValue { get; set; }
		[Ordinal(13)] [RED("trueValue")] public CFloat TrueValue { get; set; }
		[Ordinal(14)] [RED("falseValue")] public CFloat FalseValue { get; set; }
		[Ordinal(15)] [RED("operation")] public CEnum<animEAnimGraphCompareFunc> Operation { get; set; }
		[Ordinal(16)] [RED("firstInputLink")] public animFloatLink FirstInputLink { get; set; }
		[Ordinal(17)] [RED("secondInputLink")] public animFloatLink SecondInputLink { get; set; }
		[Ordinal(18)] [RED("trueInputLink")] public animFloatLink TrueInputLink { get; set; }
		[Ordinal(19)] [RED("falseInputLink")] public animFloatLink FalseInputLink { get; set; }

		public animAnimNode_FloatComparator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
