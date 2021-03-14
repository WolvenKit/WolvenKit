using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceDataElement : CVariable
	{
		private CString _owner;
		private CString _date;
		private CString _title;
		private CString _content;
		private redResourceReferenceScriptToken _videoPath;
		private CHandle<gameJournalPath> _journalPath;
		private CName _documentName;
		private gamedeviceQuestInfo _questInfo;
		private CBool _isEncrypted;
		private CBool _wasRead;
		private CBool _isEnabled;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("journalPath")] 
		public CHandle<gameJournalPath> JournalPath
		{
			get
			{
				if (_journalPath == null)
				{
					_journalPath = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "journalPath", cr2w, this);
				}
				return _journalPath;
			}
			set
			{
				if (_journalPath == value)
				{
					return;
				}
				_journalPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("documentName")] 
		public CName DocumentName
		{
			get
			{
				if (_documentName == null)
				{
					_documentName = (CName) CR2WTypeManager.Create("CName", "documentName", cr2w, this);
				}
				return _documentName;
			}
			set
			{
				if (_documentName == value)
				{
					return;
				}
				_documentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public gamedeviceDataElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
