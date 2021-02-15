using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkStateTransitionAnimationController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("transition")] public CArray<inkWidgetStateAnimatedTransition> Transition { get; set; }
		[Ordinal(2)] [RED("stopActiveAnimation")] public CBool StopActiveAnimation { get; set; }

		public inkStateTransitionAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
