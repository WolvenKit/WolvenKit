using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexDescription_ : gameJournalEntry
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

		public gameJournalCodexDescription_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
