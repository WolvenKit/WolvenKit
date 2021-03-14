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
			get
			{
				if (_triggerHandler == null)
				{
					_triggerHandler = (CHandle<DeviceOperationsTrigger>) CR2WTypeManager.Create("handle:DeviceOperationsTrigger", "triggerHandler", cr2w, this);
				}
				return _triggerHandler;
			}
			set
			{
				if (_triggerHandler == value)
				{
					return;
				}
				_triggerHandler = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("namedOperation")] 
		public CHandle<OperationExecutionData> NamedOperation
		{
			get
			{
				if (_namedOperation == null)
				{
					_namedOperation = (CHandle<OperationExecutionData>) CR2WTypeManager.Create("handle:OperationExecutionData", "namedOperation", cr2w, this);
				}
				return _namedOperation;
			}
			set
			{
				if (_namedOperation == value)
				{
					return;
				}
				_namedOperation = value;
				PropertySet(this);
			}
		}

		public DelayedDeviceOperationTriggerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
