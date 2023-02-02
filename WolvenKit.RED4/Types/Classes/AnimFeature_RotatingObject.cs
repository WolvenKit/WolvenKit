using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_RotatingObject : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("rotateClockwise")] 
		public CBool RotateClockwise
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("randomizeBladesRotation")] 
		public CBool RandomizeBladesRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("timeToMaxRotation")] 
		public CFloat TimeToMaxRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_RotatingObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
