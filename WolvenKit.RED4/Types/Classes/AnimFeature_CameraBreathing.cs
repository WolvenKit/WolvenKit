using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_CameraBreathing : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("amplitudeWeight")] 
		public CFloat AmplitudeWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("dampIncreaseSpeed")] 
		public CFloat DampIncreaseSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("dampDecreaseSpeed")] 
		public CFloat DampDecreaseSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_CameraBreathing()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
