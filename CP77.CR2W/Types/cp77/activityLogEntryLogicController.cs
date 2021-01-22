using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class activityLogEntryLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("appearingAnim")] public CHandle<inkanimController> AppearingAnim { get; set; }
		[Ordinal(1)]  [RED("available")] public CBool Available { get; set; }
		[Ordinal(2)]  [RED("disappearingAnim")] public CHandle<inkanimController> DisappearingAnim { get; set; }
		[Ordinal(3)]  [RED("disappearingAnimDef")] public CHandle<inkanimDefinition> DisappearingAnimDef { get; set; }
		[Ordinal(4)]  [RED("disappearingAnimProxy")] public CHandle<inkanimProxy> DisappearingAnimProxy { get; set; }
		[Ordinal(5)]  [RED("displayText")] public CString DisplayText { get; set; }
		[Ordinal(6)]  [RED("originalSize")] public CUInt16 OriginalSize { get; set; }
		[Ordinal(7)]  [RED("root")] public wCHandle<inkTextWidget> Root { get; set; }
		[Ordinal(8)]  [RED("size")] public CUInt16 Size { get; set; }
		[Ordinal(9)]  [RED("typingAnim")] public CHandle<inkanimController> TypingAnim { get; set; }
		[Ordinal(10)]  [RED("typingAnimDef")] public CHandle<inkanimDefinition> TypingAnimDef { get; set; }
		[Ordinal(11)]  [RED("typingAnimProxy")] public CHandle<inkanimProxy> TypingAnimProxy { get; set; }

		public activityLogEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
