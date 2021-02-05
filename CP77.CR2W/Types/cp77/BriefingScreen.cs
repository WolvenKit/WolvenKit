using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BriefingScreen : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("logicControllerRef")] public inkWidgetReference LogicControllerRef { get; set; }
		[Ordinal(8)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(9)]  [RED("bbOpenerEventID")] public CUInt32 BbOpenerEventID { get; set; }
		[Ordinal(10)]  [RED("bbSizeEventID")] public CUInt32 BbSizeEventID { get; set; }
		[Ordinal(11)]  [RED("bbAlignmentEventID")] public CUInt32 BbAlignmentEventID { get; set; }

		public BriefingScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
