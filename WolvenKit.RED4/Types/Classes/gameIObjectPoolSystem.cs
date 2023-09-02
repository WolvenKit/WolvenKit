
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIObjectPoolSystem : gameIGameSystem
	{
		public gameIObjectPoolSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
