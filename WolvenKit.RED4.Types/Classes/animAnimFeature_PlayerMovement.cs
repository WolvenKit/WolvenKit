using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_PlayerMovement : animAnimFeature_Movement
	{
		[Ordinal(9)] 
		[RED("facingDirection")] 
		public Vector4 FacingDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(10)] 
		[RED("verticalSpeed")] 
		public CFloat VerticalSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("movementDirectionHorizontalAngle")] 
		public CFloat MovementDirectionHorizontalAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("inAir")] 
		public CBool InAir
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("standingTerrainAngle")] 
		public CFloat StandingTerrainAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimFeature_PlayerMovement()
		{
			FacingDirection = new() { Y = 1.000000F, W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
