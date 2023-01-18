namespace WolvenKit.RED4.Types;

public partial class VendingMachine
{
    [RED("focusModeOperations")]
    public CHandle<FocusModeOperations> FocusModeOperations
    {
        get => GetPropertyValue<CHandle<FocusModeOperations>>();
        set => SetPropertyValue<CHandle<FocusModeOperations>>(value);
    }
}
