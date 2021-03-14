using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubTimeSkipController : inkWidgetLogicController
	{
		private inkTextWidgetReference _gameTimeText;
		private inkWidgetReference _cantSkipTimeContainer;
		private inkWidgetReference _timeSkipButton;
		private wCHandle<gameuiMenuGameController> _gameCtrlRef;
		private wCHandle<gameTimeSystem> _timeSystem;
		private CHandle<inkGameNotificationToken> _timeSkipPopupToken;
		private CHandle<inkanimProxy> _cantSkipTimeAnim;
		private CHandle<textTextParameterSet> _gameTimeTextParams;
		private CBool _canSkipTime;

		[Ordinal(1)] 
		[RED("gameTimeText")] 
		public inkTextWidgetReference GameTimeText
		{
			get
			{
				if (_gameTimeText == null)
				{
					_gameTimeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "gameTimeText", cr2w, this);
				}
				return _gameTimeText;
			}
			set
			{
				if (_gameTimeText == value)
				{
					return;
				}
				_gameTimeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cantSkipTimeContainer")] 
		public inkWidgetReference CantSkipTimeContainer
		{
			get
			{
				if (_cantSkipTimeContainer == null)
				{
					_cantSkipTimeContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "cantSkipTimeContainer", cr2w, this);
				}
				return _cantSkipTimeContainer;
			}
			set
			{
				if (_cantSkipTimeContainer == value)
				{
					return;
				}
				_cantSkipTimeContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeSkipButton")] 
		public inkWidgetReference TimeSkipButton
		{
			get
			{
				if (_timeSkipButton == null)
				{
					_timeSkipButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "timeSkipButton", cr2w, this);
				}
				return _timeSkipButton;
			}
			set
			{
				if (_timeSkipButton == value)
				{
					return;
				}
				_timeSkipButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("gameCtrlRef")] 
		public wCHandle<gameuiMenuGameController> GameCtrlRef
		{
			get
			{
				if (_gameCtrlRef == null)
				{
					_gameCtrlRef = (wCHandle<gameuiMenuGameController>) CR2WTypeManager.Create("whandle:gameuiMenuGameController", "gameCtrlRef", cr2w, this);
				}
				return _gameCtrlRef;
			}
			set
			{
				if (_gameCtrlRef == value)
				{
					return;
				}
				_gameCtrlRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("timeSystem")] 
		public wCHandle<gameTimeSystem> TimeSystem
		{
			get
			{
				if (_timeSystem == null)
				{
					_timeSystem = (wCHandle<gameTimeSystem>) CR2WTypeManager.Create("whandle:gameTimeSystem", "timeSystem", cr2w, this);
				}
				return _timeSystem;
			}
			set
			{
				if (_timeSystem == value)
				{
					return;
				}
				_timeSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timeSkipPopupToken")] 
		public CHandle<inkGameNotificationToken> TimeSkipPopupToken
		{
			get
			{
				if (_timeSkipPopupToken == null)
				{
					_timeSkipPopupToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "timeSkipPopupToken", cr2w, this);
				}
				return _timeSkipPopupToken;
			}
			set
			{
				if (_timeSkipPopupToken == value)
				{
					return;
				}
				_timeSkipPopupToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cantSkipTimeAnim")] 
		public CHandle<inkanimProxy> CantSkipTimeAnim
		{
			get
			{
				if (_cantSkipTimeAnim == null)
				{
					_cantSkipTimeAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "cantSkipTimeAnim", cr2w, this);
				}
				return _cantSkipTimeAnim;
			}
			set
			{
				if (_cantSkipTimeAnim == value)
				{
					return;
				}
				_cantSkipTimeAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("gameTimeTextParams")] 
		public CHandle<textTextParameterSet> GameTimeTextParams
		{
			get
			{
				if (_gameTimeTextParams == null)
				{
					_gameTimeTextParams = (CHandle<textTextParameterSet>) CR2WTypeManager.Create("handle:textTextParameterSet", "gameTimeTextParams", cr2w, this);
				}
				return _gameTimeTextParams;
			}
			set
			{
				if (_gameTimeTextParams == value)
				{
					return;
				}
				_gameTimeTextParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("canSkipTime")] 
		public CBool CanSkipTime
		{
			get
			{
				if (_canSkipTime == null)
				{
					_canSkipTime = (CBool) CR2WTypeManager.Create("Bool", "canSkipTime", cr2w, this);
				}
				return _canSkipTime;
			}
			set
			{
				if (_canSkipTime == value)
				{
					return;
				}
				_canSkipTime = value;
				PropertySet(this);
			}
		}

		public HubTimeSkipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
