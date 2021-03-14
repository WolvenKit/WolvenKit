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
			get
			{
				if (_operationHandler == null)
				{
					_operationHandler = (CHandle<DeviceOperations>) CR2WTypeManager.Create("handle:DeviceOperations", "operationHandler", cr2w, this);
				}
				return _operationHandler;
			}
			set
			{
				if (_operationHandler == value)
				{
					return;
				}
				_operationHandler = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (SBaseDeviceOperationData) CR2WTypeManager.Create("SBaseDeviceOperationData", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		public DelayedOperationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
