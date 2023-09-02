
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIStatusEffectListener : IScriptable
	{
		public gameIStatusEffectListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
