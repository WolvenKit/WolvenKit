using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BasicAnimationController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("showAnimation")] public CName ShowAnimation { get; set; }
		[Ordinal(2)] [RED("idleAnimation")] public CName IdleAnimation { get; set; }
		[Ordinal(3)] [RED("hideAnimation")] public CName HideAnimation { get; set; }
		[Ordinal(4)] [RED("animationPlayer")] public CHandle<AnimationChainPlayer> AnimationPlayer { get; set; }
		[Ordinal(5)] [RED("currentAnimation")] public CName CurrentAnimation { get; set; }

		public BasicAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
