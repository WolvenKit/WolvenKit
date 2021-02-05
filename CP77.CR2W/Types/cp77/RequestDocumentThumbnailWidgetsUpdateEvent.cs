using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RequestDocumentThumbnailWidgetsUpdateEvent : RequestWidgetUpdateEvent
	{
		[Ordinal(0)]  [RED("requester")] public gamePersistentID Requester { get; set; }
		[Ordinal(1)]  [RED("screenDefinition")] public ScreenDefinitionPackage ScreenDefinition { get; set; }
		[Ordinal(2)]  [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }

		public RequestDocumentThumbnailWidgetsUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
