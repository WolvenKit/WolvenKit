using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuest : gameJournalFileEntry
	{
		[Ordinal(3)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameJournalQuestType> Type
		{
			get => GetPropertyValue<CEnum<gameJournalQuestType>>();
			set => SetPropertyValue<CEnum<gameJournalQuestType>>(value);
		}

		[Ordinal(5)] 
		[RED("recommendedLevelID")] 
		public TweakDBID RecommendedLevelID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("districtID")] 
		public CString DistrictID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameJournalQuest()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();
			Title = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
