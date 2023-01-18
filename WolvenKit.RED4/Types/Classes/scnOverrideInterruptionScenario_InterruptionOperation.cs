using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnOverrideInterruptionScenario_InterruptionOperation : scnIInterruptionOperation
	{
		[Ordinal(0)] 
		[RED("scenarioId")] 
		public scnInterruptionScenarioId ScenarioId
		{
			get => GetPropertyValue<scnInterruptionScenarioId>();
			set => SetPropertyValue<scnInterruptionScenarioId>(value);
		}

		[Ordinal(1)] 
		[RED("scenarioOperations")] 
		public CArray<CHandle<scnIInterruptionScenarioOperation>> ScenarioOperations
		{
			get => GetPropertyValue<CArray<CHandle<scnIInterruptionScenarioOperation>>>();
			set => SetPropertyValue<CArray<CHandle<scnIInterruptionScenarioOperation>>>(value);
		}

		public scnOverrideInterruptionScenario_InterruptionOperation()
		{
			ScenarioId = new() { Id = 4294967295 };
			ScenarioOperations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
