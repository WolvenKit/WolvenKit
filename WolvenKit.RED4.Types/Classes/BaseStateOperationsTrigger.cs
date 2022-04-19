using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseStateOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] 
		[RED("triggerData")] 
		public CHandle<BaseStateOperationTriggerData> TriggerData
		{
			get => GetPropertyValue<CHandle<BaseStateOperationTriggerData>>();
			set => SetPropertyValue<CHandle<BaseStateOperationTriggerData>>(value);
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
		public CEnum<EDeviceStatus> CachedState
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		public BaseStateOperationsTrigger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
