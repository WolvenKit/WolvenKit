using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LiftWidgetCustomData : WidgetCustomData
	{
		private CEnum<gamePlatformMovementState> _movementState;

		[Ordinal(0)] 
		[RED("movementState")] 
		public CEnum<gamePlatformMovementState> MovementState
		{
			get => GetProperty(ref _movementState);
			set => SetProperty(ref _movementState, value);
		}
	}
}
