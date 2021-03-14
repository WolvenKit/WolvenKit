using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
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
