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
			get => GetProperty(ref _operationsToExecute);
			set => SetProperty(ref _operationsToExecute, value);
		}

		public DeviceOperationTriggerData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
