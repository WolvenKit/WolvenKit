using System.Collections.Generic;
using WolvenKit.App.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive.CR2W;

namespace WolvenKit.App.Services;

public class AppHookService : HookService
{
    private List<OnSaveHook> _onSaveHooks = new();

    public AppHookService()
    {
        RegisterOnSave(InkWidgetHelper.OnSave);
    }

    public void RegisterOnSave(OnSaveHook hook) => _onSaveHooks.Add(hook);

    public bool OnSave(string extStr, ref CR2WFile cr2wFile)
    {
        var ret = true;
        foreach (var hook in _onSaveHooks)
        {
            ret |= hook.Invoke(extStr, ref cr2wFile);
        }
        return ret;
    }

    #region Delegates

    public delegate bool OnSaveHook(string extStr, ref CR2WFile cr2wFile);

    #endregion
}