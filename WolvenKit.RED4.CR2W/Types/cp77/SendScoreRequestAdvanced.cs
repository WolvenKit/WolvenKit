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
			get
			{
				if (_gameState == null)
				{
					_gameState = (CHandle<gameuiSideScrollerMiniGameStateAdvanced>) CR2WTypeManager.Create("handle:gameuiSideScrollerMiniGameStateAdvanced", "gameState", cr2w, this);
				}
				return _gameState;
			}
			set
			{
				if (_gameState == value)
				{
					return;
				}
				_gameState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("gameName")] 
		public CString GameName
		{
			get
			{
				if (_gameName == null)
				{
					_gameName = (CString) CR2WTypeManager.Create("String", "gameName", cr2w, this);
				}
				return _gameName;
			}
			set
			{
				if (_gameName == value)
				{
					return;
				}
				_gameName = value;
				PropertySet(this);
			}
		}

		public SendScoreRequestAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
