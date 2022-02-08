namespace WolvenKit.RED4.Types
{
    public partial class VendingMachineControllerPS
    {
        [OrdinalOverride(Before = 22)]
        [RED("vendingMachineSkillchecks")]
        public CHandle<EngDemoContainer> VendingMachineSkillchecks
        {
            get => GetPropertyValue<CHandle<EngDemoContainer>>();
            set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
        }
    }
}
