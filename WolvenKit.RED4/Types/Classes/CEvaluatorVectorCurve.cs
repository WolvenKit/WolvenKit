using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorVectorCurve : IEvaluatorVector
	{
		[Ordinal(2)] 
		[RED("curves")] 
		public CLegacySingleChannelCurve<Vector4> Curves
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<Vector4>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<Vector4>>(value);
		}

		[Ordinal(3)] 
		[RED("numberOfCurveSamples")] 
		public CUInt32 NumberOfCurveSamples
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public CEvaluatorVectorCurve()
		{
			FreeAxes = Enums.EFreeVectorAxes.FVA_Three;
			Spill = true;
			NumberOfCurveSamples = 16;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
