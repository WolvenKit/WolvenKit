using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionAnimationSlideParams : CVariable
	{
		private CFloat _distance;
		private CFloat _directionAngle;
		private CFloat _finalRotationAngle;
		private CFloat _offsetToTarget;
		private CFloat _offsetAroundTarget;
		private CBool _slideToTarget;
		private CFloat _duration;
		private CFloat _positionSpeed;
		private CFloat _rotationSpeed;
		private CFloat _maxSlidePositionDistance;
		private CFloat _maxSlideRotationAngle;
		private CFloat _slideStartDelay;
		private CBool _usePositionSlide;
		private CBool _useRotationSlide;
		private CFloat _maxTargetVelocity;
		private CFloat _zAlignmentThreshold;

		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(1)] 
		[RED("directionAngle")] 
		public CFloat DirectionAngle
		{
			get => GetProperty(ref _directionAngle);
			set => SetProperty(ref _directionAngle, value);
		}

		[Ordinal(2)] 
		[RED("finalRotationAngle")] 
		public CFloat FinalRotationAngle
		{
			get => GetProperty(ref _finalRotationAngle);
			set => SetProperty(ref _finalRotationAngle, value);
		}

		[Ordinal(3)] 
		[RED("offsetToTarget")] 
		public CFloat OffsetToTarget
		{
			get => GetProperty(ref _offsetToTarget);
			set => SetProperty(ref _offsetToTarget, value);
		}

		[Ordinal(4)] 
		[RED("offsetAroundTarget")] 
		public CFloat OffsetAroundTarget
		{
			get => GetProperty(ref _offsetAroundTarget);
			set => SetProperty(ref _offsetAroundTarget, value);
		}

		[Ordinal(5)] 
		[RED("slideToTarget")] 
		public CBool SlideToTarget
		{
			get => GetProperty(ref _slideToTarget);
			set => SetProperty(ref _slideToTarget, value);
		}

		[Ordinal(6)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(7)] 
		[RED("positionSpeed")] 
		public CFloat PositionSpeed
		{
			get => GetProperty(ref _positionSpeed);
			set => SetProperty(ref _positionSpeed, value);
		}

		[Ordinal(8)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get => GetProperty(ref _rotationSpeed);
			set => SetProperty(ref _rotationSpeed, value);
		}

		[Ordinal(9)] 
		[RED("maxSlidePositionDistance")] 
		public CFloat MaxSlidePositionDistance
		{
			get => GetProperty(ref _maxSlidePositionDistance);
			set => SetProperty(ref _maxSlidePositionDistance, value);
		}

		[Ordinal(10)] 
		[RED("maxSlideRotationAngle")] 
		public CFloat MaxSlideRotationAngle
		{
			get => GetProperty(ref _maxSlideRotationAngle);
			set => SetProperty(ref _maxSlideRotationAngle, value);
		}

		[Ordinal(11)] 
		[RED("slideStartDelay")] 
		public CFloat SlideStartDelay
		{
			get => GetProperty(ref _slideStartDelay);
			set => SetProperty(ref _slideStartDelay, value);
		}

		[Ordinal(12)] 
		[RED("usePositionSlide")] 
		public CBool UsePositionSlide
		{
			get => GetProperty(ref _usePositionSlide);
			set => SetProperty(ref _usePositionSlide, value);
		}

		[Ordinal(13)] 
		[RED("useRotationSlide")] 
		public CBool UseRotationSlide
		{
			get => GetProperty(ref _useRotationSlide);
			set => SetProperty(ref _useRotationSlide, value);
		}

		[Ordinal(14)] 
		[RED("maxTargetVelocity")] 
		public CFloat MaxTargetVelocity
		{
			get => GetProperty(ref _maxTargetVelocity);
			set => SetProperty(ref _maxTargetVelocity, value);
		}

		[Ordinal(15)] 
		[RED("zAlignmentThreshold")] 
		public CFloat ZAlignmentThreshold
		{
			get => GetProperty(ref _zAlignmentThreshold);
			set => SetProperty(ref _zAlignmentThreshold, value);
		}

		public gameActionAnimationSlideParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
