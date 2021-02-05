using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MultipleParentConstraint_ParentInfo : CVariable
	{
		[Ordinal(0)]  [RED("parentTransform")] public animTransformIndex ParentTransform { get; set; }
		[Ordinal(1)]  [RED("parentWeightMode")] public CEnum<animConstraintWeightMode> ParentWeightMode { get; set; }
		[Ordinal(2)]  [RED("parentStaticWeight")] public CFloat ParentStaticWeight { get; set; }
		[Ordinal(3)]  [RED("parentTrackWeight")] public animNamedTrackIndex ParentTrackWeight { get; set; }
		[Ordinal(4)]  [RED("useComplementWeight")] public CBool UseComplementWeight { get; set; }
		[Ordinal(5)]  [RED("useOffset")] public CBool UseOffset { get; set; }
		[Ordinal(6)]  [RED("offset")] public QsTransform Offset { get; set; }

		public animAnimNode_MultipleParentConstraint_ParentInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
