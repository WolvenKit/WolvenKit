namespace WolvenKit.RED4.Types
{
    public partial class physicsRagdollBodyInfo : IRedOverload
    {
        void IRedOverload.ConstructorOverload()
        {
            // TODO: Workaround, default values is Serialized
            SwingAnglesY = null;
            TwistAngles = null;
        }
    }
}
