using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalCodexGroup : gameJournalContainerEntry
	{
		[Ordinal(3)] 
		[RED("groupName")] 
		public LocalizationString GroupName
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(4)] 
		[RED("isSorted")] 
		public CBool IsSorted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameJournalCodexGroup()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();
			GroupName = new() { Unk1 = 0, Value = "" };
			IsSorted = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
