
namespace WolvenKit.RED4.Types
{
	public abstract partial class IDebugConsole : RedBaseClass
	{
		public IDebugConsole()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
