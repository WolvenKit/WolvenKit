
namespace WolvenKit.RED4.Types
{
	public abstract partial class vehicleIRacingSystem : gameIGameSystem
	{
		public vehicleIRacingSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
