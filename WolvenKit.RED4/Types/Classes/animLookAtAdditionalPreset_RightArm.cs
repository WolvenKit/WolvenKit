using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtAdditionalPreset_RightArm : animLookAtAdditionalPreset
	{
		[Ordinal(0)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animLookAtAdditionalPreset_RightArm()
		{
			SoftLimitAngle = 360.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
