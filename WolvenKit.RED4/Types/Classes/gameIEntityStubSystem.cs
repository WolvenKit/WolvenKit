
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIEntityStubSystem : gameIGameSystem
	{
		public gameIEntityStubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
