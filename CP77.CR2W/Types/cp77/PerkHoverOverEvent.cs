using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerkHoverOverEvent : redEvent
	{
		[Ordinal(0)] [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(1)] [RED("perkIndex")] public CInt32 PerkIndex { get; set; }
		[Ordinal(2)] [RED("perkData")] public CHandle<BasePerkDisplayData> PerkData { get; set; }

		public PerkHoverOverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
