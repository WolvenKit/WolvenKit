using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Multilayer_LayerTemplate : CResource
	{
		[Ordinal(1)] 
		[RED("overrides")] 
		public Multilayer_LayerTemplateOverrides Overrides
		{
			get => GetPropertyValue<Multilayer_LayerTemplateOverrides>();
			set => SetPropertyValue<Multilayer_LayerTemplateOverrides>(value);
		}

		[Ordinal(2)] 
		[RED("defaultOverrides")] 
		public Multilayer_LayerOverrideSelection DefaultOverrides
		{
			get => GetPropertyValue<Multilayer_LayerOverrideSelection>();
			set => SetPropertyValue<Multilayer_LayerOverrideSelection>(value);
		}

		[Ordinal(3)] 
		[RED("colorTexture")] 
		public CResourceReference<CBitmapTexture> ColorTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(4)] 
		[RED("normalTexture")] 
		public CResourceReference<CBitmapTexture> NormalTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(5)] 
		[RED("roughnessTexture")] 
		public CResourceReference<CBitmapTexture> RoughnessTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(6)] 
		[RED("metalnessTexture")] 
		public CResourceReference<CBitmapTexture> MetalnessTexture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(7)] 
		[RED("tilingMultiplier")] 
		public CFloat TilingMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("colorMaskLevelsIn", 2)] 
		public CArrayFixedSize<CFloat> ColorMaskLevelsIn
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("colorMaskLevelsOut", 2)] 
		public CArrayFixedSize<CFloat> ColorMaskLevelsOut
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		public Multilayer_LayerTemplate()
		{
			Overrides = new() { ColorScale = new(), RoughLevelsIn = new(), RoughLevelsOut = new(), MetalLevelsIn = new(), MetalLevelsOut = new(), NormalStrength = new() };
			DefaultOverrides = new() { ColorScale = "null_null", NormalStrength = "null", RoughLevelsIn = "null", RoughLevelsOut = "null", MetalLevelsIn = "null", MetalLevelsOut = "null" };
			TilingMultiplier = 1.000000F;
			ColorMaskLevelsIn = new(2);
			ColorMaskLevelsOut = new(2);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
