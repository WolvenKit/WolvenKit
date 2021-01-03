using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestTrackedData : CVariable
	{
		[Ordinal(0)]  [RED("entryPath")] public CHandle<gameJournalPath> EntryPath { get; set; }
		[Ordinal(1)]  [RED("entryType")] public CName EntryType { get; set; }
		[Ordinal(2)]  [RED("state")] public CEnum<gameJournalEntryState> State { get; set; }

		public gameJournalQuestTrackedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
