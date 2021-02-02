using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Climb : animAnimFeature
	{
		[Ordinal(0)]  [RED("verticalPosition")] public Vector4 VerticalPosition { get; set; }
		[Ordinal(1)]  [RED("horizontalPosition")] public Vector4 HorizontalPosition { get; set; }
		[Ordinal(2)]  [RED("frontEdgePosition")] public Vector4 FrontEdgePosition { get; set; }
		[Ordinal(3)]  [RED("frontEdgeNormal")] public Vector4 FrontEdgeNormal { get; set; }
		[Ordinal(4)]  [RED("toVerticalTime")] public CFloat ToVerticalTime { get; set; }
		[Ordinal(5)]  [RED("verticalToHorizontalTime")] public CFloat VerticalToHorizontalTime { get; set; }
		[Ordinal(6)]  [RED("yawAngle")] public CFloat YawAngle { get; set; }
		[Ordinal(7)]  [RED("stateLength")] public CFloat StateLength { get; set; }
		[Ordinal(8)]  [RED("climbType")] public CInt32 ClimbType { get; set; }
		[Ordinal(9)]  [RED("state")] public CInt32 State { get; set; }

		public animAnimFeature_Climb(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
