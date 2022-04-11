using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorVectorMultiCurve : IEvaluatorVector
	{
		[Ordinal(2)] 
		[RED("curves")] 
		public MultiChannelCurve<CFloat> Curves
		{
			get => GetPropertyValue<MultiChannelCurve<CFloat>>();
			set => SetPropertyValue<MultiChannelCurve<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("numberOfCurveSamples")] 
		public CUInt32 NumberOfCurveSamples
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public CEvaluatorVectorMultiCurve()
		{
			FreeAxes = Enums.EFreeVectorAxes.FVA_Three;
			Spill = true;
			NumberOfCurveSamples = 16;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
