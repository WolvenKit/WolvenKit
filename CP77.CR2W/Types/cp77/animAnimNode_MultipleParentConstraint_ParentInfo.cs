using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MultipleParentConstraint_ParentInfo : CVariable
	{
		[Ordinal(0)]  [RED("offset")] public QsTransform Offset { get; set; }
		[Ordinal(1)]  [RED("parentStaticWeight")] public CFloat ParentStaticWeight { get; set; }
		[Ordinal(2)]  [RED("parentTrackWeight")] public animNamedTrackIndex ParentTrackWeight { get; set; }
		[Ordinal(3)]  [RED("parentTransform")] public animTransformIndex ParentTransform { get; set; }
		[Ordinal(4)]  [RED("parentWeightMode")] public CEnum<animConstraintWeightMode> ParentWeightMode { get; set; }
		[Ordinal(5)]  [RED("useComplementWeight")] public CBool UseComplementWeight { get; set; }
		[Ordinal(6)]  [RED("useOffset")] public CBool UseOffset { get; set; }

		public animAnimNode_MultipleParentConstraint_ParentInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
