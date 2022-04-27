using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIThreatCalculationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("temporaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType
		{
			get => GetPropertyValue<CEnum<EAIThreatCalculationType>>();
			set => SetPropertyValue<CEnum<EAIThreatCalculationType>>(value);
		}

		public AIThreatCalculationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
