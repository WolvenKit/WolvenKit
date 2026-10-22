
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameCallbackSystemTarget : IScriptable
	{
		public gameCallbackSystemTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
