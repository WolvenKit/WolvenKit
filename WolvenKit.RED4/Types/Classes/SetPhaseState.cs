using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetPhaseState : AIActionHelperTask
	{
		[Ordinal(5)] 
		[RED("phaseStateValue")] 
		public CEnum<ENPCPhaseState> PhaseStateValue
		{
			get => GetPropertyValue<CEnum<ENPCPhaseState>>();
			set => SetPropertyValue<CEnum<ENPCPhaseState>>(value);
		}

		public SetPhaseState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
