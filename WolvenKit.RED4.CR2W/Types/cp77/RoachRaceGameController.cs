using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoachRaceGameController : gameuiSideScrollerMiniGameController
	{
		private inkWidgetReference _gameMenu;
		private inkWidgetReference _scoreboardMenu;
		private CBool _isCutsceneInProgress;

		[Ordinal(4)] 
		[RED("gameMenu")] 
		public inkWidgetReference GameMenu
		{
			get
			{
				if (_gameMenu == null)
				{
					_gameMenu = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gameMenu", cr2w, this);
				}
				return _gameMenu;
			}
			set
			{
				if (_gameMenu == value)
				{
					return;
				}
				_gameMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scoreboardMenu")] 
		public inkWidgetReference ScoreboardMenu
		{
			get
			{
				if (_scoreboardMenu == null)
				{
					_scoreboardMenu = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "scoreboardMenu", cr2w, this);
				}
				return _scoreboardMenu;
			}
			set
			{
				if (_scoreboardMenu == value)
				{
					return;
				}
				_scoreboardMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isCutsceneInProgress")] 
		public CBool IsCutsceneInProgress
		{
			get
			{
				if (_isCutsceneInProgress == null)
				{
					_isCutsceneInProgress = (CBool) CR2WTypeManager.Create("Bool", "isCutsceneInProgress", cr2w, this);
				}
				return _isCutsceneInProgress;
			}
			set
			{
				if (_isCutsceneInProgress == value)
				{
					return;
				}
				_isCutsceneInProgress = value;
				PropertySet(this);
			}
		}

		public RoachRaceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
