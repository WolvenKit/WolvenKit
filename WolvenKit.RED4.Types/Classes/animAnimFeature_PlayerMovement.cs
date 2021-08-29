using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_PlayerMovement : animAnimFeature_Movement
	{
		private Vector4 _facingDirection;
		private CFloat _verticalSpeed;
		private CFloat _movementDirectionHorizontalAngle;
		private CBool _inAir;
		private CFloat _standingTerrainAngle;

		[Ordinal(9)] 
		[RED("facingDirection")] 
		public Vector4 FacingDirection
		{
			get => GetProperty(ref _facingDirection);
			set => SetProperty(ref _facingDirection, value);
		}

		[Ordinal(10)] 
		[RED("verticalSpeed")] 
		public CFloat VerticalSpeed
		{
			get => GetProperty(ref _verticalSpeed);
			set => SetProperty(ref _verticalSpeed, value);
		}

		[Ordinal(11)] 
		[RED("movementDirectionHorizontalAngle")] 
		public CFloat MovementDirectionHorizontalAngle
		{
			get => GetProperty(ref _movementDirectionHorizontalAngle);
			set => SetProperty(ref _movementDirectionHorizontalAngle, value);
		}

		[Ordinal(12)] 
		[RED("inAir")] 
		public CBool InAir
		{
			get => GetProperty(ref _inAir);
			set => SetProperty(ref _inAir, value);
		}

		[Ordinal(13)] 
		[RED("standingTerrainAngle")] 
		public CFloat StandingTerrainAngle
		{
			get => GetProperty(ref _standingTerrainAngle);
			set => SetProperty(ref _standingTerrainAngle, value);
		}
	}
}
