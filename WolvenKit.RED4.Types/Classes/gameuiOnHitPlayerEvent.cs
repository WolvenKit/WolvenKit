using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiOnHitPlayerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiMinigameState> GameState
		{
			get => GetPropertyValue<CHandle<gameuiMinigameState>>();
			set => SetPropertyValue<CHandle<gameuiMinigameState>>(value);
		}
	}
}
