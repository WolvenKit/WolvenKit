
namespace WolvenKit.RED4.Types
{
	public abstract partial class scnNPCStatusEffectsListener : gameIStatusEffectListener
	{
		public scnNPCStatusEffectsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
