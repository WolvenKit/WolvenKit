using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WarningMessageGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("animProxyHide")] public CHandle<inkanimProxy> AnimProxyHide { get; set; }
		[Ordinal(1)]  [RED("animProxyShow")] public CHandle<inkanimProxy> AnimProxyShow { get; set; }
		[Ordinal(2)]  [RED("animProxyTimeout")] public CHandle<inkanimProxy> AnimProxyTimeout { get; set; }
		[Ordinal(3)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(4)]  [RED("blackboardDef")] public CHandle<UI_NotificationsDef> BlackboardDef { get; set; }
		[Ordinal(5)]  [RED("blinkingAnim")] public CHandle<inkanimDefinition> BlinkingAnim { get; set; }
		[Ordinal(6)]  [RED("hideAnim")] public CHandle<inkanimDefinition> HideAnim { get; set; }
		[Ordinal(7)]  [RED("mainTextWidget")] public inkTextWidgetReference MainTextWidget { get; set; }
		[Ordinal(8)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(9)]  [RED("showAnim")] public CHandle<inkanimDefinition> ShowAnim { get; set; }
		[Ordinal(10)]  [RED("simpleMessage")] public gameSimpleScreenMessage SimpleMessage { get; set; }
		[Ordinal(11)]  [RED("warningMessageCallbackId")] public CUInt32 WarningMessageCallbackId { get; set; }

		public WarningMessageGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
