namespace WolvenKit.RED4.Types
{
    public partial class animLookAtPartInfo : IRedOverload
    {
        [Ordinal(1002)]
        [RED("debugDrawingEnabled")]
        public CBool DebugDrawingEnabled
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        void IRedOverload.ConstructorOverload()
        {
            DebugDrawingEnabled = true;
        }
    }
}
