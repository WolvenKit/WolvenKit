using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalCodexCategory : gameJournalFileEntry
	{
		[Ordinal(2)] 
		[RED("categoryName")] 
		public LocalizationString CategoryName
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public gameJournalCodexCategory()
		{
			Entries = new();
			CategoryName = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
