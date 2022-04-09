using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DetectionParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("canDetectIntruders")] 
		public CBool CanDetectIntruders
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("timeToActionAfterSpot")] 
		public CFloat TimeToActionAfterSpot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("overrideRootRotation")] 
		public CFloat OverrideRootRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxRotationAngle")] 
		public CFloat MaxRotationAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("pitchAngle")] 
		public CFloat PitchAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DetectionParameters()
		{
			CanDetectIntruders = true;
			TimeToActionAfterSpot = 2.000000F;
			MaxRotationAngle = 90.000000F;
			PitchAngle = -15.000000F;
			RotationSpeed = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
