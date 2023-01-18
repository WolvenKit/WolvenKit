
namespace WolvenKit.RED4.Types
{
	public partial class CDebugConsole : IDebugConsole
	{
		public CDebugConsole()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
