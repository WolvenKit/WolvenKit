using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestTrackingEvent : redEvent
	{
		[Ordinal(0)]  [RED("journalEntry")] public wCHandle<gameJournalQuestObjectiveBase> JournalEntry { get; set; }
		[Ordinal(1)]  [RED("objective")] public wCHandle<QuestItemController> Objective { get; set; }

		public QuestTrackingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
