using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BloomAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("blurSizeX")] 
		public CFloat BlurSizeX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("blurSizeY")] 
		public CFloat BlurSizeY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("mipColors", 5)] 
		public CArrayFixedSize<CColor> MipColors
		{
			get => GetPropertyValue<CArrayFixedSize<CColor>>();
			set => SetPropertyValue<CArrayFixedSize<CColor>>(value);
		}

		[Ordinal(5)] 
		[RED("mipLuminanceClamp", 3)] 
		public CArrayFixedSize<CFloat> MipLuminanceClamp
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("luminanceThresholdMin")] 
		public CFloat LuminanceThresholdMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("luminanceThresholdMax")] 
		public CFloat LuminanceThresholdMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("sceneColorScale")] 
		public CFloat SceneColorScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("bloomColorScale")] 
		public CFloat BloomColorScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("numDownsamplePasses")] 
		public CUInt8 NumDownsamplePasses
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(11)] 
		[RED("shaftsAreaSettings")] 
		public ShaftsAreaSettings ShaftsAreaSettings
		{
			get => GetPropertyValue<ShaftsAreaSettings>();
			set => SetPropertyValue<ShaftsAreaSettings>(value);
		}

		public BloomAreaSettings()
		{
			Enable = true;
			BlurSizeX = 1.000000F;
			BlurSizeY = 1.000000F;
			MipColors = new(5);
			MipLuminanceClamp = new(3);
			LuminanceThresholdMax = 2.000000F;
			SceneColorScale = 0.800000F;
			BloomColorScale = 0.200000F;
			NumDownsamplePasses = 6;
			ShaftsAreaSettings = new ShaftsAreaSettings { ShaftsLevelIndex = 1, ShaftsIntensity = 1.000000F, ShaftsThresholdsScale = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
