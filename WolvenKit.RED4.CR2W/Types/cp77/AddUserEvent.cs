using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddUserEvent : redEvent
	{
		private SecuritySystemClearanceEntry _userEntry;

		[Ordinal(0)] 
		[RED("userEntry")] 
		public SecuritySystemClearanceEntry UserEntry
		{
			get
			{
				if (_userEntry == null)
				{
					_userEntry = (SecuritySystemClearanceEntry) CR2WTypeManager.Create("SecuritySystemClearanceEntry", "userEntry", cr2w, this);
				}
				return _userEntry;
			}
			set
			{
				if (_userEntry == value)
				{
					return;
				}
				_userEntry = value;
				PropertySet(this);
			}
		}

		public AddUserEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
