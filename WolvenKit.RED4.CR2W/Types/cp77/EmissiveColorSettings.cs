using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EmissiveColorSettings : IAreaSettings
	{
		private curveData<HDRColor> _tint;
		private curveData<CFloat> _saturation;
		private curveData<CFloat> _brigtness;
		private curveData<Vector2> _exposure;
		private curveData<Vector2> _cameraLuminance;
		private curveData<CFloat> _evBlend;
		private curveData<CFloat> _exposureIBL;
		private curveData<CFloat> _luminanceIBL;
		private CFloat _curveRampIBL;
		private curveData<CFloat> _exposureScale;

		[Ordinal(2)] 
		[RED("tint")] 
		public curveData<HDRColor> Tint
		{
			get => GetProperty(ref _tint);
			set => SetProperty(ref _tint, value);
		}

		[Ordinal(3)] 
		[RED("saturation")] 
		public curveData<CFloat> Saturation
		{
			get => GetProperty(ref _saturation);
			set => SetProperty(ref _saturation, value);
		}

		[Ordinal(4)] 
		[RED("brigtness")] 
		public curveData<CFloat> Brigtness
		{
			get => GetProperty(ref _brigtness);
			set => SetProperty(ref _brigtness, value);
		}

		[Ordinal(5)] 
		[RED("exposure")] 
		public curveData<Vector2> Exposure
		{
			get => GetProperty(ref _exposure);
			set => SetProperty(ref _exposure, value);
		}

		[Ordinal(6)] 
		[RED("cameraLuminance")] 
		public curveData<Vector2> CameraLuminance
		{
			get => GetProperty(ref _cameraLuminance);
			set => SetProperty(ref _cameraLuminance, value);
		}

		[Ordinal(7)] 
		[RED("evBlend")] 
		public curveData<CFloat> EvBlend
		{
			get => GetProperty(ref _evBlend);
			set => SetProperty(ref _evBlend, value);
		}

		[Ordinal(8)] 
		[RED("exposureIBL")] 
		public curveData<CFloat> ExposureIBL
		{
			get => GetProperty(ref _exposureIBL);
			set => SetProperty(ref _exposureIBL, value);
		}

		[Ordinal(9)] 
		[RED("luminanceIBL")] 
		public curveData<CFloat> LuminanceIBL
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
		public curveData<CFloat> ExposureScale
		{
			get => GetProperty(ref _exposureScale);
			set => SetProperty(ref _exposureScale, value);
		}

		public EmissiveColorSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
