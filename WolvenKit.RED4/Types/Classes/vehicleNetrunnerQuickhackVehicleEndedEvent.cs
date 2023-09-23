using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleNetrunnerQuickhackVehicleEndedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("vehicleNetrunnerQuickhackType")] 
		public CEnum<vehicleVehicleNetrunnerQuickhackType> VehicleNetrunnerQuickhackType
		{
			get => GetPropertyValue<CEnum<vehicleVehicleNetrunnerQuickhackType>>();
			set => SetPropertyValue<CEnum<vehicleVehicleNetrunnerQuickhackType>>(value);
		}

		[Ordinal(1)] 
		[RED("shouldTriggerPanicDriving")] 
		public CBool ShouldTriggerPanicDriving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("shouldRejoinTraffic")] 
		public CBool ShouldRejoinTraffic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleNetrunnerQuickhackVehicleEndedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
