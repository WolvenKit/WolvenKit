using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HubTimeSkipController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("gameTimeText")] public inkTextWidgetReference GameTimeText { get; set; }
		[Ordinal(2)] [RED("cantSkipTimeContainer")] public inkWidgetReference CantSkipTimeContainer { get; set; }
		[Ordinal(3)] [RED("timeSkipButton")] public inkWidgetReference TimeSkipButton { get; set; }
		[Ordinal(4)] [RED("gameCtrlRef")] public wCHandle<gameuiMenuGameController> GameCtrlRef { get; set; }
		[Ordinal(5)] [RED("timeSystem")] public wCHandle<gameTimeSystem> TimeSystem { get; set; }
		[Ordinal(6)] [RED("timeSkipPopupToken")] public CHandle<inkGameNotificationToken> TimeSkipPopupToken { get; set; }
		[Ordinal(7)] [RED("cantSkipTimeAnim")] public CHandle<inkanimProxy> CantSkipTimeAnim { get; set; }
		[Ordinal(8)] [RED("gameTimeTextParams")] public CHandle<textTextParameterSet> GameTimeTextParams { get; set; }
		[Ordinal(9)] [RED("canSkipTime")] public CBool CanSkipTime { get; set; }

		public HubTimeSkipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
