using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiStealthIndicatorPartLogicController : gameuiBaseDirectionalIndicatorPartLogicController
	{
		[Ordinal(3)] [RED("arrowFrontWidget")] public inkImageWidgetReference ArrowFrontWidget { get; set; }
		[Ordinal(4)] [RED("wrapper")] public inkCompoundWidgetReference Wrapper { get; set; }
		[Ordinal(5)] [RED("stealthIndicatorDeadZoneAngle")] public CFloat StealthIndicatorDeadZoneAngle { get; set; }
		[Ordinal(6)] [RED("slowestFlashTime")] public CFloat SlowestFlashTime { get; set; }
		[Ordinal(7)] [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(8)] [RED("lastValue")] public CFloat LastValue { get; set; }
		[Ordinal(9)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(10)] [RED("flashAnimProxy")] public CHandle<inkanimProxy> FlashAnimProxy { get; set; }
		[Ordinal(11)] [RED("scaleAnimDef")] public CHandle<inkanimDefinition> ScaleAnimDef { get; set; }

		public gameuiStealthIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
