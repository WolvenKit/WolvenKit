
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICombatTargetHelper : IScriptable
	{
		public AICombatTargetHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
