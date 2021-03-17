using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedOperationEvent : redEvent
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

		public DelayedOperationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
