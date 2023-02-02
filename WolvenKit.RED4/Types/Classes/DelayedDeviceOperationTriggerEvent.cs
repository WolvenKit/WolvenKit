using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedDeviceOperationTriggerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("triggerHandler")] 
		public CHandle<DeviceOperationsTrigger> TriggerHandler
		{
			get => GetPropertyValue<CHandle<DeviceOperationsTrigger>>();
			set => SetPropertyValue<CHandle<DeviceOperationsTrigger>>(value);
		}

		[Ordinal(1)] 
		[RED("namedOperation")] 
		public CHandle<OperationExecutionData> NamedOperation
		{
			get => GetPropertyValue<CHandle<OperationExecutionData>>();
			set => SetPropertyValue<CHandle<OperationExecutionData>>(value);
		}

		public DelayedDeviceOperationTriggerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
