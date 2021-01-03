using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiStealthIndicatorPartLogicController : gameuiBaseDirectionalIndicatorPartLogicController
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("arrowFrontWidget")] public inkImageWidgetReference ArrowFrontWidget { get; set; }
		[Ordinal(2)]  [RED("flashAnimProxy")] public CHandle<inkanimProxy> FlashAnimProxy { get; set; }
		[Ordinal(3)]  [RED("lastValue")] public CFloat LastValue { get; set; }
		[Ordinal(4)]  [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(5)]  [RED("scaleAnimDef")] public CHandle<inkanimDefinition> ScaleAnimDef { get; set; }
		[Ordinal(6)]  [RED("slowestFlashTime")] public CFloat SlowestFlashTime { get; set; }
		[Ordinal(7)]  [RED("stealthIndicatorDeadZoneAngle")] public CFloat StealthIndicatorDeadZoneAngle { get; set; }
		[Ordinal(8)]  [RED("wrapper")] public inkCompoundWidgetReference Wrapper { get; set; }

		public gameuiStealthIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
