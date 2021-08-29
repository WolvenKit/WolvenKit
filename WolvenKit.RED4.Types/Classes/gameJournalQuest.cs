using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuest : gameJournalFileEntry
	{
		private LocalizationString _title;
		private CEnum<gameJournalQuestType> _type;
		private TweakDBID _recommendedLevelID;
		private CString _districtID;

		[Ordinal(2)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gameJournalQuestType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("recommendedLevelID")] 
		public TweakDBID RecommendedLevelID
		{
			get => GetProperty(ref _recommendedLevelID);
			set => SetProperty(ref _recommendedLevelID, value);
		}

		[Ordinal(5)] 
		[RED("districtID")] 
		public CString DistrictID
		{
			get => GetProperty(ref _districtID);
			set => SetProperty(ref _districtID, value);
		}
	}
}
