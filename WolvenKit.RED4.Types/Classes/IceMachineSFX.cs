using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IceMachineSFX : VendingMachineSFX
	{
		[Ordinal(2)] 
		[RED("iceFalls")] 
		public CName IceFalls
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("processing")] 
		public CName Processing
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public IceMachineSFX()
		{
			IceFalls = "dev_ice_machine_ice_cube_falls";
			Processing = "dev_vending_machine_processing";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
