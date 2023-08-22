
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIISmartObjectManager : gameIGameSystem
	{
		public AIISmartObjectManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
