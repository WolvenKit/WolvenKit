using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ComputerDocumentThumbnailWidgetController : DeviceButtonLogicControllerBase
	{
		private inkImageWidgetReference _documentIconWidget;
		private SDocumentAdress _documentAdress;
		private CEnum<EDocumentType> _documentType;
		private gamedeviceQuestInfo _questInfo;

		[Ordinal(26)] 
		[RED("documentIconWidget")] 
		public inkImageWidgetReference DocumentIconWidget
		{
			get => GetProperty(ref _documentIconWidget);
			set => SetProperty(ref _documentIconWidget, value);
		}

		[Ordinal(27)] 
		[RED("documentAdress")] 
		public SDocumentAdress DocumentAdress
		{
			get => GetProperty(ref _documentAdress);
			set => SetProperty(ref _documentAdress, value);
		}

		[Ordinal(28)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetProperty(ref _documentType);
			set => SetProperty(ref _documentType, value);
		}

		[Ordinal(29)] 
		[RED("questInfo")] 
		public gamedeviceQuestInfo QuestInfo
		{
			get => GetProperty(ref _questInfo);
			set => SetProperty(ref _questInfo, value);
		}
	}
}
