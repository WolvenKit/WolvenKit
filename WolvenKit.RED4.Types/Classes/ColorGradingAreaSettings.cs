using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ColorGradingAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("contrast")] 
		public CFloat Contrast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("contrastPivot")] 
		public CFloat ContrastPivot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("saturation")] 
		public CFloat Saturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("hue")] 
		public CFloat Hue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("brightness")] 
		public CFloat Brightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("lift")] 
		public ColorBalance Lift
		{
			get => GetPropertyValue<ColorBalance>();
			set => SetPropertyValue<ColorBalance>(value);
		}

		[Ordinal(8)] 
		[RED("gammaValue")] 
		public ColorBalance GammaValue
		{
			get => GetPropertyValue<ColorBalance>();
			set => SetPropertyValue<ColorBalance>(value);
		}

		[Ordinal(9)] 
		[RED("gain")] 
		public ColorBalance Gain
		{
			get => GetPropertyValue<ColorBalance>();
			set => SetPropertyValue<ColorBalance>(value);
		}

		[Ordinal(10)] 
		[RED("offset")] 
		public ColorBalance Offset
		{
			get => GetPropertyValue<ColorBalance>();
			set => SetPropertyValue<ColorBalance>(value);
		}

		[Ordinal(11)] 
		[RED("lowRange")] 
		public CFloat LowRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("shadowOffset")] 
		public ColorBalance ShadowOffset
		{
			get => GetPropertyValue<ColorBalance>();
			set => SetPropertyValue<ColorBalance>(value);
		}

		[Ordinal(13)] 
		[RED("midtoneOffset")] 
		public ColorBalance MidtoneOffset
		{
			get => GetPropertyValue<ColorBalance>();
			set => SetPropertyValue<ColorBalance>(value);
		}

		[Ordinal(14)] 
		[RED("highRange")] 
		public CFloat HighRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("highlightOffset")] 
		public ColorBalance HighlightOffset
		{
			get => GetPropertyValue<ColorBalance>();
			set => SetPropertyValue<ColorBalance>(value);
		}

		[Ordinal(16)] 
		[RED("ldrLut")] 
		public ColorGradingLutParams LdrLut
		{
			get => GetPropertyValue<ColorGradingLutParams>();
			set => SetPropertyValue<ColorGradingLutParams>(value);
		}

		[Ordinal(17)] 
		[RED("hdrLut")] 
		public ColorGradingLutParams HdrLut
		{
			get => GetPropertyValue<ColorGradingLutParams>();
			set => SetPropertyValue<ColorGradingLutParams>(value);
		}

		[Ordinal(18)] 
		[RED("forceHdrLut")] 
		public CBool ForceHdrLut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ColorGradingAreaSettings()
		{
			Enable = true;
			Contrast = 1.000000F;
			ContrastPivot = 0.435000F;
			Saturation = 1.000000F;
			Brightness = 1.000000F;
			Lift = new();
			GammaValue = new() { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Luminance = 1.000000F };
			Gain = new() { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Luminance = 1.000000F };
			Offset = new();
			LowRange = 0.100000F;
			ShadowOffset = new();
			MidtoneOffset = new();
			HighRange = 0.450000F;
			HighlightOffset = new();
			LdrLut = new() { InputMapping = Enums.EColorMappingFunction.CMF_sRGB, OutputMapping = Enums.EColorMappingFunction.CMF_sRGB };
			HdrLut = new() { InputMapping = Enums.EColorMappingFunction.CMF_sRGB, OutputMapping = Enums.EColorMappingFunction.CMF_sRGB };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
