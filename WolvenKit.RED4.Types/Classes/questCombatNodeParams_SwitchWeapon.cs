using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCombatNodeParams_SwitchWeapon : questCombatNodeParams
	{
		private CEnum<questSwitchWeaponModes> _mode;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questSwitchWeaponModes> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}
	}
}
