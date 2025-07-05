using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorFloatConst : IEvaluatorFloat
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CEvaluatorFloatConst()
		{
			Value = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
