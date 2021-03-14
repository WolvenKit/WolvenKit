using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOnGameFinishEvent : redEvent
	{
		private CHandle<gameuiMinigameState> _gameState;
		private CName _gameName;

		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiMinigameState> GameState
		{
			get
			{
				if (_gameState == null)
				{
					_gameState = (CHandle<gameuiMinigameState>) CR2WTypeManager.Create("handle:gameuiMinigameState", "gameState", cr2w, this);
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
		public CName GameName
		{
			get
			{
				if (_gameName == null)
				{
					_gameName = (CName) CR2WTypeManager.Create("CName", "gameName", cr2w, this);
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

		public gameuiOnGameFinishEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
