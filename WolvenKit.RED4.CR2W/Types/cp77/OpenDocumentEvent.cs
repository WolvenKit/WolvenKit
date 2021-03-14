using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenDocumentEvent : redEvent
	{
		private CEnum<EDocumentType> _documentType;
		private CName _documentName;
		private SDocumentAdress _documentAdress;
		private CBool _wakeUp;
		private entEntityID _ownerID;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("wakeUp")] 
		public CBool WakeUp
		{
			get
			{
				if (_wakeUp == null)
				{
					_wakeUp = (CBool) CR2WTypeManager.Create("Bool", "wakeUp", cr2w, this);
				}
				return _wakeUp;
			}
			set
			{
				if (_wakeUp == value)
				{
					return;
				}
				_wakeUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		public OpenDocumentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
