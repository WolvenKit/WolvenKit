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
			get
			{
				if (_categoryName == null)
				{
					_categoryName = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "categoryName", cr2w, this);
				}
				return _categoryName;
			}
			set
			{
				if (_categoryName == value)
				{
					return;
				}
				_categoryName = value;
				PropertySet(this);
			}
		}

		public gameJournalCodexCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
