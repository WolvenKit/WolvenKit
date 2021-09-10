namespace WolvenKit.RED4.Types
{
    public partial class animDangleConstraint_SimulationDyng : IRedOverload
    {
        [Ordinal(999)]
        [RED("drawDebugConstraint")]
        public CBool DrawDebugConstraint
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        void IRedOverload.ConstructorOverload()
        {
            DrawDebugText = true;
            DrawDebugAxis = true;
            DrawDebugCollisionCapsule = true;
            DrawDebugCollisionShapes = true;
            DrawDebugConstraint = true;
        }
    }
}
