
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleBurnOut_Record
	{
		[RED("burnOutGripBonus")]
		[REDProperty(IsIgnored = true)]
		public CFloat BurnOutGripBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("gripBonusMaxLaunchSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat GripBonusMaxLaunchSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("gripBonusMaxSpeedMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat GripBonusMaxSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lateralAccelForwardSpeedMaxDecimation")]
		[REDProperty(IsIgnored = true)]
		public CFloat LateralAccelForwardSpeedMaxDecimation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lateralForceMaxAcceleration")]
		[REDProperty(IsIgnored = true)]
		public CFloat LateralForceMaxAcceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lateralForceMaxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat LateralForceMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lateralSlipRatioInfluence")]
		[REDProperty(IsIgnored = true)]
		public CFloat LateralSlipRatioInfluence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxBrakeForceModifier")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxBrakeForceModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxDriveWheelSlipRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxDriveWheelSlipRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxLateralAccelSlipRatioMultipler")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxLateralAccelSlipRatioMultipler
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxLongFrictionSlipRatioMultipler")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxLongFrictionSlipRatioMultipler
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxSpeedToInitiateBurnOut")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxSpeedToInitiateBurnOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minBrakeForceModifier")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinBrakeForceModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minLongFrictionCoeff")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinLongFrictionCoeff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minLongFrictionSlipRatioScaled")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinLongFrictionSlipRatioScaled
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
