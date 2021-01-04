using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SDocumentWidgetPackage : SWidgetPackage
	{
		[Ordinal(0)]  [RED("content")] public CString Content { get; set; }
		[Ordinal(1)]  [RED("date")] public CString Date { get; set; }
		[Ordinal(2)]  [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }
		[Ordinal(3)]  [RED("image")] public TweakDBID Image { get; set; }
		[Ordinal(4)]  [RED("isEncrypted")] public CBool IsEncrypted { get; set; }
		[Ordinal(5)]  [RED("owner")] public CString Owner { get; set; }
		[Ordinal(6)]  [RED("questInfo")] public gamedeviceQuestInfo QuestInfo { get; set; }
		[Ordinal(7)]  [RED("title")] public CString Title { get; set; }
		[Ordinal(8)]  [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }
		[Ordinal(9)]  [RED("wasRead")] public CBool WasRead { get; set; }

		public SDocumentWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
