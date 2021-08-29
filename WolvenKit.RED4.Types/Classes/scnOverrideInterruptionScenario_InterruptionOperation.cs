using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnOverrideInterruptionScenario_InterruptionOperation : scnIInterruptionOperation
	{
		private scnInterruptionScenarioId _scenarioId;
		private CArray<CHandle<scnIInterruptionScenarioOperation>> _scenarioOperations;

		[Ordinal(0)] 
		[RED("scenarioId")] 
		public scnInterruptionScenarioId ScenarioId
		{
			get => GetProperty(ref _scenarioId);
			set => SetProperty(ref _scenarioId, value);
		}

		[Ordinal(1)] 
		[RED("scenarioOperations")] 
		public CArray<CHandle<scnIInterruptionScenarioOperation>> ScenarioOperations
		{
			get => GetProperty(ref _scenarioOperations);
			set => SetProperty(ref _scenarioOperations, value);
		}
	}
}
