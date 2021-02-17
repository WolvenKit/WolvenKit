using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_MoveOnSpline : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)] [RED("splineNode")] public NodeRef SplineNode { get; set; }
		[Ordinal(1)] [RED("from")] public CFloat From { get; set; }
		[Ordinal(2)] [RED("to")] public CFloat To { get; set; }
		[Ordinal(3)] [RED("rotationMode")] public CEnum<gameTransformAnimation_MoveOnSplineRotationMode> RotationMode { get; set; }
		[Ordinal(4)] [RED("movement")] public CHandle<gameTransformAnimation_Movement> Movement { get; set; }

		public gameTransformAnimation_MoveOnSpline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
