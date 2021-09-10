using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_SweepMelee_Box : gameEffectObjectProvider_SweepOverTime
	{
		[Ordinal(1)] 
		[RED("playerStaticDetectionConeDistance")] 
		public CFloat PlayerStaticDetectionConeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("playerStaticDetectionConeStartAngle")] 
		public CFloat PlayerStaticDetectionConeStartAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("playerStaticDetectionConeEndAngle")] 
		public CFloat PlayerStaticDetectionConeEndAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("checkMeleeInvulnerability")] 
		public CBool CheckMeleeInvulnerability
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectObjectProvider_SweepMelee_Box()
		{
			PlayerStaticDetectionConeDistance = 2.000000F;
			PlayerStaticDetectionConeStartAngle = 5.000000F;
			PlayerStaticDetectionConeEndAngle = 18.000000F;
			CheckMeleeInvulnerability = true;
		}
	}
}
