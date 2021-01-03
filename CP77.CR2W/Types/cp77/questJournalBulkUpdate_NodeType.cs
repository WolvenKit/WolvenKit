using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questJournalBulkUpdate_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)]  [RED("newEntryState")] public CName NewEntryState { get; set; }
		[Ordinal(1)]  [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
		[Ordinal(2)]  [RED("propagateChange")] public CBool PropagateChange { get; set; }
		[Ordinal(3)]  [RED("requiredEntryState")] public CName RequiredEntryState { get; set; }
		[Ordinal(4)]  [RED("requiredEntryType")] public CName RequiredEntryType { get; set; }
		[Ordinal(5)]  [RED("sendNotification")] public CBool SendNotification { get; set; }

		public questJournalBulkUpdate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
