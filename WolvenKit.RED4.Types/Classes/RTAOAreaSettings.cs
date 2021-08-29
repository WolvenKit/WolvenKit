using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RTAOAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<CFloat> _rangeNear;
		private CLegacySingleChannelCurve<CFloat> _rangeFar;
		private CLegacySingleChannelCurve<CFloat> _radiusNear;
		private CLegacySingleChannelCurve<CFloat> _radiusFar;
		private CLegacySingleChannelCurve<CFloat> _coneAoDiffuseStrength;
		private CLegacySingleChannelCurve<CFloat> _coneAoSpecularStrength;
		private CLegacySingleChannelCurve<CFloat> _coneAoSpecularTreshold;
		private CLegacySingleChannelCurve<CFloat> _lightAoDiffuseStrength;
		private CLegacySingleChannelCurve<CFloat> _lightAoSpecularStrength;

		[Ordinal(2)] 
		[RED("RangeNear")] 
		public CLegacySingleChannelCurve<CFloat> RangeNear
		{
			get => GetProperty(ref _rangeNear);
			set => SetProperty(ref _rangeNear, value);
		}

		[Ordinal(3)] 
		[RED("RangeFar")] 
		public CLegacySingleChannelCurve<CFloat> RangeFar
		{
			get => GetProperty(ref _rangeFar);
			set => SetProperty(ref _rangeFar, value);
		}

		[Ordinal(4)] 
		[RED("RadiusNear")] 
		public CLegacySingleChannelCurve<CFloat> RadiusNear
		{
			get => GetProperty(ref _radiusNear);
			set => SetProperty(ref _radiusNear, value);
		}

		[Ordinal(5)] 
		[RED("RadiusFar")] 
		public CLegacySingleChannelCurve<CFloat> RadiusFar
		{
			get => GetProperty(ref _radiusFar);
			set => SetProperty(ref _radiusFar, value);
		}

		[Ordinal(6)] 
		[RED("coneAoDiffuseStrength")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoDiffuseStrength
		{
			get => GetProperty(ref _coneAoDiffuseStrength);
			set => SetProperty(ref _coneAoDiffuseStrength, value);
		}

		[Ordinal(7)] 
		[RED("coneAoSpecularStrength")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoSpecularStrength
		{
			get => GetProperty(ref _coneAoSpecularStrength);
			set => SetProperty(ref _coneAoSpecularStrength, value);
		}

		[Ordinal(8)] 
		[RED("coneAoSpecularTreshold")] 
		public CLegacySingleChannelCurve<CFloat> ConeAoSpecularTreshold
		{
			get => GetProperty(ref _coneAoSpecularTreshold);
			set => SetProperty(ref _coneAoSpecularTreshold, value);
		}

		[Ordinal(9)] 
		[RED("lightAoDiffuseStrength")] 
		public CLegacySingleChannelCurve<CFloat> LightAoDiffuseStrength
		{
			get => GetProperty(ref _lightAoDiffuseStrength);
			set => SetProperty(ref _lightAoDiffuseStrength, value);
		}

		[Ordinal(10)] 
		[RED("lightAoSpecularStrength")] 
		public CLegacySingleChannelCurve<CFloat> LightAoSpecularStrength
		{
			get => GetProperty(ref _lightAoSpecularStrength);
			set => SetProperty(ref _lightAoSpecularStrength, value);
		}
	}
}
