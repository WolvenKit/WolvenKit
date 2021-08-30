using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ImageBasedFlareAreaSettings : IAreaSettings
	{
		private CFloat _treshold;
		private CFloat _dispersal;
		private CFloat _haloWidth;
		private CFloat _distortion;
		private CFloat _curve;
		private CArrayFixedSize<CColor> _tint;
		private CLegacySingleChannelCurve<CFloat> _scale;
		private CLegacySingleChannelCurve<CFloat> _saturation;

		[Ordinal(2)] 
		[RED("treshold")] 
		public CFloat Treshold
		{
			get => GetProperty(ref _treshold);
			set => SetProperty(ref _treshold, value);
		}

		[Ordinal(3)] 
		[RED("dispersal")] 
		public CFloat Dispersal
		{
			get => GetProperty(ref _dispersal);
			set => SetProperty(ref _dispersal, value);
		}

		[Ordinal(4)] 
		[RED("haloWidth")] 
		public CFloat HaloWidth
		{
			get => GetProperty(ref _haloWidth);
			set => SetProperty(ref _haloWidth, value);
		}

		[Ordinal(5)] 
		[RED("distortion")] 
		public CFloat Distortion
		{
			get => GetProperty(ref _distortion);
			set => SetProperty(ref _distortion, value);
		}

		[Ordinal(6)] 
		[RED("curve")] 
		public CFloat Curve
		{
			get => GetProperty(ref _curve);
			set => SetProperty(ref _curve, value);
		}

		[Ordinal(7)] 
		[RED("tint", 8)] 
		public CArrayFixedSize<CColor> Tint
		{
			get => GetProperty(ref _tint);
			set => SetProperty(ref _tint, value);
		}

		[Ordinal(8)] 
		[RED("scale")] 
		public CLegacySingleChannelCurve<CFloat> Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(9)] 
		[RED("saturation")] 
		public CLegacySingleChannelCurve<CFloat> Saturation
		{
			get => GetProperty(ref _saturation);
			set => SetProperty(ref _saturation, value);
		}

		public ImageBasedFlareAreaSettings()
		{
			_treshold = 2.000000F;
			_dispersal = 0.300000F;
			_haloWidth = 0.550000F;
			_distortion = 1.000000F;
			_curve = 1.000000F;
		}
	}
}
