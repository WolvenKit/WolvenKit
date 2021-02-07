using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questJournalQuestEntry_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)]  [RED("sendNotification")] public CBool SendNotification { get; set; }
		[Ordinal(1)]  [RED("trackQuest")] public CBool TrackQuest { get; set; }

		public questJournalQuestEntry_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
