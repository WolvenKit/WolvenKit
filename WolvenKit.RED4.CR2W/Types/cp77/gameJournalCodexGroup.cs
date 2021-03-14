using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexGroup : gameJournalContainerEntry
	{
		private LocalizationString _groupName;

		[Ordinal(2)] 
		[RED("groupName")] 
		public LocalizationString GroupName
		{
			get
			{
				if (_groupName == null)
				{
					_groupName = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "groupName", cr2w, this);
				}
				return _groupName;
			}
			set
			{
				if (_groupName == value)
				{
					return;
				}
				_groupName = value;
				PropertySet(this);
			}
		}

		public gameJournalCodexGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
