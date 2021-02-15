using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_Base : animAnimNode_Base_
    {
        //[Ordinal(988)] [RED("debugName")] public CName DebugName { get; set; }
        [Ordinal(989)] [RED("visWhenActive")] public CBool VisWhenActive { get; set; }
        [Ordinal(990)] [RED("visRigPartMask")] public CName VisRigPartMask { get; set; }
        [Ordinal(991)] [RED("visPrePose")] public CBool VisPrePose { get; set; }
        [Ordinal(992)] [RED("visPrePoseColor")] public CColor VisPrePoseColor { get; set; }
        [Ordinal(993)] [RED("visPostPoseColor")] public CColor VisPostPoseColor { get; set; }
        [Ordinal(994)] [RED("visPostPose")] public CBool VisPostPose { get; set; }
        [Ordinal(995)] [RED("visAxes")] public CBool VisAxes { get; set; }
        [Ordinal(996)] [RED("visNames")] public CBool VisNames { get; set; }
        [Ordinal(997)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
        [Ordinal(998)] [RED("poseInfoLogger")] public animPoseInfoLogger PoseInfoLogger { get; set; }
        //[Ordinal(1000)] [RED("debugDrawingEnabled")] public CBool DebugDrawingEnabled { get; set; }
        //[Ordinal(999)] [RED("debug")] public CBool Debug { get; set; }

        public animAnimNode_Base(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
