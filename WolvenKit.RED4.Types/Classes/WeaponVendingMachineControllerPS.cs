using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponVendingMachineControllerPS : VendingMachineControllerPS
	{
		[Ordinal(112)] 
		[RED("weaponVendingMachineSetup")] 
		public WeaponVendingMachineSetup WeaponVendingMachineSetup
		{
			get => GetPropertyValue<WeaponVendingMachineSetup>();
			set => SetPropertyValue<WeaponVendingMachineSetup>(value);
		}

		[Ordinal(113)] 
		[RED("weaponVendingMachineSFX")] 
		public WeaponVendingMachineSFX WeaponVendingMachineSFX
		{
			get => GetPropertyValue<WeaponVendingMachineSFX>();
			set => SetPropertyValue<WeaponVendingMachineSFX>(value);
		}

		public WeaponVendingMachineControllerPS()
		{
			DeviceName = "LocKey#17883";
			TweakDBRecord = new() { Value = 124293458313 };
			TweakDBDescriptionRecord = new() { Value = 174063646172 };
			WeaponVendingMachineSetup = new() { TimeToCompletePurchase = 3.000000F };
			WeaponVendingMachineSFX = new() { Processing = "dev_vending_machine_processing" };
		}
	}
}
