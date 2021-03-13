using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalPointOfInterestMappin : gameJournalEntry
	{
		[Ordinal(1)] [RED("staticNodeRef")] public NodeRef StaticNodeRef { get; set; }
		[Ordinal(2)] [RED("dynamicEntityRef")] public gameEntityReference DynamicEntityRef { get; set; }
		[Ordinal(3)] [RED("securityAreaRef")] public NodeRef SecurityAreaRef { get; set; }
		[Ordinal(4)] [RED("mappinData")] public gamemappinsPointOfInterestMappinData MappinData { get; set; }
		[Ordinal(5)] [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(6)] [RED("questPath")] public CHandle<gameJournalPath> QuestPath { get; set; }
		[Ordinal(7)] [RED("recommendedLevelID")] public TweakDBID RecommendedLevelID { get; set; }
		[Ordinal(8)] [RED("notificationTriggerAreaRef")] public NodeRef NotificationTriggerAreaRef { get; set; }

		public gameJournalPointOfInterestMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
