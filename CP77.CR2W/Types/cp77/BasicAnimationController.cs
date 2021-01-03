using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BasicAnimationController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("animationPlayer")] public CHandle<AnimationChainPlayer> AnimationPlayer { get; set; }
		[Ordinal(1)]  [RED("currentAnimation")] public CName CurrentAnimation { get; set; }
		[Ordinal(2)]  [RED("hideAnimation")] public CName HideAnimation { get; set; }
		[Ordinal(3)]  [RED("idleAnimation")] public CName IdleAnimation { get; set; }
		[Ordinal(4)]  [RED("showAnimation")] public CName ShowAnimation { get; set; }

		public BasicAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
