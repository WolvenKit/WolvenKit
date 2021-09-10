using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SendScoreRequestAdvanced : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState
		{
			get => GetPropertyValue<CHandle<gameuiSideScrollerMiniGameStateAdvanced>>();
			set => SetPropertyValue<CHandle<gameuiSideScrollerMiniGameStateAdvanced>>(value);
		}

		[Ordinal(1)] 
		[RED("gameName")] 
		public CString GameName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
