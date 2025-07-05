
namespace WolvenKit.RED4.Types
{
	public abstract partial class tickITimeDilationListener : IScriptable
	{
		public tickITimeDilationListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
