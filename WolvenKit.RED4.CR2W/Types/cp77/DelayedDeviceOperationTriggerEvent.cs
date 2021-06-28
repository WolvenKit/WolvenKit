using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedDeviceOperationTriggerEvent : redEvent
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

		public DelayedDeviceOperationTriggerEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
