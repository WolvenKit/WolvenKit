namespace WolvenKit.RED4.Types
{
    public partial class WindowBlindersControllerPS
    {
        [OrdinalOverride(Before = 104)]
        [RED("doorProperties")]
        public DoorSetup DoorProperties
        {
            get => GetPropertyValue<DoorSetup>();
            set => SetPropertyValue<DoorSetup>(value);
        }
    }
}
