using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialPopupGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _actionHint;
		private inkWidgetReference _popupPanel;
		private inkWidgetReference _popupFullscreenPanel;
		private inkWidgetReference _popupBlockingPanel;
		private inkWidgetReference _popupFullscreenRightPanel;
		private wCHandle<TutorialPopupData> _data;
		private CBool _inputBlocked;
		private CBool _gamePaused;
		private CUInt32 _isShownBbId;
		private CName _animIntroPopup;
		private CName _animIntroPopupModal;
		private CName _animIntroFullscreenLeft;
		private CName _animIntroFullscreenRight;
		private CName _animOutroPopup;
		private CName _animOutroPopupModal;
		private CName _animOutroFullscreenLeft;
		private CName _animOutroFullscreenRight;
		private CName _animIntro;
		private CName _animOutro;
		private inkWidgetReference _targetPopup;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(2)] 
		[RED("actionHint")] 
		public inkWidgetReference ActionHint
		{
			get
			{
				if (_actionHint == null)
				{
					_actionHint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "actionHint", cr2w, this);
				}
				return _actionHint;
			}
			set
			{
				if (_actionHint == value)
				{
					return;
				}
				_actionHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("popupPanel")] 
		public inkWidgetReference PopupPanel
		{
			get
			{
				if (_popupPanel == null)
				{
					_popupPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "popupPanel", cr2w, this);
				}
				return _popupPanel;
			}
			set
			{
				if (_popupPanel == value)
				{
					return;
				}
				_popupPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("popupFullscreenPanel")] 
		public inkWidgetReference PopupFullscreenPanel
		{
			get
			{
				if (_popupFullscreenPanel == null)
				{
					_popupFullscreenPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "popupFullscreenPanel", cr2w, this);
				}
				return _popupFullscreenPanel;
			}
			set
			{
				if (_popupFullscreenPanel == value)
				{
					return;
				}
				_popupFullscreenPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("popupBlockingPanel")] 
		public inkWidgetReference PopupBlockingPanel
		{
			get
			{
				if (_popupBlockingPanel == null)
				{
					_popupBlockingPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "popupBlockingPanel", cr2w, this);
				}
				return _popupBlockingPanel;
			}
			set
			{
				if (_popupBlockingPanel == value)
				{
					return;
				}
				_popupBlockingPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("popupFullscreenRightPanel")] 
		public inkWidgetReference PopupFullscreenRightPanel
		{
			get
			{
				if (_popupFullscreenRightPanel == null)
				{
					_popupFullscreenRightPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "popupFullscreenRightPanel", cr2w, this);
				}
				return _popupFullscreenRightPanel;
			}
			set
			{
				if (_popupFullscreenRightPanel == value)
				{
					return;
				}
				_popupFullscreenRightPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("data")] 
		public wCHandle<TutorialPopupData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (wCHandle<TutorialPopupData>) CR2WTypeManager.Create("whandle:TutorialPopupData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inputBlocked")] 
		public CBool InputBlocked
		{
			get
			{
				if (_inputBlocked == null)
				{
					_inputBlocked = (CBool) CR2WTypeManager.Create("Bool", "inputBlocked", cr2w, this);
				}
				return _inputBlocked;
			}
			set
			{
				if (_inputBlocked == value)
				{
					return;
				}
				_inputBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("gamePaused")] 
		public CBool GamePaused
		{
			get
			{
				if (_gamePaused == null)
				{
					_gamePaused = (CBool) CR2WTypeManager.Create("Bool", "gamePaused", cr2w, this);
				}
				return _gamePaused;
			}
			set
			{
				if (_gamePaused == value)
				{
					return;
				}
				_gamePaused = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isShownBbId")] 
		public CUInt32 IsShownBbId
		{
			get
			{
				if (_isShownBbId == null)
				{
					_isShownBbId = (CUInt32) CR2WTypeManager.Create("Uint32", "isShownBbId", cr2w, this);
				}
				return _isShownBbId;
			}
			set
			{
				if (_isShownBbId == value)
				{
					return;
				}
				_isShownBbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("animIntroPopup")] 
		public CName AnimIntroPopup
		{
			get
			{
				if (_animIntroPopup == null)
				{
					_animIntroPopup = (CName) CR2WTypeManager.Create("CName", "animIntroPopup", cr2w, this);
				}
				return _animIntroPopup;
			}
			set
			{
				if (_animIntroPopup == value)
				{
					return;
				}
				_animIntroPopup = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("animIntroPopupModal")] 
		public CName AnimIntroPopupModal
		{
			get
			{
				if (_animIntroPopupModal == null)
				{
					_animIntroPopupModal = (CName) CR2WTypeManager.Create("CName", "animIntroPopupModal", cr2w, this);
				}
				return _animIntroPopupModal;
			}
			set
			{
				if (_animIntroPopupModal == value)
				{
					return;
				}
				_animIntroPopupModal = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animIntroFullscreenLeft")] 
		public CName AnimIntroFullscreenLeft
		{
			get
			{
				if (_animIntroFullscreenLeft == null)
				{
					_animIntroFullscreenLeft = (CName) CR2WTypeManager.Create("CName", "animIntroFullscreenLeft", cr2w, this);
				}
				return _animIntroFullscreenLeft;
			}
			set
			{
				if (_animIntroFullscreenLeft == value)
				{
					return;
				}
				_animIntroFullscreenLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animIntroFullscreenRight")] 
		public CName AnimIntroFullscreenRight
		{
			get
			{
				if (_animIntroFullscreenRight == null)
				{
					_animIntroFullscreenRight = (CName) CR2WTypeManager.Create("CName", "animIntroFullscreenRight", cr2w, this);
				}
				return _animIntroFullscreenRight;
			}
			set
			{
				if (_animIntroFullscreenRight == value)
				{
					return;
				}
				_animIntroFullscreenRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animOutroPopup")] 
		public CName AnimOutroPopup
		{
			get
			{
				if (_animOutroPopup == null)
				{
					_animOutroPopup = (CName) CR2WTypeManager.Create("CName", "animOutroPopup", cr2w, this);
				}
				return _animOutroPopup;
			}
			set
			{
				if (_animOutroPopup == value)
				{
					return;
				}
				_animOutroPopup = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("animOutroPopupModal")] 
		public CName AnimOutroPopupModal
		{
			get
			{
				if (_animOutroPopupModal == null)
				{
					_animOutroPopupModal = (CName) CR2WTypeManager.Create("CName", "animOutroPopupModal", cr2w, this);
				}
				return _animOutroPopupModal;
			}
			set
			{
				if (_animOutroPopupModal == value)
				{
					return;
				}
				_animOutroPopupModal = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animOutroFullscreenLeft")] 
		public CName AnimOutroFullscreenLeft
		{
			get
			{
				if (_animOutroFullscreenLeft == null)
				{
					_animOutroFullscreenLeft = (CName) CR2WTypeManager.Create("CName", "animOutroFullscreenLeft", cr2w, this);
				}
				return _animOutroFullscreenLeft;
			}
			set
			{
				if (_animOutroFullscreenLeft == value)
				{
					return;
				}
				_animOutroFullscreenLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("animOutroFullscreenRight")] 
		public CName AnimOutroFullscreenRight
		{
			get
			{
				if (_animOutroFullscreenRight == null)
				{
					_animOutroFullscreenRight = (CName) CR2WTypeManager.Create("CName", "animOutroFullscreenRight", cr2w, this);
				}
				return _animOutroFullscreenRight;
			}
			set
			{
				if (_animOutroFullscreenRight == value)
				{
					return;
				}
				_animOutroFullscreenRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("animIntro")] 
		public CName AnimIntro
		{
			get
			{
				if (_animIntro == null)
				{
					_animIntro = (CName) CR2WTypeManager.Create("CName", "animIntro", cr2w, this);
				}
				return _animIntro;
			}
			set
			{
				if (_animIntro == value)
				{
					return;
				}
				_animIntro = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("animOutro")] 
		public CName AnimOutro
		{
			get
			{
				if (_animOutro == null)
				{
					_animOutro = (CName) CR2WTypeManager.Create("CName", "animOutro", cr2w, this);
				}
				return _animOutro;
			}
			set
			{
				if (_animOutro == value)
				{
					return;
				}
				_animOutro = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("targetPopup")] 
		public inkWidgetReference TargetPopup
		{
			get
			{
				if (_targetPopup == null)
				{
					_targetPopup = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetPopup", cr2w, this);
				}
				return _targetPopup;
			}
			set
			{
				if (_targetPopup == value)
				{
					return;
				}
				_targetPopup = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		public gameuiTutorialPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
