
namespace WolvenKit.RED4.Types
{
	public partial class AIInterruptionHandlerDenyDefinition : AIInterruptionHandlerDefinition
	{
		public AIInterruptionHandlerDenyDefinition()
		{
			Signal = new() { Importance = Enums.AIEInterruptionImportance.Casual };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
