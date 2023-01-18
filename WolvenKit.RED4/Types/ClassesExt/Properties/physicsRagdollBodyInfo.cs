namespace WolvenKit.RED4.Types
{
    public partial class physicsRagdollBodyInfo
    {
        partial void PostConstruct()
        {
            // TODO: Workaround, default values is Serialized
            SwingAnglesY = null;
            TwistAngles = null;
        }
    }
}
