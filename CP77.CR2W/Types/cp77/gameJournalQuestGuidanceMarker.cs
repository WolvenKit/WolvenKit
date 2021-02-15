using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestGuidanceMarker : gameJournalEntry
	{
		[Ordinal(1)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(2)] [RED("pathfindingType")] public CEnum<gameQuestGuidanceMarkerPathfindingType> PathfindingType { get; set; }
		[Ordinal(3)] [RED("isPortal")] public CBool IsPortal { get; set; }

		public gameJournalQuestGuidanceMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
