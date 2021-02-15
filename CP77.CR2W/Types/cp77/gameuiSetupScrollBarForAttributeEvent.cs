using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSetupScrollBarForAttributeEvent : redEvent
	{
		[Ordinal(0)] [RED("attribute")] public CUInt32 Attribute { get; set; }
		[Ordinal(1)] [RED("startValue")] public CFloat StartValue { get; set; }
		[Ordinal(2)] [RED("minValue")] public CFloat MinValue { get; set; }
		[Ordinal(3)] [RED("maxValue")] public CFloat MaxValue { get; set; }
		[Ordinal(4)] [RED("step")] public CFloat Step { get; set; }

		public gameuiSetupScrollBarForAttributeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
