using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestDocumentWidgetUpdateEvent : RequestWidgetUpdateEvent
	{
		[Ordinal(2)] [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }
		[Ordinal(3)] [RED("documentAdress")] public SDocumentAdress DocumentAdress { get; set; }

		public RequestDocumentWidgetUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
