namespace WolvenKit.RED4.Types
{
    public partial class animAnimNode_BlendFromPose
    {
        [Ordinal(998)]
        [RED("debug")]
        public CBool Debug
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
