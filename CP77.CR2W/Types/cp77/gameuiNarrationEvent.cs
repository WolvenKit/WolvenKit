using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiNarrationEvent : CVariable
	{
		[Ordinal(0)] [RED("text")] public CString Text { get; set; }
		[Ordinal(1)] [RED("durationSec")] public CFloat DurationSec { get; set; }
		[Ordinal(2)] [RED("color")] public CColor Color { get; set; }

		public gameuiNarrationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
