using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsSquadStartedCombatEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("started")] 
		public CBool Started
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameeventsSquadStartedCombatEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
