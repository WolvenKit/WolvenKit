
namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformMovementLinear : gameIMovingPlatformMovementPointToPoint
	{
		public gameMovingPlatformMovementLinear()
		{
			InitData = new gameIMovingPlatformMovementInitData { InitType = (Enums.gameMovingPlatformMovementInitializationType)0 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
