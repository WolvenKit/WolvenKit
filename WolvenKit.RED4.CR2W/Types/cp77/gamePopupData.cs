using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePopupData : CVariable
	{
		private CString _title;
		private CString _message;
		private TweakDBID _iconID;
		private CBool _isModal;
		private CEnum<gameVideoType> _videoType;
		private raRef<Bink> _video;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get
			{
				if (_iconID == null)
				{
					_iconID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "iconID", cr2w, this);
				}
				return _iconID;
			}
			set
			{
				if (_iconID == value)
				{
					return;
				}
				_iconID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		public gamePopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
