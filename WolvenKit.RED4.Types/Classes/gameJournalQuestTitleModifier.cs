using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestTitleModifier : gameJournalEntry
	{
		[Ordinal(1)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public gameJournalQuestTitleModifier()
		{
			Title = new() { Unk1 = 0, Value = "" };
		}
	}
}
