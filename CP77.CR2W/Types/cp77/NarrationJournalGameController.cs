using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NarrationJournalGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("entriesContainer")] public inkCompoundWidgetReference EntriesContainer { get; set; }
		[Ordinal(10)] [RED("narrationJournalBlackboardId")] public CUInt32 NarrationJournalBlackboardId { get; set; }

		public NarrationJournalGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
