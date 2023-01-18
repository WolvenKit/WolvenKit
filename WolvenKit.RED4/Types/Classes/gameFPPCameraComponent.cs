using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameFPPCameraComponent : gameCameraComponent
	{
		[Ordinal(35)] 
		[RED("pitchMin")] 
		public CFloat PitchMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("pitchMax")] 
		public CFloat PitchMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("yawMaxLeft")] 
		public CFloat YawMaxLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("yawMaxRight")] 
		public CFloat YawMaxRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("headingLocked")] 
		public CBool HeadingLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("sensitivityMultX")] 
		public CFloat SensitivityMultX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(41)] 
		[RED("sensitivityMultY")] 
		public CFloat SensitivityMultY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("timeDilationCurveName")] 
		public CName TimeDilationCurveName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameFPPCameraComponent()
		{
			Fov = 51.000000F;
			SensitivityMultX = 1.000000F;
			SensitivityMultY = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
