using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalBriefingVideoSection : gameJournalBriefingBaseSection
	{
		[Ordinal(1)] 
		[RED("videoResource")] 
		public CResourceAsyncReference<Bink> VideoResource
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		public gameJournalBriefingVideoSection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
