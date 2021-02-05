using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalPointOfInterestMappin : gameJournalEntry
	{
		[Ordinal(0)]  [RED("staticNodeRef")] public NodeRef StaticNodeRef { get; set; }
		[Ordinal(1)]  [RED("dynamicEntityRef")] public gameEntityReference DynamicEntityRef { get; set; }
		[Ordinal(2)]  [RED("securityAreaRef")] public NodeRef SecurityAreaRef { get; set; }
		[Ordinal(3)]  [RED("mappinData")] public gamemappinsPointOfInterestMappinData MappinData { get; set; }
		[Ordinal(4)]  [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(5)]  [RED("questPath")] public CHandle<gameJournalPath> QuestPath { get; set; }
		[Ordinal(6)]  [RED("recommendedLevelID")] public TweakDBID RecommendedLevelID { get; set; }
		[Ordinal(7)]  [RED("notificationTriggerAreaRef")] public NodeRef NotificationTriggerAreaRef { get; set; }

		public gameJournalPointOfInterestMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
