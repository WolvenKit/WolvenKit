using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive.CR2W;

namespace WolvenKit.App.Services;

public class AppHookService : HookService
{
    private OnSaveHook? _onSaveHook;

    public void RegisterOnSave(OnSaveHook hook) => _onSaveHook = hook;

    public bool OnSave(string extStr, ref CR2WFile cr2wFile) => _onSaveHook == null || _onSaveHook.Invoke(extStr, ref cr2wFile);

    #region Delegates

    public delegate bool OnSaveHook(string extStr, ref CR2WFile cr2wFile);

    #endregion
}