using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SpringDamp : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("massFactor")] public CFloat MassFactor { get; set; }
		[Ordinal(12)] [RED("springFactor")] public CFloat SpringFactor { get; set; }
		[Ordinal(13)] [RED("dampFactor")] public CFloat DampFactor { get; set; }
		[Ordinal(14)] [RED("startFromDefaultValue")] public CBool StartFromDefaultValue { get; set; }
		[Ordinal(15)] [RED("defaultInitialValue")] public CFloat DefaultInitialValue { get; set; }
		[Ordinal(16)] [RED("wrapAroundRange")] public CBool WrapAroundRange { get; set; }
		[Ordinal(17)] [RED("rangeMin")] public CFloat RangeMin { get; set; }
		[Ordinal(18)] [RED("rangeMax")] public CFloat RangeMax { get; set; }
		[Ordinal(19)] [RED("timeStep")] public CFloat TimeStep { get; set; }
		[Ordinal(20)] [RED("inputNode")] public animFloatLink InputNode { get; set; }

		public animAnimNode_SpringDamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
