
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameITeleportationFacility : gameIGameSystem
	{
		public gameITeleportationFacility()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
