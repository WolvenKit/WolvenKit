using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWorldGlobalLightParameters : RedBaseClass
	{
		private CEnum<ELightUnit> _unit;
		private CLegacySingleChannelCurve<HDRColor> _sunColor;
		private CLegacySingleChannelCurve<HDRColor> _moonColor;
		private CLegacySingleChannelCurve<CFloat> _sunSize;
		private CLegacySingleChannelCurve<CFloat> _moonSize;
		private CLegacySingleChannelCurve<HDRColor> _specularTint;

		[Ordinal(0)] 
		[RED("unit")] 
		public CEnum<ELightUnit> Unit
		{
			get => GetProperty(ref _unit);
			set => SetProperty(ref _unit, value);
		}

		[Ordinal(1)] 
		[RED("sunColor")] 
		public CLegacySingleChannelCurve<HDRColor> SunColor
		{
			get => GetProperty(ref _sunColor);
			set => SetProperty(ref _sunColor, value);
		}

		[Ordinal(2)] 
		[RED("moonColor")] 
		public CLegacySingleChannelCurve<HDRColor> MoonColor
		{
			get => GetProperty(ref _moonColor);
			set => SetProperty(ref _moonColor, value);
		}

		[Ordinal(3)] 
		[RED("sunSize")] 
		public CLegacySingleChannelCurve<CFloat> SunSize
		{
			get => GetProperty(ref _sunSize);
			set => SetProperty(ref _sunSize, value);
		}

		[Ordinal(4)] 
		[RED("moonSize")] 
		public CLegacySingleChannelCurve<CFloat> MoonSize
		{
			get => GetProperty(ref _moonSize);
			set => SetProperty(ref _moonSize, value);
		}

		[Ordinal(5)] 
		[RED("specularTint")] 
		public CLegacySingleChannelCurve<HDRColor> SpecularTint
		{
			get => GetProperty(ref _specularTint);
			set => SetProperty(ref _specularTint, value);
		}
	}
}
