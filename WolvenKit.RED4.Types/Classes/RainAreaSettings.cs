using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RainAreaSettings : IAreaSettings
	{
		private CUInt32 _numParticles;
		private CFloat _radius;
		private CFloat _heightRange;
		private CFloat _globalLightResponse;
		private CLegacySingleChannelCurve<CFloat> _tiling;
		private CFloat _porosityThresholdStart;
		private CFloat _porosityThresholdEnd;
		private CFloat _glossinessFactor;
		private CFloat _baseColorFactor;
		private CFloat _moistureAccumulationSpeed;
		private CFloat _puddlesAccumulationSpeed;
		private CFloat _moistureEvaporationSpeed;
		private CFloat _puddlesEvaporationSpeed;
		private CLegacySingleChannelCurve<CFloat> _rainIntensity;
		private CLegacySingleChannelCurve<CFloat> _rainOverride;
		private CLegacySingleChannelCurve<CFloat> _rainMoistureOverride;
		private CLegacySingleChannelCurve<CFloat> _rainPuddlesOverride;
		private CResourceReference<CBitmapTexture> _rainleaksMask;
		private CResourceReference<CBitmapTexture> _raindropsMask;
		private CResourceReference<CBitmapTexture> _rainRipplesMask;

		[Ordinal(2)] 
		[RED("numParticles")] 
		public CUInt32 NumParticles
		{
			get => GetProperty(ref _numParticles);
			set => SetProperty(ref _numParticles, value);
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(4)] 
		[RED("heightRange")] 
		public CFloat HeightRange
		{
			get => GetProperty(ref _heightRange);
			set => SetProperty(ref _heightRange, value);
		}

		[Ordinal(5)] 
		[RED("globalLightResponse")] 
		public CFloat GlobalLightResponse
		{
			get => GetProperty(ref _globalLightResponse);
			set => SetProperty(ref _globalLightResponse, value);
		}

		[Ordinal(6)] 
		[RED("tiling")] 
		public CLegacySingleChannelCurve<CFloat> Tiling
		{
			get => GetProperty(ref _tiling);
			set => SetProperty(ref _tiling, value);
		}

		[Ordinal(7)] 
		[RED("porosityThresholdStart")] 
		public CFloat PorosityThresholdStart
		{
			get => GetProperty(ref _porosityThresholdStart);
			set => SetProperty(ref _porosityThresholdStart, value);
		}

		[Ordinal(8)] 
		[RED("porosityThresholdEnd")] 
		public CFloat PorosityThresholdEnd
		{
			get => GetProperty(ref _porosityThresholdEnd);
			set => SetProperty(ref _porosityThresholdEnd, value);
		}

		[Ordinal(9)] 
		[RED("glossinessFactor")] 
		public CFloat GlossinessFactor
		{
			get => GetProperty(ref _glossinessFactor);
			set => SetProperty(ref _glossinessFactor, value);
		}

		[Ordinal(10)] 
		[RED("baseColorFactor")] 
		public CFloat BaseColorFactor
		{
			get => GetProperty(ref _baseColorFactor);
			set => SetProperty(ref _baseColorFactor, value);
		}

		[Ordinal(11)] 
		[RED("moistureAccumulationSpeed")] 
		public CFloat MoistureAccumulationSpeed
		{
			get => GetProperty(ref _moistureAccumulationSpeed);
			set => SetProperty(ref _moistureAccumulationSpeed, value);
		}

		[Ordinal(12)] 
		[RED("puddlesAccumulationSpeed")] 
		public CFloat PuddlesAccumulationSpeed
		{
			get => GetProperty(ref _puddlesAccumulationSpeed);
			set => SetProperty(ref _puddlesAccumulationSpeed, value);
		}

		[Ordinal(13)] 
		[RED("moistureEvaporationSpeed")] 
		public CFloat MoistureEvaporationSpeed
		{
			get => GetProperty(ref _moistureEvaporationSpeed);
			set => SetProperty(ref _moistureEvaporationSpeed, value);
		}

		[Ordinal(14)] 
		[RED("puddlesEvaporationSpeed")] 
		public CFloat PuddlesEvaporationSpeed
		{
			get => GetProperty(ref _puddlesEvaporationSpeed);
			set => SetProperty(ref _puddlesEvaporationSpeed, value);
		}

		[Ordinal(15)] 
		[RED("rainIntensity")] 
		public CLegacySingleChannelCurve<CFloat> RainIntensity
		{
			get => GetProperty(ref _rainIntensity);
			set => SetProperty(ref _rainIntensity, value);
		}

		[Ordinal(16)] 
		[RED("rainOverride")] 
		public CLegacySingleChannelCurve<CFloat> RainOverride
		{
			get => GetProperty(ref _rainOverride);
			set => SetProperty(ref _rainOverride, value);
		}

		[Ordinal(17)] 
		[RED("rainMoistureOverride")] 
		public CLegacySingleChannelCurve<CFloat> RainMoistureOverride
		{
			get => GetProperty(ref _rainMoistureOverride);
			set => SetProperty(ref _rainMoistureOverride, value);
		}

		[Ordinal(18)] 
		[RED("rainPuddlesOverride")] 
		public CLegacySingleChannelCurve<CFloat> RainPuddlesOverride
		{
			get => GetProperty(ref _rainPuddlesOverride);
			set => SetProperty(ref _rainPuddlesOverride, value);
		}

		[Ordinal(19)] 
		[RED("rainleaksMask")] 
		public CResourceReference<CBitmapTexture> RainleaksMask
		{
			get => GetProperty(ref _rainleaksMask);
			set => SetProperty(ref _rainleaksMask, value);
		}

		[Ordinal(20)] 
		[RED("raindropsMask")] 
		public CResourceReference<CBitmapTexture> RaindropsMask
		{
			get => GetProperty(ref _raindropsMask);
			set => SetProperty(ref _raindropsMask, value);
		}

		[Ordinal(21)] 
		[RED("rainRipplesMask")] 
		public CResourceReference<CBitmapTexture> RainRipplesMask
		{
			get => GetProperty(ref _rainRipplesMask);
			set => SetProperty(ref _rainRipplesMask, value);
		}
	}
}
