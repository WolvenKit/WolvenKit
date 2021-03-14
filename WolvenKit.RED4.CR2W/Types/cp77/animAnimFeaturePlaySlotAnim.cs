using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeaturePlaySlotAnim : animAnimFeature
	{
		[Ordinal(0)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(1)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(2)] [RED("blendInTime")] public CFloat BlendInTime { get; set; }
		[Ordinal(3)] [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
		[Ordinal(4)] [RED("speedMultiplier")] public CFloat SpeedMultiplier { get; set; }
		[Ordinal(5)] [RED("startOffsetRelative")] public CFloat StartOffsetRelative { get; set; }
		[Ordinal(6)] [RED("playAsAdditive")] public CBool PlayAsAdditive { get; set; }
		[Ordinal(7)] [RED("enableMotion")] public CBool EnableMotion { get; set; }
		[Ordinal(8)] [RED("numberOfLoops")] public CInt32 NumberOfLoops { get; set; }

		public animAnimFeaturePlaySlotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
