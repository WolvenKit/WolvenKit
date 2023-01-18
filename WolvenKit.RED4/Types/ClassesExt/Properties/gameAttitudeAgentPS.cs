namespace WolvenKit.RED4.Types
{
    public partial class gameAttitudeAgentPS
    {
        [RED("contentScale")]
        public TweakDBID ContentScale
        {
            get => GetPropertyValue<TweakDBID>();
            set => SetPropertyValue<TweakDBID>(value);
        }

        [RED("cameraSkillChecks")]
        public CHandle<EngDemoContainer> CameraSkillChecks
        {
            get => GetPropertyValue<CHandle<EngDemoContainer>>();
            set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
        }
    }
}
