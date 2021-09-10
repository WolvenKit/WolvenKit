using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BloomAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("luminanceThresholdMin")] 
		public CFloat LuminanceThresholdMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("luminanceThresholdMax")] 
		public CFloat LuminanceThresholdMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("sceneColorScale")] 
		public CFloat SceneColorScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("bloomColorScale")] 
		public CFloat BloomColorScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("numDownsamplePasses")] 
		public CUInt8 NumDownsamplePasses
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(7)] 
		[RED("shaftsAreaSettings")] 
		public ShaftsAreaSettings ShaftsAreaSettings
		{
			get => GetPropertyValue<ShaftsAreaSettings>();
			set => SetPropertyValue<ShaftsAreaSettings>(value);
		}

		public BloomAreaSettings()
		{
			Enable = true;
			LuminanceThresholdMax = 2.000000F;
			SceneColorScale = 0.800000F;
			BloomColorScale = 0.200000F;
			NumDownsamplePasses = 6;
			ShaftsAreaSettings = new() { ShaftsLevelIndex = 1, ShaftsIntensity = 1.000000F, ShaftsThresholdsScale = 1.000000F };
		}
	}
}
