using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CFoliageProfile : CResource
	{
		private CFloat _cutoffAlphaMinMip;
		private CFloat _cutoffAlphaMaxMip;
		private CFloat _billboardCutoffAlpha;
		private CFloat _aoScale;
		private CFloat _terrainBlendScale;
		private CFloat _terrainBlendBias;
		private CFloat _billboardDepthScale;
		private CFloat _billboardRoughnessBias;
		private CResourceReference<CGradient> _colorGradient;
		private CFloat _colorGradientWeight;
		private CFloat _colorGradientDarkenWeight;
		private CFloat _preserveOriginalColor;

		[Ordinal(1)] 
		[RED("cutoffAlphaMinMip")] 
		public CFloat CutoffAlphaMinMip
		{
			get => GetProperty(ref _cutoffAlphaMinMip);
			set => SetProperty(ref _cutoffAlphaMinMip, value);
		}

		[Ordinal(2)] 
		[RED("cutoffAlphaMaxMip")] 
		public CFloat CutoffAlphaMaxMip
		{
			get => GetProperty(ref _cutoffAlphaMaxMip);
			set => SetProperty(ref _cutoffAlphaMaxMip, value);
		}

		[Ordinal(3)] 
		[RED("billboardCutoffAlpha")] 
		public CFloat BillboardCutoffAlpha
		{
			get => GetProperty(ref _billboardCutoffAlpha);
			set => SetProperty(ref _billboardCutoffAlpha, value);
		}

		[Ordinal(4)] 
		[RED("aoScale")] 
		public CFloat AoScale
		{
			get => GetProperty(ref _aoScale);
			set => SetProperty(ref _aoScale, value);
		}

		[Ordinal(5)] 
		[RED("terrainBlendScale")] 
		public CFloat TerrainBlendScale
		{
			get => GetProperty(ref _terrainBlendScale);
			set => SetProperty(ref _terrainBlendScale, value);
		}

		[Ordinal(6)] 
		[RED("terrainBlendBias")] 
		public CFloat TerrainBlendBias
		{
			get => GetProperty(ref _terrainBlendBias);
			set => SetProperty(ref _terrainBlendBias, value);
		}

		[Ordinal(7)] 
		[RED("billboardDepthScale")] 
		public CFloat BillboardDepthScale
		{
			get => GetProperty(ref _billboardDepthScale);
			set => SetProperty(ref _billboardDepthScale, value);
		}

		[Ordinal(8)] 
		[RED("billboardRoughnessBias")] 
		public CFloat BillboardRoughnessBias
		{
			get => GetProperty(ref _billboardRoughnessBias);
			set => SetProperty(ref _billboardRoughnessBias, value);
		}

		[Ordinal(9)] 
		[RED("colorGradient")] 
		public CResourceReference<CGradient> ColorGradient
		{
			get => GetProperty(ref _colorGradient);
			set => SetProperty(ref _colorGradient, value);
		}

		[Ordinal(10)] 
		[RED("colorGradientWeight")] 
		public CFloat ColorGradientWeight
		{
			get => GetProperty(ref _colorGradientWeight);
			set => SetProperty(ref _colorGradientWeight, value);
		}

		[Ordinal(11)] 
		[RED("colorGradientDarkenWeight")] 
		public CFloat ColorGradientDarkenWeight
		{
			get => GetProperty(ref _colorGradientDarkenWeight);
			set => SetProperty(ref _colorGradientDarkenWeight, value);
		}

		[Ordinal(12)] 
		[RED("preserveOriginalColor")] 
		public CFloat PreserveOriginalColor
		{
			get => GetProperty(ref _preserveOriginalColor);
			set => SetProperty(ref _preserveOriginalColor, value);
		}
	}
}
