
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectAction : IScriptable
	{
		public gameEffectAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
