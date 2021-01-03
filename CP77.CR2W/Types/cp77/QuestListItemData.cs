using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestListItemData : IScriptable
	{
		[Ordinal(0)]  [RED("State")] public CEnum<gameJournalEntryState> State { get; set; }
		[Ordinal(1)]  [RED("distancesFetched")] public CBool DistancesFetched { get; set; }
		[Ordinal(2)]  [RED("isOpenedQuest")] public CBool IsOpenedQuest { get; set; }
		[Ordinal(3)]  [RED("isResolved")] public CBool IsResolved { get; set; }
		[Ordinal(4)]  [RED("isTrackedQuest")] public CBool IsTrackedQuest { get; set; }
		[Ordinal(5)]  [RED("isVisited")] public CBool IsVisited { get; set; }
		[Ordinal(6)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(7)]  [RED("objectivesDistances")] public CArray<CHandle<QuestListDistanceData>> ObjectivesDistances { get; set; }
		[Ordinal(8)]  [RED("playerLevel")] public CInt32 PlayerLevel { get; set; }
		[Ordinal(9)]  [RED("questData")] public wCHandle<gameJournalQuest> QuestData { get; set; }
		[Ordinal(10)]  [RED("questType")] public CInt32 QuestType { get; set; }
		[Ordinal(11)]  [RED("recommendedLevel")] public CInt32 RecommendedLevel { get; set; }
		[Ordinal(12)]  [RED("timestamp")] public GameTime Timestamp { get; set; }

		public QuestListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
