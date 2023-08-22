
namespace WolvenKit.RED4.Types
{
	public abstract partial class FunctionalTestsIGameSystem : gameIGameSystem
	{
		public FunctionalTestsIGameSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
