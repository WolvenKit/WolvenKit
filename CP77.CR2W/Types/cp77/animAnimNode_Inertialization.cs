using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Inertialization : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("safeMode")] public CBool SafeMode { get; set; }
		[Ordinal(3)] [RED("transformsCountUpperBound")] public CUInt32 TransformsCountUpperBound { get; set; }
		[Ordinal(4)] [RED("tracksCountUpperBound")] public CUInt32 TracksCountUpperBound { get; set; }
		[Ordinal(5)] [RED("rotationLimits")] public CArray<animInertializationRotationLimit> RotationLimits { get; set; }

		public animAnimNode_Inertialization(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
