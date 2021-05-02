using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RainAreaSettings : IAreaSettings
	{
		private CUInt32 _numParticles;
		private CFloat _radius;
		private CFloat _heightRange;
		private CFloat _globalLightResponse;
		private curveData<CFloat> _tiling;
		private curveData<CFloat> _speed;
		private CFloat _roughnessShift;
		private CFloat _roughnessClip;
		private CFloat _roughnessExponent;
		private CFloat _baseColorShift;
		private CFloat _baseColorClip;
		private CFloat _baseColorExponent;
		private CFloat _porosityThreshold;
		private CFloat _moistureAccumulationSpeed;
		private CFloat _puddlesAccumulationSpeed;
		private CFloat _moistureEvaporationSpeed;
		private CFloat _puddlesEvaporationSpeed;
		private curveData<CFloat> _rainIntensity;
		private curveData<CFloat> _rainOverride;
		private curveData<CFloat> _rainMoistureOverride;
		private curveData<CFloat> _rainPuddlesOverride;
		private rRef<CBitmapTexture> _rainleaksMask;
		private rRef<CBitmapTexture> _raindropsMask;
		private rRef<CBitmapTexture> _rainRipplesMask;

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
		public curveData<CFloat> Tiling
		{
			get => GetProperty(ref _tiling);
			set => SetProperty(ref _tiling, value);
		}

		[Ordinal(7)] 
		[RED("speed")] 
		public curveData<CFloat> Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(8)] 
		[RED("roughnessShift")] 
		public CFloat RoughnessShift
		{
			get => GetProperty(ref _roughnessShift);
			set => SetProperty(ref _roughnessShift, value);
		}

		[Ordinal(9)] 
		[RED("roughnessClip")] 
		public CFloat RoughnessClip
		{
			get => GetProperty(ref _roughnessClip);
			set => SetProperty(ref _roughnessClip, value);
		}

		[Ordinal(10)] 
		[RED("roughnessExponent")] 
		public CFloat RoughnessExponent
		{
			get => GetProperty(ref _roughnessExponent);
			set => SetProperty(ref _roughnessExponent, value);
		}

		[Ordinal(11)] 
		[RED("baseColorShift")] 
		public CFloat BaseColorShift
		{
			get => GetProperty(ref _baseColorShift);
			set => SetProperty(ref _baseColorShift, value);
		}

		[Ordinal(12)] 
		[RED("baseColorClip")] 
		public CFloat BaseColorClip
		{
			get => GetProperty(ref _baseColorClip);
			set => SetProperty(ref _baseColorClip, value);
		}

		[Ordinal(13)] 
		[RED("baseColorExponent")] 
		public CFloat BaseColorExponent
		{
			get => GetProperty(ref _baseColorExponent);
			set => SetProperty(ref _baseColorExponent, value);
		}

		[Ordinal(14)] 
		[RED("porosityThreshold")] 
		public CFloat PorosityThreshold
		{
			get => GetProperty(ref _porosityThreshold);
			set => SetProperty(ref _porosityThreshold, value);
		}

		[Ordinal(15)] 
		[RED("moistureAccumulationSpeed")] 
		public CFloat MoistureAccumulationSpeed
		{
			get => GetProperty(ref _moistureAccumulationSpeed);
			set => SetProperty(ref _moistureAccumulationSpeed, value);
		}

		[Ordinal(16)] 
		[RED("puddlesAccumulationSpeed")] 
		public CFloat PuddlesAccumulationSpeed
		{
			get => GetProperty(ref _puddlesAccumulationSpeed);
			set => SetProperty(ref _puddlesAccumulationSpeed, value);
		}

		[Ordinal(17)] 
		[RED("moistureEvaporationSpeed")] 
		public CFloat MoistureEvaporationSpeed
		{
			get => GetProperty(ref _moistureEvaporationSpeed);
			set => SetProperty(ref _moistureEvaporationSpeed, value);
		}

		[Ordinal(18)] 
		[RED("puddlesEvaporationSpeed")] 
		public CFloat PuddlesEvaporationSpeed
		{
			get => GetProperty(ref _puddlesEvaporationSpeed);
			set => SetProperty(ref _puddlesEvaporationSpeed, value);
		}

		[Ordinal(19)] 
		[RED("rainIntensity")] 
		public curveData<CFloat> RainIntensity
		{
			get => GetProperty(ref _rainIntensity);
			set => SetProperty(ref _rainIntensity, value);
		}

		[Ordinal(20)] 
		[RED("rainOverride")] 
		public curveData<CFloat> RainOverride
		{
			get => GetProperty(ref _rainOverride);
			set => SetProperty(ref _rainOverride, value);
		}

		[Ordinal(21)] 
		[RED("rainMoistureOverride")] 
		public curveData<CFloat> RainMoistureOverride
		{
			get => GetProperty(ref _rainMoistureOverride);
			set => SetProperty(ref _rainMoistureOverride, value);
		}

		[Ordinal(22)] 
		[RED("rainPuddlesOverride")] 
		public curveData<CFloat> RainPuddlesOverride
		{
			get => GetProperty(ref _rainPuddlesOverride);
			set => SetProperty(ref _rainPuddlesOverride, value);
		}

		[Ordinal(23)] 
		[RED("rainleaksMask")] 
		public rRef<CBitmapTexture> RainleaksMask
		{
			get => GetProperty(ref _rainleaksMask);
			set => SetProperty(ref _rainleaksMask, value);
		}

		[Ordinal(24)] 
		[RED("raindropsMask")] 
		public rRef<CBitmapTexture> RaindropsMask
		{
			get => GetProperty(ref _raindropsMask);
			set => SetProperty(ref _raindropsMask, value);
		}

		[Ordinal(25)] 
		[RED("rainRipplesMask")] 
		public rRef<CBitmapTexture> RainRipplesMask
		{
			get => GetProperty(ref _rainRipplesMask);
			set => SetProperty(ref _rainRipplesMask, value);
		}

		public RainAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
