using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_FootPhaseEvent : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("footPhase")] 
		public CEnum<animEFootPhase> FootPhase
		{
			get => GetPropertyValue<CEnum<animEFootPhase>>();
			set => SetPropertyValue<CEnum<animEFootPhase>>(value);
		}

		public animAnimStateTransitionCondition_FootPhaseEvent()
		{
			FootPhase = Enums.animEFootPhase.NotConsidered;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
