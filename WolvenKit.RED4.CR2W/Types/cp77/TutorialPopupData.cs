using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TutorialPopupData : inkGameNotificationData
	{
		private CBool _closeAtInput;
		private CBool _pauseGame;
		private CBool _isModal;
		private CEnum<gamePopupPosition> _position;
		private inkMargin _margin;
		private TweakDBID _imageId;
		private CString _title;
		private CString _message;
		private CEnum<gameVideoType> _videoType;
		private redResourceReferenceScriptToken _video;

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("isModal")] 
		public CBool IsModal
		{
			get
			{
				if (_isModal == null)
				{
					_isModal = (CBool) CR2WTypeManager.Create("Bool", "isModal", cr2w, this);
				}
				return _isModal;
			}
			set
			{
				if (_isModal == value)
				{
					return;
				}
				_isModal = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get
			{
				if (_imageId == null)
				{
					_imageId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "imageId", cr2w, this);
				}
				return _imageId;
			}
			set
			{
				if (_imageId == value)
				{
					return;
				}
				_imageId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("message")] 
		public CString Message
		{
			get
			{
				if (_message == null)
				{
					_message = (CString) CR2WTypeManager.Create("String", "message", cr2w, this);
				}
				return _message;
			}
			set
			{
				if (_message == value)
				{
					return;
				}
				_message = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("video")] 
		public redResourceReferenceScriptToken Video
		{
			get
			{
				if (_video == null)
				{
					_video = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "video", cr2w, this);
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

		public TutorialPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
