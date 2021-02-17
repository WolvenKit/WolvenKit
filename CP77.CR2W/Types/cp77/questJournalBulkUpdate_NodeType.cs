using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questJournalBulkUpdate_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
		[Ordinal(1)] [RED("requiredEntryType")] public CName RequiredEntryType { get; set; }
		[Ordinal(2)] [RED("requiredEntryState")] public CName RequiredEntryState { get; set; }
		[Ordinal(3)] [RED("newEntryState")] public CName NewEntryState { get; set; }
		[Ordinal(4)] [RED("sendNotification")] public CBool SendNotification { get; set; }
		[Ordinal(5)] [RED("propagateChange")] public CBool PropagateChange { get; set; }

		public questJournalBulkUpdate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
