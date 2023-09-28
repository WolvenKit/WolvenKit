using System.IO;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.Modkit.Scripting;

public class HookService : IHookService
{
    private OnExportHook? _onExportHook;
    private OnPreImportHook? _onImportHook;
    private OnImportFromJsonHook? _onImportFromJsonHook;

    public void RegisterOnExport(OnExportHook hook) => _onExportHook = hook;
    public void OnExport(ref FileInfo fileInfo, ref GlobalExportArgs args) => _onExportHook?.Invoke(ref fileInfo, ref args);

    public void RegisterOnPreImport(OnPreImportHook hook) => _onImportHook = hook;
    public void OnPreImport(ref RedRelativePath rawRelative, ref GlobalImportArgs args, ref DirectoryInfo? outDir) => _onImportHook?.Invoke(ref rawRelative, ref args, ref outDir);

    public void RegisterOnImportFromJson(OnImportFromJsonHook hook) => _onImportFromJsonHook = hook;
    public void OnImportFromJson(ref string jsonText) => _onImportFromJsonHook?.Invoke(ref jsonText);

    #region Delegates

    public delegate void OnExportHook(ref FileInfo fileInfo, ref GlobalExportArgs args);
    public delegate void OnPreImportHook(ref RedRelativePath rawRelative, ref GlobalImportArgs args, ref DirectoryInfo? outDir);
    public delegate void OnImportFromJsonHook(ref string jsonText);

    #endregion
}