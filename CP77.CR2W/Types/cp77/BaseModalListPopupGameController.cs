using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BaseModalListPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("c_scrollInputThreshold")] public CFloat C_scrollInputThreshold { get; set; }
		[Ordinal(1)]  [RED("content")] public inkWidgetReference Content { get; set; }
		[Ordinal(2)]  [RED("listController")] public wCHandle<inkVirtualListController> ListController { get; set; }
		[Ordinal(3)]  [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(4)]  [RED("popupData")] public CHandle<inkGameNotificationData> PopupData { get; set; }
		[Ordinal(5)]  [RED("switchAnimProxy")] public CHandle<inkanimProxy> SwitchAnimProxy { get; set; }
		[Ordinal(6)]  [RED("systemRequestsHandler")] public wCHandle<inkISystemRequestsHandler> SystemRequestsHandler { get; set; }
		[Ordinal(7)]  [RED("templateClassifier")] public CHandle<BaseModalListPopupTemplateClassifier> TemplateClassifier { get; set; }
		[Ordinal(8)]  [RED("transitionAnimProxy")] public CHandle<inkanimProxy> TransitionAnimProxy { get; set; }

		public BaseModalListPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
