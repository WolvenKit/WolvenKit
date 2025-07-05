using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalBriefingVideoSection : gameJournalBriefingBaseSection
	{
		[Ordinal(2)] 
		[RED("videoResource")] 
		public CResourceAsyncReference<Bink> VideoResource
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		public gameJournalBriefingVideoSection()
		{
			JournalEntryOverrideDataList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
