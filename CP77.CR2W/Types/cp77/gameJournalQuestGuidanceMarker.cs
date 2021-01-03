using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestGuidanceMarker : gameJournalEntry
	{
		[Ordinal(0)]  [RED("isPortal")] public CBool IsPortal { get; set; }
		[Ordinal(1)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(2)]  [RED("pathfindingType")] public CEnum<gameQuestGuidanceMarkerPathfindingType> PathfindingType { get; set; }

		public gameJournalQuestGuidanceMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
