using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleSpeed_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<vehicleEVehicleSpeedConditionType> ComparisonType
		{
			get => GetPropertyValue<CEnum<vehicleEVehicleSpeedConditionType>>();
			set => SetPropertyValue<CEnum<vehicleEVehicleSpeedConditionType>>(value);
		}

		public questVehicleSpeed_ConditionType()
		{
			VehicleRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
