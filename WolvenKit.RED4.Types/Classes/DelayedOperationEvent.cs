using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedOperationEvent : redEvent
	{
		private CHandle<DeviceOperations> _operationHandler;
		private SBaseDeviceOperationData _operation;

		[Ordinal(0)] 
		[RED("operationHandler")] 
		public CHandle<DeviceOperations> OperationHandler
		{
			get => GetProperty(ref _operationHandler);
			set => SetProperty(ref _operationHandler, value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}
	}
}
