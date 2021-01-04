using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProgressBarSimpleWidgetLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("MaxCNBarFlashSize")] public CFloat MaxCNBarFlashSize { get; set; }
		[Ordinal(1)]  [RED("animDuration")] public CFloat AnimDuration { get; set; }
		[Ordinal(2)]  [RED("barCap")] public inkWidgetReference BarCap { get; set; }
		[Ordinal(3)]  [RED("barCap_anim")] public CHandle<inkanimDefinition> BarCap_anim { get; set; }
		[Ordinal(4)]  [RED("barCap_anim_proxy")] public CHandle<inkanimProxy> BarCap_anim_proxy { get; set; }
		[Ordinal(5)]  [RED("changeNBar")] public inkWidgetReference ChangeNBar { get; set; }
		[Ordinal(6)]  [RED("changeN_anim")] public CHandle<inkanimDefinition> ChangeN_anim { get; set; }
		[Ordinal(7)]  [RED("changeN_anim_proxy")] public CHandle<inkanimProxy> ChangeN_anim_proxy { get; set; }
		[Ordinal(8)]  [RED("changePBar")] public inkWidgetReference ChangePBar { get; set; }
		[Ordinal(9)]  [RED("changeP_anim")] public CHandle<inkanimDefinition> ChangeP_anim { get; set; }
		[Ordinal(10)]  [RED("changeP_anim_proxy")] public CHandle<inkanimProxy> ChangeP_anim_proxy { get; set; }
		[Ordinal(11)]  [RED("currentValue")] public CFloat CurrentValue { get; set; }
		[Ordinal(12)]  [RED("emptyBar")] public inkWidgetReference EmptyBar { get; set; }
		[Ordinal(13)]  [RED("empty_anim")] public CHandle<inkanimDefinition> Empty_anim { get; set; }
		[Ordinal(14)]  [RED("empty_anim_proxy")] public CHandle<inkanimProxy> Empty_anim_proxy { get; set; }
		[Ordinal(15)]  [RED("fullBar")] public inkWidgetReference FullBar { get; set; }
		[Ordinal(16)]  [RED("full_anim")] public CHandle<inkanimDefinition> Full_anim { get; set; }
		[Ordinal(17)]  [RED("full_anim_proxy")] public CHandle<inkanimProxy> Full_anim_proxy { get; set; }
		[Ordinal(18)]  [RED("height")] public CFloat Height { get; set; }
		[Ordinal(19)]  [RED("previousValue")] public CFloat PreviousValue { get; set; }
		[Ordinal(20)]  [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(21)]  [RED("showBarCap")] public CBool ShowBarCap { get; set; }
		[Ordinal(22)]  [RED("width")] public CFloat Width { get; set; }

		public ProgressBarSimpleWidgetLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
