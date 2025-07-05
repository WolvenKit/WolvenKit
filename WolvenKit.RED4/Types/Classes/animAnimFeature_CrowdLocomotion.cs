using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_CrowdLocomotion : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("slopeAngle")] 
		public CFloat SlopeAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("isCrowd")] 
		public CBool IsCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimFeature_CrowdLocomotion()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
