
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIObjectSelectionManagerInterface : gameIGameSystem
	{
		public AIObjectSelectionManagerInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
