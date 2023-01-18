namespace WolvenKit.RED4.Types
{
    public partial class animDangleConstraint_Simulation
    {
        [Ordinal(8)]
        [RED("debugDrawingEnabled")]
        public CBool DebugDrawingEnabled
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        //[Ordinal(999)] [RED("drawDebugConstraint")] public CBool DrawDebugConstraint { get; set; }
        [Ordinal(9)]
        [RED("drawDebugText")]
        public CBool DrawDebugText
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [Ordinal(10)]
        [RED("drawDebugAxis")]
        public CBool DrawDebugAxis
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [Ordinal(11)]
        [RED("drawDebugCollisionCapsule")]
        public CBool DrawDebugCollisionCapsule
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [Ordinal(12)]
        [RED("drawDebugCollisionShapes")]
        public CBool DrawDebugCollisionShapes
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
