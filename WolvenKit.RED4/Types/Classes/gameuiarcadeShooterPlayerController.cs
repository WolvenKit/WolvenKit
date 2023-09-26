
namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterPlayerController : gameuiarcadeArcadePlayerController
	{
		public gameuiarcadeShooterPlayerController()
		{
			ColliderList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
