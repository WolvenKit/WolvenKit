using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
    [REDMeta]
    [REDClass(SerializeDefault = true)]
    public partial class WorldTransformExt : WorldTransform
    {
/*        [Ordinal(0)]
        [RED("Position")]
        public WorldPosition Position
        {
            get => GetPropertyValue<WorldPosition>();
            set => SetPropertyValue<WorldPosition>(value);
        }

        [Ordinal(1)]
        [RED("Orientation")]
        public Quaternion Orientation
        {
            get => GetPropertyValue<Quaternion>();
            set => SetPropertyValue<Quaternion>(value);
        }*/

        [Ordinal(2)]
        [RED("Scale")]
        public Vector3 Scale
        {
            get => GetPropertyValue<Vector3>();
            set => SetPropertyValue<Vector3>(value);
        }

        public WorldTransformExt() : base()
        {
            Scale = new();
        }
    }
}
