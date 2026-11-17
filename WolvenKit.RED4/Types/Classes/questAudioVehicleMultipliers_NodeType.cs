using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioVehicleMultipliers_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("multipliers")] 
		public audioVehicleMultipliers Multipliers
		{
			get => GetPropertyValue<audioVehicleMultipliers>();
			set => SetPropertyValue<audioVehicleMultipliers>(value);
		}

		public questAudioVehicleMultipliers_NodeType()
		{
			VehicleRef = new gameEntityReference();
			Multipliers = new audioVehicleMultipliers();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
