using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintEllipsoid_ : animIDyngConstraint
	{
		[Ordinal(0)] [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(1)] [RED("ellipsoidTransformLS")] public QsTransform EllipsoidTransformLS { get; set; }
		[Ordinal(2)] [RED("constraintRadius")] public CFloat ConstraintRadius { get; set; }
		[Ordinal(3)] [RED("constraintScale1")] public CFloat ConstraintScale1 { get; set; }
		[Ordinal(4)] [RED("constraintScale2")] public CFloat ConstraintScale2 { get; set; }

		public animDyngConstraintEllipsoid_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
