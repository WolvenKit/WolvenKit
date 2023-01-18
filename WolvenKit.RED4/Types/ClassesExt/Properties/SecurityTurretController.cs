namespace WolvenKit.RED4.Types
{
    public partial class SecurityTurretController
    {
        [RED("deviceState")]
        public CEnum<Enums.EDeviceStatus> DeviceState
        {
            get => GetPropertyValue<CEnum<Enums.EDeviceStatus>>();
            set => SetPropertyValue<CEnum<Enums.EDeviceStatus>>(value);
        }

        [RED("tweakDBRecord")]
        public TweakDBID TweakDBRecord
        {
            get => GetPropertyValue<TweakDBID>();
            set => SetPropertyValue<TweakDBID>(value);
        }

        [RED("contentScale")]
        public TweakDBID ContentScale
        {
            get => GetPropertyValue<TweakDBID>();
            set => SetPropertyValue<TweakDBID>(value);
        }

        [RED("detectionParameters")]
        public DetectionParameters DetectionParameters
        {
            get => GetPropertyValue<DetectionParameters>();
            set => SetPropertyValue<DetectionParameters>(value);
        }

        [RED("turretSkillChecks")]
        public CHandle<EngDemoContainer> TurretSkillChecks
        {
            get => GetPropertyValue<CHandle<EngDemoContainer>>();
            set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
        }
    }
}
