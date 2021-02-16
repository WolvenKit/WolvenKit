using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAt : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("transform")] public animTransformIndex Transform { get; set; }
		[Ordinal(3)] [RED("forwardAxis")] public CEnum<animAxis> ForwardAxis { get; set; }
		[Ordinal(4)] [RED("useLimits")] public CBool UseLimits { get; set; }
		[Ordinal(5)] [RED("limitAxis")] public CEnum<animAxis> LimitAxis { get; set; }
		[Ordinal(6)] [RED("limitAngle")] public CFloat LimitAngle { get; set; }
		[Ordinal(7)] [RED("targetNode")] public animVectorLink TargetNode { get; set; }
		[Ordinal(8)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }

		public animAnimNode_LookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
