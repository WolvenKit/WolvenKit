using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessengerDialogViewController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("messagesList")] public inkCompoundWidgetReference MessagesList { get; set; }
		[Ordinal(2)] [RED("choicesList")] public inkCompoundWidgetReference ChoicesList { get; set; }
		[Ordinal(3)] [RED("replayFluff")] public inkCompoundWidgetReference ReplayFluff { get; set; }
		[Ordinal(4)] [RED("messagesListController")] public wCHandle<JournalEntriesListController> MessagesListController { get; set; }
		[Ordinal(5)] [RED("choicesListController")] public wCHandle<JournalEntriesListController> ChoicesListController { get; set; }
		[Ordinal(6)] [RED("scrollController")] public wCHandle<inkScrollController> ScrollController { get; set; }
		[Ordinal(7)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(8)] [RED("replyOptions")] public CArray<wCHandle<gameJournalEntry>> ReplyOptions { get; set; }
		[Ordinal(9)] [RED("messages")] public CArray<wCHandle<gameJournalEntry>> Messages { get; set; }
		[Ordinal(10)] [RED("parentEntry")] public wCHandle<gameJournalEntry> ParentEntry { get; set; }
		[Ordinal(11)] [RED("singleThreadMode")] public CBool SingleThreadMode { get; set; }
		[Ordinal(12)] [RED("newMessageAninmProxy")] public CHandle<inkanimProxy> NewMessageAninmProxy { get; set; }

		public MessengerDialogViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
