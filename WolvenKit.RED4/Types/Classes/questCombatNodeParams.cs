
namespace WolvenKit.RED4.Types
{
	public abstract partial class questCombatNodeParams : questAICommandParams
	{
		public questCombatNodeParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
