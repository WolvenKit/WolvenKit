using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionRevealExpiredEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("revealId")] 
		public gameVisionModeSystemRevealIdentifier RevealId
		{
			get => GetPropertyValue<gameVisionModeSystemRevealIdentifier>();
			set => SetPropertyValue<gameVisionModeSystemRevealIdentifier>(value);
		}

		public gameVisionRevealExpiredEvent()
		{
			RevealId = new gameVisionModeSystemRevealIdentifier { SourceEntityId = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
