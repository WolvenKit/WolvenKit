using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceOperationTriggerData : IScriptable
	{
		private CArray<CHandle<OperationExecutionData>> _operationsToExecute;

		[Ordinal(0)] 
		[RED("operationsToExecute")] 
		public CArray<CHandle<OperationExecutionData>> OperationsToExecute
		{
			get => GetProperty(ref _operationsToExecute);
			set => SetProperty(ref _operationsToExecute, value);
		}
	}
}
