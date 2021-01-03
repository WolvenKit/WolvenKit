using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalPointOfInterestMappin : gameJournalEntry
	{
		[Ordinal(0)]  [RED("dynamicEntityRef")] public gameEntityReference DynamicEntityRef { get; set; }
		[Ordinal(1)]  [RED("mappinData")] public gamemappinsPointOfInterestMappinData MappinData { get; set; }
		[Ordinal(2)]  [RED("notificationTriggerAreaRef")] public NodeRef NotificationTriggerAreaRef { get; set; }
		[Ordinal(3)]  [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(4)]  [RED("questPath")] public CHandle<gameJournalPath> QuestPath { get; set; }
		[Ordinal(5)]  [RED("recommendedLevelID")] public TweakDBID RecommendedLevelID { get; set; }
		[Ordinal(6)]  [RED("securityAreaRef")] public NodeRef SecurityAreaRef { get; set; }
		[Ordinal(7)]  [RED("staticNodeRef")] public NodeRef StaticNodeRef { get; set; }

		public gameJournalPointOfInterestMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
