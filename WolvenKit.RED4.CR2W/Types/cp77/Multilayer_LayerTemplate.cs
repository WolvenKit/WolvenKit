using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplate : CResource
	{
		private Multilayer_LayerTemplateOverrides _overrides;
		private Multilayer_LayerOverrideSelection _defaultOverrides;
		private rRef<CBitmapTexture> _colorTexture;
		private rRef<CBitmapTexture> _normalTexture;
		private rRef<CBitmapTexture> _roughnessTexture;
		private rRef<CBitmapTexture> _metalnessTexture;
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
		public rRef<CBitmapTexture> ColorTexture
		{
			get => GetProperty(ref _colorTexture);
			set => SetProperty(ref _colorTexture, value);
		}

		[Ordinal(4)] 
		[RED("normalTexture")] 
		public rRef<CBitmapTexture> NormalTexture
		{
			get => GetProperty(ref _normalTexture);
			set => SetProperty(ref _normalTexture, value);
		}

		[Ordinal(5)] 
		[RED("roughnessTexture")] 
		public rRef<CBitmapTexture> RoughnessTexture
		{
			get => GetProperty(ref _roughnessTexture);
			set => SetProperty(ref _roughnessTexture, value);
		}

		[Ordinal(6)] 
		[RED("metalnessTexture")] 
		public rRef<CBitmapTexture> MetalnessTexture
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

		public Multilayer_LayerTemplate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
