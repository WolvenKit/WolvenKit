using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_MoveOnSpline : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)]  [RED("from")] public CFloat From { get; set; }
		[Ordinal(1)]  [RED("movement")] public CHandle<gameTransformAnimation_Movement> Movement { get; set; }
		[Ordinal(2)]  [RED("rotationMode")] public CEnum<gameTransformAnimation_MoveOnSplineRotationMode> RotationMode { get; set; }
		[Ordinal(3)]  [RED("splineNode")] public NodeRef SplineNode { get; set; }
		[Ordinal(4)]  [RED("to")] public CFloat To { get; set; }

		public gameTransformAnimation_MoveOnSpline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
