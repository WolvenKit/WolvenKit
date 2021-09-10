using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalCodexGroup : gameJournalContainerEntry
	{
		[Ordinal(2)] 
		[RED("groupName")] 
		public LocalizationString GroupName
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public gameJournalCodexGroup()
		{
			Entries = new();
			GroupName = new() { Unk1 = 0, Value = "" };
		}
	}
}
