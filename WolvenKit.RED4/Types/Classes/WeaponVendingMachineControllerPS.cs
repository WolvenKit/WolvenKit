using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponVendingMachineControllerPS : VendingMachineControllerPS
	{
		[Ordinal(115)] 
		[RED("weaponVendingMachineSetup")] 
		public WeaponVendingMachineSetup WeaponVendingMachineSetup
		{
			get => GetPropertyValue<WeaponVendingMachineSetup>();
			set => SetPropertyValue<WeaponVendingMachineSetup>(value);
		}

		[Ordinal(116)] 
		[RED("weaponVendingMachineSFX")] 
		public WeaponVendingMachineSFX WeaponVendingMachineSFX
		{
			get => GetPropertyValue<WeaponVendingMachineSFX>();
			set => SetPropertyValue<WeaponVendingMachineSFX>(value);
		}

		public WeaponVendingMachineControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
