using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WarningMessageGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(10)] [RED("mainTextWidget")] public inkTextWidgetReference MainTextWidget { get; set; }
		[Ordinal(11)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(12)] [RED("blackboardDef")] public CHandle<UI_NotificationsDef> BlackboardDef { get; set; }
		[Ordinal(13)] [RED("warningMessageCallbackId")] public CUInt32 WarningMessageCallbackId { get; set; }
		[Ordinal(14)] [RED("simpleMessage")] public gameSimpleScreenMessage SimpleMessage { get; set; }
		[Ordinal(15)] [RED("blinkingAnim")] public CHandle<inkanimDefinition> BlinkingAnim { get; set; }
		[Ordinal(16)] [RED("showAnim")] public CHandle<inkanimDefinition> ShowAnim { get; set; }
		[Ordinal(17)] [RED("hideAnim")] public CHandle<inkanimDefinition> HideAnim { get; set; }
		[Ordinal(18)] [RED("animProxyShow")] public CHandle<inkanimProxy> AnimProxyShow { get; set; }
		[Ordinal(19)] [RED("animProxyHide")] public CHandle<inkanimProxy> AnimProxyHide { get; set; }
		[Ordinal(20)] [RED("animProxyTimeout")] public CHandle<inkanimProxy> AnimProxyTimeout { get; set; }

		public WarningMessageGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
