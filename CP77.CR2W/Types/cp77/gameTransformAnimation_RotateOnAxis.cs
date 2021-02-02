using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_RotateOnAxis : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)]  [RED("axis")] public CEnum<gameTransformAnimation_RotateOnAxisAxis> Axis { get; set; }
		[Ordinal(1)]  [RED("startAngle")] public CFloat StartAngle { get; set; }
		[Ordinal(2)]  [RED("numberOfFullRotations")] public CFloat NumberOfFullRotations { get; set; }
		[Ordinal(3)]  [RED("reverseDirection")] public CBool ReverseDirection { get; set; }
		[Ordinal(4)]  [RED("movement")] public CHandle<gameTransformAnimation_Movement> Movement { get; set; }

		public gameTransformAnimation_RotateOnAxis(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
