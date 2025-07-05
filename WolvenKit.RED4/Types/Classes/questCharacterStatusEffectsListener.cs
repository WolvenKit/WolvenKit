
namespace WolvenKit.RED4.Types
{
	public abstract partial class questCharacterStatusEffectsListener : gameIStatusEffectListener
	{
		public questCharacterStatusEffectsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
