
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAimAssistCommon_Record
	{
		[RED("aimAssistType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AimAssistType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("angleDistUnit")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleDistUnit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleDistUnitWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleDistUnitWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleProximityBonus")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleProximityBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleProximityThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleProximityThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("firstPassAngleRange")]
		[REDProperty(IsIgnored = true)]
		public EulerAngles FirstPassAngleRange
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}
		
		[RED("forceSoftLockMinimumWeight")]
		[REDProperty(IsIgnored = true)]
		public CBool ForceSoftLockMinimumWeight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isEnabled")]
		[REDProperty(IsIgnored = true)]
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isEnabledForMouse")]
		[REDProperty(IsIgnored = true)]
		public CBool IsEnabledForMouse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("pastTargetWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat PastTargetWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("primaryComponentsOnly")]
		[REDProperty(IsIgnored = true)]
		public CBool PrimaryComponentsOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("recentInputTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat RecentInputTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rotatingAwayFromPastTargetPenalty")]
		[REDProperty(IsIgnored = true)]
		public CFloat RotatingAwayFromPastTargetPenalty
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("softLockBrakeAngle")]
		[REDProperty(IsIgnored = true)]
		public EulerAngles SoftLockBrakeAngle
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}
		
		[RED("softLockTargetLostTimeOut")]
		[REDProperty(IsIgnored = true)]
		public CFloat SoftLockTargetLostTimeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("softLockTargetWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat SoftLockTargetWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("targetAcquisitionDelayTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat TargetAcquisitionDelayTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("targetFilter")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TargetFilter
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("targetFilterPriority")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TargetFilterPriority
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("targetFilterPriorityBonus")]
		[REDProperty(IsIgnored = true)]
		public CFloat TargetFilterPriorityBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("targetLostTimeOut")]
		[REDProperty(IsIgnored = true)]
		public CFloat TargetLostTimeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("worldDistUnit")]
		[REDProperty(IsIgnored = true)]
		public CFloat WorldDistUnit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("worldDistUnitWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat WorldDistUnitWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("worldProximityBonus")]
		[REDProperty(IsIgnored = true)]
		public CFloat WorldProximityBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("worldProximityThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat WorldProximityThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
