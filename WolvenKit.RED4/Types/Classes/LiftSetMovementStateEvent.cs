using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LiftSetMovementStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("movementState")] 
		public CEnum<gamePlatformMovementState> MovementState
		{
			get => GetPropertyValue<CEnum<gamePlatformMovementState>>();
			set => SetPropertyValue<CEnum<gamePlatformMovementState>>(value);
		}

		public LiftSetMovementStateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
