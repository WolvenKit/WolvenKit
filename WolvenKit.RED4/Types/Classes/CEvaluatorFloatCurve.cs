using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorFloatCurve : IEvaluatorFloat
	{
		[Ordinal(0)] 
		[RED("curves")] 
		public CLegacySingleChannelCurve<CFloat> Curves
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("numberOfCurveSamples")] 
		public CUInt32 NumberOfCurveSamples
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public CEvaluatorFloatCurve()
		{
			NumberOfCurveSamples = 16;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
