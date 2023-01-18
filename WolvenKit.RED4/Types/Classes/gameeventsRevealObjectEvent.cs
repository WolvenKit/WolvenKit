using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsRevealObjectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("reveal")] 
		public CBool Reveal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public gameVisionModeSystemRevealIdentifier Reason
		{
			get => GetPropertyValue<gameVisionModeSystemRevealIdentifier>();
			set => SetPropertyValue<gameVisionModeSystemRevealIdentifier>(value);
		}

		[Ordinal(2)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameeventsRevealObjectEvent()
		{
			Reason = new() { SourceEntityId = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
