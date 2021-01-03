using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeaturePlaySlotAnim : animAnimFeature
	{
		[Ordinal(0)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)]  [RED("blendInTime")] public CFloat BlendInTime { get; set; }
		[Ordinal(2)]  [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
		[Ordinal(3)]  [RED("enableMotion")] public CBool EnableMotion { get; set; }
		[Ordinal(4)]  [RED("numberOfLoops")] public CInt32 NumberOfLoops { get; set; }
		[Ordinal(5)]  [RED("playAsAdditive")] public CBool PlayAsAdditive { get; set; }
		[Ordinal(6)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(7)]  [RED("speedMultiplier")] public CFloat SpeedMultiplier { get; set; }
		[Ordinal(8)]  [RED("startOffsetRelative")] public CFloat StartOffsetRelative { get; set; }

		public animAnimFeaturePlaySlotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
