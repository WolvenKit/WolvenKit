using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTrackDirectConnConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("floatTrackIndex")] public animNamedTrackIndex FloatTrackIndex { get; set; }
		[Ordinal(1)]  [RED("transformIndex")] public animTransformIndex TransformIndex { get; set; }
		[Ordinal(2)]  [RED("channel")] public CEnum<animTransformChannel> Channel { get; set; }
		[Ordinal(3)]  [RED("mulFactor")] public CFloat MulFactor { get; set; }
		[Ordinal(4)]  [RED("weight")] public CFloat Weight { get; set; }
		[Ordinal(5)]  [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(6)]  [RED("mulFactorNode")] public animFloatLink MulFactorNode { get; set; }

		public animAnimNode_FloatTrackDirectConnConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
