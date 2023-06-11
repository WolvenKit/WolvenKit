namespace WolvenKit.Modkit.Scripting;

public class HookService : IHookService
{
    private OnExportHook? _onExportHook;

    public void RegisterOnExport(OnExportHook hook) => _onExportHook = hook;

    public void OnExport() => _onExportHook?.Invoke();

    #region Delegates

    public delegate void OnExportHook();

    #endregion
}