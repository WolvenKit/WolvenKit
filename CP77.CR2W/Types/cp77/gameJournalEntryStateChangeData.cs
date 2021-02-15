using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalEntryStateChangeData : CVariable
	{
		[Ordinal(0)] [RED("entryPath")] public CHandle<gameJournalPath> EntryPath { get; set; }
		[Ordinal(1)] [RED("entryName")] public CString EntryName { get; set; }
		[Ordinal(2)] [RED("entryType")] public CName EntryType { get; set; }
		[Ordinal(3)] [RED("isEntryTracked")] public CBool IsEntryTracked { get; set; }
		[Ordinal(4)] [RED("isQuestEntryTracked")] public CBool IsQuestEntryTracked { get; set; }
		[Ordinal(5)] [RED("oldState")] public CEnum<gameJournalEntryState> OldState { get; set; }
		[Ordinal(6)] [RED("newState")] public CEnum<gameJournalEntryState> NewState { get; set; }
		[Ordinal(7)] [RED("notifyOption")] public CEnum<gameJournalNotifyOption> NotifyOption { get; set; }
		[Ordinal(8)] [RED("changeType")] public CEnum<gameJournalChangeType> ChangeType { get; set; }

		public gameJournalEntryStateChangeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
