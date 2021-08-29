using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalCodexCategory : gameJournalFileEntry
	{
		private LocalizationString _categoryName;

		[Ordinal(2)] 
		[RED("categoryName")] 
		public LocalizationString CategoryName
		{
			get => GetProperty(ref _categoryName);
			set => SetProperty(ref _categoryName, value);
		}
	}
}
