using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnOverrideReturnConditions_InterruptionScenarioOperation : scnIInterruptionScenarioOperation
	{
		[Ordinal(0)] 
		[RED("returnConditions")] 
		public CArray<CHandle<scnIReturnCondition>> ReturnConditions
		{
			get => GetPropertyValue<CArray<CHandle<scnIReturnCondition>>>();
			set => SetPropertyValue<CArray<CHandle<scnIReturnCondition>>>(value);
		}

		public scnOverrideReturnConditions_InterruptionScenarioOperation()
		{
			ReturnConditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
