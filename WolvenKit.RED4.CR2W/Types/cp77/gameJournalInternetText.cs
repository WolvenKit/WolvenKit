using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetText : gameJournalInternetBase
	{
		private LocalizationString _text;

		[Ordinal(4)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		public gameJournalInternetText(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
