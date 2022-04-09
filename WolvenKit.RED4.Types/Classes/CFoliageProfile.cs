using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CFoliageProfile : CResource
	{
		[Ordinal(1)] 
		[RED("cutoffAlphaMinMip")] 
		public CFloat CutoffAlphaMinMip
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("cutoffAlphaMaxMip")] 
		public CFloat CutoffAlphaMaxMip
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("billboardCutoffAlpha")] 
		public CFloat BillboardCutoffAlpha
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("aoScale")] 
		public CFloat AoScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("terrainBlendScale")] 
		public CFloat TerrainBlendScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("terrainBlendBias")] 
		public CFloat TerrainBlendBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("billboardDepthScale")] 
		public CFloat BillboardDepthScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("billboardRoughnessBias")] 
		public CFloat BillboardRoughnessBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("colorGradient")] 
		public CResourceReference<CGradient> ColorGradient
		{
			get => GetPropertyValue<CResourceReference<CGradient>>();
			set => SetPropertyValue<CResourceReference<CGradient>>(value);
		}

		[Ordinal(10)] 
		[RED("colorGradientWeight")] 
		public CFloat ColorGradientWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("colorGradientDarkenWeight")] 
		public CFloat ColorGradientDarkenWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("preserveOriginalColor")] 
		public CFloat PreserveOriginalColor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CFoliageProfile()
		{
			CutoffAlphaMinMip = 0.450000F;
			CutoffAlphaMaxMip = 0.120000F;
			BillboardCutoffAlpha = 0.600000F;
			AoScale = 0.500000F;
			TerrainBlendScale = 0.200000F;
			BillboardDepthScale = 1.000000F;
			BillboardRoughnessBias = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
