using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleAIVehicleDisabledEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("reason")] 
		public CEnum<vehicleDisabledReason> Reason
		{
			get => GetPropertyValue<CEnum<vehicleDisabledReason>>();
			set => SetPropertyValue<CEnum<vehicleDisabledReason>>(value);
		}

		public vehicleAIVehicleDisabledEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
