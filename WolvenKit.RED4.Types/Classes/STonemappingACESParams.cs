using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class STonemappingACESParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("minStops")] 
		public CFloat MinStops
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("maxStops")] 
		public CFloat MaxStops
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("midGrayScale")] 
		public CFloat MidGrayScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("surroundGamma")] 
		public CFloat SurroundGamma
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("toneCurveSaturation")] 
		public CFloat ToneCurveSaturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("adjustWhitePoint")] 
		public CBool AdjustWhitePoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("desaturate")] 
		public CBool Desaturate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("dimSurround")] 
		public CBool DimSurround
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("tonemapLuminance")] 
		public CBool TonemapLuminance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("applyAfterLUT")] 
		public CBool ApplyAfterLUT
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public STonemappingACESParams()
		{
			MinStops = -7.000000F;
			MaxStops = 9.000000F;
			MidGrayScale = 1.000000F;
			SurroundGamma = 1.000000F;
			ToneCurveSaturation = 1.000000F;
			AdjustWhitePoint = true;
			DimSurround = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
