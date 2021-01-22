using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiChatBoxGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("chatBox")] public inkWidgetReference ChatBox { get; set; }
		[Ordinal(1)]  [RED("chatBoxBlackboardId")] public CUInt32 ChatBoxBlackboardId { get; set; }
		[Ordinal(2)]  [RED("chatBoxOpen")] public CBool ChatBoxOpen { get; set; }
		[Ordinal(3)]  [RED("chatHistory")] public CArray<gameuiChatBoxText> ChatHistory { get; set; }
		[Ordinal(4)]  [RED("enteredText")] public inkTextInputWidgetReference EnteredText { get; set; }
		[Ordinal(5)]  [RED("historyContainer")] public wCHandle<inkVerticalPanelWidget> HistoryContainer { get; set; }
		[Ordinal(6)]  [RED("lastChatId")] public CInt32 LastChatId { get; set; }
		[Ordinal(7)]  [RED("maxChatHistory")] public CInt32 MaxChatHistory { get; set; }
		[Ordinal(8)]  [RED("maxChatsDisplayed")] public CInt32 MaxChatsDisplayed { get; set; }
		[Ordinal(9)]  [RED("player")] public wCHandle<gamePuppetBase> Player { get; set; }
		[Ordinal(10)]  [RED("recentChatsShown")] public CArray<wCHandle<inkWidget>> RecentChatsShown { get; set; }
		[Ordinal(11)]  [RED("recentContainer")] public wCHandle<inkVerticalPanelWidget> RecentContainer { get; set; }

		public gameuiChatBoxGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
