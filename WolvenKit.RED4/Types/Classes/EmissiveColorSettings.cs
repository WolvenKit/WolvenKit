using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EmissiveColorSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("tint")] 
		public CLegacySingleChannelCurve<HDRColor> Tint
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(3)] 
		[RED("saturation")] 
		public CLegacySingleChannelCurve<CFloat> Saturation
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("brigtness")] 
		public CLegacySingleChannelCurve<CFloat> Brigtness
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("exposure")] 
		public CLegacySingleChannelCurve<Vector2> Exposure
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<Vector2>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<Vector2>>(value);
		}

		[Ordinal(6)] 
		[RED("cameraLuminance")] 
		public CLegacySingleChannelCurve<Vector2> CameraLuminance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<Vector2>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<Vector2>>(value);
		}

		[Ordinal(7)] 
		[RED("evBlend")] 
		public CLegacySingleChannelCurve<CFloat> EvBlend
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(8)] 
		[RED("exposureIBL")] 
		public CLegacySingleChannelCurve<CFloat> ExposureIBL
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("luminanceIBL")] 
		public CLegacySingleChannelCurve<CFloat> LuminanceIBL
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(10)] 
		[RED("curveRampIBL")] 
		public CFloat CurveRampIBL
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("exposureScale")] 
		public CLegacySingleChannelCurve<CFloat> ExposureScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public EmissiveColorSettings()
		{
			Enable = true;
			CurveRampIBL = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
