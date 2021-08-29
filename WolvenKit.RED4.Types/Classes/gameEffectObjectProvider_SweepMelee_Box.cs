using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_SweepMelee_Box : gameEffectObjectProvider_SweepOverTime
	{
		private CFloat _playerStaticDetectionConeDistance;
		private CFloat _playerStaticDetectionConeStartAngle;
		private CFloat _playerStaticDetectionConeEndAngle;
		private CBool _checkMeleeInvulnerability;

		[Ordinal(1)] 
		[RED("playerStaticDetectionConeDistance")] 
		public CFloat PlayerStaticDetectionConeDistance
		{
			get => GetProperty(ref _playerStaticDetectionConeDistance);
			set => SetProperty(ref _playerStaticDetectionConeDistance, value);
		}

		[Ordinal(2)] 
		[RED("playerStaticDetectionConeStartAngle")] 
		public CFloat PlayerStaticDetectionConeStartAngle
		{
			get => GetProperty(ref _playerStaticDetectionConeStartAngle);
			set => SetProperty(ref _playerStaticDetectionConeStartAngle, value);
		}

		[Ordinal(3)] 
		[RED("playerStaticDetectionConeEndAngle")] 
		public CFloat PlayerStaticDetectionConeEndAngle
		{
			get => GetProperty(ref _playerStaticDetectionConeEndAngle);
			set => SetProperty(ref _playerStaticDetectionConeEndAngle, value);
		}

		[Ordinal(4)] 
		[RED("checkMeleeInvulnerability")] 
		public CBool CheckMeleeInvulnerability
		{
			get => GetProperty(ref _checkMeleeInvulnerability);
			set => SetProperty(ref _checkMeleeInvulnerability, value);
		}
	}
}
