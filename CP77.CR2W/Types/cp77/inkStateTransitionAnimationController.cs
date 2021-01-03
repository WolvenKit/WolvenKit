using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkStateTransitionAnimationController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("stopActiveAnimation")] public CBool StopActiveAnimation { get; set; }
		[Ordinal(1)]  [RED("transition")] public CArray<inkWidgetStateAnimatedTransition> Transition { get; set; }

		public inkStateTransitionAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
