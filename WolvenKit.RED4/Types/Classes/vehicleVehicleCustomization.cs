using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleVehicleCustomization : entIComponent
	{
		[Ordinal(3)] 
		[RED("defaultDecalsPerAppearance")] 
		public CArray<vehicleVehicleAppearanceToDecalsName> DefaultDecalsPerAppearance
		{
			get => GetPropertyValue<CArray<vehicleVehicleAppearanceToDecalsName>>();
			set => SetPropertyValue<CArray<vehicleVehicleAppearanceToDecalsName>>(value);
		}

		public vehicleVehicleCustomization()
		{
			Name = "Component";
			DefaultDecalsPerAppearance = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
