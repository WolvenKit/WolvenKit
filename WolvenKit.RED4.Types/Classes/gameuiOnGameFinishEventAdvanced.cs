using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiOnGameFinishEventAdvanced : redEvent
	{
		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState
		{
			get => GetPropertyValue<CHandle<gameuiSideScrollerMiniGameStateAdvanced>>();
			set => SetPropertyValue<CHandle<gameuiSideScrollerMiniGameStateAdvanced>>(value);
		}
	}
}
