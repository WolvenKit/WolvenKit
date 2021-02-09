using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseModalListPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("content")] public inkWidgetReference Content { get; set; }
		[Ordinal(1)]  [RED("listController")] public wCHandle<inkVirtualListController> ListController { get; set; }
		[Ordinal(2)]  [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(3)]  [RED("popupData")] public CHandle<inkGameNotificationData> PopupData { get; set; }
		[Ordinal(4)]  [RED("templateClassifier")] public CHandle<BaseModalListPopupTemplateClassifier> TemplateClassifier { get; set; }
		[Ordinal(5)]  [RED("systemRequestsHandler")] public wCHandle<inkISystemRequestsHandler> SystemRequestsHandler { get; set; }
		[Ordinal(6)]  [RED("switchAnimProxy")] public CHandle<inkanimProxy> SwitchAnimProxy { get; set; }
		[Ordinal(7)]  [RED("transitionAnimProxy")] public CHandle<inkanimProxy> TransitionAnimProxy { get; set; }
		[Ordinal(8)]  [RED("c_scrollInputThreshold")] public CFloat C_scrollInputThreshold { get; set; }

		public BaseModalListPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
