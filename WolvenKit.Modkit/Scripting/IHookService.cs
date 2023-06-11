using static WolvenKit.Modkit.Scripting.HookService;

namespace WolvenKit.Modkit.Scripting;

public interface IHookService
{
    public void RegisterOnExport(OnExportHook hook);
    public void OnExport();
}