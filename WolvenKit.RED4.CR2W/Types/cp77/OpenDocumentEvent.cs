using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenDocumentEvent : redEvent
	{
		[Ordinal(0)] [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }
		[Ordinal(1)] [RED("documentName")] public CName DocumentName { get; set; }
		[Ordinal(2)] [RED("documentAdress")] public SDocumentAdress DocumentAdress { get; set; }
		[Ordinal(3)] [RED("wakeUp")] public CBool WakeUp { get; set; }
		[Ordinal(4)] [RED("ownerID")] public entEntityID OwnerID { get; set; }

		public OpenDocumentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
