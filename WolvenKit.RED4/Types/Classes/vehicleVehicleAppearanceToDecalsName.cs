using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleAppearanceToDecalsName : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("decalsName")] 
		public CArray<CName> DecalsName
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public vehicleVehicleAppearanceToDecalsName()
		{
			DecalsName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
