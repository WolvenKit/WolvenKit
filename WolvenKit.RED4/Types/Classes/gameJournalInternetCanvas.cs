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
			TintColor = new CColor { Red = 255, Green = 255, Blue = 255 };
			HoverTintColor = new CColor { Red = 255, Green = 255, Blue = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
