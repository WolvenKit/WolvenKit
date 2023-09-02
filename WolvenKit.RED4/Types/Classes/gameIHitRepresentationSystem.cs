
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIHitRepresentationSystem : gameIGameSystem
	{
		public gameIHitRepresentationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
