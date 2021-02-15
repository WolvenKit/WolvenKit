using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPlaneUncompressedMotionExtraction : animIMotionExtraction
	{
		[Ordinal(0)] [RED("frames")] public CArray<Vector3> Frames { get; set; }
		[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }

		public animPlaneUncompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
