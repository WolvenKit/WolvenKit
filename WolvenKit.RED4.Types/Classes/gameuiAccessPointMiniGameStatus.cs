using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiAccessPointMiniGameStatus : redEvent
	{
		private CEnum<gameuiHackingMinigameState> _minigameState;

		[Ordinal(0)] 
		[RED("minigameState")] 
		public CEnum<gameuiHackingMinigameState> MinigameState
		{
			get => GetProperty(ref _minigameState);
			set => SetProperty(ref _minigameState, value);
		}
	}
}
