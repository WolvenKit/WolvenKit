using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class animDangleConstraint_Simulation : animDangleConstraint_Simulation_
    {
        [Ordinal(995)] [RED("debugDrawingEnabled")] public CBool DebugDrawingEnabled { get; set; }
        //[Ordinal(996)] [RED("drawDebugConstraint")] public CBool DrawDebugConstraint { get; set; }
        [Ordinal(997)] [RED("drawDebugText")] public CBool DrawDebugText { get; set; }
        [Ordinal(998)] [RED("drawDebugAxis")] public CBool DrawDebugAxis { get; set; }
        [Ordinal(999)] [RED("drawDebugCollisionCapsule")] public CBool DrawDebugCollisionCapsule { get; set; }
        [Ordinal(1000)] [RED("drawDebugCollisionShapes")] public CBool DrawDebugCollisionShapes { get; set; }

        public animDangleConstraint_Simulation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
