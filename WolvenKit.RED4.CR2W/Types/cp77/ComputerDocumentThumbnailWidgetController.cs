using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerDocumentThumbnailWidgetController : DeviceButtonLogicControllerBase
	{
		private inkImageWidgetReference _documentIconWidget;
		private SDocumentAdress _documentAdress;
		private CEnum<EDocumentType> _documentType;
		private gamedeviceQuestInfo _questInfo;

		[Ordinal(26)] 
		[RED("documentIconWidget")] 
		public inkImageWidgetReference DocumentIconWidget
		{
			get
			{
				if (_documentIconWidget == null)
				{
					_documentIconWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "documentIconWidget", cr2w, this);
				}
				return _documentIconWidget;
			}
			set
			{
				if (_documentIconWidget == value)
				{
					return;
				}
				_documentIconWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
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

		[Ordinal(28)] 
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

		[Ordinal(29)] 
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

		public ComputerDocumentThumbnailWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
