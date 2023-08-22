
namespace WolvenKit.RED4.Types
{
	public partial class AIInterruptionHandlerDenyDefinition : AIInterruptionHandlerDefinition
	{
		public AIInterruptionHandlerDenyDefinition()
		{
			Signal = new AIInterruptionSignal { Importance = Enums.AIEInterruptionImportance.Casual };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
