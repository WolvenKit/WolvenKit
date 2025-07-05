using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCombatNodeParams_SwitchWeapon : questCombatNodeParams
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<questSwitchWeaponModes> Mode
		{
			get => GetPropertyValue<CEnum<questSwitchWeaponModes>>();
			set => SetPropertyValue<CEnum<questSwitchWeaponModes>>(value);
		}

		public questCombatNodeParams_SwitchWeapon()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
