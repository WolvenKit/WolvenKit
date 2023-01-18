
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionSlideData_Record
	{
		[RED("directionAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat DirectionAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("disablePositionSlideAgainstNpc")]
		[REDProperty(IsIgnored = true)]
		public CBool DisablePositionSlideAgainstNpc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("distance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("finalRotationAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat FinalRotationAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("offsetAroundTarget")]
		[REDProperty(IsIgnored = true)]
		public CFloat OffsetAroundTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("offsetToTarget")]
		[REDProperty(IsIgnored = true)]
		public CFloat OffsetToTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("overrideOffsetToTargetFromWeapon")]
		[REDProperty(IsIgnored = true)]
		public CBool OverrideOffsetToTargetFromWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("positionPredictionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat PositionPredictionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("positionSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat PositionSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rotationSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat RotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slideStartDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat SlideStartDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("usePositionSlide")]
		[REDProperty(IsIgnored = true)]
		public CBool UsePositionSlide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("useRotationSlide")]
		[REDProperty(IsIgnored = true)]
		public CBool UseRotationSlide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("zAlignmentCollisionThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat ZAlignmentCollisionThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
