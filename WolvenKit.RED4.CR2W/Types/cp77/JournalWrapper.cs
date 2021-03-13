using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalWrapper : ABaseWrapper
	{
		[Ordinal(0)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(1)] [RED("journalContext")] public gameJournalRequestContext JournalContext { get; set; }
		[Ordinal(2)] [RED("journalSubQuestContext")] public gameJournalRequestContext JournalSubQuestContext { get; set; }
		[Ordinal(3)] [RED("listOfJournalEntries")] public CArray<wCHandle<gameJournalEntry>> ListOfJournalEntries { get; set; }
		[Ordinal(4)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }

		public JournalWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
