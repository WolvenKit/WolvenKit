using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleControllerPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("vehicleDoors", 6)] 
		public CStatic<vehicleVehicleSlotsState> VehicleDoors
		{
			get => GetPropertyValue<CStatic<vehicleVehicleSlotsState>>();
			set => SetPropertyValue<CStatic<vehicleVehicleSlotsState>>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<vehicleEState> State
		{
			get => GetPropertyValue<CEnum<vehicleEState>>();
			set => SetPropertyValue<CEnum<vehicleEState>>(value);
		}

		[Ordinal(2)] 
		[RED("lightMode")] 
		public CEnum<vehicleELightMode> LightMode
		{
			get => GetPropertyValue<CEnum<vehicleELightMode>>();
			set => SetPropertyValue<CEnum<vehicleELightMode>>(value);
		}

		[Ordinal(3)] 
		[RED("isAlarmOn")] 
		public CBool IsAlarmOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("lightTypeMask")] 
		public CInt32 LightTypeMask
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("allowPassengerCameraSwitch")] 
		public CBool AllowPassengerCameraSwitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleControllerPS()
		{
			VehicleDoors = new(6);
			State = Enums.vehicleEState.Default;
			LightTypeMask = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
