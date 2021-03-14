using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDocumentThumbnailWidgetPackage : SWidgetPackage
	{
		[Ordinal(17)] [RED("folderName")] public CString FolderName { get; set; }
		[Ordinal(18)] [RED("documentAdress")] public SDocumentAdress DocumentAdress { get; set; }
		[Ordinal(19)] [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }
		[Ordinal(20)] [RED("questInfo")] public gamedeviceQuestInfo QuestInfo { get; set; }
		[Ordinal(21)] [RED("wasRead")] public CBool WasRead { get; set; }
		[Ordinal(22)] [RED("isOpened")] public CBool IsOpened { get; set; }

		public SDocumentThumbnailWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
