
namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeTankProjectileSpawnerController : gameuiarcadeArcadeSpawnerController
	{
		public gameuiarcadeTankProjectileSpawnerController()
		{
			ObjectLibraryID = "Projectile";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
