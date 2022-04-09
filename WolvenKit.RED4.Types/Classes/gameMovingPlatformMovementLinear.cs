
namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformMovementLinear : gameIMovingPlatformMovementPointToPoint
	{
		public gameMovingPlatformMovementLinear()
		{
			InitData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
