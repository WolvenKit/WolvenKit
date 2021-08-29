using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalCodexDescription : gameJournalEntry
	{
		private LocalizationString _subTitle;
		private LocalizationString _textContent;

		[Ordinal(1)] 
		[RED("subTitle")] 
		public LocalizationString SubTitle
		{
			get => GetProperty(ref _subTitle);
			set => SetProperty(ref _subTitle, value);
		}

		[Ordinal(2)] 
		[RED("textContent")] 
		public LocalizationString TextContent
		{
			get => GetProperty(ref _textContent);
			set => SetProperty(ref _textContent, value);
		}
	}
}
