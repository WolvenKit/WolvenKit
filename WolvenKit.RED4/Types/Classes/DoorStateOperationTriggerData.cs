using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorStateOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EDoorStatus> State
		{
			get => GetPropertyValue<CEnum<EDoorStatus>>();
			set => SetPropertyValue<CEnum<EDoorStatus>>(value);
		}

		public DoorStateOperationTriggerData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
