using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestDocumentThumbnailWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		[Ordinal(2)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetPropertyValue<CEnum<EDocumentType>>();
			set => SetPropertyValue<CEnum<EDocumentType>>(value);
		}

		public RequestDocumentThumbnailWidgetsUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
