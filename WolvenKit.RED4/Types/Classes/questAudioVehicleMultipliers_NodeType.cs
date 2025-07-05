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
			VehicleRef = new gameEntityReference { Names = new() };
			Multipliers = new audioVehicleMultipliers { ThrottleInputMultiplier = 1.000000F, RpmMultiplier = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
