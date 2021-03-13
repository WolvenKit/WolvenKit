using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAt : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("transform")] public animTransformIndex Transform { get; set; }
		[Ordinal(13)] [RED("forwardAxis")] public CEnum<animAxis> ForwardAxis { get; set; }
		[Ordinal(14)] [RED("useLimits")] public CBool UseLimits { get; set; }
		[Ordinal(15)] [RED("limitAxis")] public CEnum<animAxis> LimitAxis { get; set; }
		[Ordinal(16)] [RED("limitAngle")] public CFloat LimitAngle { get; set; }
		[Ordinal(17)] [RED("targetNode")] public animVectorLink TargetNode { get; set; }
		[Ordinal(18)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }

		public animAnimNode_LookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
