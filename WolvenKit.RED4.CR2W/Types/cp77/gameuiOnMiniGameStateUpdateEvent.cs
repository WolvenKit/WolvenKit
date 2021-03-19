using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOnMiniGameStateUpdateEvent : redEvent
	{
		private CHandle<gameuiMinigameState> _gameState;
		private CName _gameName;

		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiMinigameState> GameState
		{
			get => GetProperty(ref _gameState);
			set => SetProperty(ref _gameState, value);
		}

		[Ordinal(1)] 
		[RED("gameName")] 
		public CName GameName
		{
			get => GetProperty(ref _gameName);
			set => SetProperty(ref _gameName, value);
		}

		public gameuiOnMiniGameStateUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
