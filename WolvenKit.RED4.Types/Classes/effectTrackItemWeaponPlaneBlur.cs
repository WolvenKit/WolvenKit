using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemWeaponPlaneBlur : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("farPlaneMultiplier")] 
		public effectEffectParameterEvaluatorFloat FarPlaneMultiplier
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(4)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public effectTrackItemWeaponPlaneBlur()
		{
			TimeDuration = 1.000000F;
			FarPlaneMultiplier = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
