using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVehicleAVArrived_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questVehicleAVArrived_ConditionType()
		{
			VehicleRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
