using System.IO;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Model;
using WolvenKit.RED4.Types;
using static WolvenKit.Common.Services.HookService;

namespace WolvenKit.Common.Services;

public interface IHookService
{
    public void RegisterOnExport(OnExportHook hook);
    public void OnExport(ref FileInfo fileInfo, ref GlobalExportArgs args);

    public void RegisterOnPreImport(OnPreImportHook hook);
    public void OnPreImport(ref RedRelativePath rawRelative, ref GlobalImportArgs args, ref DirectoryInfo? outDir);

    public void RegisterOnImportFromJson(OnImportFromJsonHook hook);
    public void OnImportFromJson(ref string jsonText);

    public void RegisterOnParsingError(OnParsingErrorHook hook);
    public bool OnParsingError(ParsingErrorEventArgs eventData);
}