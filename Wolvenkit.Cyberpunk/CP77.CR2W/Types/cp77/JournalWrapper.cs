using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JournalWrapper : ABaseWrapper
	{
		[Ordinal(0)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(1)]  [RED("journalContext")] public gameJournalRequestContext JournalContext { get; set; }
		[Ordinal(2)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(3)]  [RED("journalSubQuestContext")] public gameJournalRequestContext JournalSubQuestContext { get; set; }
		[Ordinal(4)]  [RED("listOfJournalEntries")] public CArray<wCHandle<gameJournalEntry>> ListOfJournalEntries { get; set; }

		public JournalWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
