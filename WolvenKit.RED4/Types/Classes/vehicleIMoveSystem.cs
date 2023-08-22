
namespace WolvenKit.RED4.Types
{
	public abstract partial class vehicleIMoveSystem : gameIGameSystem
	{
		public vehicleIMoveSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
