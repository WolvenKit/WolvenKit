using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HudPhoneMessageController : HUDPhoneElement
	{
		[Ordinal(1)]  [RED("MessageText")] public inkTextWidgetReference MessageText { get; set; }
		[Ordinal(2)]  [RED("MessageAnim")] public CHandle<inkanimProxy> MessageAnim { get; set; }
		[Ordinal(3)]  [RED("ShowingAnimationName")] public CName ShowingAnimationName { get; set; }
		[Ordinal(4)]  [RED("HidingAnimationName")] public CName HidingAnimationName { get; set; }
		[Ordinal(5)]  [RED("VisibleAnimationName")] public CName VisibleAnimationName { get; set; }
		[Ordinal(6)]  [RED("MessageMaxLength")] public CInt32 MessageMaxLength { get; set; }
		[Ordinal(7)]  [RED("MessageTopper")] public CString MessageTopper { get; set; }
		[Ordinal(8)]  [RED("Paused")] public CBool Paused { get; set; }
		[Ordinal(9)]  [RED("CurrentMessage")] public wCHandle<gameJournalPhoneMessage> CurrentMessage { get; set; }
		[Ordinal(10)]  [RED("Queue")] public CArray<wCHandle<gameJournalPhoneMessage>> Queue { get; set; }

		public HudPhoneMessageController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
