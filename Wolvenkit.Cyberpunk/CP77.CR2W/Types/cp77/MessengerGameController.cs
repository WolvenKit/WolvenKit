using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessengerGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("activeData")] public CHandle<MessengerContactSyncData> ActiveData { get; set; }
		[Ordinal(1)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(2)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(3)]  [RED("contactsRef")] public inkWidgetReference ContactsRef { get; set; }
		[Ordinal(4)]  [RED("dialogController")] public wCHandle<MessengerDialogViewController> DialogController { get; set; }
		[Ordinal(5)]  [RED("dialogRef")] public inkWidgetReference DialogRef { get; set; }
		[Ordinal(6)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(7)]  [RED("listController")] public wCHandle<MessengerContactsVirtualNestedListController> ListController { get; set; }
		[Ordinal(8)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(9)]  [RED("virtualList")] public inkWidgetReference VirtualList { get; set; }

		public MessengerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
