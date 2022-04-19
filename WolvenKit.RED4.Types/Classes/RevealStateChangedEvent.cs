using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealStateChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<ERevealState> State
		{
			get => GetPropertyValue<CEnum<ERevealState>>();
			set => SetPropertyValue<CEnum<ERevealState>>(value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public gameVisionModeSystemRevealIdentifier Reason
		{
			get => GetPropertyValue<gameVisionModeSystemRevealIdentifier>();
			set => SetPropertyValue<gameVisionModeSystemRevealIdentifier>(value);
		}

		[Ordinal(2)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RevealStateChangedEvent()
		{
			Reason = new() { SourceEntityId = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
