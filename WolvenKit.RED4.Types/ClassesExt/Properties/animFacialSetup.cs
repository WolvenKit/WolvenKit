namespace WolvenKit.RED4.Types
{
    // TODO: Check ordinal
    public partial class animFacialSetup
    {
        [RED("faceCorrectiveNames")]
        public CArray<CName> FaceCorrectiveNames
        {
            get => GetPropertyValue<CArray<CName>>();
            set => SetPropertyValue<CArray<CName>>(value);
        }

        [RED("tongueCorrectiveNames")]
        public CArray<CName> TongueCorrectiveNames
        {
            get => GetPropertyValue<CArray<CName>>();
            set => SetPropertyValue<CArray<CName>>(value);
        }
    }
}
