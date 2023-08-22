
namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformMovementLinear : gameIMovingPlatformMovementPointToPoint
	{
		public gameMovingPlatformMovementLinear()
		{
			InitData = new gameIMovingPlatformMovementInitData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
