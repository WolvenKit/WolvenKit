using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalInternetVideo : gameJournalInternetBase
	{
		[Ordinal(4)] 
		[RED("videoResource")] 
		public CResourceAsyncReference<Bink> VideoResource
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		public gameJournalInternetVideo()
		{
			TintColor = new();
			HoverTintColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
