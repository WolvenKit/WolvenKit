namespace WolvenKit.RED4.Types
{
    public partial class SurveillanceCameraControllerPS
    {
        [OrdinalOverride(Before = 146)]
        [RED("cameraParams")]
        public CameraParams CameraParams
        {
            get => GetPropertyValue<CameraParams>();
            set => SetPropertyValue<CameraParams>(value);
        }

        [RED("engineeringCheck")]
        public CHandle<EngineeringSkillCheck> EngineeringCheck
        {
            get => GetPropertyValue<CHandle<EngineeringSkillCheck>>();
            set => SetPropertyValue<CHandle<EngineeringSkillCheck>>(value);
        }
    }
}
