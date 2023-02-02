using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtAdditionalPreset_BothArms : animLookAtAdditionalPreset
	{
		[Ordinal(0)] 
		[RED("rightHanded")] 
		public CBool RightHanded
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

		public animLookAtAdditionalPreset_BothArms()
		{
			RightHanded = true;
			SoftLimitAngle = 360.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
