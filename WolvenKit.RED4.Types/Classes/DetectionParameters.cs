using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DetectionParameters : RedBaseClass
	{
		private CBool _canDetectIntruders;
		private CFloat _timeToActionAfterSpot;
		private CFloat _overrideRootRotation;
		private CFloat _maxRotationAngle;
		private CFloat _pitchAngle;
		private CFloat _rotationSpeed;

		[Ordinal(0)] 
		[RED("canDetectIntruders")] 
		public CBool CanDetectIntruders
		{
			get => GetProperty(ref _canDetectIntruders);
			set => SetProperty(ref _canDetectIntruders, value);
		}

		[Ordinal(1)] 
		[RED("timeToActionAfterSpot")] 
		public CFloat TimeToActionAfterSpot
		{
			get => GetProperty(ref _timeToActionAfterSpot);
			set => SetProperty(ref _timeToActionAfterSpot, value);
		}

		[Ordinal(2)] 
		[RED("overrideRootRotation")] 
		public CFloat OverrideRootRotation
		{
			get => GetProperty(ref _overrideRootRotation);
			set => SetProperty(ref _overrideRootRotation, value);
		}

		[Ordinal(3)] 
		[RED("maxRotationAngle")] 
		public CFloat MaxRotationAngle
		{
			get => GetProperty(ref _maxRotationAngle);
			set => SetProperty(ref _maxRotationAngle, value);
		}

		[Ordinal(4)] 
		[RED("pitchAngle")] 
		public CFloat PitchAngle
		{
			get => GetProperty(ref _pitchAngle);
			set => SetProperty(ref _pitchAngle, value);
		}

		[Ordinal(5)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get => GetProperty(ref _rotationSpeed);
			set => SetProperty(ref _rotationSpeed, value);
		}

		public DetectionParameters()
		{
			_canDetectIntruders = true;
			_timeToActionAfterSpot = 2.000000F;
			_maxRotationAngle = 90.000000F;
			_pitchAngle = -15.000000F;
			_rotationSpeed = 5.000000F;
		}
	}
}
