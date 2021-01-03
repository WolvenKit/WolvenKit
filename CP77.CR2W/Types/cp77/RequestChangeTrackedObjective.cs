using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RequestChangeTrackedObjective : redEvent
	{
		[Ordinal(0)]  [RED("objective")] public wCHandle<gameJournalQuestObjective> Objective { get; set; }
		[Ordinal(1)]  [RED("quest")] public wCHandle<gameJournalQuest> Quest { get; set; }

		public RequestChangeTrackedObjective(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
