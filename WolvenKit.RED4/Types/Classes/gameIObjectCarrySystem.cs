
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIObjectCarrySystem : gameIGameSystem
	{
		public gameIObjectCarrySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
