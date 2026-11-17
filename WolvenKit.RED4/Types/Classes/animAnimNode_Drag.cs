using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Drag : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("sourceBone")] 
		public animTransformIndex SourceBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("outTargetBone")] 
		public animTransformIndex OutTargetBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("simulationFps")] 
		public CFloat SimulationFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("sourceSpeedMultiplier")] 
		public CFloat SourceSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("hasOvershoot")] 
		public CBool HasOvershoot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("overshootDuration")] 
		public CFloat OvershootDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("overshootDetectionMinSpeed")] 
		public CFloat OvershootDetectionMinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("overshootDetectionMaxSpeed")] 
		public CFloat OvershootDetectionMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("useSteps")] 
		public CBool UseSteps
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("stepsTargetSpeedMultiplier")] 
		public CFloat StepsTargetSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("timeBetweenSteps")] 
		public CFloat TimeBetweenSteps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("timeInStep")] 
		public CFloat TimeInStep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_Drag()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			SourceBone = new animTransformIndex();
			OutTargetBone = new animTransformIndex();
			SimulationFps = 100.000000F;
			SourceSpeedMultiplier = 10.000000F;
			HasOvershoot = true;
			OvershootDuration = 1.000000F;
			OvershootDetectionMinSpeed = 0.400000F;
			OvershootDetectionMaxSpeed = 4.000000F;
			StepsTargetSpeedMultiplier = 10000.000000F;
			TimeBetweenSteps = 0.100000F;
			TimeInStep = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
