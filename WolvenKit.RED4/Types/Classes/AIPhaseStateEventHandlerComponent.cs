using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIPhaseStateEventHandlerComponent : AIRelatedComponents
	{
		[Ordinal(5)] 
		[RED("phaseStateValue")] 
		public CEnum<ENPCPhaseState> PhaseStateValue
		{
			get => GetPropertyValue<CEnum<ENPCPhaseState>>();
			set => SetPropertyValue<CEnum<ENPCPhaseState>>(value);
		}

		public AIPhaseStateEventHandlerComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
