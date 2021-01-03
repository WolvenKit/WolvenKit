using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HudPhoneMessageController : HUDPhoneElement
	{
		[Ordinal(0)]  [RED("CurrentMessage")] public wCHandle<gameJournalPhoneMessage> CurrentMessage { get; set; }
		[Ordinal(1)]  [RED("HidingAnimationName")] public CName HidingAnimationName { get; set; }
		[Ordinal(2)]  [RED("MessageAnim")] public CHandle<inkanimProxy> MessageAnim { get; set; }
		[Ordinal(3)]  [RED("MessageMaxLength")] public CInt32 MessageMaxLength { get; set; }
		[Ordinal(4)]  [RED("MessageText")] public inkTextWidgetReference MessageText { get; set; }
		[Ordinal(5)]  [RED("MessageTopper")] public CString MessageTopper { get; set; }
		[Ordinal(6)]  [RED("Paused")] public CBool Paused { get; set; }
		[Ordinal(7)]  [RED("Queue")] public CArray<wCHandle<gameJournalPhoneMessage>> Queue { get; set; }
		[Ordinal(8)]  [RED("ShowingAnimationName")] public CName ShowingAnimationName { get; set; }
		[Ordinal(9)]  [RED("VisibleAnimationName")] public CName VisibleAnimationName { get; set; }

		public HudPhoneMessageController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
