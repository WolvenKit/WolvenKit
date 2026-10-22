using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalInternetText : gameJournalInternetBase
	{
		[Ordinal(4)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public gameJournalInternetText()
		{
			TintColor = new CColor { Red = 255, Green = 255, Blue = 255 };
			HoverTintColor = new CColor { Red = 255, Green = 255, Blue = 255 };
			Text = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
