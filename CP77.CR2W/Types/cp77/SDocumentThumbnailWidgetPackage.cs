using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SDocumentThumbnailWidgetPackage : SWidgetPackage
	{
		[Ordinal(0)]  [RED("folderName")] public CString FolderName { get; set; }
		[Ordinal(1)]  [RED("documentAdress")] public SDocumentAdress DocumentAdress { get; set; }
		[Ordinal(2)]  [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }
		[Ordinal(3)]  [RED("questInfo")] public gamedeviceQuestInfo QuestInfo { get; set; }
		[Ordinal(4)]  [RED("wasRead")] public CBool WasRead { get; set; }
		[Ordinal(5)]  [RED("isOpened")] public CBool IsOpened { get; set; }

		public SDocumentThumbnailWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
