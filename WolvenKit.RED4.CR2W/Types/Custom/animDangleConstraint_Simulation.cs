using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animDangleConstraint_Simulation : animDangleConstraint_Simulation_
    {
        [Ordinal(8)] [RED("debugDrawingEnabled")] public CBool DebugDrawingEnabled { get; set; }
        //[Ordinal(999)] [RED("drawDebugConstraint")] public CBool DrawDebugConstraint { get; set; }
        [Ordinal(9)] [RED("drawDebugText")] public CBool DrawDebugText { get; set; }
        [Ordinal(10)] [RED("drawDebugAxis")] public CBool DrawDebugAxis { get; set; }
        [Ordinal(11)] [RED("drawDebugCollisionCapsule")] public CBool DrawDebugCollisionCapsule { get; set; }
        [Ordinal(12)] [RED("drawDebugCollisionShapes")] public CBool DrawDebugCollisionShapes { get; set; }

        public animDangleConstraint_Simulation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
