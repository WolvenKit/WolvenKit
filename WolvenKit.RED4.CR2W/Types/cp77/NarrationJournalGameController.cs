using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NarrationJournalGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("entriesContainer")] public inkCompoundWidgetReference EntriesContainer { get; set; }
		[Ordinal(10)] [RED("narrationJournalBlackboardId")] public CUInt32 NarrationJournalBlackboardId { get; set; }

		public NarrationJournalGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
