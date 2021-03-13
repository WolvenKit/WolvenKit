using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDocumentStateEvent : redEvent
	{
		[Ordinal(0)] [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }
		[Ordinal(1)] [RED("documentAdress")] public SDocumentAdress DocumentAdress { get; set; }
		[Ordinal(2)] [RED("isOpened")] public CBool IsOpened { get; set; }

		public SetDocumentStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
