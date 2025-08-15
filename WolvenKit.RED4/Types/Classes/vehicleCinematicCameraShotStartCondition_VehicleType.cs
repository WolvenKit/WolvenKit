using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCinematicCameraShotStartCondition_VehicleType : vehicleCinematicCameraShotStartCondition
	{
		[Ordinal(0)] 
		[RED("vehicleType")] 
		public CEnum<gamedataVehicleType> VehicleType
		{
			get => GetPropertyValue<CEnum<gamedataVehicleType>>();
			set => SetPropertyValue<CEnum<gamedataVehicleType>>(value);
		}

		public vehicleCinematicCameraShotStartCondition_VehicleType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
