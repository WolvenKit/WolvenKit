using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOnMiniGameStateUpdateEventAdvanced : redEvent
	{
		private CHandle<gameuiSideScrollerMiniGameStateAdvanced> _gameState;
		private CArray<CName> _propertyNames;

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
		[RED("propertyNames")] 
		public CArray<CName> PropertyNames
		{
			get
			{
				if (_propertyNames == null)
				{
					_propertyNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "propertyNames", cr2w, this);
				}
				return _propertyNames;
			}
			set
			{
				if (_propertyNames == value)
				{
					return;
				}
				_propertyNames = value;
				PropertySet(this);
			}
		}

		public gameuiOnMiniGameStateUpdateEventAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
