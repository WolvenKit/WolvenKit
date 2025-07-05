namespace WolvenKit.RED4.Types;

public partial class GenericDevice
{
    [RED("baseStateOperations")]
    public CHandle<BaseStateOperations> BaseStateOperations
    {
        get => GetPropertyValue<CHandle<BaseStateOperations>>();
        set => SetPropertyValue<CHandle<BaseStateOperations>>(value);
    }

    [RED("baseActionOperations")]
    public CHandle<BaseActionOperations> BaseActionOperations
    {
        get => GetPropertyValue<CHandle<BaseActionOperations>>();
        set => SetPropertyValue<CHandle<BaseActionOperations>>(value);
    }

    [RED("triggerVolumeOperations")]
    public CHandle<TriggerVolumeOperations> TriggerVolumeOperations
    {
        get => GetPropertyValue<CHandle<TriggerVolumeOperations>>();
        set => SetPropertyValue<CHandle<TriggerVolumeOperations>>(value);
    }

    [RED("focusModeOperations")]
    public CHandle<FocusModeOperations> FocusModeOperations
    {
        get => GetPropertyValue<CHandle<FocusModeOperations>>();
        set => SetPropertyValue<CHandle<FocusModeOperations>>(value);
    }

    [RED("actionsOperations")]
    public CHandle<CustomActionOperations> ActionsOperations
    {
        get => GetPropertyValue<CHandle<CustomActionOperations>>();
        set => SetPropertyValue<CHandle<CustomActionOperations>>(value);
    }
}
