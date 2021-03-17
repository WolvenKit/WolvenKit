using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestDocumentThumbnailWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		private CEnum<EDocumentType> _documentType;

		[Ordinal(2)] 
		[RED("documentType")] 
		public CEnum<EDocumentType> DocumentType
		{
			get => GetProperty(ref _documentType);
			set => SetProperty(ref _documentType, value);
		}

		public RequestDocumentThumbnailWidgetsUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
