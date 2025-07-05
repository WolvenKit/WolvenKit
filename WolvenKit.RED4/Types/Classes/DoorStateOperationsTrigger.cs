using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorStateOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<DoorStateOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<DoorStateOperationTriggerData>>();
			set => SetPropertyValue<CHandle<DoorStateOperationTriggerData>>(value);
		}

		[Ordinal(1)] 
		[RED("wasStateCached")] 
		public CBool WasStateCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("cachedState")] 
		public CEnum<EDoorStatus> CachedState
		{
			get => GetPropertyValue<CEnum<EDoorStatus>>();
			set => SetPropertyValue<CEnum<EDoorStatus>>(value);
		}

		public DoorStateOperationsTrigger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
