using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_AdHocAnimation : animAnimFeature
	{
		[Ordinal(0)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(1)] [RED("useBothHands")] public CBool UseBothHands { get; set; }
		[Ordinal(2)] [RED("animationIndex")] public CInt32 AnimationIndex { get; set; }

		public AnimFeature_AdHocAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
