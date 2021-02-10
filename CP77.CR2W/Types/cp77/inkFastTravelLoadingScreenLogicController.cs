using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkFastTravelLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(0)]  [RED("mainBackgroundImage")] public inkImageWidgetReference MainBackgroundImage { get; set; }
		[Ordinal(1)]  [RED("supportBackgroundImage")] public inkImageWidgetReference SupportBackgroundImage { get; set; }
		[Ordinal(2)]  [RED("introAnimationName")] public CName IntroAnimationName { get; set; }
		[Ordinal(3)]  [RED("loopAnimationName")] public CName LoopAnimationName { get; set; }
		[Ordinal(4)]  [RED("tooltipAnimName")] public CName TooltipAnimName { get; set; }
		[Ordinal(5)]  [RED("breathInAnimName")] public CName BreathInAnimName { get; set; }
		[Ordinal(6)]  [RED("breathOutAnimName")] public CName BreathOutAnimName { get; set; }
		[Ordinal(7)]  [RED("tooltipsWidget")] public inkRichTextBoxWidgetReference TooltipsWidget { get; set; }
		[Ordinal(8)]  [RED("progressBarRoot")] public inkWidgetReference ProgressBarRoot { get; set; }
		[Ordinal(9)]  [RED("progressBarController")] public wCHandle<LoadingScreenProgressBarController> ProgressBarController { get; set; }

		public inkFastTravelLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
