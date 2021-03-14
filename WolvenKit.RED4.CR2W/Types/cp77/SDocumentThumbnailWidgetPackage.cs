using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDocumentThumbnailWidgetPackage : SWidgetPackage
	{
		private CString _folderName;
		private SDocumentAdress _documentAdress;
		private CEnum<EDocumentType> _documentType;
		private gamedeviceQuestInfo _questInfo;
		private CBool _wasRead;
		private CBool _isOpened;

		[Ordinal(17)] 
		[RED("folderName")] 
		public CString FolderName
		{
			get
			{
				if (_folderName == null)
				{
					_folderName = (CString) CR2WTypeManager.Create("String", "folderName", cr2w, this);
				}
				return _folderName;
			}
			set
			{
				if (_folderName == value)
				{
					return;
				}
				_folderName = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("documentAdress")] 
		public SDocumentAdress DocumentAdress
		{
			get
			{
				if (_documentAdress == null)
				{
					_documentAdress = (SDocumentAdress) CR2WTypeManager.Create("SDocumentAdress", "documentAdress", cr2w, this);
				}
				return _documentAdress;
			}
			set
			{
				if (_documentAdress == value)
				{
					return;
				}
				_documentAdress = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
		[RED("isOpened")] 
		public CBool IsOpened
		{
			get
			{
				if (_isOpened == null)
				{
					_isOpened = (CBool) CR2WTypeManager.Create("Bool", "isOpened", cr2w, this);
				}
				return _isOpened;
			}
			set
			{
				if (_isOpened == value)
				{
					return;
				}
				_isOpened = value;
				PropertySet(this);
			}
		}

		public SDocumentThumbnailWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
