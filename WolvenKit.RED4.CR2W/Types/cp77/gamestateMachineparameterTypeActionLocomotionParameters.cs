using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeActionLocomotionParameters : IScriptable
	{
		private CBool _imperfectTurn;
		private CBool _speedBoostInputRequired;
		private CBool _speedBoostMultiplyByDot;
		private CBool _useCameraHeadingForMovement;
		private CBool _validImperfectTurn;
		private CBool _validSpeedBoostInputRequired;
		private CBool _validSpeedBoostMultiplyByDot;
		private CBool _validUseCameraHeadingForMovement;
		private CBool _doJump;
		private CBool _doSpeedBoost;

		[Ordinal(0)] 
		[RED("imperfectTurn")] 
		public CBool ImperfectTurn
		{
			get => GetProperty(ref _imperfectTurn);
			set => SetProperty(ref _imperfectTurn, value);
		}

		[Ordinal(1)] 
		[RED("speedBoostInputRequired")] 
		public CBool SpeedBoostInputRequired
		{
			get => GetProperty(ref _speedBoostInputRequired);
			set => SetProperty(ref _speedBoostInputRequired, value);
		}

		[Ordinal(2)] 
		[RED("speedBoostMultiplyByDot")] 
		public CBool SpeedBoostMultiplyByDot
		{
			get => GetProperty(ref _speedBoostMultiplyByDot);
			set => SetProperty(ref _speedBoostMultiplyByDot, value);
		}

		[Ordinal(3)] 
		[RED("useCameraHeadingForMovement")] 
		public CBool UseCameraHeadingForMovement
		{
			get => GetProperty(ref _useCameraHeadingForMovement);
			set => SetProperty(ref _useCameraHeadingForMovement, value);
		}

		[Ordinal(4)] 
		[RED("validImperfectTurn")] 
		public CBool ValidImperfectTurn
		{
			get => GetProperty(ref _validImperfectTurn);
			set => SetProperty(ref _validImperfectTurn, value);
		}

		[Ordinal(5)] 
		[RED("validSpeedBoostInputRequired")] 
		public CBool ValidSpeedBoostInputRequired
		{
			get => GetProperty(ref _validSpeedBoostInputRequired);
			set => SetProperty(ref _validSpeedBoostInputRequired, value);
		}

		[Ordinal(6)] 
		[RED("validSpeedBoostMultiplyByDot")] 
		public CBool ValidSpeedBoostMultiplyByDot
		{
			get => GetProperty(ref _validSpeedBoostMultiplyByDot);
			set => SetProperty(ref _validSpeedBoostMultiplyByDot, value);
		}

		[Ordinal(7)] 
		[RED("validUseCameraHeadingForMovement")] 
		public CBool ValidUseCameraHeadingForMovement
		{
			get => GetProperty(ref _validUseCameraHeadingForMovement);
			set => SetProperty(ref _validUseCameraHeadingForMovement, value);
		}

		[Ordinal(8)] 
		[RED("doJump")] 
		public CBool DoJump
		{
			get => GetProperty(ref _doJump);
			set => SetProperty(ref _doJump, value);
		}

		[Ordinal(9)] 
		[RED("doSpeedBoost")] 
		public CBool DoSpeedBoost
		{
			get => GetProperty(ref _doSpeedBoost);
			set => SetProperty(ref _doSpeedBoost, value);
		}

		public gamestateMachineparameterTypeActionLocomotionParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
