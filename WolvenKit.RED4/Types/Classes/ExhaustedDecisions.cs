using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExhaustedDecisions : StaminaTransition
	{
		[Ordinal(1)] 
		[RED("staminaRatioEnterCondition")] 
		public CFloat StaminaRatioEnterCondition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ExhaustedDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
