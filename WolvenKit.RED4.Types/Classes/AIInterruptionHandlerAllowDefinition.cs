
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIInterruptionHandlerAllowDefinition : AIInterruptionHandlerDefinition
	{

		public AIInterruptionHandlerAllowDefinition()
		{
			Signal = new() { Importance = Enums.AIEInterruptionImportance.Casual };
		}
	}
}
