using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceOperationTriggerData : IScriptable
	{
		private CArray<CHandle<OperationExecutionData>> _operationsToExecute;

		[Ordinal(0)] 
		[RED("operationsToExecute")] 
		public CArray<CHandle<OperationExecutionData>> OperationsToExecute
		{
			get
			{
				if (_operationsToExecute == null)
				{
					_operationsToExecute = (CArray<CHandle<OperationExecutionData>>) CR2WTypeManager.Create("array:handle:OperationExecutionData", "operationsToExecute", cr2w, this);
				}
				return _operationsToExecute;
			}
			set
			{
				if (_operationsToExecute == value)
				{
					return;
				}
				_operationsToExecute = value;
				PropertySet(this);
			}
		}

		public DeviceOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
