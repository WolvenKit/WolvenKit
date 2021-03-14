using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PersonnelSystem : DeviceSystemBase
	{
		private CBool _enableE3QuickHacks;

		[Ordinal(93)] 
		[RED("EnableE3QuickHacks")] 
		public CBool EnableE3QuickHacks
		{
			get
			{
				if (_enableE3QuickHacks == null)
				{
					_enableE3QuickHacks = (CBool) CR2WTypeManager.Create("Bool", "EnableE3QuickHacks", cr2w, this);
				}
				return _enableE3QuickHacks;
			}
			set
			{
				if (_enableE3QuickHacks == value)
				{
					return;
				}
				_enableE3QuickHacks = value;
				PropertySet(this);
			}
		}

		public PersonnelSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
