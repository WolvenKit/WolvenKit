namespace WolvenKit.RED4.Types
{
    public partial class animAnimNode_Sermo
    {
        [Ordinal(999)]
        [RED("testController")]
        public animSermoTestController TestController
        {
            get => GetPropertyValue<animSermoTestController>();
            set => SetPropertyValue<animSermoTestController>(value);
        }
    }
}
