using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOnGameFinishEventAdvanced : redEvent
	{
		private CHandle<gameuiSideScrollerMiniGameStateAdvanced> _gameState;

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

		public gameuiOnGameFinishEventAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
