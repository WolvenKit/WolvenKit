using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Multilayer_LayerTemplate : CResource
	{
		private Multilayer_LayerTemplateOverrides _overrides;
		private Multilayer_LayerOverrideSelection _defaultOverrides;
		private CResourceReference<CBitmapTexture> _colorTexture;
		private CResourceReference<CBitmapTexture> _normalTexture;
		private CResourceReference<CBitmapTexture> _roughnessTexture;
		private CResourceReference<CBitmapTexture> _metalnessTexture;
		private CFloat _tilingMultiplier;
		private CArrayFixedSize<CFloat> _colorMaskLevelsIn;
		private CArrayFixedSize<CFloat> _colorMaskLevelsOut;

		[Ordinal(1)] 
		[RED("overrides")] 
		public Multilayer_LayerTemplateOverrides Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}

		[Ordinal(2)] 
		[RED("defaultOverrides")] 
		public Multilayer_LayerOverrideSelection DefaultOverrides
		{
			get => GetProperty(ref _defaultOverrides);
			set => SetProperty(ref _defaultOverrides, value);
		}

		[Ordinal(3)] 
		[RED("colorTexture")] 
		public CResourceReference<CBitmapTexture> ColorTexture
		{
			get => GetProperty(ref _colorTexture);
			set => SetProperty(ref _colorTexture, value);
		}

		[Ordinal(4)] 
		[RED("normalTexture")] 
		public CResourceReference<CBitmapTexture> NormalTexture
		{
			get => GetProperty(ref _normalTexture);
			set => SetProperty(ref _normalTexture, value);
		}

		[Ordinal(5)] 
		[RED("roughnessTexture")] 
		public CResourceReference<CBitmapTexture> RoughnessTexture
		{
			get => GetProperty(ref _roughnessTexture);
			set => SetProperty(ref _roughnessTexture, value);
		}

		[Ordinal(6)] 
		[RED("metalnessTexture")] 
		public CResourceReference<CBitmapTexture> MetalnessTexture
		{
			get => GetProperty(ref _metalnessTexture);
			set => SetProperty(ref _metalnessTexture, value);
		}

		[Ordinal(7)] 
		[RED("tilingMultiplier")] 
		public CFloat TilingMultiplier
		{
			get => GetProperty(ref _tilingMultiplier);
			set => SetProperty(ref _tilingMultiplier, value);
		}

		[Ordinal(8)] 
		[RED("colorMaskLevelsIn", 2)] 
		public CArrayFixedSize<CFloat> ColorMaskLevelsIn
		{
			get => GetProperty(ref _colorMaskLevelsIn);
			set => SetProperty(ref _colorMaskLevelsIn, value);
		}

		[Ordinal(9)] 
		[RED("colorMaskLevelsOut", 2)] 
		public CArrayFixedSize<CFloat> ColorMaskLevelsOut
		{
			get => GetProperty(ref _colorMaskLevelsOut);
			set => SetProperty(ref _colorMaskLevelsOut, value);
		}
	}
}
