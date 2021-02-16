using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestListItemData : IScriptable
	{
		[Ordinal(0)] [RED("questType")] public CInt32 QuestType { get; set; }
		[Ordinal(1)] [RED("timestamp")] public GameTime Timestamp { get; set; }
		[Ordinal(2)] [RED("isTrackedQuest")] public CBool IsTrackedQuest { get; set; }
		[Ordinal(3)] [RED("isOpenedQuest")] public CBool IsOpenedQuest { get; set; }
		[Ordinal(4)] [RED("questData")] public wCHandle<gameJournalQuest> QuestData { get; set; }
		[Ordinal(5)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(6)] [RED("playerLevel")] public CInt32 PlayerLevel { get; set; }
		[Ordinal(7)] [RED("recommendedLevel")] public CInt32 RecommendedLevel { get; set; }
		[Ordinal(8)] [RED("isVisited")] public CBool IsVisited { get; set; }
		[Ordinal(9)] [RED("isResolved")] public CBool IsResolved { get; set; }
		[Ordinal(10)] [RED("State")] public CEnum<gameJournalEntryState> State { get; set; }
		[Ordinal(11)] [RED("distancesFetched")] public CBool DistancesFetched { get; set; }
		[Ordinal(12)] [RED("objectivesDistances")] public CArray<CHandle<QuestListDistanceData>> ObjectivesDistances { get; set; }

		public QuestListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
