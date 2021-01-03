using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OpenDocumentEvent : redEvent
	{
		[Ordinal(0)]  [RED("documentAdress")] public SDocumentAdress DocumentAdress { get; set; }
		[Ordinal(1)]  [RED("documentName")] public CName DocumentName { get; set; }
		[Ordinal(2)]  [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }
		[Ordinal(3)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(4)]  [RED("wakeUp")] public CBool WakeUp { get; set; }

		public OpenDocumentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
