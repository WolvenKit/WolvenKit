using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceOperationsContainer : IScriptable
	{
		private CArray<CHandle<DeviceOperationBase>> _operations;
		private CArray<CHandle<DeviceOperationsTrigger>> _triggers;

		[Ordinal(0)] 
		[RED("operations")] 
		public CArray<CHandle<DeviceOperationBase>> Operations
		{
			get
			{
				if (_operations == null)
				{
					_operations = (CArray<CHandle<DeviceOperationBase>>) CR2WTypeManager.Create("array:handle:DeviceOperationBase", "operations", cr2w, this);
				}
				return _operations;
			}
			set
			{
				if (_operations == value)
				{
					return;
				}
				_operations = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("triggers")] 
		public CArray<CHandle<DeviceOperationsTrigger>> Triggers
		{
			get
			{
				if (_triggers == null)
				{
					_triggers = (CArray<CHandle<DeviceOperationsTrigger>>) CR2WTypeManager.Create("array:handle:DeviceOperationsTrigger", "triggers", cr2w, this);
				}
				return _triggers;
			}
			set
			{
				if (_triggers == value)
				{
					return;
				}
				_triggers = value;
				PropertySet(this);
			}
		}

		public DeviceOperationsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
