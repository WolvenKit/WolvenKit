using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPoseLimitWeights : CVariable
	{
		[Ordinal(0)] [RED("min")] public CFloat Min { get; set; }
		[Ordinal(1)] [RED("mid")] public CFloat Mid { get; set; }
		[Ordinal(2)] [RED("max")] public CFloat Max { get; set; }
		[Ordinal(3)] [RED("poseTrackIndex")] public CInt16 PoseTrackIndex { get; set; }
		[Ordinal(4)] [RED("type")] public CUInt8 Type { get; set; }
		[Ordinal(5)] [RED("isCachable")] public CBool IsCachable { get; set; }

		public animPoseLimitWeights(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
