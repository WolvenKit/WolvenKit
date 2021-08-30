using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EmissiveColorSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<HDRColor> _tint;
		private CLegacySingleChannelCurve<CFloat> _saturation;
		private CLegacySingleChannelCurve<CFloat> _brigtness;
		private CLegacySingleChannelCurve<Vector2> _exposure;
		private CLegacySingleChannelCurve<Vector2> _cameraLuminance;
		private CLegacySingleChannelCurve<CFloat> _evBlend;
		private CLegacySingleChannelCurve<CFloat> _exposureIBL;
		private CLegacySingleChannelCurve<CFloat> _luminanceIBL;
		private CFloat _curveRampIBL;
		private CLegacySingleChannelCurve<CFloat> _exposureScale;

		[Ordinal(2)] 
		[RED("tint")] 
		public CLegacySingleChannelCurve<HDRColor> Tint
		{
			get => GetProperty(ref _tint);
			set => SetProperty(ref _tint, value);
		}

		[Ordinal(3)] 
		[RED("saturation")] 
		public CLegacySingleChannelCurve<CFloat> Saturation
		{
			get => GetProperty(ref _saturation);
			set => SetProperty(ref _saturation, value);
		}

		[Ordinal(4)] 
		[RED("brigtness")] 
		public CLegacySingleChannelCurve<CFloat> Brigtness
		{
			get => GetProperty(ref _brigtness);
			set => SetProperty(ref _brigtness, value);
		}

		[Ordinal(5)] 
		[RED("exposure")] 
		public CLegacySingleChannelCurve<Vector2> Exposure
		{
			get => GetProperty(ref _exposure);
			set => SetProperty(ref _exposure, value);
		}

		[Ordinal(6)] 
		[RED("cameraLuminance")] 
		public CLegacySingleChannelCurve<Vector2> CameraLuminance
		{
			get => GetProperty(ref _cameraLuminance);
			set => SetProperty(ref _cameraLuminance, value);
		}

		[Ordinal(7)] 
		[RED("evBlend")] 
		public CLegacySingleChannelCurve<CFloat> EvBlend
		{
			get => GetProperty(ref _evBlend);
			set => SetProperty(ref _evBlend, value);
		}

		[Ordinal(8)] 
		[RED("exposureIBL")] 
		public CLegacySingleChannelCurve<CFloat> ExposureIBL
		{
			get => GetProperty(ref _exposureIBL);
			set => SetProperty(ref _exposureIBL, value);
		}

		[Ordinal(9)] 
		[RED("luminanceIBL")] 
		public CLegacySingleChannelCurve<CFloat> LuminanceIBL
		{
			get => GetProperty(ref _luminanceIBL);
			set => SetProperty(ref _luminanceIBL, value);
		}

		[Ordinal(10)] 
		[RED("curveRampIBL")] 
		public CFloat CurveRampIBL
		{
			get => GetProperty(ref _curveRampIBL);
			set => SetProperty(ref _curveRampIBL, value);
		}

		[Ordinal(11)] 
		[RED("exposureScale")] 
		public CLegacySingleChannelCurve<CFloat> ExposureScale
		{
			get => GetProperty(ref _exposureScale);
			set => SetProperty(ref _exposureScale, value);
		}

		public EmissiveColorSettings()
		{
			_curveRampIBL = 2.000000F;
		}
	}
}
