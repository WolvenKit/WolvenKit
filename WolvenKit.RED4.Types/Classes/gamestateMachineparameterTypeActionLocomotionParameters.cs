using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineparameterTypeActionLocomotionParameters : IScriptable
	{
		[Ordinal(0)] 
		[RED("imperfectTurn")] 
		public CBool ImperfectTurn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("speedBoostInputRequired")] 
		public CBool SpeedBoostInputRequired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("speedBoostMultiplyByDot")] 
		public CBool SpeedBoostMultiplyByDot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("useCameraHeadingForMovement")] 
		public CBool UseCameraHeadingForMovement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("validImperfectTurn")] 
		public CBool ValidImperfectTurn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("validSpeedBoostInputRequired")] 
		public CBool ValidSpeedBoostInputRequired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("validSpeedBoostMultiplyByDot")] 
		public CBool ValidSpeedBoostMultiplyByDot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("validUseCameraHeadingForMovement")] 
		public CBool ValidUseCameraHeadingForMovement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("doJump")] 
		public CBool DoJump
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("doSpeedBoost")] 
		public CBool DoSpeedBoost
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamestateMachineparameterTypeActionLocomotionParameters()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
