using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ColorGradingLutParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("LUT")] 
		public CResourceReference<CBitmapTexture> LUT
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}

		[Ordinal(1)] 
		[RED("inputMapping")] 
		public CEnum<EColorMappingFunction> InputMapping
		{
			get => GetPropertyValue<CEnum<EColorMappingFunction>>();
			set => SetPropertyValue<CEnum<EColorMappingFunction>>(value);
		}

		[Ordinal(2)] 
		[RED("outputMapping")] 
		public CEnum<EColorMappingFunction> OutputMapping
		{
			get => GetPropertyValue<CEnum<EColorMappingFunction>>();
			set => SetPropertyValue<CEnum<EColorMappingFunction>>(value);
		}

		public ColorGradingLutParams()
		{
			InputMapping = Enums.EColorMappingFunction.CMF_sRGB;
			OutputMapping = Enums.EColorMappingFunction.CMF_sRGB;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
