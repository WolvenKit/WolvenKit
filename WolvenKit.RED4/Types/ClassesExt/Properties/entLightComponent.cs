namespace WolvenKit.RED4.Types
{
    public partial class entLightComponent
    {
        [OrdinalOverride(Before = 5)]
        [RED("placedEditorData")]
        public CHandle<entIPlacedComponentEditorData> PlacedEditorData
        {
            get => GetPropertyValue<CHandle<entIPlacedComponentEditorData>>();
            set => SetPropertyValue<CHandle<entIPlacedComponentEditorData>>(value);
        }

        [OrdinalOverride(Before = 5)]
        [RED("initialTransform")]
        public Transform InitialTransform
        {
            get => GetPropertyValue<Transform>();
            set => SetPropertyValue<Transform>(value);
        }

        [OrdinalOverride(Before = 17)]
        [RED("noSpecular")]
        public CBool NoSpecular
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [OrdinalOverride(Before = 18)]
        [RED("sceneSpecular")]
        public CBool SceneSpecular
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [OrdinalOverride(Before = 21)]
        [RED("useInGI")]
        public CBool UseInGI
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [OrdinalOverride(Before = 21)]
        [RED("useInEnvProbes")]
        public CBool UseInEnvProbes
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [OrdinalOverride(Before = 25)]
        [RED("useInFog")]
        public CBool UseInFog
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [OrdinalOverride(Before = 42)]
        [RED("enableContactShadows")]
        public CBool EnableContactShadows
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [OrdinalOverride(Before = 42)]
        [RED("enableShadowAngleControl")]
        public CBool EnableShadowAngleControl
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
