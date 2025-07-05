using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalInternetCanvas : gameJournalInternetBase
	{
		[Ordinal(4)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameJournalInternetCanvas()
		{
			TintColor = new CColor();
			HoverTintColor = new CColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
