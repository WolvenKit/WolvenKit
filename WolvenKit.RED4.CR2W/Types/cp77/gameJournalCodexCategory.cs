using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexCategory : gameJournalFileEntry
	{
		private LocalizationString _categoryName;

		[Ordinal(2)] 
		[RED("categoryName")] 
		public LocalizationString CategoryName
		{
			get => GetProperty(ref _categoryName);
			set => SetProperty(ref _categoryName, value);
		}

		public gameJournalCodexCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
