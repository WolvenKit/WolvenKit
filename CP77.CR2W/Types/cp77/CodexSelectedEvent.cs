using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexSelectedEvent : redEvent
	{
		[Ordinal(0)] [RED("group")] public CBool Group { get; set; }
		[Ordinal(1)] [RED("entryHash")] public CInt32 EntryHash { get; set; }
		[Ordinal(2)] [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(3)] [RED("data")] public wCHandle<CodexEntryData> Data { get; set; }
		[Ordinal(4)] [RED("activeDataSync")] public wCHandle<CodexListSyncData> ActiveDataSync { get; set; }

		public CodexSelectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
