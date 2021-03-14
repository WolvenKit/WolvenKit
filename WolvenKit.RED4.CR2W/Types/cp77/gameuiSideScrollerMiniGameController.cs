using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _gameplayCanvas;
		private CName _gameName;

		[Ordinal(2)] 
		[RED("gameplayCanvas")] 
		public inkWidgetReference GameplayCanvas
		{
			get
			{
				if (_gameplayCanvas == null)
				{
					_gameplayCanvas = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gameplayCanvas", cr2w, this);
				}
				return _gameplayCanvas;
			}
			set
			{
				if (_gameplayCanvas == value)
				{
					return;
				}
				_gameplayCanvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public gameuiSideScrollerMiniGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
