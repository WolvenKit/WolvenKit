using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CRenderSimWaterFFT : IDynamicTextureGenerator
	{
		private CFloat _windDir;
		private CFloat _windSpeed;
		private CFloat _windScale;
		private CFloat _amplitude;
		private CFloat _lambda;

		[Ordinal(0)] 
		[RED("windDir")] 
		public CFloat WindDir
		{
			get => GetProperty(ref _windDir);
			set => SetProperty(ref _windDir, value);
		}

		[Ordinal(1)] 
		[RED("windSpeed")] 
		public CFloat WindSpeed
		{
			get => GetProperty(ref _windSpeed);
			set => SetProperty(ref _windSpeed, value);
		}

		[Ordinal(2)] 
		[RED("windScale")] 
		public CFloat WindScale
		{
			get => GetProperty(ref _windScale);
			set => SetProperty(ref _windScale, value);
		}

		[Ordinal(3)] 
		[RED("amplitude")] 
		public CFloat Amplitude
		{
			get => GetProperty(ref _amplitude);
			set => SetProperty(ref _amplitude, value);
		}

		[Ordinal(4)] 
		[RED("lambda")] 
		public CFloat Lambda
		{
			get => GetProperty(ref _lambda);
			set => SetProperty(ref _lambda, value);
		}

		public CRenderSimWaterFFT(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
