using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorFloatStartEnd : IEvaluatorFloat
	{
		[Ordinal(0)] 
		[RED("start")] 
		public CFloat Start
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public CFloat End
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CEvaluatorFloatStartEnd()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
