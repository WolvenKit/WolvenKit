using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponVendingMachineSFX : VendingMachineSFX
	{
		[Ordinal(2)] 
		[RED("processing")] 
		public CName Processing
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("gunFalls")] 
		public CName GunFalls
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public WeaponVendingMachineSFX()
		{
			Processing = "dev_vending_machine_processing";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
