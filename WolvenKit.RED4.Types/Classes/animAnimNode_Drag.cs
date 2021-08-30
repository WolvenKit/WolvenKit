using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Drag : animAnimNode_OnePoseInput
	{
		private animTransformIndex _sourceBone;
		private animTransformIndex _outTargetBone;
		private CFloat _simulationFps;
		private CFloat _sourceSpeedMultiplier;
		private CBool _hasOvershoot;
		private CFloat _overshootDuration;
		private CFloat _overshootDetectionMinSpeed;
		private CFloat _overshootDetectionMaxSpeed;
		private CBool _useSteps;
		private CFloat _stepsTargetSpeedMultiplier;
		private CFloat _timeBetweenSteps;
		private CFloat _timeInStep;

		[Ordinal(12)] 
		[RED("sourceBone")] 
		public animTransformIndex SourceBone
		{
			get => GetProperty(ref _sourceBone);
			set => SetProperty(ref _sourceBone, value);
		}

		[Ordinal(13)] 
		[RED("outTargetBone")] 
		public animTransformIndex OutTargetBone
		{
			get => GetProperty(ref _outTargetBone);
			set => SetProperty(ref _outTargetBone, value);
		}

		[Ordinal(14)] 
		[RED("simulationFps")] 
		public CFloat SimulationFps
		{
			get => GetProperty(ref _simulationFps);
			set => SetProperty(ref _simulationFps, value);
		}

		[Ordinal(15)] 
		[RED("sourceSpeedMultiplier")] 
		public CFloat SourceSpeedMultiplier
		{
			get => GetProperty(ref _sourceSpeedMultiplier);
			set => SetProperty(ref _sourceSpeedMultiplier, value);
		}

		[Ordinal(17)] 
		[RED("hasOvershoot")] 
		public CBool HasOvershoot
		{
			get => GetProperty(ref _hasOvershoot);
			set => SetProperty(ref _hasOvershoot, value);
		}

		[Ordinal(18)] 
		[RED("overshootDuration")] 
		public CFloat OvershootDuration
		{
			get => GetProperty(ref _overshootDuration);
			set => SetProperty(ref _overshootDuration, value);
		}

		[Ordinal(19)] 
		[RED("overshootDetectionMinSpeed")] 
		public CFloat OvershootDetectionMinSpeed
		{
			get => GetProperty(ref _overshootDetectionMinSpeed);
			set => SetProperty(ref _overshootDetectionMinSpeed, value);
		}

		[Ordinal(20)] 
		[RED("overshootDetectionMaxSpeed")] 
		public CFloat OvershootDetectionMaxSpeed
		{
			get => GetProperty(ref _overshootDetectionMaxSpeed);
			set => SetProperty(ref _overshootDetectionMaxSpeed, value);
		}

		[Ordinal(21)] 
		[RED("useSteps")] 
		public CBool UseSteps
		{
			get => GetProperty(ref _useSteps);
			set => SetProperty(ref _useSteps, value);
		}

		[Ordinal(22)] 
		[RED("stepsTargetSpeedMultiplier")] 
		public CFloat StepsTargetSpeedMultiplier
		{
			get => GetProperty(ref _stepsTargetSpeedMultiplier);
			set => SetProperty(ref _stepsTargetSpeedMultiplier, value);
		}

		[Ordinal(23)] 
		[RED("timeBetweenSteps")] 
		public CFloat TimeBetweenSteps
		{
			get => GetProperty(ref _timeBetweenSteps);
			set => SetProperty(ref _timeBetweenSteps, value);
		}

		[Ordinal(24)] 
		[RED("timeInStep")] 
		public CFloat TimeInStep
		{
			get => GetProperty(ref _timeInStep);
			set => SetProperty(ref _timeInStep, value);
		}

		public animAnimNode_Drag()
		{
			_simulationFps = 100.000000F;
			_sourceSpeedMultiplier = 10.000000F;
			_hasOvershoot = true;
			_overshootDuration = 1.000000F;
			_overshootDetectionMinSpeed = 0.400000F;
			_overshootDetectionMaxSpeed = 4.000000F;
			_stepsTargetSpeedMultiplier = 10000.000000F;
			_timeBetweenSteps = 0.100000F;
			_timeInStep = 0.100000F;
		}
	}
}
