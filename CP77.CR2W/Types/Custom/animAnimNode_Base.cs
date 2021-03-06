using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_Base : animAnimNode_Base_
    {
        [Ordinal(1)] [RED("debugName")] public CName DebugName { get; set; }
        [Ordinal(2)] [RED("visPrePose")] public CBool VisPrePose { get; set; }
        [Ordinal(3)] [RED("visPrePoseColor")] public CColor VisPrePoseColor { get; set; }
        [Ordinal(4)] [RED("visPostPose")] public CBool VisPostPose { get; set; }
        [Ordinal(5)] [RED("visPostPoseColor")] public CColor VisPostPoseColor { get; set; }
        [Ordinal(6)] [RED("visRigPartMask")] public CName VisRigPartMask { get; set; }
        [Ordinal(7)] [RED("visAxes")] public CBool VisAxes { get; set; }
        [Ordinal(8)] [RED("visNames")] public CBool VisNames { get; set; }
        [Ordinal(9)] [RED("visMask")] public CArray<animTransformIndex> VisMask { get; set; }
        [Ordinal(10)] [RED("poseInfoLogger")] public animPoseInfoLogger PoseInfoLogger { get; set; }

        [Ordinal(1000)] [RED("visWhenActive")] public CBool VisWhenActive { get; set; }
        //[Ordinal(1001)] [RED("debug")] public CBool Debug { get; set; }
        //[Ordinal(1002)] [RED("debugDrawingEnabled")] public CBool DebugDrawingEnabled { get; set; }

        public animAnimNode_Base(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
