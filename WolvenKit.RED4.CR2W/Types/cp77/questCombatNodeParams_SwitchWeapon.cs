using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_SwitchWeapon : questCombatNodeParams
	{
		private CEnum<questSwitchWeaponModes> _mode;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questSwitchWeaponModes> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<questSwitchWeaponModes>) CR2WTypeManager.Create("questSwitchWeaponModes", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public questCombatNodeParams_SwitchWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
