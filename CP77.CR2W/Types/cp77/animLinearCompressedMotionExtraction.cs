using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLinearCompressedMotionExtraction : animIMotionExtraction
	{
		[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)] [RED("rotFrames")] public CArray<Quaternion> RotFrames { get; set; }
		[Ordinal(2)] [RED("posFrames")] public CArray<Vector3> PosFrames { get; set; }
		[Ordinal(3)] [RED("rotTime")] public CArray<CFloat> RotTime { get; set; }
		[Ordinal(4)] [RED("posTime")] public CArray<CFloat> PosTime { get; set; }

		public animLinearCompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
