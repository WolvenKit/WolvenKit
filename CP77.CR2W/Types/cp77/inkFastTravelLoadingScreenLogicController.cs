using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkFastTravelLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(0)]  [RED("breathInAnimName")] public CName BreathInAnimName { get; set; }
		[Ordinal(1)]  [RED("breathOutAnimName")] public CName BreathOutAnimName { get; set; }
		[Ordinal(2)]  [RED("introAnimationName")] public CName IntroAnimationName { get; set; }
		[Ordinal(3)]  [RED("loopAnimationName")] public CName LoopAnimationName { get; set; }
		[Ordinal(4)]  [RED("mainBackgroundImage")] public inkImageWidgetReference MainBackgroundImage { get; set; }
		[Ordinal(5)]  [RED("progressBarController")] public wCHandle<LoadingScreenProgressBarController> ProgressBarController { get; set; }
		[Ordinal(6)]  [RED("progressBarRoot")] public inkWidgetReference ProgressBarRoot { get; set; }
		[Ordinal(7)]  [RED("supportBackgroundImage")] public inkImageWidgetReference SupportBackgroundImage { get; set; }
		[Ordinal(8)]  [RED("tooltipAnimName")] public CName TooltipAnimName { get; set; }
		[Ordinal(9)]  [RED("tooltipsWidget")] public inkRichTextBoxWidgetReference TooltipsWidget { get; set; }

		public inkFastTravelLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
