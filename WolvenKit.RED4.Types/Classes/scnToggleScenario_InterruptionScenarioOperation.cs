using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnToggleScenario_InterruptionScenarioOperation : scnIInterruptionScenarioOperation
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnToggleScenario_InterruptionScenarioOperation()
		{
			Enable = true;
		}
	}
}
