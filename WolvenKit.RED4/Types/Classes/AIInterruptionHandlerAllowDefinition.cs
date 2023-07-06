
namespace WolvenKit.RED4.Types
{
	public partial class AIInterruptionHandlerAllowDefinition : AIInterruptionHandlerDefinition
	{
		public AIInterruptionHandlerAllowDefinition()
		{
			Signal = new AIInterruptionSignal { Importance = Enums.AIEInterruptionImportance.Casual };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
