using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiOnGameFinishEventAdvanced : redEvent
	{
		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState
		{
			get => GetPropertyValue<CHandle<gameuiSideScrollerMiniGameStateAdvanced>>();
			set => SetPropertyValue<CHandle<gameuiSideScrollerMiniGameStateAdvanced>>(value);
		}

		public gameuiOnGameFinishEventAdvanced()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
