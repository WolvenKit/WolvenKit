using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animDangleConstraint_Simulation : animDangleConstraint_Simulation_
    {
        private CBool _debugDrawingEnabled;
        private CBool _drawDebugText;
        private CBool _drawDebugAxis;
        private CBool _drawDebugCollisionCapsule;
        private CBool _drawDebugCollisionShapes;

        [Ordinal(8)]
        [RED("debugDrawingEnabled")]
        public CBool DebugDrawingEnabled
        {
            get => GetProperty(ref _debugDrawingEnabled);
            set => SetProperty(ref _debugDrawingEnabled, value);
        }

        //[Ordinal(999)] [RED("drawDebugConstraint")] public CBool DrawDebugConstraint { get; set; }
        [Ordinal(9)]
        [RED("drawDebugText")]
        public CBool DrawDebugText
        {
            get => GetProperty(ref _drawDebugText);
            set => SetProperty(ref _drawDebugText, value);
        }

        [Ordinal(10)]
        [RED("drawDebugAxis")]
        public CBool DrawDebugAxis
        {
            get => GetProperty(ref _drawDebugAxis);
            set => SetProperty(ref _drawDebugAxis, value);
        }

        [Ordinal(11)]
        [RED("drawDebugCollisionCapsule")]
        public CBool DrawDebugCollisionCapsule
        {
            get => GetProperty(ref _drawDebugCollisionCapsule);
            set => SetProperty(ref _drawDebugCollisionCapsule, value);
        }

        [Ordinal(12)]
        [RED("drawDebugCollisionShapes")]
        public CBool DrawDebugCollisionShapes
        {
            get => GetProperty(ref _drawDebugCollisionShapes);
            set => SetProperty(ref _drawDebugCollisionShapes, value);
        }

        public animDangleConstraint_Simulation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
