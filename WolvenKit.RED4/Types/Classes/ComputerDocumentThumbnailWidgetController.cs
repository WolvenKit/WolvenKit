using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerDocumentThumbnailWidgetController : DeviceButtonLogicControllerBase
	{
		[Ordinal(26)] 
		[RED("documentIconWidget")] 
		public inkImageWidgetReference DocumentIconWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("documentAdress")] 
		public SDocumentAdress DocumentAdress
		{
			get => GetPropertyValue<SDocumentAdress>();
			set => SetPropertyValue<SDocumentAdress>(value);
		}

		[Ordinal(28)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetPropertyValue<CEnum<EDocumentType>>();
			set => SetPropertyValue<CEnum<EDocumentType>>(value);
		}

		[Ordinal(29)] 
		[RED("questInfo")] 
		public gamedeviceQuestInfo QuestInfo
		{
			get => GetPropertyValue<gamedeviceQuestInfo>();
			set => SetPropertyValue<gamedeviceQuestInfo>(value);
		}

		public ComputerDocumentThumbnailWidgetController()
		{
			DocumentIconWidget = new inkImageWidgetReference();
			DocumentAdress = new SDocumentAdress { FolderID = -1, DocumentID = -1 };
			QuestInfo = new gamedeviceQuestInfo();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
