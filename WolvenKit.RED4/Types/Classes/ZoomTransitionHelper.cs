
namespace WolvenKit.RED4.Types
{
	public abstract partial class ZoomTransitionHelper : IScriptable
	{
		public ZoomTransitionHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
