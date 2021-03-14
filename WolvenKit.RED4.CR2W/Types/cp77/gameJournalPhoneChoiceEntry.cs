using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalPhoneChoiceEntry : gameJournalEntry
	{
		private LocalizationString _text;
		private CBool _isQuestImportant;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("isQuestImportant")] 
		public CBool IsQuestImportant
		{
			get
			{
				if (_isQuestImportant == null)
				{
					_isQuestImportant = (CBool) CR2WTypeManager.Create("Bool", "isQuestImportant", cr2w, this);
				}
				return _isQuestImportant;
			}
			set
			{
				if (_isQuestImportant == value)
				{
					return;
				}
				_isQuestImportant = value;
				PropertySet(this);
			}
		}

		public gameJournalPhoneChoiceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
