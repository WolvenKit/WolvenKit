using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BloomAreaSettings : IAreaSettings
	{
		private CFloat _luminanceThresholdMin;
		private CFloat _luminanceThresholdMax;
		private CFloat _sceneColorScale;
		private CFloat _bloomColorScale;
		private CUInt8 _numDownsamplePasses;
		private ShaftsAreaSettings _shaftsAreaSettings;

		[Ordinal(2)] 
		[RED("luminanceThresholdMin")] 
		public CFloat LuminanceThresholdMin
		{
			get => GetProperty(ref _luminanceThresholdMin);
			set => SetProperty(ref _luminanceThresholdMin, value);
		}

		[Ordinal(3)] 
		[RED("luminanceThresholdMax")] 
		public CFloat LuminanceThresholdMax
		{
			get => GetProperty(ref _luminanceThresholdMax);
			set => SetProperty(ref _luminanceThresholdMax, value);
		}

		[Ordinal(4)] 
		[RED("sceneColorScale")] 
		public CFloat SceneColorScale
		{
			get => GetProperty(ref _sceneColorScale);
			set => SetProperty(ref _sceneColorScale, value);
		}

		[Ordinal(5)] 
		[RED("bloomColorScale")] 
		public CFloat BloomColorScale
		{
			get => GetProperty(ref _bloomColorScale);
			set => SetProperty(ref _bloomColorScale, value);
		}

		[Ordinal(6)] 
		[RED("numDownsamplePasses")] 
		public CUInt8 NumDownsamplePasses
		{
			get => GetProperty(ref _numDownsamplePasses);
			set => SetProperty(ref _numDownsamplePasses, value);
		}

		[Ordinal(7)] 
		[RED("shaftsAreaSettings")] 
		public ShaftsAreaSettings ShaftsAreaSettings
		{
			get => GetProperty(ref _shaftsAreaSettings);
			set => SetProperty(ref _shaftsAreaSettings, value);
		}
	}
}
