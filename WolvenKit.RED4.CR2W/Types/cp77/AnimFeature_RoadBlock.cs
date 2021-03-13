using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_RoadBlock : animAnimFeature
	{
		[Ordinal(0)] [RED("isOpening")] public CBool IsOpening { get; set; }
		[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(2)] [RED("initOpen")] public CBool InitOpen { get; set; }

		public AnimFeature_RoadBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
