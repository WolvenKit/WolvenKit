using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDocumentWidgetPackage : SWidgetPackage
	{
		private CString _owner;
		private CString _date;
		private CString _title;
		private CString _content;
		private TweakDBID _image;
		private redResourceReferenceScriptToken _videoPath;
		private CBool _isEncrypted;
		private gamedeviceQuestInfo _questInfo;
		private CBool _wasRead;
		private CEnum<EDocumentType> _documentType;

		[Ordinal(17)] 
		[RED("owner")] 
		public CString Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (CString) CR2WTypeManager.Create("String", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("date")] 
		public CString Date
		{
			get
			{
				if (_date == null)
				{
					_date = (CString) CR2WTypeManager.Create("String", "date", cr2w, this);
				}
				return _date;
			}
			set
			{
				if (_date == value)
				{
					return;
				}
				_date = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("content")] 
		public CString Content
		{
			get
			{
				if (_content == null)
				{
					_content = (CString) CR2WTypeManager.Create("String", "content", cr2w, this);
				}
				return _content;
			}
			set
			{
				if (_content == value)
				{
					return;
				}
				_content = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("image")] 
		public TweakDBID Image
		{
			get
			{
				if (_image == null)
				{
					_image = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "image", cr2w, this);
				}
				return _image;
			}
			set
			{
				if (_image == value)
				{
					return;
				}
				_image = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get
			{
				if (_videoPath == null)
				{
					_videoPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "videoPath", cr2w, this);
				}
				return _videoPath;
			}
			set
			{
				if (_videoPath == value)
				{
					return;
				}
				_videoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isEncrypted")] 
		public CBool IsEncrypted
		{
			get
			{
				if (_isEncrypted == null)
				{
					_isEncrypted = (CBool) CR2WTypeManager.Create("Bool", "isEncrypted", cr2w, this);
				}
				return _isEncrypted;
			}
			set
			{
				if (_isEncrypted == value)
				{
					return;
				}
				_isEncrypted = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("questInfo")] 
		public gamedeviceQuestInfo QuestInfo
		{
			get
			{
				if (_questInfo == null)
				{
					_questInfo = (gamedeviceQuestInfo) CR2WTypeManager.Create("gamedeviceQuestInfo", "questInfo", cr2w, this);
				}
				return _questInfo;
			}
			set
			{
				if (_questInfo == value)
				{
					return;
				}
				_questInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("wasRead")] 
		public CBool WasRead
		{
			get
			{
				if (_wasRead == null)
				{
					_wasRead = (CBool) CR2WTypeManager.Create("Bool", "wasRead", cr2w, this);
				}
				return _wasRead;
			}
			set
			{
				if (_wasRead == value)
				{
					return;
				}
				_wasRead = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get
			{
				if (_documentType == null)
				{
					_documentType = (CEnum<EDocumentType>) CR2WTypeManager.Create("EDocumentType", "documentType", cr2w, this);
				}
				return _documentType;
			}
			set
			{
				if (_documentType == value)
				{
					return;
				}
				_documentType = value;
				PropertySet(this);
			}
		}

		public SDocumentWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
