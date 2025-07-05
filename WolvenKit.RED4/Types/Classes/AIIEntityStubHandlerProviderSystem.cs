
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIIEntityStubHandlerProviderSystem : gameIGameSystem
	{
		public AIIEntityStubHandlerProviderSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
