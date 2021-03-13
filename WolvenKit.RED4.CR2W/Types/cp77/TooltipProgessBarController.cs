using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipProgessBarController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("progressFill")] public inkWidgetReference ProgressFill { get; set; }
		[Ordinal(2)] [RED("hintHolder")] public inkWidgetReference HintHolder { get; set; }
		[Ordinal(3)] [RED("progressHolder")] public inkWidgetReference ProgressHolder { get; set; }
		[Ordinal(4)] [RED("postprogressHolder")] public inkWidgetReference PostprogressHolder { get; set; }
		[Ordinal(5)] [RED("hintTextHolder")] public inkCompoundWidgetReference HintTextHolder { get; set; }
		[Ordinal(6)] [RED("libraryPath")] public inkWidgetLibraryReference LibraryPath { get; set; }
		[Ordinal(7)] [RED("postprogressText")] public inkTextWidgetReference PostprogressText { get; set; }
		[Ordinal(8)] [RED("isCraftable")] public CBool IsCraftable { get; set; }
		[Ordinal(9)] [RED("isCrafted")] public CBool IsCrafted { get; set; }

		public TooltipProgessBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
