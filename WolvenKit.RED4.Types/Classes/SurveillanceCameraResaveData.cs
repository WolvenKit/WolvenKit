using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SurveillanceCameraResaveData : RedBaseClass
	{
		private CBool _shouldRotate;
		private CFloat _maxRotationAngle;
		private CFloat _pitchAngle;
		private CFloat _rotationSpeed;
		private CBool _canStreamVideo;
		private CBool _canDetectIntruders;
		private CBool _canBeControled;
		private CName _factOnFeedReceived;
		private CName _questFactOnDetection;

		[Ordinal(0)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get => GetProperty(ref _shouldRotate);
			set => SetProperty(ref _shouldRotate, value);
		}

		[Ordinal(1)] 
		[RED("maxRotationAngle")] 
		public CFloat MaxRotationAngle
		{
			get => GetProperty(ref _maxRotationAngle);
			set => SetProperty(ref _maxRotationAngle, value);
		}

		[Ordinal(2)] 
		[RED("pitchAngle")] 
		public CFloat PitchAngle
		{
			get => GetProperty(ref _pitchAngle);
			set => SetProperty(ref _pitchAngle, value);
		}

		[Ordinal(3)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get => GetProperty(ref _rotationSpeed);
			set => SetProperty(ref _rotationSpeed, value);
		}

		[Ordinal(4)] 
		[RED("canStreamVideo")] 
		public CBool CanStreamVideo
		{
			get => GetProperty(ref _canStreamVideo);
			set => SetProperty(ref _canStreamVideo, value);
		}

		[Ordinal(5)] 
		[RED("canDetectIntruders")] 
		public CBool CanDetectIntruders
		{
			get => GetProperty(ref _canDetectIntruders);
			set => SetProperty(ref _canDetectIntruders, value);
		}

		[Ordinal(6)] 
		[RED("canBeControled")] 
		public CBool CanBeControled
		{
			get => GetProperty(ref _canBeControled);
			set => SetProperty(ref _canBeControled, value);
		}

		[Ordinal(7)] 
		[RED("factOnFeedReceived")] 
		public CName FactOnFeedReceived
		{
			get => GetProperty(ref _factOnFeedReceived);
			set => SetProperty(ref _factOnFeedReceived, value);
		}

		[Ordinal(8)] 
		[RED("questFactOnDetection")] 
		public CName QuestFactOnDetection
		{
			get => GetProperty(ref _questFactOnDetection);
			set => SetProperty(ref _questFactOnDetection, value);
		}
	}
}
