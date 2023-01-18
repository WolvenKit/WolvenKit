using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorColorMultiCurve : IEvaluatorColor
	{
		[Ordinal(0)] 
		[RED("curves")] 
		public MultiChannelCurve<CFloat> Curves
		{
			get => GetPropertyValue<MultiChannelCurve<CFloat>>();
			set => SetPropertyValue<MultiChannelCurve<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("numberOfCurveSamples")] 
		public CUInt32 NumberOfCurveSamples
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public CEvaluatorColorMultiCurve()
		{
			NumberOfCurveSamples = 16;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
