
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectPreAction : gameEffectAction
	{
		public gameEffectPreAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
