using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemColorGrade : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("contrast")] 
		public effectEffectParameterEvaluatorFloat Contrast
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(4)] 
		[RED("saturate")] 
		public effectEffectParameterEvaluatorFloat Saturate
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(5)] 
		[RED("brightness")] 
		public effectEffectParameterEvaluatorFloat Brightness
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(6)] 
		[RED("lutWeight")] 
		public effectEffectParameterEvaluatorFloat LutWeight
		{
			get => GetPropertyValue<effectEffectParameterEvaluatorFloat>();
			set => SetPropertyValue<effectEffectParameterEvaluatorFloat>(value);
		}

		[Ordinal(7)] 
		[RED("lutParams")] 
		public ColorGradingLutParams LutParams
		{
			get => GetPropertyValue<ColorGradingLutParams>();
			set => SetPropertyValue<ColorGradingLutParams>(value);
		}

		[Ordinal(8)] 
		[RED("lutParamsHdr")] 
		public ColorGradingLutParams LutParamsHdr
		{
			get => GetPropertyValue<ColorGradingLutParams>();
			set => SetPropertyValue<ColorGradingLutParams>(value);
		}

		[Ordinal(9)] 
		[RED("blendWithBaseLut")] 
		public CBool BlendWithBaseLut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("mask")] 
		public CArray<CEnum<ERenderObjectType>> Mask
		{
			get => GetPropertyValue<CArray<CEnum<ERenderObjectType>>>();
			set => SetPropertyValue<CArray<CEnum<ERenderObjectType>>>(value);
		}

		public effectTrackItemColorGrade()
		{
			TimeDuration = 1.000000F;
			Contrast = new effectEffectParameterEvaluatorFloat();
			Saturate = new effectEffectParameterEvaluatorFloat();
			Brightness = new effectEffectParameterEvaluatorFloat();
			LutWeight = new effectEffectParameterEvaluatorFloat();
			LutParams = new ColorGradingLutParams { InputMapping = Enums.EColorMappingFunction.CMF_sRGB, OutputMapping = Enums.EColorMappingFunction.CMF_sRGB };
			LutParamsHdr = new ColorGradingLutParams { InputMapping = Enums.EColorMappingFunction.CMF_sRGB, OutputMapping = Enums.EColorMappingFunction.CMF_sRGB };
			BlendWithBaseLut = true;
			Mask = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
