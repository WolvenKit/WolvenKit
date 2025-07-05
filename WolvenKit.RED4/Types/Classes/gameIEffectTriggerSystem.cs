
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIEffectTriggerSystem : gameIGameSystem
	{
		public gameIEffectTriggerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
