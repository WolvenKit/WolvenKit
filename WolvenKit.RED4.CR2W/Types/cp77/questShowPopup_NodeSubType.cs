using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowPopup_NodeSubType : questITutorial_NodeSubType
	{
		private CHandle<gameJournalPath> _path;
		private CBool _open;
		private CBool _closeAtInput;
		private CBool _pauseGame;
		private CBool _hideInMenu;
		private inkMargin _margin;
		private CEnum<questTutorialScreenMode> _screenMode;
		private CEnum<gamePopupPosition> _position;
		private CBool _lockPlayerMovement;
		private CBool _closeCurrentPopup;
		private CEnum<gameVideoType> _videoType;
		private raRef<Bink> _video;
		private CBool _ignoreDisabledTutorials;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("open")] 
		public CBool Open
		{
			get
			{
				if (_open == null)
				{
					_open = (CBool) CR2WTypeManager.Create("Bool", "open", cr2w, this);
				}
				return _open;
			}
			set
			{
				if (_open == value)
				{
					return;
				}
				_open = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("closeAtInput")] 
		public CBool CloseAtInput
		{
			get
			{
				if (_closeAtInput == null)
				{
					_closeAtInput = (CBool) CR2WTypeManager.Create("Bool", "closeAtInput", cr2w, this);
				}
				return _closeAtInput;
			}
			set
			{
				if (_closeAtInput == value)
				{
					return;
				}
				_closeAtInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get
			{
				if (_pauseGame == null)
				{
					_pauseGame = (CBool) CR2WTypeManager.Create("Bool", "pauseGame", cr2w, this);
				}
				return _pauseGame;
			}
			set
			{
				if (_pauseGame == value)
				{
					return;
				}
				_pauseGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hideInMenu")] 
		public CBool HideInMenu
		{
			get
			{
				if (_hideInMenu == null)
				{
					_hideInMenu = (CBool) CR2WTypeManager.Create("Bool", "hideInMenu", cr2w, this);
				}
				return _hideInMenu;
			}
			set
			{
				if (_hideInMenu == value)
				{
					return;
				}
				_hideInMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get
			{
				if (_margin == null)
				{
					_margin = (inkMargin) CR2WTypeManager.Create("inkMargin", "margin", cr2w, this);
				}
				return _margin;
			}
			set
			{
				if (_margin == value)
				{
					return;
				}
				_margin = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("screenMode")] 
		public CEnum<questTutorialScreenMode> ScreenMode
		{
			get
			{
				if (_screenMode == null)
				{
					_screenMode = (CEnum<questTutorialScreenMode>) CR2WTypeManager.Create("questTutorialScreenMode", "screenMode", cr2w, this);
				}
				return _screenMode;
			}
			set
			{
				if (_screenMode == value)
				{
					return;
				}
				_screenMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("position")] 
		public CEnum<gamePopupPosition> Position
		{
			get
			{
				if (_position == null)
				{
					_position = (CEnum<gamePopupPosition>) CR2WTypeManager.Create("gamePopupPosition", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("lockPlayerMovement")] 
		public CBool LockPlayerMovement
		{
			get
			{
				if (_lockPlayerMovement == null)
				{
					_lockPlayerMovement = (CBool) CR2WTypeManager.Create("Bool", "lockPlayerMovement", cr2w, this);
				}
				return _lockPlayerMovement;
			}
			set
			{
				if (_lockPlayerMovement == value)
				{
					return;
				}
				_lockPlayerMovement = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("closeCurrentPopup")] 
		public CBool CloseCurrentPopup
		{
			get
			{
				if (_closeCurrentPopup == null)
				{
					_closeCurrentPopup = (CBool) CR2WTypeManager.Create("Bool", "closeCurrentPopup", cr2w, this);
				}
				return _closeCurrentPopup;
			}
			set
			{
				if (_closeCurrentPopup == value)
				{
					return;
				}
				_closeCurrentPopup = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("videoType")] 
		public CEnum<gameVideoType> VideoType
		{
			get
			{
				if (_videoType == null)
				{
					_videoType = (CEnum<gameVideoType>) CR2WTypeManager.Create("gameVideoType", "videoType", cr2w, this);
				}
				return _videoType;
			}
			set
			{
				if (_videoType == value)
				{
					return;
				}
				_videoType = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("video")] 
		public raRef<Bink> Video
		{
			get
			{
				if (_video == null)
				{
					_video = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "video", cr2w, this);
				}
				return _video;
			}
			set
			{
				if (_video == value)
				{
					return;
				}
				_video = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("ignoreDisabledTutorials")] 
		public CBool IgnoreDisabledTutorials
		{
			get
			{
				if (_ignoreDisabledTutorials == null)
				{
					_ignoreDisabledTutorials = (CBool) CR2WTypeManager.Create("Bool", "ignoreDisabledTutorials", cr2w, this);
				}
				return _ignoreDisabledTutorials;
			}
			set
			{
				if (_ignoreDisabledTutorials == value)
				{
					return;
				}
				_ignoreDisabledTutorials = value;
				PropertySet(this);
			}
		}

		public questShowPopup_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
