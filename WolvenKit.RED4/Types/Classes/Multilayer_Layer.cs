using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Multilayer_Layer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("matTile")] 
		public CFloat MatTile
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("mbTile")] 
		public CFloat MbTile
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("microblend")] 
		public CResourceReference<CBitmapTexture> Microblend
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(3)] 
		[RED("microblendContrast")] 
		public CFloat MicroblendContrast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("microblendNormalStrength")] 
		public CFloat MicroblendNormalStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("microblendOffsetU")] 
		public CFloat MicroblendOffsetU
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("microblendOffsetV")] 
		public CFloat MicroblendOffsetV
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("offsetU")] 
		public CFloat OffsetU
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("offsetV")] 
		public CFloat OffsetV
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("material")] 
		public CResourceReference<Multilayer_LayerTemplate> Material
		{
			get => GetPropertyValue<CResourceReference<Multilayer_LayerTemplate>>();
			set => SetPropertyValue<CResourceReference<Multilayer_LayerTemplate>>(value);
		}

		[Ordinal(11)] 
		[RED("colorScale")] 
		public CName ColorScale
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("normalStrength")] 
		public CName NormalStrength
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("roughLevelsIn")] 
		public CName RoughLevelsIn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("roughLevelsOut")] 
		public CName RoughLevelsOut
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("metalLevelsIn")] 
		public CName MetalLevelsIn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("metalLevelsOut")] 
		public CName MetalLevelsOut
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("overrides")] 
		public CName Overrides
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public Multilayer_Layer()
		{
			MatTile = 1.000000F;
			MbTile = 1.000000F;
			MicroblendContrast = 0.500000F;
			MicroblendNormalStrength = 1.000000F;
			Opacity = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
