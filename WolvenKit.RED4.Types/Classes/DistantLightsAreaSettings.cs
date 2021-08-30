using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DistantLightsAreaSettings : IAreaSettings
	{
		private CFloat _distantLightStartDistance;
		private CFloat _distantLightFadeDistance;

		[Ordinal(2)] 
		[RED("distantLightStartDistance")] 
		public CFloat DistantLightStartDistance
		{
			get => GetProperty(ref _distantLightStartDistance);
			set => SetProperty(ref _distantLightStartDistance, value);
		}

		[Ordinal(3)] 
		[RED("distantLightFadeDistance")] 
		public CFloat DistantLightFadeDistance
		{
			get => GetProperty(ref _distantLightFadeDistance);
			set => SetProperty(ref _distantLightFadeDistance, value);
		}

		public DistantLightsAreaSettings()
		{
			_distantLightStartDistance = 50.000000F;
			_distantLightFadeDistance = 15.000000F;
		}
	}
}
