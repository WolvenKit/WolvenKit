using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDocumentWidgetPackage : SWidgetPackage
	{
		[Ordinal(17)] [RED("owner")] public CString Owner { get; set; }
		[Ordinal(18)] [RED("date")] public CString Date { get; set; }
		[Ordinal(19)] [RED("title")] public CString Title { get; set; }
		[Ordinal(20)] [RED("content")] public CString Content { get; set; }
		[Ordinal(21)] [RED("image")] public TweakDBID Image { get; set; }
		[Ordinal(22)] [RED("videoPath")] public redResourceReferenceScriptToken VideoPath { get; set; }
		[Ordinal(23)] [RED("isEncrypted")] public CBool IsEncrypted { get; set; }
		[Ordinal(24)] [RED("questInfo")] public gamedeviceQuestInfo QuestInfo { get; set; }
		[Ordinal(25)] [RED("wasRead")] public CBool WasRead { get; set; }
		[Ordinal(26)] [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }

		public SDocumentWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
