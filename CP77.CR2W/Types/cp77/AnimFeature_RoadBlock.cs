using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_RoadBlock : animAnimFeature
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("initOpen")] public CBool InitOpen { get; set; }
		[Ordinal(2)]  [RED("isOpening")] public CBool IsOpening { get; set; }

		public AnimFeature_RoadBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
