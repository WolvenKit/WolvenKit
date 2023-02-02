using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalCodexDescription : gameJournalEntry
	{
		[Ordinal(1)] 
		[RED("subTitle")] 
		public LocalizationString SubTitle
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(2)] 
		[RED("textContent")] 
		public LocalizationString TextContent
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public gameJournalCodexDescription()
		{
			SubTitle = new() { Unk1 = 0, Value = "" };
			TextContent = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
