using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDocumentStateEvent : redEvent
	{
		private CEnum<EDocumentType> _documentType;
		private SDocumentAdress _documentAdress;
		private CBool _isOpened;

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

		[Ordinal(2)] 
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

		public SetDocumentStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
