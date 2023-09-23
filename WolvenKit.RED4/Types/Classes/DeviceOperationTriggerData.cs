using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceOperationTriggerData : IScriptable
	{
		[Ordinal(0)] 
		[RED("operationsToExecute")] 
		public CArray<CHandle<OperationExecutionData>> OperationsToExecute
		{
			get => GetPropertyValue<CArray<CHandle<OperationExecutionData>>>();
			set => SetPropertyValue<CArray<CHandle<OperationExecutionData>>>(value);
		}

		public DeviceOperationTriggerData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
