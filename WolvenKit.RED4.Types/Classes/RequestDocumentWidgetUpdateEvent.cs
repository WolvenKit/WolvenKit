using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestDocumentWidgetUpdateEvent : RequestWidgetUpdateEvent
	{
		[Ordinal(2)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetPropertyValue<CEnum<EDocumentType>>();
			set => SetPropertyValue<CEnum<EDocumentType>>(value);
		}

		[Ordinal(3)] 
		[RED("documentAdress")] 
		public SDocumentAdress DocumentAdress
		{
			get => GetPropertyValue<SDocumentAdress>();
			set => SetPropertyValue<SDocumentAdress>(value);
		}

		public RequestDocumentWidgetUpdateEvent()
		{
			DocumentAdress = new() { FolderID = -1, DocumentID = -1 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
