using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformMovementStateChanged : redEvent
	{
		[Ordinal(0)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameMovingPlatformMovementStateChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
