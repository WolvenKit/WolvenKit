using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipAnimationController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(2)] [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(3)] [RED("tooltipAnimHide")] public CHandle<inkanimProxy> TooltipAnimHide { get; set; }
		[Ordinal(4)] [RED("tooltipDelayedShow")] public CHandle<inkanimProxy> TooltipDelayedShow { get; set; }
		[Ordinal(5)] [RED("axisDataThreshold")] public CFloat AxisDataThreshold { get; set; }
		[Ordinal(6)] [RED("isHidden")] public CBool IsHidden { get; set; }

		public TooltipAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
