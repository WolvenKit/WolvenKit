using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Multilayer_Layer : RedBaseClass
	{
		private CFloat _matTile;
		private CFloat _mbTile;
		private CResourceReference<CBitmapTexture> _microblend;
		private CFloat _microblendContrast;
		private CFloat _microblendNormalStrength;
		private CFloat _microblendOffsetU;
		private CFloat _microblendOffsetV;
		private CFloat _opacity;
		private CFloat _offsetU;
		private CFloat _offsetV;
		private CResourceReference<Multilayer_LayerTemplate> _material;
		private CName _colorScale;
		private CName _normalStrength;
		private CName _roughLevelsIn;
		private CName _roughLevelsOut;
		private CName _metalLevelsIn;
		private CName _metalLevelsOut;
		private CName _overrides;

		[Ordinal(0)] 
		[RED("matTile")] 
		public CFloat MatTile
		{
			get => GetProperty(ref _matTile);
			set => SetProperty(ref _matTile, value);
		}

		[Ordinal(1)] 
		[RED("mbTile")] 
		public CFloat MbTile
		{
			get => GetProperty(ref _mbTile);
			set => SetProperty(ref _mbTile, value);
		}

		[Ordinal(2)] 
		[RED("microblend")] 
		public CResourceReference<CBitmapTexture> Microblend
		{
			get => GetProperty(ref _microblend);
			set => SetProperty(ref _microblend, value);
		}

		[Ordinal(3)] 
		[RED("microblendContrast")] 
		public CFloat MicroblendContrast
		{
			get => GetProperty(ref _microblendContrast);
			set => SetProperty(ref _microblendContrast, value);
		}

		[Ordinal(4)] 
		[RED("microblendNormalStrength")] 
		public CFloat MicroblendNormalStrength
		{
			get => GetProperty(ref _microblendNormalStrength);
			set => SetProperty(ref _microblendNormalStrength, value);
		}

		[Ordinal(5)] 
		[RED("microblendOffsetU")] 
		public CFloat MicroblendOffsetU
		{
			get => GetProperty(ref _microblendOffsetU);
			set => SetProperty(ref _microblendOffsetU, value);
		}

		[Ordinal(6)] 
		[RED("microblendOffsetV")] 
		public CFloat MicroblendOffsetV
		{
			get => GetProperty(ref _microblendOffsetV);
			set => SetProperty(ref _microblendOffsetV, value);
		}

		[Ordinal(7)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetProperty(ref _opacity);
			set => SetProperty(ref _opacity, value);
		}

		[Ordinal(8)] 
		[RED("offsetU")] 
		public CFloat OffsetU
		{
			get => GetProperty(ref _offsetU);
			set => SetProperty(ref _offsetU, value);
		}

		[Ordinal(9)] 
		[RED("offsetV")] 
		public CFloat OffsetV
		{
			get => GetProperty(ref _offsetV);
			set => SetProperty(ref _offsetV, value);
		}

		[Ordinal(10)] 
		[RED("material")] 
		public CResourceReference<Multilayer_LayerTemplate> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		[Ordinal(11)] 
		[RED("colorScale")] 
		public CName ColorScale
		{
			get => GetProperty(ref _colorScale);
			set => SetProperty(ref _colorScale, value);
		}

		[Ordinal(12)] 
		[RED("normalStrength")] 
		public CName NormalStrength
		{
			get => GetProperty(ref _normalStrength);
			set => SetProperty(ref _normalStrength, value);
		}

		[Ordinal(13)] 
		[RED("roughLevelsIn")] 
		public CName RoughLevelsIn
		{
			get => GetProperty(ref _roughLevelsIn);
			set => SetProperty(ref _roughLevelsIn, value);
		}

		[Ordinal(14)] 
		[RED("roughLevelsOut")] 
		public CName RoughLevelsOut
		{
			get => GetProperty(ref _roughLevelsOut);
			set => SetProperty(ref _roughLevelsOut, value);
		}

		[Ordinal(15)] 
		[RED("metalLevelsIn")] 
		public CName MetalLevelsIn
		{
			get => GetProperty(ref _metalLevelsIn);
			set => SetProperty(ref _metalLevelsIn, value);
		}

		[Ordinal(16)] 
		[RED("metalLevelsOut")] 
		public CName MetalLevelsOut
		{
			get => GetProperty(ref _metalLevelsOut);
			set => SetProperty(ref _metalLevelsOut, value);
		}

		[Ordinal(17)] 
		[RED("overrides")] 
		public CName Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}
	}
}
