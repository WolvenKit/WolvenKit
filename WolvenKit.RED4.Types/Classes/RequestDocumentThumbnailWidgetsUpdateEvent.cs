using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestDocumentThumbnailWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		[Ordinal(2)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetPropertyValue<CEnum<EDocumentType>>();
			set => SetPropertyValue<CEnum<EDocumentType>>(value);
		}
	}
}
