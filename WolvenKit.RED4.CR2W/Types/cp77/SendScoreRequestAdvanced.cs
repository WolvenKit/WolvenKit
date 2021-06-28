using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendScoreRequestAdvanced : gameScriptableSystemRequest
	{
		private CHandle<gameuiSideScrollerMiniGameStateAdvanced> _gameState;
		private CString _gameName;

		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState
		{
			get => GetProperty(ref _gameState);
			set => SetProperty(ref _gameState, value);
		}

		[Ordinal(1)] 
		[RED("gameName")] 
		public CString GameName
		{
			get => GetProperty(ref _gameName);
			set => SetProperty(ref _gameName, value);
		}

		public SendScoreRequestAdvanced(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
