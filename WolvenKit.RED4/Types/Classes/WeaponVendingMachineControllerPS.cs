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
			DeviceName = "LocKey#17883";
			TweakDBRecord = "Devices.WeaponVendingMachine";
			TweakDBDescriptionRecord = 174063646172;
			WeaponVendingMachineSetup = new WeaponVendingMachineSetup { TimeToCompletePurchase = 3.000000F };
			WeaponVendingMachineSFX = new WeaponVendingMachineSFX { Processing = "dev_vending_machine_processing" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
