using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TwistConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("debug")] public CBool Debug { get; set; }
		[Ordinal(1)]  [RED("frontAxis")] public CEnum<animAxis> FrontAxis { get; set; }
		[Ordinal(2)]  [RED("transformA")] public animTransformIndex TransformA { get; set; }
		[Ordinal(3)]  [RED("transformB")] public animTransformIndex TransformB { get; set; }
		[Ordinal(4)]  [RED("outputs")] public CArray<animTwistOutput> Outputs { get; set; }

		public animAnimNode_TwistConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
