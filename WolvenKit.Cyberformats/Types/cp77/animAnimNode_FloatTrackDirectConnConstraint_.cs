using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTrackDirectConnConstraint_ : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("floatTrackIndex")] public animNamedTrackIndex FloatTrackIndex { get; set; }
		[Ordinal(13)] [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(14)] [RED("channel")] public CEnum<animTransformChannel> Channel { get; set; }
		[Ordinal(15)] [RED("mulFactor")] public CFloat MulFactor { get; set; }
		[Ordinal(16)] [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(17)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(18)] [RED("mulFactorNode")] public animFloatLink MulFactorNode { get; set; }

		public animAnimNode_FloatTrackDirectConnConstraint_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
