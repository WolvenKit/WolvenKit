using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckPhaseState : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("phaseStateValue")] 
		public CEnum<ENPCPhaseState> PhaseStateValue
		{
			get => GetPropertyValue<CEnum<ENPCPhaseState>>();
			set => SetPropertyValue<CEnum<ENPCPhaseState>>(value);
		}

		public CheckPhaseState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
