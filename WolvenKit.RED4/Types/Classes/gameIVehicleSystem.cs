
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIVehicleSystem : gameIGameSystem
	{
		public gameIVehicleSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
