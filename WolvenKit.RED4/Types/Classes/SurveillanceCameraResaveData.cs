using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SurveillanceCameraResaveData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("maxRotationAngle")] 
		public CFloat MaxRotationAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("pitchAngle")] 
		public CFloat PitchAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("canStreamVideo")] 
		public CBool CanStreamVideo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("canDetectIntruders")] 
		public CBool CanDetectIntruders
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("canBeControled")] 
		public CBool CanBeControled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("factOnFeedReceived")] 
		public CName FactOnFeedReceived
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("questFactOnDetection")] 
		public CName QuestFactOnDetection
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SurveillanceCameraResaveData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
