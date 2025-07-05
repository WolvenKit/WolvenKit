using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiAccessPointMiniGameStatus : redEvent
	{
		[Ordinal(0)] 
		[RED("minigameState")] 
		public CEnum<gameuiHackingMinigameState> MinigameState
		{
			get => GetPropertyValue<CEnum<gameuiHackingMinigameState>>();
			set => SetPropertyValue<CEnum<gameuiHackingMinigameState>>(value);
		}

		public gameuiAccessPointMiniGameStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
