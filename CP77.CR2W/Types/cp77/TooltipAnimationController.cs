using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TooltipAnimationController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(1)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(2)]  [RED("tooltipAnimHide")] public CHandle<inkanimProxy> TooltipAnimHide { get; set; }
		[Ordinal(3)]  [RED("tooltipDelayedShow")] public CHandle<inkanimProxy> TooltipDelayedShow { get; set; }
		[Ordinal(4)]  [RED("axisDataThreshold")] public CFloat AxisDataThreshold { get; set; }
		[Ordinal(5)]  [RED("isHidden")] public CBool IsHidden { get; set; }

		public TooltipAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
