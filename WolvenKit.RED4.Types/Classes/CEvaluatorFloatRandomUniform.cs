using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorFloatRandomUniform : IEvaluatorFloat
	{
		[Ordinal(0)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CEvaluatorFloatRandomUniform()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
