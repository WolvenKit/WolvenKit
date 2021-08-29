using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedDeviceOperationTriggerEvent : redEvent
	{
		private CHandle<DeviceOperationsTrigger> _triggerHandler;
		private CHandle<OperationExecutionData> _namedOperation;

		[Ordinal(0)] 
		[RED("triggerHandler")] 
		public CHandle<DeviceOperationsTrigger> TriggerHandler
		{
			get => GetProperty(ref _triggerHandler);
			set => SetProperty(ref _triggerHandler, value);
		}

		[Ordinal(1)] 
		[RED("namedOperation")] 
		public CHandle<OperationExecutionData> NamedOperation
		{
			get => GetProperty(ref _namedOperation);
			set => SetProperty(ref _namedOperation, value);
		}
	}
}
