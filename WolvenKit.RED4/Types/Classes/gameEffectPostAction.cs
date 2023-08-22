
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectPostAction : gameEffectAction
	{
		public gameEffectPostAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
