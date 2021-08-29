using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LightAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<CFloat> _latitude;
		private CEnum<ETimeOfYearSeason> _season;
		private CLegacySingleChannelCurve<CFloat> _sunRotationOffset;
		private CLegacySingleChannelCurve<HDRColor> _sunColor;
		private CLegacySingleChannelCurve<CFloat> _sunSize;
		private CLegacySingleChannelCurve<CFloat> _moonRotationOffset;
		private CLegacySingleChannelCurve<HDRColor> _moonColor;
		private CLegacySingleChannelCurve<CFloat> _moonSize;
		private CLegacySingleChannelCurve<HDRColor> _specularTint;

		[Ordinal(2)] 
		[RED("latitude")] 
		public CLegacySingleChannelCurve<CFloat> Latitude
		{
			get => GetProperty(ref _latitude);
			set => SetProperty(ref _latitude, value);
		}

		[Ordinal(3)] 
		[RED("season")] 
		public CEnum<ETimeOfYearSeason> Season
		{
			get => GetProperty(ref _season);
			set => SetProperty(ref _season, value);
		}

		[Ordinal(4)] 
		[RED("sunRotationOffset")] 
		public CLegacySingleChannelCurve<CFloat> SunRotationOffset
		{
			get => GetProperty(ref _sunRotationOffset);
			set => SetProperty(ref _sunRotationOffset, value);
		}

		[Ordinal(5)] 
		[RED("sunColor")] 
		public CLegacySingleChannelCurve<HDRColor> SunColor
		{
			get => GetProperty(ref _sunColor);
			set => SetProperty(ref _sunColor, value);
		}

		[Ordinal(6)] 
		[RED("sunSize")] 
		public CLegacySingleChannelCurve<CFloat> SunSize
		{
			get => GetProperty(ref _sunSize);
			set => SetProperty(ref _sunSize, value);
		}

		[Ordinal(7)] 
		[RED("moonRotationOffset")] 
		public CLegacySingleChannelCurve<CFloat> MoonRotationOffset
		{
			get => GetProperty(ref _moonRotationOffset);
			set => SetProperty(ref _moonRotationOffset, value);
		}

		[Ordinal(8)] 
		[RED("moonColor")] 
		public CLegacySingleChannelCurve<HDRColor> MoonColor
		{
			get => GetProperty(ref _moonColor);
			set => SetProperty(ref _moonColor, value);
		}

		[Ordinal(9)] 
		[RED("moonSize")] 
		public CLegacySingleChannelCurve<CFloat> MoonSize
		{
			get => GetProperty(ref _moonSize);
			set => SetProperty(ref _moonSize, value);
		}

		[Ordinal(10)] 
		[RED("specularTint")] 
		public CLegacySingleChannelCurve<HDRColor> SpecularTint
		{
			get => GetProperty(ref _specularTint);
			set => SetProperty(ref _specularTint, value);
		}
	}
}
