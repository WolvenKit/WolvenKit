using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Base : ISerializable
	{
		[Ordinal(0)]  [RED("id")] public CUInt32 Id { get; set; }

        [Ordinal(987)] [RED("poseInfoLogger")] public animPoseInfoLogger PoseInfoLogger { get; set; }
        [Ordinal(988)] [RED("debugName")] public CName debugName { get; set; }
        [Ordinal(989)] [RED("visWhenActive")] public CBool visWhenActive { get; set; }
        [Ordinal(990)] [RED("visRigPartMask")] public CName visRigPartMask { get; set; }
        [Ordinal(991)] [RED("debugDrawingEnabled")] public CBool debugDrawingEnabled { get; set; }
        [Ordinal(992)] [RED("debug")] public CBool debug { get; set; }
        [Ordinal(993)] [RED("visPrePose")] public CBool visPrePose { get; set; }
        [Ordinal(994)] [RED("visPrePoseColor")] public CColor visPrePoseColor { get; set; }
        [Ordinal(995)] [RED("visPostPoseColor")] public CColor visPostPoseColor { get; set; }
        [Ordinal(996)] [RED("visPostPose")] public CBool visPostPose { get; set; }
        [Ordinal(997)] [RED("visAxes")] public CBool visAxes { get; set; }
        [Ordinal(998)] [RED("visNames")] public CBool visNames { get; set; }
        [Ordinal(999)] [RED("visMask")] public CArray<animTransformIndex> visMask { get; set; }

		public animAnimNode_Base(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
