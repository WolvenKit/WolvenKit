using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JournalEntryNotificationRemoveRequestData : IScriptable
	{
		[Ordinal(0)] [RED("entryHash")] public CUInt32 EntryHash { get; set; }

		public JournalEntryNotificationRemoveRequestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
