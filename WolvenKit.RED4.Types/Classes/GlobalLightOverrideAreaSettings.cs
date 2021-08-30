using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GlobalLightOverrideAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<HDRColor> _color;
		private CFloat _lightAzimuth;
		private CFloat _lightElevation;

		[Ordinal(2)] 
		[RED("color")] 
		public CLegacySingleChannelCurve<HDRColor> Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(3)] 
		[RED("lightAzimuth")] 
		public CFloat LightAzimuth
		{
			get => GetProperty(ref _lightAzimuth);
			set => SetProperty(ref _lightAzimuth, value);
		}

		[Ordinal(4)] 
		[RED("lightElevation")] 
		public CFloat LightElevation
		{
			get => GetProperty(ref _lightElevation);
			set => SetProperty(ref _lightElevation, value);
		}

		public GlobalLightOverrideAreaSettings()
		{
			_lightAzimuth = 45.000000F;
			_lightElevation = 45.000000F;
		}
	}
}
