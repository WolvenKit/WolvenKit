using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_CameraBreathing : animAnimFeature
	{
		private CFloat _amplitudeWeight;
		private CFloat _dampIncreaseSpeed;
		private CFloat _dampDecreaseSpeed;

		[Ordinal(0)] 
		[RED("amplitudeWeight")] 
		public CFloat AmplitudeWeight
		{
			get => GetProperty(ref _amplitudeWeight);
			set => SetProperty(ref _amplitudeWeight, value);
		}

		[Ordinal(1)] 
		[RED("dampIncreaseSpeed")] 
		public CFloat DampIncreaseSpeed
		{
			get => GetProperty(ref _dampIncreaseSpeed);
			set => SetProperty(ref _dampIncreaseSpeed, value);
		}

		[Ordinal(2)] 
		[RED("dampDecreaseSpeed")] 
		public CFloat DampDecreaseSpeed
		{
			get => GetProperty(ref _dampDecreaseSpeed);
			set => SetProperty(ref _dampDecreaseSpeed, value);
		}
	}
}
