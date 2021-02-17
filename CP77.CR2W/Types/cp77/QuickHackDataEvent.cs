using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickHackDataEvent : redEvent
	{
		[Ordinal(0)] [RED("selectedData")] public CHandle<QuickhackData> SelectedData { get; set; }

		public QuickHackDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
