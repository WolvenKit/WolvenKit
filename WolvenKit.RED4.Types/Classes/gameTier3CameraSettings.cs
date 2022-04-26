using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTier3CameraSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("yawLeftLimit")] 
		public CFloat YawLeftLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("yawRightLimit")] 
		public CFloat YawRightLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("pitchTopLimit")] 
		public CFloat PitchTopLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("pitchBottomLimit")] 
		public CFloat PitchBottomLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("pitchSpeedMultiplier")] 
		public CFloat PitchSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("yawSpeedMultiplier")] 
		public CFloat YawSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameTier3CameraSettings()
		{
			YawLeftLimit = 60.000000F;
			YawRightLimit = 60.000000F;
			PitchTopLimit = 60.000000F;
			PitchBottomLimit = 45.000000F;
			PitchSpeedMultiplier = 1.000000F;
			YawSpeedMultiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
