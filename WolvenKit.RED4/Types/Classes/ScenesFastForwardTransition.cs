
namespace WolvenKit.RED4.Types
{
	public abstract partial class ScenesFastForwardTransition : DefaultTransition
	{
		public ScenesFastForwardTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
