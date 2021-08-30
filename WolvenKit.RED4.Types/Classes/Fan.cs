using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Fan : BasicDistractionDevice
	{
		private CEnum<EAnimationType> _animationType;
		private CBool _rotateClockwise;
		private CBool _randomizeBladesSpeed;
		private CFloat _maxRotationSpeed;
		private CFloat _timeToMaxRotation;
		private CHandle<AnimFeature_RotatingObject> _animFeature;
		private CHandle<UpdateComponent> _updateComp;

		[Ordinal(103)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(104)] 
		[RED("rotateClockwise")] 
		public CBool RotateClockwise
		{
			get => GetProperty(ref _rotateClockwise);
			set => SetProperty(ref _rotateClockwise, value);
		}

		[Ordinal(105)] 
		[RED("randomizeBladesSpeed")] 
		public CBool RandomizeBladesSpeed
		{
			get => GetProperty(ref _randomizeBladesSpeed);
			set => SetProperty(ref _randomizeBladesSpeed, value);
		}

		[Ordinal(106)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get => GetProperty(ref _maxRotationSpeed);
			set => SetProperty(ref _maxRotationSpeed, value);
		}

		[Ordinal(107)] 
		[RED("timeToMaxRotation")] 
		public CFloat TimeToMaxRotation
		{
			get => GetProperty(ref _timeToMaxRotation);
			set => SetProperty(ref _timeToMaxRotation, value);
		}

		[Ordinal(108)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RotatingObject> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(109)] 
		[RED("updateComp")] 
		public CHandle<UpdateComponent> UpdateComp
		{
			get => GetProperty(ref _updateComp);
			set => SetProperty(ref _updateComp, value);
		}

		public Fan()
		{
			_rotateClockwise = true;
			_maxRotationSpeed = 150.000000F;
			_timeToMaxRotation = 3.000000F;
		}
	}
}
