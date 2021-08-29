using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalPhoneChoiceEntry : gameJournalEntry
	{
		private LocalizationString _text;
		private CBool _isQuestImportant;

		[Ordinal(1)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(2)] 
		[RED("isQuestImportant")] 
		public CBool IsQuestImportant
		{
			get => GetProperty(ref _isQuestImportant);
			set => SetProperty(ref _isQuestImportant, value);
		}
	}
}
