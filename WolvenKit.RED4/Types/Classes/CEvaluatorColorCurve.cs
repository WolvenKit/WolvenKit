using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorColorCurve : IEvaluatorColor
	{
		[Ordinal(0)] 
		[RED("curves")] 
		public CLegacySingleChannelCurve<Vector4> Curves
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<Vector4>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<Vector4>>(value);
		}

		[Ordinal(1)] 
		[RED("numberOfCurveSamples")] 
		public CUInt32 NumberOfCurveSamples
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public CEvaluatorColorCurve()
		{
			NumberOfCurveSamples = 16;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
