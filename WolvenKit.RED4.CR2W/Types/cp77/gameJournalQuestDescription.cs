using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestDescription : gameJournalEntry
	{
		private LocalizationString _description;

		[Ordinal(1)] 
		[RED("description")] 
		public LocalizationString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		public gameJournalQuestDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
