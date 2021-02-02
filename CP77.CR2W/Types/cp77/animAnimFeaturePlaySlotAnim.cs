using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeaturePlaySlotAnim : animAnimFeature
	{
		[Ordinal(0)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(1)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(2)]  [RED("blendInTime")] public CFloat BlendInTime { get; set; }
		[Ordinal(3)]  [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
		[Ordinal(4)]  [RED("speedMultiplier")] public CFloat SpeedMultiplier { get; set; }
		[Ordinal(5)]  [RED("startOffsetRelative")] public CFloat StartOffsetRelative { get; set; }
		[Ordinal(6)]  [RED("numberOfLoops")] public CInt32 NumberOfLoops { get; set; }
		[Ordinal(7)]  [RED("playAsAdditive")] public CBool PlayAsAdditive { get; set; }
		[Ordinal(8)]  [RED("enableMotion")] public CBool EnableMotion { get; set; }

		public animAnimFeaturePlaySlotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
