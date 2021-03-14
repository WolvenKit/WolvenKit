using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetStateAnimatedTransition : CVariable
	{
		[Ordinal(0)] [RED("startState")] public CName StartState { get; set; }
		[Ordinal(1)] [RED("endState")] public CName EndState { get; set; }
		[Ordinal(2)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(3)] [RED("playbackOptions")] public inkanimPlaybackOptions PlaybackOptions { get; set; }

		public inkWidgetStateAnimatedTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
