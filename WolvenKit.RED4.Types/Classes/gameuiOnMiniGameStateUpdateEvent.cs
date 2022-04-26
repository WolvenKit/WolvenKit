using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiOnMiniGameStateUpdateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiMinigameState> GameState
		{
			get => GetPropertyValue<CHandle<gameuiMinigameState>>();
			set => SetPropertyValue<CHandle<gameuiMinigameState>>(value);
		}

		[Ordinal(1)] 
		[RED("gameName")] 
		public CName GameName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiOnMiniGameStateUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
