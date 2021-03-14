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
			get
			{
				if (_subTitle == null)
				{
					_subTitle = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "subTitle", cr2w, this);
				}
				return _subTitle;
			}
			set
			{
				if (_subTitle == value)
				{
					return;
				}
				_subTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("textContent")] 
		public LocalizationString TextContent
		{
			get
			{
				if (_textContent == null)
				{
					_textContent = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "textContent", cr2w, this);
				}
				return _textContent;
			}
			set
			{
				if (_textContent == value)
				{
					return;
				}
				_textContent = value;
				PropertySet(this);
			}
		}

		public gameJournalCodexDescription_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
