
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIInterruptionHandlerDenyDefinition : AIInterruptionHandlerDefinition
	{

		public AIInterruptionHandlerDenyDefinition()
		{
			Signal = new() { Importance = Enums.AIEInterruptionImportance.Casual };
		}
	}
}
