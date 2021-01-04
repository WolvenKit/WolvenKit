using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatPoolModifier : CVariable
	{
		[Ordinal(0)]  [RED("delayOnChange")] public CBool DelayOnChange { get; set; }
		[Ordinal(1)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(2)]  [RED("rangeBegin")] public CFloat RangeBegin { get; set; }
		[Ordinal(3)]  [RED("rangeEnd")] public CFloat RangeEnd { get; set; }
		[Ordinal(4)]  [RED("startDelay")] public CFloat StartDelay { get; set; }
		[Ordinal(5)]  [RED("usingPointValues")] public CBool UsingPointValues { get; set; }
		[Ordinal(6)]  [RED("valuePerSec")] public CFloat ValuePerSec { get; set; }

		public gameStatPoolModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
