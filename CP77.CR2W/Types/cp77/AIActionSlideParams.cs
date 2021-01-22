using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIActionSlideParams : CVariable
	{
		[Ordinal(0)]  [RED("debugDrawSlideLines")] public CBool DebugDrawSlideLines { get; set; }
		[Ordinal(1)]  [RED("directionAngle")] public CFloat DirectionAngle { get; set; }
		[Ordinal(2)]  [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(3)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(4)]  [RED("offset")] public CFloat Offset { get; set; }
		[Ordinal(5)]  [RED("slideToTarget")] public CBool SlideToTarget { get; set; }

		public AIActionSlideParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
