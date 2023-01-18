
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAimAssistMagnetism_Record
	{
		[RED("blendOffTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlendOffTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("blendOnTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlendOnTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("checkWeaponEffectiveRange")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckWeaponEffectiveRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("disableWithNoInput")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableWithNoInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("distanceMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CName DistanceMultiplier
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("fullStickThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat FullStickThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("fullStickYawAngleDisable")]
		[REDProperty(IsIgnored = true)]
		public CFloat FullStickYawAngleDisable
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isEnabled")]
		[REDProperty(IsIgnored = true)]
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("maxStrength")]
		[REDProperty(IsIgnored = true)]
		public Vector2 MaxStrength
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("maxTimeTillOffTarget")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxTimeTillOffTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minTimeTillOffTarget")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinTimeTillOffTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pitchBoundAdditiveForYawMagnetism")]
		[REDProperty(IsIgnored = true)]
		public CFloat PitchBoundAdditiveForYawMagnetism
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("softLockTimeToReach")]
		[REDProperty(IsIgnored = true)]
		public CFloat SoftLockTimeToReach
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("stickInputMagMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CName StickInputMagMultiplier
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("targetLostBlendOut")]
		[REDProperty(IsIgnored = true)]
		public CBool TargetLostBlendOut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("yawBoundAdditiveForPitchMagnetism")]
		[REDProperty(IsIgnored = true)]
		public CFloat YawBoundAdditiveForPitchMagnetism
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
