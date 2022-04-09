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
			TintColor = new();
			HoverTintColor = new();
			Text = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
