
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIRenderGameplayEffectsManagerSystem : gameIGameSystem
	{
		public gameIRenderGameplayEffectsManagerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
