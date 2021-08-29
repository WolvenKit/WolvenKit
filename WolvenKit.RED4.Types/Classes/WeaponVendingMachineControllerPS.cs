using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponVendingMachineControllerPS : VendingMachineControllerPS
	{
		private WeaponVendingMachineSetup _weaponVendingMachineSetup;
		private WeaponVendingMachineSFX _weaponVendingMachineSFX;

		[Ordinal(112)] 
		[RED("weaponVendingMachineSetup")] 
		public WeaponVendingMachineSetup WeaponVendingMachineSetup
		{
			get => GetProperty(ref _weaponVendingMachineSetup);
			set => SetProperty(ref _weaponVendingMachineSetup, value);
		}

		[Ordinal(113)] 
		[RED("weaponVendingMachineSFX")] 
		public WeaponVendingMachineSFX WeaponVendingMachineSFX
		{
			get => GetProperty(ref _weaponVendingMachineSFX);
			set => SetProperty(ref _weaponVendingMachineSFX, value);
		}
	}
}
