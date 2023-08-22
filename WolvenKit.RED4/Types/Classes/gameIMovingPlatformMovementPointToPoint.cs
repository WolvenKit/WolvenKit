
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIMovingPlatformMovementPointToPoint : gameIMovingPlatformMovement
	{
		public gameIMovingPlatformMovementPointToPoint()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
