using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Drag : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("sourceBone")] 
		public animTransformIndex SourceBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("outTargetBone")] 
		public animTransformIndex OutTargetBone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("simulationFps")] 
		public CFloat SimulationFps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("sourceSpeedMultiplier")] 
		public CFloat SourceSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("hasOvershoot")] 
		public CBool HasOvershoot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("overshootDuration")] 
		public CFloat OvershootDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("overshootDetectionMinSpeed")] 
		public CFloat OvershootDetectionMinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("overshootDetectionMaxSpeed")] 
		public CFloat OvershootDetectionMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("useSteps")] 
		public CBool UseSteps
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("stepsTargetSpeedMultiplier")] 
		public CFloat StepsTargetSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("timeBetweenSteps")] 
		public CFloat TimeBetweenSteps
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("timeInStep")] 
		public CFloat TimeInStep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_Drag()
		{
			Id = 4294967295;
			InputLink = new();
			SourceBone = new();
			OutTargetBone = new();
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
