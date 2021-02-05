using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerDocumentWidgetController : DeviceInkLogicControllerBase
	{
		[Ordinal(0)]  [RED("targetWidgetRef")] public inkWidgetReference TargetWidgetRef { get; set; }
		[Ordinal(1)]  [RED("displayNameWidget")] public inkTextWidgetReference DisplayNameWidget { get; set; }
		[Ordinal(2)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(3)]  [RED("targetWidget")] public wCHandle<inkWidget> TargetWidget { get; set; }
		[Ordinal(4)]  [RED("titleWidget")] public inkTextWidgetReference TitleWidget { get; set; }
		[Ordinal(5)]  [RED("ownerNameWidget")] public inkTextWidgetReference OwnerNameWidget { get; set; }
		[Ordinal(6)]  [RED("dateWidget")] public inkTextWidgetReference DateWidget { get; set; }
		[Ordinal(7)]  [RED("datePanelWidget")] public inkTextWidgetReference DatePanelWidget { get; set; }
		[Ordinal(8)]  [RED("ownerPanelWidget")] public inkTextWidgetReference OwnerPanelWidget { get; set; }
		[Ordinal(9)]  [RED("textContentWidget")] public inkTextWidgetReference TextContentWidget { get; set; }
		[Ordinal(10)]  [RED("textContentHolder")] public inkWidgetReference TextContentHolder { get; set; }
		[Ordinal(11)]  [RED("videoContentWidget")] public inkVideoWidgetReference VideoContentWidget { get; set; }
		[Ordinal(12)]  [RED("imageContentWidget")] public inkImageWidgetReference ImageContentWidget { get; set; }
		[Ordinal(13)]  [RED("closeButtonWidget")] public inkWidgetReference CloseButtonWidget { get; set; }
		[Ordinal(14)]  [RED("documentType")] public CEnum<EDocumentType> DocumentType { get; set; }
		[Ordinal(15)]  [RED("lastPlayedVideo")] public redResourceReferenceScriptToken LastPlayedVideo { get; set; }

		public ComputerDocumentWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
