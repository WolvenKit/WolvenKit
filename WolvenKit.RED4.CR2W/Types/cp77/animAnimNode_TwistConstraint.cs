using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TwistConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("frontAxis")] public CEnum<animAxis> FrontAxis { get; set; }
		[Ordinal(13)] [RED("transformA")] public animTransformIndex TransformA { get; set; }
		[Ordinal(14)] [RED("transformB")] public animTransformIndex TransformB { get; set; }
		[Ordinal(15)] [RED("outputs")] public CArray<animTwistOutput> Outputs { get; set; }
		[Ordinal(16)] [RED("debug")] public CBool Debug { get; set; }

		public animAnimNode_TwistConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
