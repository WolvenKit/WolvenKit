using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatPoolModifier : CVariable
	{
		[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)] [RED("rangeBegin")] public CFloat RangeBegin { get; set; }
		[Ordinal(2)] [RED("rangeEnd")] public CFloat RangeEnd { get; set; }
		[Ordinal(3)] [RED("startDelay")] public CFloat StartDelay { get; set; }
		[Ordinal(4)] [RED("valuePerSec")] public CFloat ValuePerSec { get; set; }
		[Ordinal(5)] [RED("delayOnChange")] public CBool DelayOnChange { get; set; }
		[Ordinal(6)] [RED("usingPointValues")] public CBool UsingPointValues { get; set; }

		public gameStatPoolModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
