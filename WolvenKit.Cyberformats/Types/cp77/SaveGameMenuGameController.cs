using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SaveGameMenuGameController : gameuiSaveHandlingController
	{
		[Ordinal(3)] [RED("list")] public inkCompoundWidgetReference List { get; set; }
		[Ordinal(4)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(5)] [RED("eventDispatcher")] public wCHandle<inkMenuEventDispatcher> EventDispatcher { get; set; }
		[Ordinal(6)] [RED("loadComplete")] public CBool LoadComplete { get; set; }
		[Ordinal(7)] [RED("handler")] public wCHandle<inkISystemRequestsHandler> Handler { get; set; }
		[Ordinal(8)] [RED("saveInfo")] public CHandle<inkSaveMetadataInfo> SaveInfo { get; set; }
		[Ordinal(9)] [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(10)] [RED("hasEmptySlot")] public CBool HasEmptySlot { get; set; }
		[Ordinal(11)] [RED("saveInProgress")] public CBool SaveInProgress { get; set; }

		public SaveGameMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
