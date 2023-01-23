using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestDataWrapper : AJournalEntryWrapper
	{
		[Ordinal(1)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("quest")] 
		public CWeakHandle<gameJournalQuest> Quest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(3)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("questObjectives")] 
		public CArray<CHandle<QuestObjectiveWrapper>> QuestObjectives
		{
			get => GetPropertyValue<CArray<CHandle<QuestObjectiveWrapper>>>();
			set => SetPropertyValue<CArray<CHandle<QuestObjectiveWrapper>>>(value);
		}

		[Ordinal(6)] 
		[RED("links")] 
		public CArray<CWeakHandle<gameJournalEntry>> Links
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalEntry>>>(value);
		}

		[Ordinal(7)] 
		[RED("questStatus")] 
		public CEnum<gameJournalEntryState> QuestStatus
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(8)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isChildTracked")] 
		public CBool IsChildTracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("recommendedLevel")] 
		public CInt32 RecommendedLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("district")] 
		public CHandle<gamedataDistrict_Record> District
		{
			get => GetPropertyValue<CHandle<gamedataDistrict_Record>>();
			set => SetPropertyValue<CHandle<gamedataDistrict_Record>>(value);
		}

		public QuestDataWrapper()
		{
			QuestObjectives = new();
			Links = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
