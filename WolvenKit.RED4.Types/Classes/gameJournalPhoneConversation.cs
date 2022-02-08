using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalPhoneConversation : gameJournalContainerEntry
	{
		[Ordinal(2)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public gameJournalPhoneConversation()
		{
			Entries = new();
			Title = new() { Unk1 = 0, Value = "" };
		}
	}
}
