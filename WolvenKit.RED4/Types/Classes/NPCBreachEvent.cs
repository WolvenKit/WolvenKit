using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCBreachEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameuiHackingMinigameState> State
		{
			get => GetPropertyValue<CEnum<gameuiHackingMinigameState>>();
			set => SetPropertyValue<CEnum<gameuiHackingMinigameState>>(value);
		}

		public NPCBreachEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
