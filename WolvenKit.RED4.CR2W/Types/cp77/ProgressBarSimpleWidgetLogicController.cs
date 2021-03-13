using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressBarSimpleWidgetLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("width")] public CFloat Width { get; set; }
		[Ordinal(2)] [RED("height")] public CFloat Height { get; set; }
		[Ordinal(3)] [RED("currentValue")] public CFloat CurrentValue { get; set; }
		[Ordinal(4)] [RED("previousValue")] public CFloat PreviousValue { get; set; }
		[Ordinal(5)] [RED("MaxCNBarFlashSize")] public CFloat MaxCNBarFlashSize { get; set; }
		[Ordinal(6)] [RED("fullBar")] public inkWidgetReference FullBar { get; set; }
		[Ordinal(7)] [RED("changePBar")] public inkWidgetReference ChangePBar { get; set; }
		[Ordinal(8)] [RED("changeNBar")] public inkWidgetReference ChangeNBar { get; set; }
		[Ordinal(9)] [RED("emptyBar")] public inkWidgetReference EmptyBar { get; set; }
		[Ordinal(10)] [RED("barCap")] public inkWidgetReference BarCap { get; set; }
		[Ordinal(11)] [RED("showBarCap")] public CBool ShowBarCap { get; set; }
		[Ordinal(12)] [RED("animDuration")] public CFloat AnimDuration { get; set; }
		[Ordinal(13)] [RED("full_anim_proxy")] public CHandle<inkanimProxy> Full_anim_proxy { get; set; }
		[Ordinal(14)] [RED("full_anim")] public CHandle<inkanimDefinition> Full_anim { get; set; }
		[Ordinal(15)] [RED("empty_anim_proxy")] public CHandle<inkanimProxy> Empty_anim_proxy { get; set; }
		[Ordinal(16)] [RED("empty_anim")] public CHandle<inkanimDefinition> Empty_anim { get; set; }
		[Ordinal(17)] [RED("changeP_anim_proxy")] public CHandle<inkanimProxy> ChangeP_anim_proxy { get; set; }
		[Ordinal(18)] [RED("changeP_anim")] public CHandle<inkanimDefinition> ChangeP_anim { get; set; }
		[Ordinal(19)] [RED("changeN_anim_proxy")] public CHandle<inkanimProxy> ChangeN_anim_proxy { get; set; }
		[Ordinal(20)] [RED("changeN_anim")] public CHandle<inkanimDefinition> ChangeN_anim { get; set; }
		[Ordinal(21)] [RED("barCap_anim_proxy")] public CHandle<inkanimProxy> BarCap_anim_proxy { get; set; }
		[Ordinal(22)] [RED("barCap_anim")] public CHandle<inkanimDefinition> BarCap_anim { get; set; }
		[Ordinal(23)] [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }

		public ProgressBarSimpleWidgetLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
