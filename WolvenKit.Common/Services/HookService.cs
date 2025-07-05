using System.IO;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Model;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Services;

public class HookService : IHookService
{
    private OnExportHook? _onExportHook;
    private OnPreImportHook? _onImportHook;
    private OnImportFromJsonHook? _onImportFromJsonHook;
    private OnParsingErrorHook? _onParsingErrorHook;

    public void RegisterOnExport(OnExportHook hook) => _onExportHook = hook;
    public void OnExport(ref FileInfo fileInfo, ref GlobalExportArgs args) => _onExportHook?.Invoke(ref fileInfo, ref args);

    public void RegisterOnPreImport(OnPreImportHook hook) => _onImportHook = hook;
    public void OnPreImport(ref RedRelativePath rawRelative, ref GlobalImportArgs args, ref DirectoryInfo? outDir) => _onImportHook?.Invoke(ref rawRelative, ref args, ref outDir);

    public void RegisterOnImportFromJson(OnImportFromJsonHook hook) => _onImportFromJsonHook = hook;
    public void OnImportFromJson(ref string jsonText, string redExtension) => _onImportFromJsonHook?.Invoke(ref jsonText, redExtension);

    public void RegisterOnParsingError(OnParsingErrorHook hook) => _onParsingErrorHook = hook;
    public bool OnParsingError(ParsingErrorEventArgs eventData) => _onParsingErrorHook != null && _onParsingErrorHook.Invoke(eventData);

    #region Delegates

    public delegate void OnExportHook(ref FileInfo fileInfo, ref GlobalExportArgs args);
    public delegate void OnPreImportHook(ref RedRelativePath rawRelative, ref GlobalImportArgs args, ref DirectoryInfo? outDir);
    public delegate void OnImportFromJsonHook(ref string jsonText, string redExtension);
    public delegate bool OnParsingErrorHook(ParsingErrorEventArgs eventData);

    #endregion
}